using System;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;
using SDK_Log_Capture_Tool.ATEQ;
using SDK_Log_Capture_Tool.SFIS;
using SDK_Log_Capture_Tool.ModbusTcp;

namespace SDK_Log_Capture_Tool
{
    public partial class SDK_Log_Capturer : Form
    {
        private string pre_leak;
        private bool rosta_counter = false;
        private AteqStatusMonitor _monitor;
        private PressureReader _n2PressureReader;
        private readonly ISfisService _f620sfisService;
        private readonly ISfisService _watersfisService;
        private readonly ISfisService _n2sfisService;
        private readonly string logFilePath = $"D:\\F620_Log_{DateTime.Now:yyyy_MM_dd}.txt";
        public SDK_Log_Capturer(IAteqModbusTransport transport, ISfisService sfisService = null)
        {
            InitializeComponent();

            _f620sfisService = sfisService ?? new WebServiceFunc(new F620_Sfis_Upload_Para());
            _watersfisService = sfisService ?? new WebServiceFunc(new Water_Sfis_Upload_Para());
            _n2sfisService = sfisService ?? new WebServiceFunc(new N2_Sfis_Upload_Para());
            _transport = transport;

            this.Load += SDK_Log_Capturer_Load;
        }

        private IAteqModbusTransport _transport;

        private async void SDK_Log_Capturer_Load(object sender, EventArgs e)
        {
            this.Load -= SDK_Log_Capturer_Load;

            await InitializeAsync(_transport);
        }

        private async Task InitializeAsync(IAteqModbusTransport transport, CancellationToken token = default)
        {
            try
            {
                _monitor = new AteqStatusMonitor(transport);
                int[] test = transport.ReadHoldingRegisters(0, 1);
                Console.WriteLine("ATEQ F620 connection success.");
                _n2PressureReader = new PressureReader("192.168.1.2");
                Console.WriteLine($"Default logFilePath is '{logFilePath}'");
                // ===============================
                //    Keep trying LoginAsync(1)
                // ===============================
                SfisResult loginResult;

                while (true)
                {
                    token.ThrowIfCancellationRequested();

                    loginResult = await _f620sfisService.LoginAsync(1);

                    if (loginResult.IsSuccess)
                        break;

                    loginResult = await _f620sfisService.LoginAsync(2);
                    await Task.Delay(1000, token);
                }

                Console.WriteLine("SFIS Login",
                           $"Login successful: {loginResult.Response}");
            }
            catch (OperationCanceledException)
            {
                ShowResult(false, "Operation Canceled", "Login process was canceled.");
                _monitor = null;
            }
            catch (Exception ex)
            {
                ShowResult(false, "Instrument Connection Failed",
                          "Unable to connect to ATEQ F620 leak tester! " +
                          "Please confirm that the COM Port is correct.\n\n" +
                          ex.Message);

                _monitor = null;
            }
        }

