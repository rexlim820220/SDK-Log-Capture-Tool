using SDK_Log_Capture_Tool.ATEQ;
using SDK_Log_Capture_Tool.SFIS;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDK_Log_Capture_Tool
{
    public partial class SDK_Log_Capturer : Form
    {
        private AteqStatusMonitor _monitor;
        private readonly ISfisService _f620sfisService;
        private readonly ISfisService _watersfisService;
        private readonly string logFilePath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), $"SDK_Log_{DateTime.Now:yyyy_MM_dd}.txt");
        public SDK_Log_Capturer(IAteqModbusTransport transport, ISfisService sfisService = null)
        {
            InitializeComponent();

            _f620sfisService = sfisService ?? new WebServiceFunc(new F620_Sfis_Upload_Para());
            _watersfisService = sfisService ?? new WebServiceFunc(new Water_Sfis_Upload_Para());
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

                ShowResult(true, "ATEQ Connection", "ATEQ F620 connection success.");
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

                    ShowResult(false, "SFIS Login Failed",
                               loginResult.Response, loginResult.ErrorMessage);

                    loginResult = await _f620sfisService.LoginAsync(2);
                    await Task.Delay(1000, token);
                }

                ShowResult(true, "SFIS Login",
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

        private void F620_UploadSFIS_Click(object sender, EventArgs e)
        {
            try
            {
                string isn = txtISNATEQ.Text.Trim();
                if (string.IsNullOrEmpty(isn))
                    return;

                string startTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string programID = txtProgramNumber.Text.Trim();
                string leak = txtLeakATEQ.Text.Trim();
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
                        $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}, {isn}, {startTime}, {programID}, {leak}, {status}, Check Route Failed" + Environment.NewLine
                    );
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

        private void CheckTextBoxes(object sender, EventArgs e)
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
                if(!is_auto.Checked || string.IsNullOrEmpty(txtISNATEQ.Text))
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
        private void is_manual_CheckedChanged(object sender, EventArgs e)
        {
            if (is_manual.Checked)
            {
                txtProgramNumber.ReadOnly = false;
                //txtPressureATEQ.ReadOnly = false;
                txtLeakATEQ.ReadOnly = false;
                txtStatusATEQ.ReadOnly = false;
            }
        }

        private void is_auto_CheckedChanged(object sender, EventArgs e)
        {
            if (is_auto.Checked)
            {
                txtProgramNumber.ReadOnly = true;
                //txtPressureATEQ.ReadOnly = true;
                txtLeakATEQ.ReadOnly = true;
                txtStatusATEQ.ReadOnly = true;
                txtProgramNumber.Clear();
                //txtPressureATEQ.Clear();
                txtLeakATEQ.Clear();
                txtStatusATEQ.Clear();
            }
        }

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
                    dataGrid_Water.Rows.Add(isn, "Loop 1", startTime, endTime);
                    txt_loop1ISNWater.Clear();
                    loop1_STARTTime.Clear();
                    btn_loop1UploadSFISWater.Enabled = false;

                    SfisResult result = _watersfisService.UploadResult(isn, tomData);
                    MessageBox.Show(
                        result.IsSuccess
                            ? $"Upload Successful: {result.Response}"
                            : $"Upload Failed: {result.Response}\nError: {result.ErrorMessage}",
                        result.IsSuccess? "Success": "Error"
                    );
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
                    dataGrid_Water.Rows.Add(isn, "Loop 2", startTime, endTime);
                    txt_loop1ISNWater.Clear();
                    loop1_STARTTime.Clear();
                    btn_loop1UploadSFISWater.Enabled = false;

                    SfisResult result = _watersfisService.UploadResult(isn, tomData);
                    MessageBox.Show(
                        result.IsSuccess
                            ? $"Upload Successful: {result.Response}"
                            : $"Upload Failed: {result.Response}\nError: {result.ErrorMessage}",
                        result.IsSuccess ? "Success" : "Error"
                    );
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
                    dataGrid_Water.Rows.Add(isn, "Loop 3", startTime, endTime);
                    txt_loop1ISNWater.Clear();
                    loop1_STARTTime.Clear();
                    btn_loop1UploadSFISWater.Enabled = false;

                    SfisResult result = _watersfisService.UploadResult(isn, tomData);
                    MessageBox.Show(
                        result.IsSuccess
                            ? $"Upload Successful: {result.Response}"
                            : $"Upload Failed: {result.Response}\nError: {result.ErrorMessage}",
                        result.IsSuccess ? "Success" : "Error"
                    );
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
                    dataGrid_Water.Rows.Add(isn, "Loop 4", startTime, endTime);
                    txt_loop1ISNWater.Clear();
                    loop1_STARTTime.Clear();
                    btn_loop1UploadSFISWater.Enabled = false;

                    SfisResult result = _watersfisService.UploadResult(isn, tomData);
                    MessageBox.Show(
                        result.IsSuccess
                            ? $"Upload Successful: {result.Response}"
                            : $"Upload Failed: {result.Response}\nError: {result.ErrorMessage}",
                        result.IsSuccess ? "Success" : "Error"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Upexpected error: {ex.Message}", "Error");
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

        private void Allow_N2_Start(object sender, EventArgs e)
        {
            btn_start_N2Filler.Enabled = !string.IsNullOrEmpty(ISN_N2Filler.Text);
        }

        private void Reset_N2_Start(object sender, EventArgs e)
        {
            ISN_N2Filler.Clear();
        }

        private void N2_manual_CheckedChanged(object sender, EventArgs e)
        {
            if (btnN2_manual_radio.Checked)
            {
                N2_txtProgramNumber.ReadOnly = false;
                N2_textBox2.ReadOnly = false;
                N2_textBox3.ReadOnly = false;
            }
        }

        private void Allow_N2_Upload(object sender, EventArgs e)
        {
            AteqResult result;
            btn_N2_upload.Enabled = !string.IsNullOrEmpty(ISN_N2Filler.Text) &&
                     !string.IsNullOrEmpty(N2_txtProgramNumber.Text) &&
                     !string.IsNullOrEmpty(N2_textBox2.Text) &&
                     !string.IsNullOrEmpty(N2_textBox3.Text);
            try
            {
                if (btnN2_auto_radio.Checked && _monitor.TryGetResult(out result) && !string.IsNullOrEmpty(ISN_N2Filler.Text))
                {
#if DEBUG
                    Random rand = new Random();
                    result.Parameters = new Dictionary<string, double> {
                        { "Pressure", rand.NextDouble() * 5.0 },
                        { "LeakRate", rand.NextDouble() * 0.1 },
                        { "TestTime", rand.NextDouble() * 30.0 }
                    };
#endif
                    N2_txtProgramNumber.Text = result.Parameters["Pressure"].ToString("F3");
                    N2_textBox2.Text = result.Parameters["LeakRate"].ToString("F3");
                    N2_textBox3.Text = result.Status;
                }
                else if (string.IsNullOrEmpty(ISN_N2Filler.Text))
                {
                    N2_txtProgramNumber.Clear();
                    N2_textBox2.Clear();
                    N2_textBox3.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Read Failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ISN_N2Filler.Clear();
                N2_txtProgramNumber.Clear();
                N2_textBox2.Clear();
                N2_textBox3.Clear();
                return;
            }
        }

        private void N2_UploadSFIS_Click(object sender, EventArgs e)
        {
            try
            {
                string isn = ISN_N2Filler.Text.Trim();
                string startTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss").Trim();
                string 介質 = N2_txtProgramNumber.Text.Trim();
                string 設定壓力 = N2_textBox2.Text.Trim();
                string 產品壓力 = N2_textBox3.Text.Trim();

                if (!string.IsNullOrEmpty(isn))
                {
                    N2filler_GridView.Rows.Add(isn, startTime, 介質, 設定壓力, 產品壓力);
                    ISN_N2Filler.Clear();
                    N2_txtProgramNumber.Clear();
                    N2_textBox2.Clear();
                    N2_textBox3.Clear();
                    btn_N2_upload.Enabled = false;
                }
            }
            catch (Exception)
            {
            }
        }
    }
}