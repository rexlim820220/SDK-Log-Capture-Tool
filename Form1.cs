using System;
using System.Windows.Forms;
using SDK_Log_Capture_Tool.ATEQ;
using SDK_Log_Capture_Tool.SFIS;
using System.Collections.Generic;

namespace SDK_Log_Capture_Tool
{
    public partial class SDK_Log_Capturer : Form
    {
        private AteqStatusMonitor _monitor;
        private SfisProcess sfis;

        public SDK_Log_Capturer()
        {
            InitializeComponent();
            sfis = SfisProcess.GetInstance();

#if DEBUG
            IAteqModbusTransport transport = new MockModbusTransport();
#else
            IAteqModbusTransport transport = new ModbusTransport("COM3");
#endif
            _monitor = new AteqStatusMonitor(transport);
        }

        private void F620_UploadSFIS_Click(object sender, EventArgs e)
        {
            try
            {
                string isn = txtISNATEQ.Text.Trim();
                string startTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss").Trim();
                string pressure = txtPressureATEQ.Text.Trim();
                string leak = txtLeakATEQ.Text.Trim();
                string status = txtStatusATEQ.Text.Trim();
                string ateqData = $"PRES:{pressure}|LEAK:{leak}|STAT:{status}";

                if (!string.IsNullOrEmpty(isn))
                {
                    dgvFIFOATEQ.Rows.Add(isn, startTime, pressure, leak, status);
                    txtISNATEQ.Clear();
                    txtPressureATEQ.Clear();
                    txtLeakATEQ.Clear();
                    txtStatusATEQ.Clear();
                    btn_upload_SFIS.Enabled = false;

                    if (sfis.UploadResult(isn, ateqData))
                    {
                        MessageBox.Show("上传成功");
                    }
                    else
                    {
                        MessageBox.Show("上传失败");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"SFIS错误: {ex.ErrorCode} - {ex.Message}");
            }
        }

        private void CheckTextBoxes(object sender, EventArgs e)
        {
            bool allFilled = !string.IsNullOrEmpty(txtISNATEQ.Text) &&
                     !string.IsNullOrEmpty(txtPressureATEQ.Text) &&
                     !string.IsNullOrEmpty(txtLeakATEQ.Text) &&
                     !string.IsNullOrEmpty(txtStatusATEQ.Text);
            btn_upload_SFIS.Enabled = allFilled;
            try
            {
                if (is_auto.Checked && _monitor.TryGetResult(out var result) && !string.IsNullOrEmpty(txtISNATEQ.Text))
                {
#if DEBUG
                    Random rand = new Random();
                    result.Parameters = new Dictionary<string, double> {
                        { "Pressure", rand.NextDouble() * 5.0 },
                        { "LeakRate", rand.NextDouble() * 0.1 },
                        { "TestTime", rand.NextDouble() * 30.0 }
                    };
#endif
                    txtPressureATEQ.Text = result.Parameters["Pressure"].ToString("F3");
                    txtLeakATEQ.Text = result.Parameters["LeakRate"].ToString("F3");
                    txtStatusATEQ.Text = result.Status;
                }
                else if(string.IsNullOrEmpty(txtISNATEQ.Text))
                {
                    txtPressureATEQ.Clear();
                    txtLeakATEQ.Clear();
                    txtStatusATEQ.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Read Failed: {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtISNATEQ.Clear();
                txtPressureATEQ.Clear();
                txtLeakATEQ.Clear();
                txtStatusATEQ.Clear();
                return;
            }
        }

        private void is_manual_CheckedChanged(object sender, EventArgs e)
        {
            if (is_manual.Checked)
            {
                txtPressureATEQ.ReadOnly = false;
                txtLeakATEQ.ReadOnly = false;
                txtStatusATEQ.ReadOnly = false;
            }
        }

        private void is_auto_CheckedChanged(object sender, EventArgs e)
        {
            if (is_auto.Checked)
            {
                txtPressureATEQ.ReadOnly = true;
                txtLeakATEQ.ReadOnly = true;
                txtStatusATEQ.ReadOnly = true;
                txtPressureATEQ.Clear();
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

                if (!string.IsNullOrEmpty(isn))
                {
                    dataGrid_Water.Rows.Add(isn, "Loop 1", startTime, endTime);
                    txt_loop1ISNWater.Clear();
                    loop1_STARTTime.Clear();
                    btn_loop1UploadSFISWater.Enabled = false;
                }
            }
            catch (Exception)
            {
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

                if (!string.IsNullOrEmpty(isn))
                {
                    dataGrid_Water.Rows.Add(isn, "Loop 2", startTime, endTime);
                    txt_loop2ISNWater.Clear();
                    loop2_STARTTime.Clear();
                    btn_loop2UploadSFISWater.Enabled = false;
                }
            }
            catch (Exception)
            {
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
                //bool isRunning = _ateqReader.IsTestRunning();
                //lblATEQStatus.Text = isRunning ? "測試中…" : "已完成";

                string isn = txt_loop3ISNWater.Text.Trim();
                string startTime = loop3_STARTTime.Text.Trim();
                string endTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss").Trim();

                if (!string.IsNullOrEmpty(isn))
                {
                    dataGrid_Water.Rows.Add(isn, "Loop 3", startTime, endTime);
                    txt_loop3ISNWater.Clear();
                    loop3_STARTTime.Clear();
                    btn_loop3UploadSFISWater.Enabled = false;
                }
            }
            catch (Exception)
            {
                //lblATEQStatus.Text = $"讀取狀態失敗: {ex.Message}";
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

                if (!string.IsNullOrEmpty(isn))
                {
                    dataGrid_Water.Rows.Add(isn, "Loop 4", startTime, endTime);
                    txt_loop4ISNWater.Clear();
                    loop4_STARTTime.Clear();
                    btn_loop4UploadSFISWater.Enabled = false;
                }
            }
            catch (Exception)
            {
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
                N2_textBox1.ReadOnly = false;
                N2_textBox2.ReadOnly = false;
                N2_textBox3.ReadOnly = false;
            }
        }

        private void Allow_N2_Upload(object sender, EventArgs e)
        {
            btn_N2_upload.Enabled = !string.IsNullOrEmpty(ISN_N2Filler.Text) &&
                     !string.IsNullOrEmpty(N2_textBox1.Text) &&
                     !string.IsNullOrEmpty(N2_textBox2.Text) &&
                     !string.IsNullOrEmpty(N2_textBox3.Text);
            try
            {
                if (btnN2_auto_radio.Checked && _monitor.TryGetResult(out var result) && !string.IsNullOrEmpty(ISN_N2Filler.Text))
                {
#if DEBUG
                    Random rand = new Random();
                    result.Parameters = new Dictionary<string, double> {
                        { "Pressure", rand.NextDouble() * 5.0 },
                        { "LeakRate", rand.NextDouble() * 0.1 },
                        { "TestTime", rand.NextDouble() * 30.0 }
                    };
#endif
                    N2_textBox1.Text = result.Parameters["Pressure"].ToString("F3");
                    N2_textBox2.Text = result.Parameters["LeakRate"].ToString("F3");
                    N2_textBox3.Text = result.Status;
                }
                else if (string.IsNullOrEmpty(ISN_N2Filler.Text))
                {
                    N2_textBox1.Clear();
                    N2_textBox2.Clear();
                    N2_textBox3.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Read Failed: {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ISN_N2Filler.Clear();
                N2_textBox1.Clear();
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
                string 介質 = N2_textBox1.Text.Trim();
                string 設定壓力 = N2_textBox2.Text.Trim();
                string 產品壓力 = N2_textBox3.Text.Trim();

                if (!string.IsNullOrEmpty(isn))
                {
                    N2filler_GridView.Rows.Add(isn, startTime, 介質, 設定壓力, 產品壓力);
                    ISN_N2Filler.Clear();
                    N2_textBox1.Clear();
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