        private void ShowResult(bool isSuccess, string title, string message, string errorDetail = null)
        {
            string fullMessage = errorDetail == null
                ? message
                : $"{message}\nError: {errorDetail}";

            Console.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {(isSuccess ? "OK" : "NG")} {title}: {fullMessage}");

            if (this.IsHandleCreated && !this.IsDisposed)
            {
                this.BeginInvoke((Action)(() =>
                {
                    MessageBox.Show(this, fullMessage, title,
                        MessageBoxButtons.OK,
                        isSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                }));
            }
        }

        private void is_manual_CheckedChanged(object sender, EventArgs e)
        {
            if (is_manual.Checked)
            {
                txtProgramNumber.ReadOnly = false;
                txtLeakATEQ.ReadOnly = false;
                txtStatusATEQ.ReadOnly = false;
            }
        }

        private void is_auto_CheckedChanged(object sender, EventArgs e)
        {
            if (is_auto.Checked)
            {
                txtProgramNumber.ReadOnly = true;
                txtLeakATEQ.ReadOnly = true;
                txtStatusATEQ.ReadOnly = true;
                txtProgramNumber.Clear();
                txtLeakATEQ.Clear();
                txtStatusATEQ.Clear();
            }
        }

        private void IsRosta_Checked(object sender, EventArgs e)
        {
            if (!check_isRosta.Checked)
            {
                rosta_counter = false;
                btn_Rosta_Fetch.Visible = false;
                btn_upload_SFIS.Visible = true;
                btn_upload_SFIS.Enabled = true;
                return;
            }

            btn_Rosta_Fetch.Visible = true;
            btn_Rosta_Fetch.Enabled = true;
            btn_upload_SFIS.Visible = false;
            btn_upload_SFIS.Enabled = false;

            if (!string.IsNullOrEmpty(txtISNATEQ.Text) &&
                     !string.IsNullOrEmpty(txtProgramNumber.Text) &&
                     !string.IsNullOrEmpty(txtLeakATEQ.Text) &&
                     !string.IsNullOrEmpty(txtStatusATEQ.Text))
            {
                if (!rosta_counter)
                {
                    ShowResult(true, "Finished", "當前測量數值已經暫存於後台，請測量第二次。");
                    txtProgramNumber.Clear();
                    txtLeakATEQ.Clear();
                    txtStatusATEQ.Clear();
                }
            }
        }

        private void btn_Rosta_Fetch_Click(object sender, EventArgs e)
        {
            AteqResult result = null;
#if DEBUG
            var r = new Random();
            result = new AteqResult
            {
                ProgramID = "Pr 006",
                Pressure = r.NextDouble() * 5.0,
                LeakRate = r.NextDouble() * 0.1,
                Status = "PASS",
            };
#else
            _monitor.TryGetResult(out result);
#endif
            result.UpdateParameters();
            pre_leak = txtLeakATEQ.Text;

            try
            {
                txtProgramNumber.Text = result.ProgramID;
                txtLeakATEQ.Text = result.Parameters["LeakRate"].ToString("F3");
                rosta_counter = !rosta_counter;
                txtStatusATEQ.Text = result.Status;
                btn_Rosta_Fetch.Enabled = false;
                btn_Rosta_Fetch.Visible = false;
                btn_upload_SFIS.Visible = true;
                btn_upload_SFIS.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Read Failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == Water_Bath_tabPage ||
                e.TabPage == N2_Filler_tabPage)
            {
                e.Cancel = true;
            }
        }

        #region ATEQ F620 SFIS Upload
        private void F620_UploadSFIS_Click(object sender, EventArgs e)
        {
            try
            {
                string isn = txtISNATEQ.Text.Trim();
                if (string.IsNullOrEmpty(isn))
                    return;

                string startTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string programID = txtProgramNumber.Text.Trim();
                string leak = (rosta_counter) ?$"1st:'{pre_leak}';2nd:'{txtLeakATEQ.Text.Trim()}'": txtLeakATEQ.Text.Trim();
                string status = txtStatusATEQ.Text.Trim();
                string ateqData = $"TEST:{programID}|LEAK:{leak}|STAT:{status}";

                // Step 1: Check Route
                var chkResult = _f620sfisService.CheckRouteAsync(isn).Result;
                if (!chkResult.IsSuccess)
                {
                    ShowResult(false, "Check Route Failed", chkResult.Response, chkResult.ErrorMessage);
                    dgvFIFOATEQ.Rows.Add(isn, startTime, programID, leak, status, "Check Route Failed");
                    System.IO.File.AppendAllText(
                        logFilePath,
                        $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}, {isn}, {programID}, {leak}, {status}, Check Route Failed" + Environment.NewLine
                    );
                    check_isRosta.Checked = false;
                    return;
                }
                ShowResult(true, "Check Route Success", chkResult.Response);

                // Step 2: Upload Result
                SfisResult uploadResult = _f620sfisService.UploadResult(isn, ateqData);
                ShowResult(uploadResult.IsSuccess,
                           uploadResult.IsSuccess ? "Upload Successful" : "Upload Failed",
                           uploadResult.Response,
                           uploadResult.ErrorMessage);

                dgvFIFOATEQ.Rows.Add(isn, startTime, programID, leak, status, uploadResult.IsSuccess ? "Upload Success" : "Upload Failed");
                System.IO.File.AppendAllText(
                    logFilePath,
                    $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}, {isn}, {startTime}, {programID}, {leak}, {status}, {uploadResult.IsSuccess}" + Environment.NewLine
                );
                ClearInputFields();
                btn_upload_SFIS.Enabled = false;
                check_isRosta.Checked = false;
            }
            catch (Exception ex)
            {
                ShowResult(false, "Unexpected Error", ex.Message);
            }
        }

        private void ClearInputFields()
        {
            txtISNATEQ.Clear();
            txtProgramNumber.Clear();
            txtLeakATEQ.Clear();
            txtStatusATEQ.Clear();
        }

