using System;
using System.Windows.Forms;

namespace SDK_Log_Capture_Tool
{
    public partial class SDK_Log_Capturer : Form
    {
	    private IAteqReader _ateqReader;

        public SDK_Log_Capturer()
        {
            InitializeComponent();
        }

        private void SDK_Log_Capturer_Load(object sender, EventArgs e)
        {
            try
            {
                _ateqReader = new AteqModbusReader("COM3");
                lblATEQStatus.Text = "ATEQ Ready";
            }
            catch (Exception ex)
            {
                lblATEQStatus.Text = $"ATEQ Init Failed: {ex.Message}";
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

        private void btnUploadSFISWater_Click(object sender, EventArgs e)
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

        private void txtISNWater_TextChanged(object sender, EventArgs e)
        {

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

        private void btnReadLastATEQ_Click(object sender, EventArgs e)
        {
            try
            {
                var data = _ateqReader.ReadData();
                txtPressureATEQ.Text = data.Pressure.ToString("F3");
                txtLeakATEQ.Text = data.Leak.ToString("F3");
                lblResultATEQ.Text = data.IsPass ? "PASS" : "FAIL";
                lblATEQStatus.Text = "Read Success";
            }
            catch (Exception ex)
            {
                lblATEQStatus.Text = $"Read Failed: {ex.Message}";
            }
        }
    }
}
