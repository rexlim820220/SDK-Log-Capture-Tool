using System;
using System.Windows.Forms;
using SDK_Log_Capture_Tool.ATEQ;

namespace SDK_Log_Capture_Tool
{
    public partial class SDK_Log_Capturer : Form
    {
        private AteqStatusMonitor _monitor;

        public SDK_Log_Capturer()
        {
            InitializeComponent();
        }

        private void SDK_Log_Capturer_Load(object sender, EventArgs e)
        {
            try
            {
                _monitor = new AteqStatusMonitor("COM3");
                txtPressureATEQ.Text = "ATEQ Ready";
            }
            catch (Exception ex)
            {
                txtPressureATEQ.Text = $"ATEQ Init Failed: {ex.Message}";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void N2_Filler_tabPage_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dgvFIFOATEQ_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void loop1ISNWater_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_loop1ISNWater.Text))
            {
                loop1_STARTTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                this.btn_loop1UploadSFISWater.Enabled = true;
            }
        }

        private void loop2ISNWater_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_loop2ISNWater.Text))
            {
                loop2_STARTTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                this.btn_loop2UploadSFISWater.Enabled = true;
            }
        }

        private void loop3ISNWater_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_loop3ISNWater.Text))
            {
                loop3_STARTTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                this.btn_loop3UploadSFISWater.Enabled = true;
            }
        }

        private void loop4ISNWater_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_loop4ISNWater.Text))
            {
                loop4_STARTTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                this.btn_loop4UploadSFISWater.Enabled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Water_Bath_tabPage_Click(object sender, EventArgs e)
        {

        }

        private void lblISNStatusWater_Click(object sender, EventArgs e)
        {

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
                    dataGrid_Water.Rows.Add(isn, startTime, endTime);
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
                // 停止上傳SFIS動作
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
                    dataGrid_Water.Rows.Add(isn, startTime, endTime);
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
                // 停止上傳SFIS動作
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
                    dataGrid_Water.Rows.Add(isn, startTime, endTime);
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
                // 停止上傳SFIS動作
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
                    dataGrid_Water.Rows.Add(isn, startTime, endTime);
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
                // 停止上傳SFIS動作
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

        private void btnReadLastATEQ_Click(object sender, EventArgs e)
        {
            try
            {
                if (_monitor.TryGetResult(out var result))
                {
                    txtPressureATEQ.Text = result.Parameters["Pressure"].ToString("F3");
                    txtLeakATEQ.Text = result.Parameters["LeakRate"].ToString("F3");
                    txtStatusATEQ.Text = result.Status;
                }
                else
                {
                    txtStatusATEQ.Text = "測試尚未完成或結果無效";
                }
            }
            catch (Exception ex)
            {
                txtPressureATEQ.Text = $"Read Failed: {ex.Message}";
            }
        }

        private void txtISNATEQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}