        private void CheckF620TextBoxes(object sender, EventArgs e)
        {
            AteqResult result = null;
            bool allFilled = !string.IsNullOrEmpty(txtISNATEQ.Text) &&
                     !string.IsNullOrEmpty(txtProgramNumber.Text) &&
                     //!string.IsNullOrEmpty(txtPressureATEQ.Text) &&
                     !string.IsNullOrEmpty(txtLeakATEQ.Text) &&
                     !string.IsNullOrEmpty(txtStatusATEQ.Text);
            btn_upload_SFIS.Enabled = allFilled;
            try
            {
                if (!is_auto.Checked || string.IsNullOrEmpty(txtISNATEQ.Text))
                {
                    return;
                }
#if DEBUG
                var r = new Random();
                result = new AteqResult
                {
                    ProgramID = "Pr 006",
                    Pressure = r.NextDouble() * 5.0,
                    LeakRate = r.NextDouble() * 0.1,
                    Status = "PASS",
                };
#else
                _monitor.TryGetResult(out result);
#endif
                result.UpdateParameters();
                txtProgramNumber.Text = result.ProgramID;
                //txtPressureATEQ.Text = result.Parameters["Pressure"].ToString("F3");
                txtLeakATEQ.Text = result.Parameters["LeakRate"].ToString("F3");
                txtStatusATEQ.Text = result.Status;
            }
            catch (AteqException ex)
            {
                MessageBox.Show($"ATEQ 讀取失敗：{ex.Message}",
                                "ATEQ F620 錯誤",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtProgramNumber.Clear();
                //txtPressureATEQ.Clear();
                txtLeakATEQ.Clear();
                txtStatusATEQ.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Read Failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProgramNumber.Clear();
                txtISNATEQ.Clear();
                //txtPressureATEQ.Clear();
                txtLeakATEQ.Clear();
                txtStatusATEQ.Clear();
                return;
            }
        }
        #endregion


        #region Water SFIS Upload
        private void loop1ISNWater_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_loop1ISNWater.Text))
            {
                loop1_STARTTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                btn_loop1UploadSFISWater.Enabled = true;
            }
            else
            {
                loop1_STARTTime.Clear();
                btn_loop1UploadSFISWater.Enabled = false;
            }
        }

        private void loop2ISNWater_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_loop2ISNWater.Text))
            {
                loop2_STARTTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                btn_loop2UploadSFISWater.Enabled = true;
            }
            else
            {
                loop2_STARTTime.Clear();
                btn_loop2UploadSFISWater.Enabled = false;
            }
        }

        private void loop3ISNWater_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_loop3ISNWater.Text))
            {
                loop3_STARTTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                btn_loop3UploadSFISWater.Enabled = true;
            }
            else
            {
                loop3_STARTTime.Clear();
                btn_loop3UploadSFISWater.Enabled = false;
            }
        }

        private void loop4ISNWater_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_loop4ISNWater.Text))
            {
                loop4_STARTTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                btn_loop4UploadSFISWater.Enabled = true;
            }
            else
            {
                loop4_STARTTime.Clear();
                btn_loop4UploadSFISWater.Enabled = false;
            }
        }

        private void btn1UploadSFISWater_Click(object sender, EventArgs e)
        {
            try
            {
                string isn = txt_loop1ISNWater.Text.Trim();
                string startTime = loop1_STARTTime.Text.Trim();
                string endTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss").Trim();
                string tomData = $"startTime:{startTime}|endTime:{endTime}";

                if (!string.IsNullOrEmpty(isn))
                {
                    var chkResult = _watersfisService.CheckRouteAsync(isn).Result;
                    if (!chkResult.IsSuccess)
                    {
                        ShowResult(false, "Loop 1 Check Route Failed", chkResult.Response, chkResult.ErrorMessage);
                        dataGrid_Water.Rows.Add(isn, "Loop 1", startTime, endTime);
                        System.IO.File.AppendAllText(
                            logFilePath,
                            $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}, {isn}, Loop 1, {endTime}, Check Route Failed" + Environment.NewLine
                        );
                        txt_loop1ISNWater.Clear();
                        loop1_STARTTime.Clear();
                        btn_loop1UploadSFISWater.Enabled = false;
                        return;
                    }

                    SfisResult uploadResult = _watersfisService.UploadResult(isn, tomData);
                    ShowResult(
                        uploadResult.IsSuccess,
                        uploadResult.IsSuccess
                            ? $"Loop 1 Upload Successful: {uploadResult.Response}"
                            : $"Loop 1 Upload Failed: {uploadResult.Response}\nError: {uploadResult.ErrorMessage}",
                        uploadResult.IsSuccess ? "Success" : "Error"
                    );

                    dataGrid_Water.Rows.Add(isn, "Loop 1", startTime, endTime);
                    System.IO.File.AppendAllText(
                        logFilePath,
                        $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}, {isn}, Loop 1, {endTime}, {uploadResult.IsSuccess}" + Environment.NewLine
                    );
                    txt_loop1ISNWater.Clear();
                    loop1_STARTTime.Clear();
                    btn_loop1UploadSFISWater.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Upexpected error: {ex.Message}", "Error");
            }
        }

        private void btn1ResetSFISWater_Click(object sender, EventArgs e)
        {
            try
            {
                //停止上傳SFIS動作
                string isn = txt_loop1ISNWater.Text.Trim();
                if (!string.IsNullOrEmpty(isn))
                {
                    txt_loop1ISNWater.Clear();
                    loop1_STARTTime.Clear();
                    btn_loop1UploadSFISWater.Enabled = false;
                }
            }
            catch (Exception)
            {
            }
        }

        private void btn2UploadSFISWater_Click(object sender, EventArgs e)
        {
            try
            {
                string isn = txt_loop2ISNWater.Text.Trim();
                string startTime = loop2_STARTTime.Text.Trim();
                string endTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss").Trim();
                string tomData = $"startTime:{startTime}|endTime:{endTime}";

                if (!string.IsNullOrEmpty(isn))
                {
                    var chkResult = _watersfisService.CheckRouteAsync(isn).Result;
                    if (!chkResult.IsSuccess)
                    {
                        ShowResult(false, "Loop 2 Check Route Failed", chkResult.Response, chkResult.ErrorMessage);
                        dataGrid_Water.Rows.Add(isn, "Loop 2", startTime, endTime);
                        System.IO.File.AppendAllText(
                            logFilePath,
                            $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}, {isn}, Loop 2, {endTime}, Check Route Failed" + Environment.NewLine
                        );
                        txt_loop1ISNWater.Clear();
                        loop1_STARTTime.Clear();
                        btn_loop1UploadSFISWater.Enabled = false;
                        return;
                    }

                    SfisResult uploadResult = _watersfisService.UploadResult(isn, tomData);
                    ShowResult(
                        uploadResult.IsSuccess,
                        uploadResult.IsSuccess
                            ? $"Loop 2 Upload Successful: {uploadResult.Response}"
                            : $"Loop 2 Upload Failed: {uploadResult.Response}\nError: {uploadResult.ErrorMessage}",
                        uploadResult.IsSuccess ? "Success" : "Error"
                    );

                    dataGrid_Water.Rows.Add(isn, "Loop 2", startTime, endTime);
                    System.IO.File.AppendAllText(
                        logFilePath,
                        $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}, {isn}, Loop 2, {endTime}, {uploadResult.IsSuccess}" + Environment.NewLine
                    );
                    txt_loop1ISNWater.Clear();
                    loop1_STARTTime.Clear();
                    btn_loop1UploadSFISWater.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Upexpected error: {ex.Message}", "Error");
            }
        }

        private void btn2ResetSFISWater_Click(object sender, EventArgs e)
        {
            try
            {
                //停止上傳SFIS動作
                string isn = txt_loop2ISNWater.Text.Trim();
                if (!string.IsNullOrEmpty(isn))
                {
                    txt_loop2ISNWater.Clear();
                    loop2_STARTTime.Clear();
                    btn_loop2UploadSFISWater.Enabled = false;
                }
            }
            catch (Exception)
            {
            }
        }

        private void btn3UploadSFISWater_Click(object sender, EventArgs e)
        {
            try
            {
                string isn = txt_loop3ISNWater.Text.Trim();
                string startTime = loop3_STARTTime.Text.Trim();
                string endTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss").Trim();
                string tomData = $"startTime:{startTime}|endTime:{endTime}";

                if (!string.IsNullOrEmpty(isn))
                {
                    var chkResult = _watersfisService.CheckRouteAsync(isn).Result;
                    if (!chkResult.IsSuccess)
                    {
                        ShowResult(false, "Loop 3 Check Route Failed", chkResult.Response, chkResult.ErrorMessage);
                        dataGrid_Water.Rows.Add(isn, "Loop 3", startTime, endTime);
                        System.IO.File.AppendAllText(
                            logFilePath,
                            $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}, {isn}, Loop 3, {endTime}, Check Route Failed" + Environment.NewLine
                        );
                        txt_loop1ISNWater.Clear();
                        loop1_STARTTime.Clear();
                        btn_loop1UploadSFISWater.Enabled = false;
                        return;
                    }

                    SfisResult uploadResult = _watersfisService.UploadResult(isn, tomData);
                    ShowResult(
                        uploadResult.IsSuccess,
                        uploadResult.IsSuccess
                            ? $"Loop 3 Upload Successful: {uploadResult.Response}"
                            : $"Loop 3 Upload Failed: {uploadResult.Response}\nError: {uploadResult.ErrorMessage}",
                        uploadResult.IsSuccess ? "Success" : "Error"
                    );

                    dataGrid_Water.Rows.Add(isn, "Loop 3", startTime, endTime);
                    System.IO.File.AppendAllText(
                        logFilePath,
                        $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}, {isn}, Loop 3, {endTime}, {uploadResult.IsSuccess}" + Environment.NewLine
                    );
                    txt_loop1ISNWater.Clear();
                    loop1_STARTTime.Clear();
                    btn_loop1UploadSFISWater.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Upexpected error: {ex.Message}", "Error");
            }
        }

        private void btn3ResetSFISWater_Click(object sender, EventArgs e)
        {
            try
            {
                //停止上傳SFIS動作
                string isn = txt_loop3ISNWater.Text.Trim();
                if (!string.IsNullOrEmpty(isn))
                {
                    txt_loop3ISNWater.Clear();
                    loop3_STARTTime.Clear();
                    btn_loop3UploadSFISWater.Enabled = false;
                }
            }
            catch (Exception)
            {
            }
        }

        private void btn4UploadSFISWater_Click(object sender, EventArgs e)
        {
            try
            {
                string isn = txt_loop4ISNWater.Text.Trim();
                string startTime = loop4_STARTTime.Text.Trim();
                string endTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss").Trim();
                string tomData = $"startTime:{startTime}|endTime:{endTime}";

                if (!string.IsNullOrEmpty(isn))
                {
                    var chkResult = _watersfisService.CheckRouteAsync(isn).Result;
                    if (!chkResult.IsSuccess)
                    {
                        ShowResult(false, "Loop 4 Check Route Failed", chkResult.Response, chkResult.ErrorMessage);
                        dataGrid_Water.Rows.Add(isn, "Loop 4", startTime, endTime);
                        System.IO.File.AppendAllText(
                            logFilePath,
                            $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}, {isn}, Loop 4, {endTime}, Check Route Failed" + Environment.NewLine
                        );
                        txt_loop1ISNWater.Clear();
                        loop1_STARTTime.Clear();
                        btn_loop1UploadSFISWater.Enabled = false;
                        return;
                    }

                    SfisResult uploadResult = _watersfisService.UploadResult(isn, tomData);
                    ShowResult(
                        uploadResult.IsSuccess,
                        uploadResult.IsSuccess
                            ? $"Loop 4 Upload Successful: {uploadResult.Response}"
                            : $"Loop 4 Upload Failed: {uploadResult.Response}\nError: {uploadResult.ErrorMessage}",
                        uploadResult.IsSuccess ? "Success" : "Error"
                    );

                    dataGrid_Water.Rows.Add(isn, "Loop 4", startTime, endTime);
                    System.IO.File.AppendAllText(
                        logFilePath,
                        $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}, {isn}, Loop 4, {endTime}, {uploadResult.IsSuccess}" + Environment.NewLine
                    );
                    txt_loop1ISNWater.Clear();
                    loop1_STARTTime.Clear();
                    btn_loop1UploadSFISWater.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                ShowResult(false, $"Upexpected error: {ex.Message}", "Error");
            }
        }

        private void btn4ResetSFISWater_Click(object sender, EventArgs e)
        {
            try
            {
                //停止上傳SFIS動作
                string isn = txt_loop4ISNWater.Text.Trim();
                if (!string.IsNullOrEmpty(isn))
                {
                    txt_loop4ISNWater.Clear();
                    loop4_STARTTime.Clear();
                    btn_loop4UploadSFISWater.Enabled = false;
                }
            }
            catch (Exception)
            {
            }
        }
        #endregion

        #region N2 Filler SFIS Upload
        private void Allow_N2_Start(object sender, EventArgs e)
        {
            btn_start_N2Filler.Enabled = !string.IsNullOrEmpty(ISN_N2Filler.Text);
        }

        private void Reset_N2_Start(object sender, EventArgs e)
        {
            ISN_N2Filler.Clear();
            N2_txtPressure.Clear();
            N2_testStatus.Clear();
        }

        public void N2_manual_upload_enabled(object sender, EventArgs e)
        {
            if (!btnN2_manual_radio.Checked)
            {
                return;
            }
            btn_N2_upload.Enabled = !string.IsNullOrEmpty(ISN_N2Filler.Text) &&
            !string.IsNullOrEmpty(N2_txtMedium.Text) &&
            !string.IsNullOrEmpty(N2_txtPressure.Text) &&
            !string.IsNullOrEmpty(N2_testStatus.Text);
        }

        private void N2_manual_CheckedChanged(object sender, EventArgs e)
        {
            if (btnN2_manual_radio.Checked)
            {
                N2_txtMedium.ReadOnly = false;
                N2_txtPressure.ReadOnly = false;
                N2_testStatus.ReadOnly = false;
                btn_start_N2Filler.Enabled = false;
            }
            else
            {
                if (!string.IsNullOrEmpty(ISN_N2Filler.Text))
                {
                    btn_start_N2Filler.Enabled = true;
                }
                N2_txtPressure.Clear();
                N2_testStatus.Clear();
                btn_N2_upload.Enabled = false;
            }
        }

        private void N2_fetch_Pressure(object sender, EventArgs e)
        {
            if (btnN2_manual_radio.Checked)
            {
                return;
            }
            var result = _n2PressureReader.ReadPressure();

            if (result.IsValid)
            {
                ShowResult(true, "Success", $"Product Pressure: {result.Pressure:F4} psi");
                N2_txtPressure.Text = $"{result.Pressure:F4} psi";
                btn_N2_upload.Enabled = true;
            }
            else
            {
                ShowResult(false, "Error", $"Failed to read pressure:{result.ErrorMessage}");
                N2_txtPressure.Text = $"0";
            }
            N2_testStatus.Text = result.IsValid ? "Pass" : "Failed";
        }

        private void N2_UploadSFIS_Click(object sender, EventArgs e)
        {
            try
            {
                string isn = ISN_N2Filler.Text.Trim();
                string startTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss").Trim();
                string medium = N2_txtMedium.Text.Trim();
                string pressure = N2_txtPressure.Text.Trim();
                string modbus = N2_testStatus.Text.Trim();
                string N2Data = $"startTime:{startTime}|Pressure:{pressure}";

                if (!string.IsNullOrEmpty(isn))
                {
                    var chkResult = _n2sfisService.CheckRouteAsync(isn).Result;
                    if (!chkResult.IsSuccess)
                    {
                        ShowResult(false, "N2 Check Route Failed", chkResult.Response, chkResult.ErrorMessage);
                        N2filler_GridView.Rows.Add(isn, startTime, pressure, modbus, chkResult.IsSuccess);
                        System.IO.File.AppendAllText(
                            logFilePath,
                            $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}, {isn}, {pressure}, Check Route Failed" + Environment.NewLine
                        );
                        ISN_N2Filler.Clear();
                        N2_txtPressure.Clear();
                        N2_testStatus.Clear();
                        btn_N2_upload.Enabled = false;
                        return;
                    }

                    SfisResult uploadResult = _n2sfisService.UploadResult(isn, N2Data);
                    ShowResult(
                        uploadResult.IsSuccess,
                        uploadResult.IsSuccess
                            ? $"Upload Successful: {uploadResult.Response}"
                            : $"Upload Failed: {uploadResult.Response}\nError: {uploadResult.ErrorMessage}",
                        uploadResult.IsSuccess ? "Success" : "Error"
                    );

                    N2filler_GridView.Rows.Add(isn, startTime, pressure, modbus, uploadResult.IsSuccess);
                    System.IO.File.AppendAllText(
                        logFilePath,
                        $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}, {isn}, {pressure}, {uploadResult.IsSuccess}" + Environment.NewLine
                    );
                    ISN_N2Filler.Clear();
                    N2_txtPressure.Clear();
                    N2_testStatus.Clear();
                    btn_N2_upload.Enabled = false;
                }
            }
            catch (Exception)
            {
            }
        }
        #endregion
    }
}