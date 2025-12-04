
namespace SDK_Log_Capture_Tool
{
    partial class SDK_Log_Capturer
    {
        ///<summary>
        ///設計工具所需的變數。
        ///</summary>
        private System.ComponentModel.IContainer components = null;

        ///<summary>
        ///清除任何使用中的資源。
        ///</summary>
        ///<param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        ///<summary>
        ///此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        ///這個方法的內容。
        ///</summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.ATEQ_F620_TabPage = new System.Windows.Forms.TabPage();
            this.ATEQ_groupBox = new System.Windows.Forms.GroupBox();
            this.btn_Rosta_Fetch = new System.Windows.Forms.Button();
            this.check_isRosta = new System.Windows.Forms.CheckBox();
            this.lbltProgramNumber = new System.Windows.Forms.Label();
            this.txtProgramNumber = new System.Windows.Forms.TextBox();
            this.is_auto = new System.Windows.Forms.RadioButton();
            this.btn_upload_SFIS = new System.Windows.Forms.Button();
            this.is_manual = new System.Windows.Forms.RadioButton();
            this.ATEQ_lbl_LeakRate = new System.Windows.Forms.Label();
            this.txtLeakATEQ = new System.Windows.Forms.TextBox();
            this.txtStatusATEQ = new System.Windows.Forms.TextBox();
            this.ATEQ_lbl_Test_Status = new System.Windows.Forms.Label();
            this.dgvFIFOATEQ = new System.Windows.Forms.DataGridView();
            this.ISN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Program = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeakRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SFISisPassed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblISNStatusATEQ = new System.Windows.Forms.Label();
            this.txtISNATEQ = new System.Windows.Forms.TextBox();
            this.label_ISN_F620 = new System.Windows.Forms.Label();
            this.Water_Bath_tabPage = new System.Windows.Forms.TabPage();
            this.dataGrid_Water = new System.Windows.Forms.DataGridView();
            this.dataGrid_Water_ISN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGrid_Water_StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGrid_Water_EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_loop4 = new System.Windows.Forms.GroupBox();
            this.btn_loop4ResetSFISWater = new System.Windows.Forms.Button();
            this.btn_loop4UploadSFISWater = new System.Windows.Forms.Button();
            this.loop4_STARTTime = new System.Windows.Forms.TextBox();
            this.label_loop4ISNWater = new System.Windows.Forms.Label();
            this.txt_loop4ISNWater = new System.Windows.Forms.TextBox();
            this.lbl_loop4_start = new System.Windows.Forms.Label();
            this.group_loop3 = new System.Windows.Forms.GroupBox();
            this.btn_loop3ResetSFISWater = new System.Windows.Forms.Button();
            this.btn_loop3UploadSFISWater = new System.Windows.Forms.Button();
            this.loop3_STARTTime = new System.Windows.Forms.TextBox();
            this.label_loop3ISNWater = new System.Windows.Forms.Label();
            this.txt_loop3ISNWater = new System.Windows.Forms.TextBox();
            this.lbl_loop3_start = new System.Windows.Forms.Label();
            this.group_loop2 = new System.Windows.Forms.GroupBox();
            this.btn_loop2ResetSFISWater = new System.Windows.Forms.Button();
            this.btn_loop2UploadSFISWater = new System.Windows.Forms.Button();
            this.loop2_STARTTime = new System.Windows.Forms.TextBox();
            this.label_loop2ISNWater = new System.Windows.Forms.Label();
            this.txt_loop2ISNWater = new System.Windows.Forms.TextBox();
            this.lbl_loop2_start = new System.Windows.Forms.Label();
            this.group_loop1 = new System.Windows.Forms.GroupBox();
            this.btn_loop1ResetSFISWater = new System.Windows.Forms.Button();
            this.loop1_STARTTime = new System.Windows.Forms.TextBox();
            this.btn_loop1UploadSFISWater = new System.Windows.Forms.Button();
            this.label_loop1ISNWater = new System.Windows.Forms.Label();
            this.txt_loop1ISNWater = new System.Windows.Forms.TextBox();
            this.lbl_loop1_start = new System.Windows.Forms.Label();
            this.N2_Filler_tabPage = new System.Windows.Forms.TabPage();
            this.N2filler_groupBox = new System.Windows.Forms.GroupBox();
            this.btnN2_auto_radio = new System.Windows.Forms.RadioButton();
            this.btn_N2_upload = new System.Windows.Forms.Button();
            this.lbl_N2_medium = new System.Windows.Forms.Label();
            this.btnN2_manual_radio = new System.Windows.Forms.RadioButton();
            this.N2_txtMedium = new System.Windows.Forms.TextBox();
            this.lbl_N2_pressure = new System.Windows.Forms.Label();
            this.N2_txtPressure = new System.Windows.Forms.TextBox();
            this.N2_testStatus = new System.Windows.Forms.TextBox();
            this.lbl_N2_status = new System.Windows.Forms.Label();
            this.N2filler_GridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pressure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModbusTCPStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N2SFIStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_reset_N2Filler = new System.Windows.Forms.Button();
            this.btn_start_N2Filler = new System.Windows.Forms.Button();
            this.label_hint_N2Filler = new System.Windows.Forms.Label();
            this.ISN_N2Filler = new System.Windows.Forms.TextBox();
            this.label_N2Filler = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.ATEQ_F620_TabPage.SuspendLayout();
            this.ATEQ_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFIFOATEQ)).BeginInit();
            this.Water_Bath_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Water)).BeginInit();
            this.group_loop4.SuspendLayout();
            this.group_loop3.SuspendLayout();
            this.group_loop2.SuspendLayout();
            this.group_loop1.SuspendLayout();
            this.N2_Filler_tabPage.SuspendLayout();
            this.N2filler_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.N2filler_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.ATEQ_F620_TabPage);
            this.tabControl.Controls.Add(this.Water_Bath_tabPage);
            this.tabControl.Controls.Add(this.N2_Filler_tabPage);
            this.tabControl.Location = new System.Drawing.Point(21, 8);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1003, 394);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedTab = ATEQ_F620_TabPage;
            this.tabControl.Selecting += TabControl_Selecting;
            // 
            // ATEQ_F620_TabPage
            // 
            this.ATEQ_F620_TabPage.Controls.Add(this.ATEQ_groupBox);
            this.ATEQ_F620_TabPage.Controls.Add(this.dgvFIFOATEQ);
            this.ATEQ_F620_TabPage.Controls.Add(this.lblISNStatusATEQ);
            this.ATEQ_F620_TabPage.Controls.Add(this.txtISNATEQ);
            this.ATEQ_F620_TabPage.Controls.Add(this.label_ISN_F620);
            this.ATEQ_F620_TabPage.Location = new System.Drawing.Point(4, 22);
            this.ATEQ_F620_TabPage.Margin = new System.Windows.Forms.Padding(2);
            this.ATEQ_F620_TabPage.Name = "ATEQ_F620_TabPage";
            this.ATEQ_F620_TabPage.Padding = new System.Windows.Forms.Padding(2);
            this.ATEQ_F620_TabPage.Size = new System.Drawing.Size(995, 368);
            this.ATEQ_F620_TabPage.TabIndex = 0;
            this.ATEQ_F620_TabPage.Text = "ATEQ F620";
            this.ATEQ_F620_TabPage.UseVisualStyleBackColor = true;
            // 
            // ATEQ_groupBox
            // 
            this.ATEQ_groupBox.Controls.Add(this.btn_Rosta_Fetch);
            this.ATEQ_groupBox.Controls.Add(this.check_isRosta);
            this.ATEQ_groupBox.Controls.Add(this.lbltProgramNumber);
            this.ATEQ_groupBox.Controls.Add(this.txtProgramNumber);
            this.ATEQ_groupBox.Controls.Add(this.is_auto);
            this.ATEQ_groupBox.Controls.Add(this.btn_upload_SFIS);
            this.ATEQ_groupBox.Controls.Add(this.is_manual);
            this.ATEQ_groupBox.Controls.Add(this.ATEQ_lbl_LeakRate);
            this.ATEQ_groupBox.Controls.Add(this.txtLeakATEQ);
            this.ATEQ_groupBox.Controls.Add(this.txtStatusATEQ);
            this.ATEQ_groupBox.Controls.Add(this.ATEQ_lbl_Test_Status);
            this.ATEQ_groupBox.Location = new System.Drawing.Point(619, 25);
            this.ATEQ_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.ATEQ_groupBox.Name = "ATEQ_groupBox";
            this.ATEQ_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.ATEQ_groupBox.Size = new System.Drawing.Size(341, 321);
            this.ATEQ_groupBox.TabIndex = 15;
            this.ATEQ_groupBox.TabStop = false;
            // 
            // btn_Rosta_Fetch
            // 
            this.btn_Rosta_Fetch.Enabled = false;
            this.btn_Rosta_Fetch.Location = new System.Drawing.Point(47, 226);
            this.btn_Rosta_Fetch.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Rosta_Fetch.Name = "btn_Rosta_Fetch";
            this.btn_Rosta_Fetch.Size = new System.Drawing.Size(108, 31);
            this.btn_Rosta_Fetch.TabIndex = 14;
            this.btn_Rosta_Fetch.Text = "Fetch Measurement";
            this.btn_Rosta_Fetch.UseVisualStyleBackColor = true;
            this.btn_Rosta_Fetch.Visible = false;
            this.btn_Rosta_Fetch.Click += new System.EventHandler(this.btn_Rosta_Fetch_Click);
            // 
            // check_isRosta
            // 
            this.check_isRosta.AutoSize = true;
            this.check_isRosta.Location = new System.Drawing.Point(60, 60);
            this.check_isRosta.Margin = new System.Windows.Forms.Padding(2);
            this.check_isRosta.Name = "check_isRosta";
            this.check_isRosta.Size = new System.Drawing.Size(225, 16);
            this.check_isRosta.TabIndex = 17;
            this.check_isRosta.Text = "Two-Measurement Batch Mode (ex: Rosta)";
            this.check_isRosta.UseVisualStyleBackColor = true;
            this.check_isRosta.CheckedChanged += new System.EventHandler(this.IsRosta_Checked);
            // 
            // lbltProgramNumber
            // 
            this.lbltProgramNumber.AutoSize = true;
            this.lbltProgramNumber.Location = new System.Drawing.Point(57, 99);
            this.lbltProgramNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltProgramNumber.Name = "lbltProgramNumber";
            this.lbltProgramNumber.Size = new System.Drawing.Size(51, 12);
            this.lbltProgramNumber.TabIndex = 15;
            this.lbltProgramNumber.Text = "Test Item:";
            // 
            // txtProgramNumber
            // 
            this.txtProgramNumber.Location = new System.Drawing.Point(159, 96);
            this.txtProgramNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtProgramNumber.Name = "txtProgramNumber";
            this.txtProgramNumber.ReadOnly = true;
            this.txtProgramNumber.Size = new System.Drawing.Size(129, 22);
            this.txtProgramNumber.TabIndex = 16;
            this.txtProgramNumber.TextChanged += new System.EventHandler(this.CheckF620TextBoxes);
            // 
            // is_auto
            // 
            this.is_auto.AutoSize = true;
            this.is_auto.Checked = true;
            this.is_auto.Location = new System.Drawing.Point(60, 27);
            this.is_auto.Margin = new System.Windows.Forms.Padding(2);
            this.is_auto.Name = "is_auto";
            this.is_auto.Size = new System.Drawing.Size(75, 16);
            this.is_auto.TabIndex = 12;
            this.is_auto.TabStop = true;
            this.is_auto.Text = "Auto mode";
            this.is_auto.UseVisualStyleBackColor = true;
            this.is_auto.CheckedChanged += new System.EventHandler(this.is_auto_CheckedChanged);
            // 
            // btn_upload_SFIS
            // 
            this.btn_upload_SFIS.Enabled = false;
            this.btn_upload_SFIS.Location = new System.Drawing.Point(47, 226);
            this.btn_upload_SFIS.Margin = new System.Windows.Forms.Padding(2);
            this.btn_upload_SFIS.Name = "btn_upload_SFIS";
            this.btn_upload_SFIS.Size = new System.Drawing.Size(108, 31);
            this.btn_upload_SFIS.TabIndex = 14;
            this.btn_upload_SFIS.Text = "Upload to SFIS";
            this.btn_upload_SFIS.UseVisualStyleBackColor = true;
            this.btn_upload_SFIS.Click += new System.EventHandler(this.F620_UploadSFIS_Click);
            // 
            // is_manual
            // 
            this.is_manual.AutoSize = true;
            this.is_manual.Location = new System.Drawing.Point(145, 27);
            this.is_manual.Margin = new System.Windows.Forms.Padding(2);
            this.is_manual.Name = "is_manual";
            this.is_manual.Size = new System.Drawing.Size(87, 16);
            this.is_manual.TabIndex = 13;
            this.is_manual.TabStop = true;
            this.is_manual.Text = "Manual mode";
            this.is_manual.UseVisualStyleBackColor = true;
            this.is_manual.CheckedChanged += new System.EventHandler(this.is_manual_CheckedChanged);
            // 
            // ATEQ_lbl_LeakRate
            // 
            this.ATEQ_lbl_LeakRate.AutoSize = true;
            this.ATEQ_lbl_LeakRate.Location = new System.Drawing.Point(57, 138);
            this.ATEQ_lbl_LeakRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ATEQ_lbl_LeakRate.Name = "ATEQ_lbl_LeakRate";
            this.ATEQ_lbl_LeakRate.Size = new System.Drawing.Size(77, 12);
            this.ATEQ_lbl_LeakRate.TabIndex = 7;
            this.ATEQ_lbl_LeakRate.Text = "Leak Rate (Pa):";
            // 
            // txtLeakATEQ
            // 
            this.txtLeakATEQ.Location = new System.Drawing.Point(159, 136);
            this.txtLeakATEQ.Margin = new System.Windows.Forms.Padding(2);
            this.txtLeakATEQ.Name = "txtLeakATEQ";
            this.txtLeakATEQ.ReadOnly = true;
            this.txtLeakATEQ.Size = new System.Drawing.Size(129, 22);
            this.txtLeakATEQ.TabIndex = 8;
            this.txtLeakATEQ.TextChanged += new System.EventHandler(this.CheckF620TextBoxes);
            // 
            // txtStatusATEQ
            // 
            this.txtStatusATEQ.Location = new System.Drawing.Point(159, 174);
            this.txtStatusATEQ.Margin = new System.Windows.Forms.Padding(2);
            this.txtStatusATEQ.Name = "txtStatusATEQ";
            this.txtStatusATEQ.ReadOnly = true;
            this.txtStatusATEQ.Size = new System.Drawing.Size(129, 22);
            this.txtStatusATEQ.TabIndex = 10;
            this.txtStatusATEQ.TextChanged += new System.EventHandler(this.CheckF620TextBoxes);
            // 
            // ATEQ_lbl_Test_Status
            // 
            this.ATEQ_lbl_Test_Status.AutoSize = true;
            this.ATEQ_lbl_Test_Status.Location = new System.Drawing.Point(57, 176);
            this.ATEQ_lbl_Test_Status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ATEQ_lbl_Test_Status.Name = "ATEQ_lbl_Test_Status";
            this.ATEQ_lbl_Test_Status.Size = new System.Drawing.Size(57, 12);
            this.ATEQ_lbl_Test_Status.TabIndex = 9;
            this.ATEQ_lbl_Test_Status.Text = "Test Status:";
            // 
            // dgvFIFOATEQ
            // 
            this.dgvFIFOATEQ.AllowUserToOrderColumns = true;
            this.dgvFIFOATEQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFIFOATEQ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISN,
            this.Program,
            this.Column1,
            this.LeakRate,
            this.Status_Column,
            this.SFISisPassed});
            this.dgvFIFOATEQ.Location = new System.Drawing.Point(48, 59);
            this.dgvFIFOATEQ.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFIFOATEQ.Name = "dgvFIFOATEQ";
            this.dgvFIFOATEQ.RowHeadersWidth = 62;
            this.dgvFIFOATEQ.RowTemplate.Height = 31;
            this.dgvFIFOATEQ.Size = new System.Drawing.Size(543, 287);
            this.dgvFIFOATEQ.TabIndex = 11;
            // 
            // ISN
            // 
            this.ISN.HeaderText = "ISN";
            this.ISN.MinimumWidth = 8;
            this.ISN.Name = "ISN";
            this.ISN.Width = 150;
            // 
            // Program
            // 
            this.Program.HeaderText = "Start Time";
            this.Program.MinimumWidth = 8;
            this.Program.Name = "Program";
            this.Program.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Program ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // LeakRate
            // 
            this.LeakRate.HeaderText = "Leak Rate";
            this.LeakRate.MinimumWidth = 8;
            this.LeakRate.Name = "LeakRate";
            this.LeakRate.Width = 150;
            // 
            // Status_Column
            // 
            this.Status_Column.HeaderText = "Modbus Status";
            this.Status_Column.MinimumWidth = 8;
            this.Status_Column.Name = "Status_Column";
            this.Status_Column.ToolTipText = "Status";
            this.Status_Column.Width = 150;
            // 
            // SFISisPassed
            // 
            this.SFISisPassed.HeaderText = "SFIS Status";
            this.SFISisPassed.MinimumWidth = 8;
            this.SFISisPassed.Name = "SFISisPassed";
            this.SFISisPassed.Width = 150;
            // 
            // lblISNStatusATEQ
            // 
            this.lblISNStatusATEQ.AutoSize = true;
            this.lblISNStatusATEQ.Location = new System.Drawing.Point(329, 27);
            this.lblISNStatusATEQ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblISNStatusATEQ.Name = "lblISNStatusATEQ";
            this.lblISNStatusATEQ.Size = new System.Drawing.Size(86, 12);
            this.lblISNStatusATEQ.TabIndex = 2;
            this.lblISNStatusATEQ.Text = "(Scan to validate)";
            // 
            // txtISNATEQ
            // 
            this.txtISNATEQ.Location = new System.Drawing.Point(159, 25);
            this.txtISNATEQ.Margin = new System.Windows.Forms.Padding(2);
            this.txtISNATEQ.Name = "txtISNATEQ";
            this.txtISNATEQ.Size = new System.Drawing.Size(154, 22);
            this.txtISNATEQ.TabIndex = 1;
            this.txtISNATEQ.TextChanged += new System.EventHandler(this.CheckF620TextBoxes);
            // 
            // label_ISN_F620
            // 
            this.label_ISN_F620.AutoSize = true;
            this.label_ISN_F620.Location = new System.Drawing.Point(46, 27);
            this.label_ISN_F620.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ISN_F620.MinimumSize = new System.Drawing.Size(1, 2);
            this.label_ISN_F620.Name = "label_ISN_F620";
            this.label_ISN_F620.Size = new System.Drawing.Size(101, 12);
            this.label_ISN_F620.TabIndex = 0;
            this.label_ISN_F620.Text = "ISN (Scan Barcode):";
            // 
            // Water_Bath_tabPage
            // 
            this.Water_Bath_tabPage.Controls.Add(this.dataGrid_Water);
            this.Water_Bath_tabPage.Controls.Add(this.group_loop4);
            this.Water_Bath_tabPage.Controls.Add(this.group_loop3);
            this.Water_Bath_tabPage.Controls.Add(this.group_loop2);
            this.Water_Bath_tabPage.Controls.Add(this.group_loop1);
            this.Water_Bath_tabPage.Enabled = false;
            this.Water_Bath_tabPage.Location = new System.Drawing.Point(4, 22);
            this.Water_Bath_tabPage.Margin = new System.Windows.Forms.Padding(2);
            this.Water_Bath_tabPage.Name = "Water_Bath_tabPage";
            this.Water_Bath_tabPage.Padding = new System.Windows.Forms.Padding(2);
            this.Water_Bath_tabPage.Size = new System.Drawing.Size(995, 368);
            this.Water_Bath_tabPage.TabIndex = 1;
            this.Water_Bath_tabPage.Text = "Water Bath";
            this.Water_Bath_tabPage.UseVisualStyleBackColor = true;
            // 
            // dataGrid_Water
            // 
            this.dataGrid_Water.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Water.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGrid_Water_ISN,
            this.Loop,
            this.dataGrid_Water_StartTime,
            this.dataGrid_Water_EndTime});
            this.dataGrid_Water.Location = new System.Drawing.Point(537, 23);
            this.dataGrid_Water.Margin = new System.Windows.Forms.Padding(2);
            this.dataGrid_Water.Name = "dataGrid_Water";
            this.dataGrid_Water.RowHeadersWidth = 62;
            this.dataGrid_Water.RowTemplate.Height = 31;
            this.dataGrid_Water.Size = new System.Drawing.Size(443, 263);
            this.dataGrid_Water.TabIndex = 14;
            // 
            // dataGrid_Water_ISN
            // 
            this.dataGrid_Water_ISN.HeaderText = "ISN";
            this.dataGrid_Water_ISN.MinimumWidth = 8;
            this.dataGrid_Water_ISN.Name = "dataGrid_Water_ISN";
            this.dataGrid_Water_ISN.Width = 150;
            // 
            // Loop
            // 
            this.Loop.HeaderText = "Loop No.";
            this.Loop.MinimumWidth = 8;
            this.Loop.Name = "Loop";
            this.Loop.Width = 150;
            // 
            // dataGrid_Water_StartTime
            // 
            this.dataGrid_Water_StartTime.HeaderText = "Start Time";
            this.dataGrid_Water_StartTime.MinimumWidth = 8;
            this.dataGrid_Water_StartTime.Name = "dataGrid_Water_StartTime";
            this.dataGrid_Water_StartTime.ToolTipText = "Start Time";
            this.dataGrid_Water_StartTime.Width = 150;
            // 
            // dataGrid_Water_EndTime
            // 
            this.dataGrid_Water_EndTime.HeaderText = "End Time";
            this.dataGrid_Water_EndTime.MinimumWidth = 8;
            this.dataGrid_Water_EndTime.Name = "dataGrid_Water_EndTime";
            this.dataGrid_Water_EndTime.Width = 150;
            // 
            // group_loop4
            // 
            this.group_loop4.Controls.Add(this.btn_loop4ResetSFISWater);
            this.group_loop4.Controls.Add(this.btn_loop4UploadSFISWater);
            this.group_loop4.Controls.Add(this.loop4_STARTTime);
            this.group_loop4.Controls.Add(this.label_loop4ISNWater);
            this.group_loop4.Controls.Add(this.txt_loop4ISNWater);
            this.group_loop4.Controls.Add(this.lbl_loop4_start);
            this.group_loop4.Location = new System.Drawing.Point(17, 237);
            this.group_loop4.Margin = new System.Windows.Forms.Padding(2);
            this.group_loop4.Name = "group_loop4";
            this.group_loop4.Padding = new System.Windows.Forms.Padding(2);
            this.group_loop4.Size = new System.Drawing.Size(500, 65);
            this.group_loop4.TabIndex = 13;
            this.group_loop4.TabStop = false;
            this.group_loop4.Text = "Loop 4";
            // 
            // btn_loop4ResetSFISWater
            // 
            this.btn_loop4ResetSFISWater.Location = new System.Drawing.Point(427, 36);
            this.btn_loop4ResetSFISWater.Margin = new System.Windows.Forms.Padding(2);
            this.btn_loop4ResetSFISWater.Name = "btn_loop4ResetSFISWater";
            this.btn_loop4ResetSFISWater.Size = new System.Drawing.Size(63, 20);
            this.btn_loop4ResetSFISWater.TabIndex = 22;
            this.btn_loop4ResetSFISWater.Text = "Reset";
            this.btn_loop4ResetSFISWater.UseVisualStyleBackColor = true;
            this.btn_loop4ResetSFISWater.Click += new System.EventHandler(this.btn4ResetSFISWater_Click);
            // 
            // btn_loop4UploadSFISWater
            // 
            this.btn_loop4UploadSFISWater.Enabled = false;
            this.btn_loop4UploadSFISWater.Location = new System.Drawing.Point(427, 12);
            this.btn_loop4UploadSFISWater.Margin = new System.Windows.Forms.Padding(2);
            this.btn_loop4UploadSFISWater.Name = "btn_loop4UploadSFISWater";
            this.btn_loop4UploadSFISWater.Size = new System.Drawing.Size(63, 20);
            this.btn_loop4UploadSFISWater.TabIndex = 21;
            this.btn_loop4UploadSFISWater.Text = "Upload";
            this.btn_loop4UploadSFISWater.UseVisualStyleBackColor = true;
            this.btn_loop4UploadSFISWater.Click += new System.EventHandler(this.btn4UploadSFISWater_Click);
            // 
            // loop4_STARTTime
            // 
            this.loop4_STARTTime.Location = new System.Drawing.Point(313, 25);
            this.loop4_STARTTime.Margin = new System.Windows.Forms.Padding(2);
            this.loop4_STARTTime.Name = "loop4_STARTTime";
            this.loop4_STARTTime.ReadOnly = true;
            this.loop4_STARTTime.Size = new System.Drawing.Size(103, 22);
            this.loop4_STARTTime.TabIndex = 20;
            // 
            // label_loop4ISNWater
            // 
            this.label_loop4ISNWater.AutoSize = true;
            this.label_loop4ISNWater.Location = new System.Drawing.Point(12, 29);
            this.label_loop4ISNWater.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_loop4ISNWater.MinimumSize = new System.Drawing.Size(1, 2);
            this.label_loop4ISNWater.Name = "label_loop4ISNWater";
            this.label_loop4ISNWater.Size = new System.Drawing.Size(101, 12);
            this.label_loop4ISNWater.TabIndex = 5;
            this.label_loop4ISNWater.Text = "ISN (Scan Barcode):";
            // 
            // txt_loop4ISNWater
            // 
            this.txt_loop4ISNWater.Location = new System.Drawing.Point(125, 25);
            this.txt_loop4ISNWater.Margin = new System.Windows.Forms.Padding(2);
            this.txt_loop4ISNWater.Name = "txt_loop4ISNWater";
            this.txt_loop4ISNWater.Size = new System.Drawing.Size(103, 22);
            this.txt_loop4ISNWater.TabIndex = 6;
            this.txt_loop4ISNWater.TextChanged += new System.EventHandler(this.loop4ISNWater_TextChanged);
            // 
            // lbl_loop4_start
            // 
            this.lbl_loop4_start.AutoSize = true;
            this.lbl_loop4_start.Location = new System.Drawing.Point(251, 29);
            this.lbl_loop4_start.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_loop4_start.Name = "lbl_loop4_start";
            this.lbl_loop4_start.Size = new System.Drawing.Size(55, 12);
            this.lbl_loop4_start.TabIndex = 7;
            this.lbl_loop4_start.Text = "Start time: ";
            // 
            // group_loop3
            // 
            this.group_loop3.Controls.Add(this.btn_loop3ResetSFISWater);
            this.group_loop3.Controls.Add(this.btn_loop3UploadSFISWater);
            this.group_loop3.Controls.Add(this.loop3_STARTTime);
            this.group_loop3.Controls.Add(this.label_loop3ISNWater);
            this.group_loop3.Controls.Add(this.txt_loop3ISNWater);
            this.group_loop3.Controls.Add(this.lbl_loop3_start);
            this.group_loop3.Location = new System.Drawing.Point(17, 159);
            this.group_loop3.Margin = new System.Windows.Forms.Padding(2);
            this.group_loop3.Name = "group_loop3";
            this.group_loop3.Padding = new System.Windows.Forms.Padding(2);
            this.group_loop3.Size = new System.Drawing.Size(500, 65);
            this.group_loop3.TabIndex = 12;
            this.group_loop3.TabStop = false;
            this.group_loop3.Text = "Loop 3";
            // 
            // btn_loop3ResetSFISWater
            // 
            this.btn_loop3ResetSFISWater.Location = new System.Drawing.Point(427, 41);
            this.btn_loop3ResetSFISWater.Margin = new System.Windows.Forms.Padding(2);
            this.btn_loop3ResetSFISWater.Name = "btn_loop3ResetSFISWater";
            this.btn_loop3ResetSFISWater.Size = new System.Drawing.Size(63, 20);
            this.btn_loop3ResetSFISWater.TabIndex = 20;
            this.btn_loop3ResetSFISWater.Text = "Reset";
            this.btn_loop3ResetSFISWater.UseVisualStyleBackColor = true;
            this.btn_loop3ResetSFISWater.Click += new System.EventHandler(this.btn3ResetSFISWater_Click);
            // 
            // btn_loop3UploadSFISWater
            // 
            this.btn_loop3UploadSFISWater.Enabled = false;
            this.btn_loop3UploadSFISWater.Location = new System.Drawing.Point(427, 17);
            this.btn_loop3UploadSFISWater.Margin = new System.Windows.Forms.Padding(2);
            this.btn_loop3UploadSFISWater.Name = "btn_loop3UploadSFISWater";
            this.btn_loop3UploadSFISWater.Size = new System.Drawing.Size(63, 20);
            this.btn_loop3UploadSFISWater.TabIndex = 19;
            this.btn_loop3UploadSFISWater.Text = "Upload";
            this.btn_loop3UploadSFISWater.UseVisualStyleBackColor = true;
            this.btn_loop3UploadSFISWater.Click += new System.EventHandler(this.btn3UploadSFISWater_Click);
            // 
            // loop3_STARTTime
            // 
            this.loop3_STARTTime.Location = new System.Drawing.Point(313, 25);
            this.loop3_STARTTime.Margin = new System.Windows.Forms.Padding(2);
            this.loop3_STARTTime.Name = "loop3_STARTTime";
            this.loop3_STARTTime.ReadOnly = true;
            this.loop3_STARTTime.Size = new System.Drawing.Size(103, 22);
            this.loop3_STARTTime.TabIndex = 18;
            // 
            // label_loop3ISNWater
            // 
            this.label_loop3ISNWater.AutoSize = true;
            this.label_loop3ISNWater.Location = new System.Drawing.Point(12, 29);
            this.label_loop3ISNWater.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_loop3ISNWater.MinimumSize = new System.Drawing.Size(1, 2);
            this.label_loop3ISNWater.Name = "label_loop3ISNWater";
            this.label_loop3ISNWater.Size = new System.Drawing.Size(101, 12);
            this.label_loop3ISNWater.TabIndex = 5;
            this.label_loop3ISNWater.Text = "ISN (Scan Barcode):";
            // 
            // txt_loop3ISNWater
            // 
            this.txt_loop3ISNWater.Location = new System.Drawing.Point(125, 25);
            this.txt_loop3ISNWater.Margin = new System.Windows.Forms.Padding(2);
            this.txt_loop3ISNWater.Name = "txt_loop3ISNWater";
            this.txt_loop3ISNWater.Size = new System.Drawing.Size(103, 22);
            this.txt_loop3ISNWater.TabIndex = 6;
            this.txt_loop3ISNWater.TextChanged += new System.EventHandler(this.loop3ISNWater_TextChanged);
            // 
            // lbl_loop3_start
            // 
            this.lbl_loop3_start.AutoSize = true;
            this.lbl_loop3_start.Location = new System.Drawing.Point(251, 29);
            this.lbl_loop3_start.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_loop3_start.Name = "lbl_loop3_start";
            this.lbl_loop3_start.Size = new System.Drawing.Size(55, 12);
            this.lbl_loop3_start.TabIndex = 7;
            this.lbl_loop3_start.Text = "Start time: ";
            // 
            // group_loop2
            // 
            this.group_loop2.Controls.Add(this.btn_loop2ResetSFISWater);
            this.group_loop2.Controls.Add(this.btn_loop2UploadSFISWater);
            this.group_loop2.Controls.Add(this.loop2_STARTTime);
            this.group_loop2.Controls.Add(this.label_loop2ISNWater);
            this.group_loop2.Controls.Add(this.txt_loop2ISNWater);
            this.group_loop2.Controls.Add(this.lbl_loop2_start);
            this.group_loop2.Location = new System.Drawing.Point(17, 84);
            this.group_loop2.Margin = new System.Windows.Forms.Padding(2);
            this.group_loop2.Name = "group_loop2";
            this.group_loop2.Padding = new System.Windows.Forms.Padding(2);
            this.group_loop2.Size = new System.Drawing.Size(500, 63);
            this.group_loop2.TabIndex = 13;
            this.group_loop2.TabStop = false;
            this.group_loop2.Text = "Loop 2";
            // 
            // btn_loop2ResetSFISWater
            // 
            this.btn_loop2ResetSFISWater.Location = new System.Drawing.Point(427, 37);
            this.btn_loop2ResetSFISWater.Margin = new System.Windows.Forms.Padding(2);
            this.btn_loop2ResetSFISWater.Name = "btn_loop2ResetSFISWater";
            this.btn_loop2ResetSFISWater.Size = new System.Drawing.Size(63, 20);
            this.btn_loop2ResetSFISWater.TabIndex = 18;
            this.btn_loop2ResetSFISWater.Text = "Reset";
            this.btn_loop2ResetSFISWater.UseVisualStyleBackColor = true;
            this.btn_loop2ResetSFISWater.Click += new System.EventHandler(this.btn2ResetSFISWater_Click);
            // 
            // btn_loop2UploadSFISWater
            // 
            this.btn_loop2UploadSFISWater.Enabled = false;
            this.btn_loop2UploadSFISWater.Location = new System.Drawing.Point(427, 13);
            this.btn_loop2UploadSFISWater.Margin = new System.Windows.Forms.Padding(2);
            this.btn_loop2UploadSFISWater.Name = "btn_loop2UploadSFISWater";
            this.btn_loop2UploadSFISWater.Size = new System.Drawing.Size(63, 20);
            this.btn_loop2UploadSFISWater.TabIndex = 17;
            this.btn_loop2UploadSFISWater.Text = "Upload";
            this.btn_loop2UploadSFISWater.UseVisualStyleBackColor = true;
            this.btn_loop2UploadSFISWater.Click += new System.EventHandler(this.btn2UploadSFISWater_Click);
            // 
            // loop2_STARTTime
            // 
            this.loop2_STARTTime.Location = new System.Drawing.Point(313, 27);
            this.loop2_STARTTime.Margin = new System.Windows.Forms.Padding(2);
            this.loop2_STARTTime.Name = "loop2_STARTTime";
            this.loop2_STARTTime.ReadOnly = true;
            this.loop2_STARTTime.Size = new System.Drawing.Size(103, 22);
            this.loop2_STARTTime.TabIndex = 16;
            // 
            // label_loop2ISNWater
            // 
            this.label_loop2ISNWater.AutoSize = true;
            this.label_loop2ISNWater.Location = new System.Drawing.Point(12, 31);
            this.label_loop2ISNWater.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_loop2ISNWater.MinimumSize = new System.Drawing.Size(1, 2);
            this.label_loop2ISNWater.Name = "label_loop2ISNWater";
            this.label_loop2ISNWater.Size = new System.Drawing.Size(101, 12);
            this.label_loop2ISNWater.TabIndex = 5;
            this.label_loop2ISNWater.Text = "ISN (Scan Barcode):";
            // 
            // txt_loop2ISNWater
            // 
            this.txt_loop2ISNWater.Location = new System.Drawing.Point(125, 27);
            this.txt_loop2ISNWater.Margin = new System.Windows.Forms.Padding(2);
            this.txt_loop2ISNWater.Name = "txt_loop2ISNWater";
            this.txt_loop2ISNWater.Size = new System.Drawing.Size(103, 22);
            this.txt_loop2ISNWater.TabIndex = 6;
            this.txt_loop2ISNWater.TextChanged += new System.EventHandler(this.loop2ISNWater_TextChanged);
            // 
            // lbl_loop2_start
            // 
            this.lbl_loop2_start.AutoSize = true;
            this.lbl_loop2_start.Location = new System.Drawing.Point(251, 32);
            this.lbl_loop2_start.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_loop2_start.Name = "lbl_loop2_start";
            this.lbl_loop2_start.Size = new System.Drawing.Size(55, 12);
            this.lbl_loop2_start.TabIndex = 7;
            this.lbl_loop2_start.Text = "Start time: ";
            // 
            // group_loop1
            // 
            this.group_loop1.Controls.Add(this.btn_loop1ResetSFISWater);
            this.group_loop1.Controls.Add(this.loop1_STARTTime);
            this.group_loop1.Controls.Add(this.btn_loop1UploadSFISWater);
            this.group_loop1.Controls.Add(this.label_loop1ISNWater);
            this.group_loop1.Controls.Add(this.txt_loop1ISNWater);
            this.group_loop1.Controls.Add(this.lbl_loop1_start);
            this.group_loop1.Location = new System.Drawing.Point(17, 11);
            this.group_loop1.Margin = new System.Windows.Forms.Padding(2);
            this.group_loop1.Name = "group_loop1";
            this.group_loop1.Padding = new System.Windows.Forms.Padding(2);
            this.group_loop1.Size = new System.Drawing.Size(500, 63);
            this.group_loop1.TabIndex = 11;
            this.group_loop1.TabStop = false;
            this.group_loop1.Text = "Loop 1";
            // 
            // btn_loop1ResetSFISWater
            // 
            this.btn_loop1ResetSFISWater.Location = new System.Drawing.Point(427, 37);
            this.btn_loop1ResetSFISWater.Margin = new System.Windows.Forms.Padding(2);
            this.btn_loop1ResetSFISWater.Name = "btn_loop1ResetSFISWater";
            this.btn_loop1ResetSFISWater.Size = new System.Drawing.Size(63, 20);
            this.btn_loop1ResetSFISWater.TabIndex = 16;
            this.btn_loop1ResetSFISWater.Text = "Reset";
            this.btn_loop1ResetSFISWater.UseVisualStyleBackColor = true;
            this.btn_loop1ResetSFISWater.Click += new System.EventHandler(this.btn1ResetSFISWater_Click);
            // 
            // loop1_STARTTime
            // 
            this.loop1_STARTTime.Location = new System.Drawing.Point(313, 25);
            this.loop1_STARTTime.Margin = new System.Windows.Forms.Padding(2);
            this.loop1_STARTTime.Name = "loop1_STARTTime";
            this.loop1_STARTTime.ReadOnly = true;
            this.loop1_STARTTime.Size = new System.Drawing.Size(103, 22);
            this.loop1_STARTTime.TabIndex = 14;
            // 
            // btn_loop1UploadSFISWater
            // 
            this.btn_loop1UploadSFISWater.Enabled = false;
            this.btn_loop1UploadSFISWater.Location = new System.Drawing.Point(427, 13);
            this.btn_loop1UploadSFISWater.Margin = new System.Windows.Forms.Padding(2);
            this.btn_loop1UploadSFISWater.Name = "btn_loop1UploadSFISWater";
            this.btn_loop1UploadSFISWater.Size = new System.Drawing.Size(63, 20);
            this.btn_loop1UploadSFISWater.TabIndex = 10;
            this.btn_loop1UploadSFISWater.Text = "Upload";
            this.btn_loop1UploadSFISWater.UseVisualStyleBackColor = true;
            this.btn_loop1UploadSFISWater.Click += new System.EventHandler(this.btn1UploadSFISWater_Click);
            // 
            // label_loop1ISNWater
            // 
            this.label_loop1ISNWater.AutoSize = true;
            this.label_loop1ISNWater.Location = new System.Drawing.Point(12, 29);
            this.label_loop1ISNWater.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_loop1ISNWater.MinimumSize = new System.Drawing.Size(1, 2);
            this.label_loop1ISNWater.Name = "label_loop1ISNWater";
            this.label_loop1ISNWater.Size = new System.Drawing.Size(101, 12);
            this.label_loop1ISNWater.TabIndex = 5;
            this.label_loop1ISNWater.Text = "ISN (Scan Barcode):";
            // 
            // txt_loop1ISNWater
            // 
            this.txt_loop1ISNWater.Location = new System.Drawing.Point(125, 26);
            this.txt_loop1ISNWater.Margin = new System.Windows.Forms.Padding(2);
            this.txt_loop1ISNWater.Name = "txt_loop1ISNWater";
            this.txt_loop1ISNWater.Size = new System.Drawing.Size(103, 22);
            this.txt_loop1ISNWater.TabIndex = 6;
            this.txt_loop1ISNWater.TextChanged += new System.EventHandler(this.loop1ISNWater_TextChanged);
            // 
            // lbl_loop1_start
            // 
            this.lbl_loop1_start.AutoSize = true;
            this.lbl_loop1_start.Location = new System.Drawing.Point(251, 29);
            this.lbl_loop1_start.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_loop1_start.Name = "lbl_loop1_start";
            this.lbl_loop1_start.Size = new System.Drawing.Size(55, 12);
            this.lbl_loop1_start.TabIndex = 7;
            this.lbl_loop1_start.Text = "Start time: ";
            // 
            // N2_Filler_tabPage
            // 
            this.N2_Filler_tabPage.Controls.Add(this.N2filler_groupBox);
            this.N2_Filler_tabPage.Controls.Add(this.N2filler_GridView);
            this.N2_Filler_tabPage.Controls.Add(this.btn_reset_N2Filler);
            this.N2_Filler_tabPage.Controls.Add(this.btn_start_N2Filler);
            this.N2_Filler_tabPage.Controls.Add(this.label_hint_N2Filler);
            this.N2_Filler_tabPage.Controls.Add(this.ISN_N2Filler);
            this.N2_Filler_tabPage.Controls.Add(this.label_N2Filler);
            this.N2_Filler_tabPage.Enabled = false;
            this.N2_Filler_tabPage.Location = new System.Drawing.Point(4, 22);
            this.N2_Filler_tabPage.Margin = new System.Windows.Forms.Padding(2);
            this.N2_Filler_tabPage.Name = "N2_Filler_tabPage";
            this.N2_Filler_tabPage.Padding = new System.Windows.Forms.Padding(2);
            this.N2_Filler_tabPage.Size = new System.Drawing.Size(995, 368);
            this.N2_Filler_tabPage.TabIndex = 2;
            this.N2_Filler_tabPage.Text = "N₂ Filler";
            this.N2_Filler_tabPage.UseVisualStyleBackColor = true;
            // 
            // N2filler_groupBox
            // 
            this.N2filler_groupBox.Controls.Add(this.btnN2_auto_radio);
            this.N2filler_groupBox.Controls.Add(this.btn_N2_upload);
            this.N2filler_groupBox.Controls.Add(this.lbl_N2_medium);
            this.N2filler_groupBox.Controls.Add(this.btnN2_manual_radio);
            this.N2filler_groupBox.Controls.Add(this.N2_txtMedium);
            this.N2filler_groupBox.Controls.Add(this.lbl_N2_pressure);
            this.N2filler_groupBox.Controls.Add(this.N2_txtPressure);
            this.N2filler_groupBox.Controls.Add(this.N2_testStatus);
            this.N2filler_groupBox.Controls.Add(this.lbl_N2_status);
            this.N2filler_groupBox.Location = new System.Drawing.Point(629, 59);
            this.N2filler_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.N2filler_groupBox.Name = "N2filler_groupBox";
            this.N2filler_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.N2filler_groupBox.Size = new System.Drawing.Size(335, 233);
            this.N2filler_groupBox.TabIndex = 16;
            this.N2filler_groupBox.TabStop = false;
            // 
            // btnN2_auto_radio
            // 
            this.btnN2_auto_radio.AutoSize = true;
            this.btnN2_auto_radio.Checked = true;
            this.btnN2_auto_radio.Location = new System.Drawing.Point(52, 27);
            this.btnN2_auto_radio.Margin = new System.Windows.Forms.Padding(2);
            this.btnN2_auto_radio.Name = "btnN2_auto_radio";
            this.btnN2_auto_radio.Size = new System.Drawing.Size(75, 16);
            this.btnN2_auto_radio.TabIndex = 12;
            this.btnN2_auto_radio.TabStop = true;
            this.btnN2_auto_radio.Text = "Auto mode";
            this.btnN2_auto_radio.UseVisualStyleBackColor = true;
            // 
            // btn_N2_upload
            // 
            this.btn_N2_upload.Enabled = false;
            this.btn_N2_upload.Location = new System.Drawing.Point(70, 288);
            this.btn_N2_upload.Name = "btn_N2_upload";
            this.btn_N2_upload.Size = new System.Drawing.Size(162, 46);
            this.btn_N2_upload.TabIndex = 14;
            this.btn_N2_upload.Text = "Upload to SFIS";
            this.btn_N2_upload.UseVisualStyleBackColor = true;
            this.btn_N2_upload.Click += new System.EventHandler(this.N2_UploadSFIS_Click);
            // 
            // lbl_N2_medium
            // 
            this.lbl_N2_medium.AutoSize = true;
            this.lbl_N2_medium.Location = new System.Drawing.Point(50, 72);
            this.lbl_N2_medium.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_N2_medium.Name = "lbl_N2_medium";
            this.lbl_N2_medium.Size = new System.Drawing.Size(47, 12);
            this.lbl_N2_medium.TabIndex = 5;
            this.lbl_N2_medium.Text = "Medium:";
            // 
            // btnN2_manual_radio
            // 
            this.btnN2_manual_radio.AutoSize = true;
            this.btnN2_manual_radio.Location = new System.Drawing.Point(136, 27);
            this.btnN2_manual_radio.Margin = new System.Windows.Forms.Padding(2);
            this.btnN2_manual_radio.Name = "btnN2_manual_radio";
            this.btnN2_manual_radio.Size = new System.Drawing.Size(87, 16);
            this.btnN2_manual_radio.TabIndex = 13;
            this.btnN2_manual_radio.TabStop = true;
            this.btnN2_manual_radio.Text = "Manual mode";
            this.btnN2_manual_radio.UseVisualStyleBackColor = true;
            this.btnN2_manual_radio.CheckedChanged += new System.EventHandler(this.N2_manual_CheckedChanged);
            // 
            // N2_txtMedium
            // 
            this.N2_txtMedium.Location = new System.Drawing.Point(159, 70);
            this.N2_txtMedium.Margin = new System.Windows.Forms.Padding(2);
            this.N2_txtMedium.Name = "N2_txtMedium";
            this.N2_txtMedium.ReadOnly = true;
            this.N2_txtMedium.Size = new System.Drawing.Size(129, 22);
            this.N2_txtMedium.TabIndex = 6;
            this.N2_txtMedium.Text = "Nitrogen (N₂)";
            this.N2_txtMedium.TextChanged += new System.EventHandler(this.N2_manual_upload_enabled);
            // 
            // lbl_N2_pressure
            // 
            this.lbl_N2_pressure.AutoSize = true;
            this.lbl_N2_pressure.Location = new System.Drawing.Point(50, 107);
            this.lbl_N2_pressure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_N2_pressure.Name = "lbl_N2_pressure";
            this.lbl_N2_pressure.Size = new System.Drawing.Size(85, 12);
            this.lbl_N2_pressure.TabIndex = 7;
            this.lbl_N2_pressure.Text = "Product Pressure:";
            // 
            // N2_txtPressure
            // 
            this.N2_txtPressure.Location = new System.Drawing.Point(159, 105);
            this.N2_txtPressure.Margin = new System.Windows.Forms.Padding(2);
            this.N2_txtPressure.Name = "N2_txtPressure";
            this.N2_txtPressure.ReadOnly = true;
            this.N2_txtPressure.Size = new System.Drawing.Size(129, 22);
            this.N2_txtPressure.TabIndex = 8;
            this.N2_txtPressure.TextChanged += new System.EventHandler(this.N2_manual_upload_enabled);
            // 
            // N2_testStatus
            // 
            this.N2_testStatus.Location = new System.Drawing.Point(159, 143);
            this.N2_testStatus.Margin = new System.Windows.Forms.Padding(2);
            this.N2_testStatus.Name = "N2_testStatus";
            this.N2_testStatus.ReadOnly = true;
            this.N2_testStatus.Size = new System.Drawing.Size(129, 22);
            this.N2_testStatus.TabIndex = 10;
            this.N2_testStatus.TextChanged += new System.EventHandler(this.N2_manual_upload_enabled);
            // 
            // lbl_N2_status
            // 
            this.lbl_N2_status.AutoSize = true;
            this.lbl_N2_status.Location = new System.Drawing.Point(50, 145);
            this.lbl_N2_status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_N2_status.Name = "lbl_N2_status";
            this.lbl_N2_status.Size = new System.Drawing.Size(57, 12);
            this.lbl_N2_status.TabIndex = 9;
            this.lbl_N2_status.Text = "Test Status:";
            // 
            // N2filler_GridView
            // 
            this.N2filler_GridView.AllowUserToOrderColumns = true;
            this.N2filler_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.N2filler_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Pressure,
            this.ModbusTCPStatus,
            this.N2SFIStatus});
            this.N2filler_GridView.Location = new System.Drawing.Point(48, 59);
            this.N2filler_GridView.Margin = new System.Windows.Forms.Padding(2);
            this.N2filler_GridView.Name = "N2filler_GridView";
            this.N2filler_GridView.RowHeadersWidth = 62;
            this.N2filler_GridView.RowTemplate.Height = 31;
            this.N2filler_GridView.Size = new System.Drawing.Size(547, 233);
            this.N2filler_GridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ISN";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Start Time";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // Pressure
            // 
            this.Pressure.HeaderText = "Product Pressure";
            this.Pressure.MinimumWidth = 8;
            this.Pressure.Name = "Pressure";
            this.Pressure.Width = 150;
            // 
            // ModbusTCPStatus
            // 
            this.ModbusTCPStatus.HeaderText = "Modbus Status";
            this.ModbusTCPStatus.MinimumWidth = 8;
            this.ModbusTCPStatus.Name = "ModbusTCPStatus";
            this.ModbusTCPStatus.Width = 150;
            // 
            // N2SFIStatus
            // 
            this.N2SFIStatus.HeaderText = "SFIS Status";
            this.N2SFIStatus.MinimumWidth = 8;
            this.N2SFIStatus.Name = "N2SFIStatus";
            this.N2SFIStatus.Width = 150;
            // 
            // btn_reset_N2Filler
            // 
            this.btn_reset_N2Filler.Location = new System.Drawing.Point(572, 18);
            this.btn_reset_N2Filler.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reset_N2Filler.Name = "btn_reset_N2Filler";
            this.btn_reset_N2Filler.Size = new System.Drawing.Size(106, 31);
            this.btn_reset_N2Filler.TabIndex = 9;
            this.btn_reset_N2Filler.Text = "Reset";
            this.btn_reset_N2Filler.UseVisualStyleBackColor = true;
            this.btn_reset_N2Filler.Click += new System.EventHandler(this.Reset_N2_Start);
            // 
            // btn_start_N2Filler
            // 
            this.btn_start_N2Filler.Enabled = false;
            this.btn_start_N2Filler.Location = new System.Drawing.Point(447, 18);
            this.btn_start_N2Filler.Margin = new System.Windows.Forms.Padding(2);
            this.btn_start_N2Filler.Name = "btn_start_N2Filler";
            this.btn_start_N2Filler.Size = new System.Drawing.Size(115, 31);
            this.btn_start_N2Filler.TabIndex = 8;
            this.btn_start_N2Filler.Text = "Start Test";
            this.btn_start_N2Filler.UseVisualStyleBackColor = true;
            this.btn_start_N2Filler.Click += new System.EventHandler(this.N2_fetch_Pressure);
            // 
            // label_hint_N2Filler
            // 
            this.label_hint_N2Filler.AutoSize = true;
            this.label_hint_N2Filler.Location = new System.Drawing.Point(329, 27);
            this.label_hint_N2Filler.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_hint_N2Filler.Name = "label_hint_N2Filler";
            this.label_hint_N2Filler.Size = new System.Drawing.Size(86, 12);
            this.label_hint_N2Filler.TabIndex = 7;
            this.label_hint_N2Filler.Text = "(Scan to validate)";
            // 
            // ISN_N2Filler
            // 
            this.ISN_N2Filler.Location = new System.Drawing.Point(159, 25);
            this.ISN_N2Filler.Margin = new System.Windows.Forms.Padding(2);
            this.ISN_N2Filler.Name = "ISN_N2Filler";
            this.ISN_N2Filler.Size = new System.Drawing.Size(154, 22);
            this.ISN_N2Filler.TabIndex = 6;
            this.ISN_N2Filler.TextChanged += new System.EventHandler(this.Allow_N2_Start);
            // 
            // label_N2Filler
            // 
            this.label_N2Filler.AutoSize = true;
            this.label_N2Filler.Location = new System.Drawing.Point(46, 27);
            this.label_N2Filler.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_N2Filler.MinimumSize = new System.Drawing.Size(1, 2);
            this.label_N2Filler.Name = "label_N2Filler";
            this.label_N2Filler.Size = new System.Drawing.Size(101, 12);
            this.label_N2Filler.TabIndex = 5;
            this.label_N2Filler.Text = "ISN (Scan Barcode):";
            // 
            // SDK_Log_Capturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 413);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SDK_Log_Capturer";
            this.Text = "SDK Log Capturer";
            this.tabControl.ResumeLayout(false);
            this.ATEQ_F620_TabPage.ResumeLayout(false);
            this.ATEQ_F620_TabPage.PerformLayout();
            this.ATEQ_groupBox.ResumeLayout(false);
            this.ATEQ_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFIFOATEQ)).EndInit();
            this.Water_Bath_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Water)).EndInit();
            this.group_loop4.ResumeLayout(false);
            this.group_loop4.PerformLayout();
            this.group_loop3.ResumeLayout(false);
            this.group_loop3.PerformLayout();
            this.group_loop2.ResumeLayout(false);
            this.group_loop2.PerformLayout();
            this.group_loop1.ResumeLayout(false);
            this.group_loop1.PerformLayout();
            this.N2_Filler_tabPage.ResumeLayout(false);
            this.N2_Filler_tabPage.PerformLayout();
            this.N2filler_groupBox.ResumeLayout(false);
            this.N2filler_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.N2filler_GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage ATEQ_F620_TabPage;
        private System.Windows.Forms.TabPage Water_Bath_tabPage;
        private System.Windows.Forms.TabPage N2_Filler_tabPage;
        private System.Windows.Forms.Label label_ISN_F620;
        private System.Windows.Forms.TextBox txtISNATEQ;
        private System.Windows.Forms.Label lblISNStatusATEQ;
        private System.Windows.Forms.Label lbl_loop1_start;
        private System.Windows.Forms.TextBox txt_loop1ISNWater;
        private System.Windows.Forms.Label label_loop1ISNWater;
        private System.Windows.Forms.Button btn_reset_N2Filler;
        private System.Windows.Forms.Button btn_start_N2Filler;
        private System.Windows.Forms.Label label_hint_N2Filler;
        private System.Windows.Forms.TextBox ISN_N2Filler;
        private System.Windows.Forms.Label label_N2Filler;
        private System.Windows.Forms.TextBox txtStatusATEQ;
        private System.Windows.Forms.Label ATEQ_lbl_Test_Status;
        private System.Windows.Forms.TextBox txtLeakATEQ;
        private System.Windows.Forms.Label ATEQ_lbl_LeakRate;
        private System.Windows.Forms.DataGridView dgvFIFOATEQ;
        private System.Windows.Forms.RadioButton is_manual;
        private System.Windows.Forms.RadioButton is_auto;
        private System.Windows.Forms.Button btn_upload_SFIS;
        private System.Windows.Forms.GroupBox group_loop1;
        private System.Windows.Forms.GroupBox group_loop3;
        private System.Windows.Forms.Label label_loop3ISNWater;
        private System.Windows.Forms.TextBox txt_loop3ISNWater;
        private System.Windows.Forms.Label lbl_loop3_start;
        private System.Windows.Forms.GroupBox group_loop2;
        private System.Windows.Forms.Label label_loop2ISNWater;
        private System.Windows.Forms.TextBox txt_loop2ISNWater;
        private System.Windows.Forms.Label lbl_loop2_start;
        private System.Windows.Forms.GroupBox group_loop4;
        private System.Windows.Forms.Label label_loop4ISNWater;
        private System.Windows.Forms.TextBox txt_loop4ISNWater;
        private System.Windows.Forms.Label lbl_loop4_start;
        private System.Windows.Forms.DataGridView dataGrid_Water;
        private System.Windows.Forms.Button btn_loop1UploadSFISWater;
        private System.Windows.Forms.TextBox loop4_STARTTime;
        private System.Windows.Forms.TextBox loop3_STARTTime;
        private System.Windows.Forms.TextBox loop2_STARTTime;
        private System.Windows.Forms.TextBox loop1_STARTTime;
        private System.Windows.Forms.Button btn_loop4ResetSFISWater;
        private System.Windows.Forms.Button btn_loop4UploadSFISWater;
        private System.Windows.Forms.Button btn_loop3ResetSFISWater;
        private System.Windows.Forms.Button btn_loop3UploadSFISWater;
        private System.Windows.Forms.Button btn_loop2ResetSFISWater;
        private System.Windows.Forms.Button btn_loop2UploadSFISWater;
        private System.Windows.Forms.Button btn_loop1ResetSFISWater;
        private System.Windows.Forms.GroupBox ATEQ_groupBox;
        private System.Windows.Forms.GroupBox N2filler_groupBox;
        private System.Windows.Forms.RadioButton btnN2_auto_radio;
        private System.Windows.Forms.Button btn_Rosta_Fetch;
        private System.Windows.Forms.Button btn_N2_upload;
        private System.Windows.Forms.Label lbl_N2_medium;
        private System.Windows.Forms.RadioButton btnN2_manual_radio;
        private System.Windows.Forms.TextBox N2_txtMedium;
        private System.Windows.Forms.Label lbl_N2_pressure;
        private System.Windows.Forms.TextBox N2_txtPressure;
        private System.Windows.Forms.TextBox N2_testStatus;
        private System.Windows.Forms.Label lbl_N2_status;
        private System.Windows.Forms.DataGridView N2filler_GridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGrid_Water_ISN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loop;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGrid_Water_StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGrid_Water_EndTime;
        private System.Windows.Forms.Label lbltProgramNumber;
        private System.Windows.Forms.TextBox txtProgramNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Program;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeakRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn SFISisPassed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pressure;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModbusTCPStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn N2SFIStatus;
        private System.Windows.Forms.CheckBox check_isRosta;
    }
}

