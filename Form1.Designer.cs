
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
            this.lbl_N2_pressure = new System.Windows.Forms.Label();
            this.btnN2_manual_radio = new System.Windows.Forms.RadioButton();
            this.N2_txtProgramNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.N2_textBox2 = new System.Windows.Forms.TextBox();
            this.N2_textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.N2filler_GridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.介質 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.設定壓力 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.產品壓力 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.系統真空 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.壓差 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.進口壓力 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_reset_N2Filler = new System.Windows.Forms.Button();
            this.btn_start_N2Filler = new System.Windows.Forms.Button();
            this.label_hint_N2Filler = new System.Windows.Forms.Label();
            this.ISN_N2Filler = new System.Windows.Forms.TextBox();
            this.label_N2Filler = new System.Windows.Forms.Label();
            this.ISN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Program = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeakRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SFISisPassed = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabControl.Location = new System.Drawing.Point(32, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1504, 591);
            this.tabControl.TabIndex = 0;
            // 
            // ATEQ_F620_TabPage
            // 
            this.ATEQ_F620_TabPage.Controls.Add(this.ATEQ_groupBox);
            this.ATEQ_F620_TabPage.Controls.Add(this.dgvFIFOATEQ);
            this.ATEQ_F620_TabPage.Controls.Add(this.lblISNStatusATEQ);
            this.ATEQ_F620_TabPage.Controls.Add(this.txtISNATEQ);
            this.ATEQ_F620_TabPage.Controls.Add(this.label_ISN_F620);
            this.ATEQ_F620_TabPage.Location = new System.Drawing.Point(4, 28);
            this.ATEQ_F620_TabPage.Name = "ATEQ_F620_TabPage";
            this.ATEQ_F620_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ATEQ_F620_TabPage.Size = new System.Drawing.Size(1496, 559);
            this.ATEQ_F620_TabPage.TabIndex = 0;
            this.ATEQ_F620_TabPage.Text = "ATEQ F620";
            this.ATEQ_F620_TabPage.UseVisualStyleBackColor = true;
            // 
            // ATEQ_groupBox
            // 
            this.ATEQ_groupBox.Controls.Add(this.lbltProgramNumber);
            this.ATEQ_groupBox.Controls.Add(this.txtProgramNumber);
            this.ATEQ_groupBox.Controls.Add(this.is_auto);
            this.ATEQ_groupBox.Controls.Add(this.btn_upload_SFIS);
            this.ATEQ_groupBox.Controls.Add(this.is_manual);
            this.ATEQ_groupBox.Controls.Add(this.ATEQ_lbl_LeakRate);
            this.ATEQ_groupBox.Controls.Add(this.txtLeakATEQ);
            this.ATEQ_groupBox.Controls.Add(this.txtStatusATEQ);
            this.ATEQ_groupBox.Controls.Add(this.ATEQ_lbl_Test_Status);
            this.ATEQ_groupBox.Location = new System.Drawing.Point(928, 38);
            this.ATEQ_groupBox.Name = "ATEQ_groupBox";
            this.ATEQ_groupBox.Size = new System.Drawing.Size(512, 482);
            this.ATEQ_groupBox.TabIndex = 15;
            this.ATEQ_groupBox.TabStop = false;
            // 
            // lbltProgramNumber
            // 
            this.lbltProgramNumber.AutoSize = true;
            this.lbltProgramNumber.Location = new System.Drawing.Point(85, 148);
            this.lbltProgramNumber.Name = "lbltProgramNumber";
            this.lbltProgramNumber.Size = new System.Drawing.Size(80, 18);
            this.lbltProgramNumber.TabIndex = 15;
            this.lbltProgramNumber.Text = "Test Item:";
            // 
            // txtProgramNumber
            // 
            this.txtProgramNumber.Location = new System.Drawing.Point(238, 144);
            this.txtProgramNumber.Name = "txtProgramNumber";
            this.txtProgramNumber.ReadOnly = true;
            this.txtProgramNumber.Size = new System.Drawing.Size(192, 29);
            this.txtProgramNumber.TabIndex = 16;
            this.txtProgramNumber.TextChanged += new System.EventHandler(this.CheckTextBoxes);
            // 
            // is_auto
            // 
            this.is_auto.AutoSize = true;
            this.is_auto.Checked = true;
            this.is_auto.Location = new System.Drawing.Point(78, 40);
            this.is_auto.Name = "is_auto";
            this.is_auto.Size = new System.Drawing.Size(108, 22);
            this.is_auto.TabIndex = 12;
            this.is_auto.TabStop = true;
            this.is_auto.Text = "Auto mode";
            this.is_auto.UseVisualStyleBackColor = true;
            this.is_auto.CheckedChanged += new System.EventHandler(this.is_auto_CheckedChanged);
            // 
            // btn_upload_SFIS
            // 
            this.btn_upload_SFIS.Enabled = false;
            this.btn_upload_SFIS.Location = new System.Drawing.Point(70, 339);
            this.btn_upload_SFIS.Name = "btn_upload_SFIS";
            this.btn_upload_SFIS.Size = new System.Drawing.Size(162, 46);
            this.btn_upload_SFIS.TabIndex = 14;
            this.btn_upload_SFIS.Text = "Upload to SFIS";
            this.btn_upload_SFIS.UseVisualStyleBackColor = true;
            this.btn_upload_SFIS.Click += new System.EventHandler(this.F620_UploadSFIS_Click);
            // 
            // is_manual
            // 
            this.is_manual.AutoSize = true;
            this.is_manual.Location = new System.Drawing.Point(204, 40);
            this.is_manual.Name = "is_manual";
            this.is_manual.Size = new System.Drawing.Size(127, 22);
            this.is_manual.TabIndex = 13;
            this.is_manual.TabStop = true;
            this.is_manual.Text = "Manual mode";
            this.is_manual.UseVisualStyleBackColor = true;
            this.is_manual.CheckedChanged += new System.EventHandler(this.is_manual_CheckedChanged);
            // 
            // ATEQ_lbl_LeakRate
            // 
            this.ATEQ_lbl_LeakRate.AutoSize = true;
            this.ATEQ_lbl_LeakRate.Location = new System.Drawing.Point(86, 207);
            this.ATEQ_lbl_LeakRate.Name = "ATEQ_lbl_LeakRate";
            this.ATEQ_lbl_LeakRate.Size = new System.Drawing.Size(118, 18);
            this.ATEQ_lbl_LeakRate.TabIndex = 7;
            this.ATEQ_lbl_LeakRate.Text = "Leak Rate (Pa):";
            // 
            // txtLeakATEQ
            // 
            this.txtLeakATEQ.Location = new System.Drawing.Point(238, 204);
            this.txtLeakATEQ.Name = "txtLeakATEQ";
            this.txtLeakATEQ.ReadOnly = true;
            this.txtLeakATEQ.Size = new System.Drawing.Size(192, 29);
            this.txtLeakATEQ.TabIndex = 8;
            this.txtLeakATEQ.TextChanged += new System.EventHandler(this.CheckTextBoxes);
            // 
            // txtStatusATEQ
            // 
            this.txtStatusATEQ.Location = new System.Drawing.Point(238, 261);
            this.txtStatusATEQ.Name = "txtStatusATEQ";
            this.txtStatusATEQ.ReadOnly = true;
            this.txtStatusATEQ.Size = new System.Drawing.Size(192, 29);
            this.txtStatusATEQ.TabIndex = 10;
            this.txtStatusATEQ.TextChanged += new System.EventHandler(this.CheckTextBoxes);
            // 
            // ATEQ_lbl_Test_Status
            // 
            this.ATEQ_lbl_Test_Status.AutoSize = true;
            this.ATEQ_lbl_Test_Status.Location = new System.Drawing.Point(86, 264);
            this.ATEQ_lbl_Test_Status.Name = "ATEQ_lbl_Test_Status";
            this.ATEQ_lbl_Test_Status.Size = new System.Drawing.Size(90, 18);
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
            this.dgvFIFOATEQ.Location = new System.Drawing.Point(72, 88);
            this.dgvFIFOATEQ.Name = "dgvFIFOATEQ";
            this.dgvFIFOATEQ.RowHeadersWidth = 62;
            this.dgvFIFOATEQ.RowTemplate.Height = 31;
            this.dgvFIFOATEQ.Size = new System.Drawing.Size(814, 430);
            this.dgvFIFOATEQ.TabIndex = 11;
            // 
            // lblISNStatusATEQ
            // 
            this.lblISNStatusATEQ.AutoSize = true;
            this.lblISNStatusATEQ.Location = new System.Drawing.Point(494, 40);
            this.lblISNStatusATEQ.Name = "lblISNStatusATEQ";
            this.lblISNStatusATEQ.Size = new System.Drawing.Size(131, 18);
            this.lblISNStatusATEQ.TabIndex = 2;
            this.lblISNStatusATEQ.Text = "(Scan to validate)";
            // 
            // txtISNATEQ
            // 
            this.txtISNATEQ.Location = new System.Drawing.Point(238, 38);
            this.txtISNATEQ.Name = "txtISNATEQ";
            this.txtISNATEQ.Size = new System.Drawing.Size(229, 29);
            this.txtISNATEQ.TabIndex = 1;
            this.txtISNATEQ.TextChanged += new System.EventHandler(this.CheckTextBoxes);
            // 
            // label_ISN_F620
            // 
            this.label_ISN_F620.AutoSize = true;
            this.label_ISN_F620.Location = new System.Drawing.Point(69, 40);
            this.label_ISN_F620.MinimumSize = new System.Drawing.Size(2, 3);
            this.label_ISN_F620.Name = "label_ISN_F620";
            this.label_ISN_F620.Size = new System.Drawing.Size(152, 18);
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
            this.Water_Bath_tabPage.Location = new System.Drawing.Point(4, 28);
            this.Water_Bath_tabPage.Name = "Water_Bath_tabPage";
            this.Water_Bath_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Water_Bath_tabPage.Size = new System.Drawing.Size(1496, 559);
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
            this.dataGrid_Water.Location = new System.Drawing.Point(806, 34);
            this.dataGrid_Water.Name = "dataGrid_Water";
            this.dataGrid_Water.RowHeadersWidth = 62;
            this.dataGrid_Water.RowTemplate.Height = 31;
            this.dataGrid_Water.Size = new System.Drawing.Size(664, 394);
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
            this.group_loop4.Location = new System.Drawing.Point(26, 356);
            this.group_loop4.Name = "group_loop4";
            this.group_loop4.Size = new System.Drawing.Size(750, 98);
            this.group_loop4.TabIndex = 13;
            this.group_loop4.TabStop = false;
            this.group_loop4.Text = "Loop 4";
            // 
            // btn_loop4ResetSFISWater
            // 
            this.btn_loop4ResetSFISWater.Location = new System.Drawing.Point(640, 54);
            this.btn_loop4ResetSFISWater.Name = "btn_loop4ResetSFISWater";
            this.btn_loop4ResetSFISWater.Size = new System.Drawing.Size(94, 30);
            this.btn_loop4ResetSFISWater.TabIndex = 22;
            this.btn_loop4ResetSFISWater.Text = "Reset";
            this.btn_loop4ResetSFISWater.UseVisualStyleBackColor = true;
            this.btn_loop4ResetSFISWater.Click += new System.EventHandler(this.btn4ResetSFISWater_Click);
            // 
            // btn_loop4UploadSFISWater
            // 
            this.btn_loop4UploadSFISWater.Enabled = false;
            this.btn_loop4UploadSFISWater.Location = new System.Drawing.Point(640, 18);
            this.btn_loop4UploadSFISWater.Name = "btn_loop4UploadSFISWater";
            this.btn_loop4UploadSFISWater.Size = new System.Drawing.Size(94, 30);
            this.btn_loop4UploadSFISWater.TabIndex = 21;
            this.btn_loop4UploadSFISWater.Text = "Upload";
            this.btn_loop4UploadSFISWater.UseVisualStyleBackColor = true;
            this.btn_loop4UploadSFISWater.Click += new System.EventHandler(this.btn4UploadSFISWater_Click);
            // 
            // loop4_STARTTime
            // 
            this.loop4_STARTTime.Location = new System.Drawing.Point(470, 38);
            this.loop4_STARTTime.Name = "loop4_STARTTime";
            this.loop4_STARTTime.ReadOnly = true;
            this.loop4_STARTTime.Size = new System.Drawing.Size(152, 29);
            this.loop4_STARTTime.TabIndex = 20;
            // 
            // label_loop4ISNWater
            // 
            this.label_loop4ISNWater.AutoSize = true;
            this.label_loop4ISNWater.Location = new System.Drawing.Point(18, 44);
            this.label_loop4ISNWater.MinimumSize = new System.Drawing.Size(2, 3);
            this.label_loop4ISNWater.Name = "label_loop4ISNWater";
            this.label_loop4ISNWater.Size = new System.Drawing.Size(152, 18);
            this.label_loop4ISNWater.TabIndex = 5;
            this.label_loop4ISNWater.Text = "ISN (Scan Barcode):";
            // 
            // txt_loop4ISNWater
            // 
            this.txt_loop4ISNWater.Location = new System.Drawing.Point(188, 38);
            this.txt_loop4ISNWater.Name = "txt_loop4ISNWater";
            this.txt_loop4ISNWater.Size = new System.Drawing.Size(152, 29);
            this.txt_loop4ISNWater.TabIndex = 6;
            this.txt_loop4ISNWater.TextChanged += new System.EventHandler(this.loop4ISNWater_TextChanged);
            // 
            // lbl_loop4_start
            // 
            this.lbl_loop4_start.AutoSize = true;
            this.lbl_loop4_start.Location = new System.Drawing.Point(376, 44);
            this.lbl_loop4_start.Name = "lbl_loop4_start";
            this.lbl_loop4_start.Size = new System.Drawing.Size(87, 18);
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
            this.group_loop3.Location = new System.Drawing.Point(26, 238);
            this.group_loop3.Name = "group_loop3";
            this.group_loop3.Size = new System.Drawing.Size(750, 98);
            this.group_loop3.TabIndex = 12;
            this.group_loop3.TabStop = false;
            this.group_loop3.Text = "Loop 3";
            // 
            // btn_loop3ResetSFISWater
            // 
            this.btn_loop3ResetSFISWater.Location = new System.Drawing.Point(640, 62);
            this.btn_loop3ResetSFISWater.Name = "btn_loop3ResetSFISWater";
            this.btn_loop3ResetSFISWater.Size = new System.Drawing.Size(94, 30);
            this.btn_loop3ResetSFISWater.TabIndex = 20;
            this.btn_loop3ResetSFISWater.Text = "Reset";
            this.btn_loop3ResetSFISWater.UseVisualStyleBackColor = true;
            this.btn_loop3ResetSFISWater.Click += new System.EventHandler(this.btn3ResetSFISWater_Click);
            // 
            // btn_loop3UploadSFISWater
            // 
            this.btn_loop3UploadSFISWater.Enabled = false;
            this.btn_loop3UploadSFISWater.Location = new System.Drawing.Point(640, 26);
            this.btn_loop3UploadSFISWater.Name = "btn_loop3UploadSFISWater";
            this.btn_loop3UploadSFISWater.Size = new System.Drawing.Size(94, 30);
            this.btn_loop3UploadSFISWater.TabIndex = 19;
            this.btn_loop3UploadSFISWater.Text = "Upload";
            this.btn_loop3UploadSFISWater.UseVisualStyleBackColor = true;
            this.btn_loop3UploadSFISWater.Click += new System.EventHandler(this.btn3UploadSFISWater_Click);
            // 
            // loop3_STARTTime
            // 
            this.loop3_STARTTime.Location = new System.Drawing.Point(470, 38);
            this.loop3_STARTTime.Name = "loop3_STARTTime";
            this.loop3_STARTTime.ReadOnly = true;
            this.loop3_STARTTime.Size = new System.Drawing.Size(152, 29);
            this.loop3_STARTTime.TabIndex = 18;
            // 
            // label_loop3ISNWater
            // 
            this.label_loop3ISNWater.AutoSize = true;
            this.label_loop3ISNWater.Location = new System.Drawing.Point(18, 44);
            this.label_loop3ISNWater.MinimumSize = new System.Drawing.Size(2, 3);
            this.label_loop3ISNWater.Name = "label_loop3ISNWater";
            this.label_loop3ISNWater.Size = new System.Drawing.Size(152, 18);
            this.label_loop3ISNWater.TabIndex = 5;
            this.label_loop3ISNWater.Text = "ISN (Scan Barcode):";
            // 
            // txt_loop3ISNWater
            // 
            this.txt_loop3ISNWater.Location = new System.Drawing.Point(188, 38);
            this.txt_loop3ISNWater.Name = "txt_loop3ISNWater";
            this.txt_loop3ISNWater.Size = new System.Drawing.Size(152, 29);
            this.txt_loop3ISNWater.TabIndex = 6;
            this.txt_loop3ISNWater.TextChanged += new System.EventHandler(this.loop3ISNWater_TextChanged);
            // 
            // lbl_loop3_start
            // 
            this.lbl_loop3_start.AutoSize = true;
            this.lbl_loop3_start.Location = new System.Drawing.Point(376, 44);
            this.lbl_loop3_start.Name = "lbl_loop3_start";
            this.lbl_loop3_start.Size = new System.Drawing.Size(87, 18);
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
            this.group_loop2.Location = new System.Drawing.Point(26, 126);
            this.group_loop2.Name = "group_loop2";
            this.group_loop2.Size = new System.Drawing.Size(750, 94);
            this.group_loop2.TabIndex = 13;
            this.group_loop2.TabStop = false;
            this.group_loop2.Text = "Loop 2";
            // 
            // btn_loop2ResetSFISWater
            // 
            this.btn_loop2ResetSFISWater.Location = new System.Drawing.Point(640, 56);
            this.btn_loop2ResetSFISWater.Name = "btn_loop2ResetSFISWater";
            this.btn_loop2ResetSFISWater.Size = new System.Drawing.Size(94, 30);
            this.btn_loop2ResetSFISWater.TabIndex = 18;
            this.btn_loop2ResetSFISWater.Text = "Reset";
            this.btn_loop2ResetSFISWater.UseVisualStyleBackColor = true;
            this.btn_loop2ResetSFISWater.Click += new System.EventHandler(this.btn2ResetSFISWater_Click);
            // 
            // btn_loop2UploadSFISWater
            // 
            this.btn_loop2UploadSFISWater.Enabled = false;
            this.btn_loop2UploadSFISWater.Location = new System.Drawing.Point(640, 20);
            this.btn_loop2UploadSFISWater.Name = "btn_loop2UploadSFISWater";
            this.btn_loop2UploadSFISWater.Size = new System.Drawing.Size(94, 30);
            this.btn_loop2UploadSFISWater.TabIndex = 17;
            this.btn_loop2UploadSFISWater.Text = "Upload";
            this.btn_loop2UploadSFISWater.UseVisualStyleBackColor = true;
            this.btn_loop2UploadSFISWater.Click += new System.EventHandler(this.btn2UploadSFISWater_Click);
            // 
            // loop2_STARTTime
            // 
            this.loop2_STARTTime.Location = new System.Drawing.Point(470, 40);
            this.loop2_STARTTime.Name = "loop2_STARTTime";
            this.loop2_STARTTime.ReadOnly = true;
            this.loop2_STARTTime.Size = new System.Drawing.Size(152, 29);
            this.loop2_STARTTime.TabIndex = 16;
            // 
            // label_loop2ISNWater
            // 
            this.label_loop2ISNWater.AutoSize = true;
            this.label_loop2ISNWater.Location = new System.Drawing.Point(18, 46);
            this.label_loop2ISNWater.MinimumSize = new System.Drawing.Size(2, 3);
            this.label_loop2ISNWater.Name = "label_loop2ISNWater";
            this.label_loop2ISNWater.Size = new System.Drawing.Size(152, 18);
            this.label_loop2ISNWater.TabIndex = 5;
            this.label_loop2ISNWater.Text = "ISN (Scan Barcode):";
            // 
            // txt_loop2ISNWater
            // 
            this.txt_loop2ISNWater.Location = new System.Drawing.Point(188, 40);
            this.txt_loop2ISNWater.Name = "txt_loop2ISNWater";
            this.txt_loop2ISNWater.Size = new System.Drawing.Size(152, 29);
            this.txt_loop2ISNWater.TabIndex = 6;
            this.txt_loop2ISNWater.TextChanged += new System.EventHandler(this.loop2ISNWater_TextChanged);
            // 
            // lbl_loop2_start
            // 
            this.lbl_loop2_start.AutoSize = true;
            this.lbl_loop2_start.Location = new System.Drawing.Point(376, 48);
            this.lbl_loop2_start.Name = "lbl_loop2_start";
            this.lbl_loop2_start.Size = new System.Drawing.Size(87, 18);
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
            this.group_loop1.Location = new System.Drawing.Point(26, 16);
            this.group_loop1.Name = "group_loop1";
            this.group_loop1.Size = new System.Drawing.Size(750, 94);
            this.group_loop1.TabIndex = 11;
            this.group_loop1.TabStop = false;
            this.group_loop1.Text = "Loop 1";
            // 
            // btn_loop1ResetSFISWater
            // 
            this.btn_loop1ResetSFISWater.Location = new System.Drawing.Point(640, 56);
            this.btn_loop1ResetSFISWater.Name = "btn_loop1ResetSFISWater";
            this.btn_loop1ResetSFISWater.Size = new System.Drawing.Size(94, 30);
            this.btn_loop1ResetSFISWater.TabIndex = 16;
            this.btn_loop1ResetSFISWater.Text = "Reset";
            this.btn_loop1ResetSFISWater.UseVisualStyleBackColor = true;
            this.btn_loop1ResetSFISWater.Click += new System.EventHandler(this.btn1ResetSFISWater_Click);
            // 
            // loop1_STARTTime
            // 
            this.loop1_STARTTime.Location = new System.Drawing.Point(470, 38);
            this.loop1_STARTTime.Name = "loop1_STARTTime";
            this.loop1_STARTTime.ReadOnly = true;
            this.loop1_STARTTime.Size = new System.Drawing.Size(152, 29);
            this.loop1_STARTTime.TabIndex = 14;
            // 
            // btn_loop1UploadSFISWater
            // 
            this.btn_loop1UploadSFISWater.Enabled = false;
            this.btn_loop1UploadSFISWater.Location = new System.Drawing.Point(640, 20);
            this.btn_loop1UploadSFISWater.Name = "btn_loop1UploadSFISWater";
            this.btn_loop1UploadSFISWater.Size = new System.Drawing.Size(94, 30);
            this.btn_loop1UploadSFISWater.TabIndex = 10;
            this.btn_loop1UploadSFISWater.Text = "Upload";
            this.btn_loop1UploadSFISWater.UseVisualStyleBackColor = true;
            this.btn_loop1UploadSFISWater.Click += new System.EventHandler(this.btn1UploadSFISWater_Click);
            // 
            // label_loop1ISNWater
            // 
            this.label_loop1ISNWater.AutoSize = true;
            this.label_loop1ISNWater.Location = new System.Drawing.Point(18, 44);
            this.label_loop1ISNWater.MinimumSize = new System.Drawing.Size(2, 3);
            this.label_loop1ISNWater.Name = "label_loop1ISNWater";
            this.label_loop1ISNWater.Size = new System.Drawing.Size(152, 18);
            this.label_loop1ISNWater.TabIndex = 5;
            this.label_loop1ISNWater.Text = "ISN (Scan Barcode):";
            // 
            // txt_loop1ISNWater
            // 
            this.txt_loop1ISNWater.Location = new System.Drawing.Point(188, 39);
            this.txt_loop1ISNWater.Name = "txt_loop1ISNWater";
            this.txt_loop1ISNWater.Size = new System.Drawing.Size(152, 29);
            this.txt_loop1ISNWater.TabIndex = 6;
            this.txt_loop1ISNWater.TextChanged += new System.EventHandler(this.loop1ISNWater_TextChanged);
            // 
            // lbl_loop1_start
            // 
            this.lbl_loop1_start.AutoSize = true;
            this.lbl_loop1_start.Location = new System.Drawing.Point(376, 44);
            this.lbl_loop1_start.Name = "lbl_loop1_start";
            this.lbl_loop1_start.Size = new System.Drawing.Size(87, 18);
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
            this.N2_Filler_tabPage.Location = new System.Drawing.Point(4, 28);
            this.N2_Filler_tabPage.Name = "N2_Filler_tabPage";
            this.N2_Filler_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.N2_Filler_tabPage.Size = new System.Drawing.Size(1496, 559);
            this.N2_Filler_tabPage.TabIndex = 2;
            this.N2_Filler_tabPage.Text = "N₂ Filler";
            this.N2_Filler_tabPage.UseVisualStyleBackColor = true;
            // 
            // N2filler_groupBox
            // 
            this.N2filler_groupBox.Controls.Add(this.btnN2_auto_radio);
            this.N2filler_groupBox.Controls.Add(this.btn_N2_upload);
            this.N2filler_groupBox.Controls.Add(this.lbl_N2_pressure);
            this.N2filler_groupBox.Controls.Add(this.btnN2_manual_radio);
            this.N2filler_groupBox.Controls.Add(this.N2_txtProgramNumber);
            this.N2filler_groupBox.Controls.Add(this.label2);
            this.N2filler_groupBox.Controls.Add(this.N2_textBox2);
            this.N2filler_groupBox.Controls.Add(this.N2_textBox3);
            this.N2filler_groupBox.Controls.Add(this.label3);
            this.N2filler_groupBox.Location = new System.Drawing.Point(944, 88);
            this.N2filler_groupBox.Name = "N2filler_groupBox";
            this.N2filler_groupBox.Size = new System.Drawing.Size(502, 350);
            this.N2filler_groupBox.TabIndex = 16;
            this.N2filler_groupBox.TabStop = false;
            // 
            // btnN2_auto_radio
            // 
            this.btnN2_auto_radio.AutoSize = true;
            this.btnN2_auto_radio.Checked = true;
            this.btnN2_auto_radio.Location = new System.Drawing.Point(78, 40);
            this.btnN2_auto_radio.Name = "btnN2_auto_radio";
            this.btnN2_auto_radio.Size = new System.Drawing.Size(108, 22);
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
            // lbl_N2_pressure
            // 
            this.lbl_N2_pressure.AutoSize = true;
            this.lbl_N2_pressure.Location = new System.Drawing.Point(75, 108);
            this.lbl_N2_pressure.Name = "lbl_N2_pressure";
            this.lbl_N2_pressure.Size = new System.Drawing.Size(49, 18);
            this.lbl_N2_pressure.TabIndex = 5;
            this.lbl_N2_pressure.Text = "介質:";
            // 
            // btnN2_manual_radio
            // 
            this.btnN2_manual_radio.AutoSize = true;
            this.btnN2_manual_radio.Location = new System.Drawing.Point(204, 40);
            this.btnN2_manual_radio.Name = "btnN2_manual_radio";
            this.btnN2_manual_radio.Size = new System.Drawing.Size(127, 22);
            this.btnN2_manual_radio.TabIndex = 13;
            this.btnN2_manual_radio.TabStop = true;
            this.btnN2_manual_radio.Text = "Manual mode";
            this.btnN2_manual_radio.UseVisualStyleBackColor = true;
            this.btnN2_manual_radio.CheckedChanged += new System.EventHandler(this.N2_manual_CheckedChanged);
            // 
            // N2_txtProgramNumber
            // 
            this.N2_txtProgramNumber.Location = new System.Drawing.Point(238, 105);
            this.N2_txtProgramNumber.Name = "N2_txtProgramNumber";
            this.N2_txtProgramNumber.ReadOnly = true;
            this.N2_txtProgramNumber.Size = new System.Drawing.Size(192, 29);
            this.N2_txtProgramNumber.TabIndex = 6;
            this.N2_txtProgramNumber.TextChanged += new System.EventHandler(this.Allow_N2_Upload);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "設定壓力:";
            // 
            // N2_textBox2
            // 
            this.N2_textBox2.Location = new System.Drawing.Point(238, 158);
            this.N2_textBox2.Name = "N2_textBox2";
            this.N2_textBox2.ReadOnly = true;
            this.N2_textBox2.Size = new System.Drawing.Size(192, 29);
            this.N2_textBox2.TabIndex = 8;
            this.N2_textBox2.TextChanged += new System.EventHandler(this.Allow_N2_Upload);
            // 
            // N2_textBox3
            // 
            this.N2_textBox3.Location = new System.Drawing.Point(238, 214);
            this.N2_textBox3.Name = "N2_textBox3";
            this.N2_textBox3.ReadOnly = true;
            this.N2_textBox3.Size = new System.Drawing.Size(192, 29);
            this.N2_textBox3.TabIndex = 10;
            this.N2_textBox3.TextChanged += new System.EventHandler(this.Allow_N2_Upload);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "產品壓力:";
            // 
            // N2filler_GridView
            // 
            this.N2filler_GridView.AllowUserToOrderColumns = true;
            this.N2filler_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.N2filler_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.介質,
            this.設定壓力,
            this.產品壓力,
            this.系統真空,
            this.壓差,
            this.進口壓力});
            this.N2filler_GridView.Location = new System.Drawing.Point(72, 88);
            this.N2filler_GridView.Name = "N2filler_GridView";
            this.N2filler_GridView.RowHeadersWidth = 62;
            this.N2filler_GridView.RowTemplate.Height = 31;
            this.N2filler_GridView.Size = new System.Drawing.Size(820, 350);
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
            // 介質
            // 
            this.介質.HeaderText = "介質";
            this.介質.MinimumWidth = 8;
            this.介質.Name = "介質";
            this.介質.Width = 150;
            // 
            // 設定壓力
            // 
            this.設定壓力.HeaderText = "設定壓力";
            this.設定壓力.MinimumWidth = 8;
            this.設定壓力.Name = "設定壓力";
            this.設定壓力.Width = 150;
            // 
            // 產品壓力
            // 
            this.產品壓力.HeaderText = "產品壓力";
            this.產品壓力.MinimumWidth = 8;
            this.產品壓力.Name = "產品壓力";
            this.產品壓力.Width = 150;
            // 
            // 系統真空
            // 
            this.系統真空.HeaderText = "系統真空";
            this.系統真空.MinimumWidth = 8;
            this.系統真空.Name = "系統真空";
            this.系統真空.Width = 150;
            // 
            // 壓差
            // 
            this.壓差.HeaderText = "壓差";
            this.壓差.MinimumWidth = 8;
            this.壓差.Name = "壓差";
            this.壓差.Width = 150;
            // 
            // 進口壓力
            // 
            this.進口壓力.HeaderText = "進口壓力";
            this.進口壓力.MinimumWidth = 8;
            this.進口壓力.Name = "進口壓力";
            this.進口壓力.Width = 150;
            // 
            // btn_reset_N2Filler
            // 
            this.btn_reset_N2Filler.Location = new System.Drawing.Point(858, 27);
            this.btn_reset_N2Filler.Name = "btn_reset_N2Filler";
            this.btn_reset_N2Filler.Size = new System.Drawing.Size(159, 46);
            this.btn_reset_N2Filler.TabIndex = 9;
            this.btn_reset_N2Filler.Text = "Reset";
            this.btn_reset_N2Filler.UseVisualStyleBackColor = true;
            this.btn_reset_N2Filler.Click += new System.EventHandler(this.Reset_N2_Start);
            // 
            // btn_start_N2Filler
            // 
            this.btn_start_N2Filler.Enabled = false;
            this.btn_start_N2Filler.Location = new System.Drawing.Point(670, 27);
            this.btn_start_N2Filler.Name = "btn_start_N2Filler";
            this.btn_start_N2Filler.Size = new System.Drawing.Size(172, 46);
            this.btn_start_N2Filler.TabIndex = 8;
            this.btn_start_N2Filler.Text = "Start Test";
            this.btn_start_N2Filler.UseVisualStyleBackColor = true;
            // 
            // label_hint_N2Filler
            // 
            this.label_hint_N2Filler.AutoSize = true;
            this.label_hint_N2Filler.Location = new System.Drawing.Point(494, 40);
            this.label_hint_N2Filler.Name = "label_hint_N2Filler";
            this.label_hint_N2Filler.Size = new System.Drawing.Size(131, 18);
            this.label_hint_N2Filler.TabIndex = 7;
            this.label_hint_N2Filler.Text = "(Scan to validate)";
            // 
            // ISN_N2Filler
            // 
            this.ISN_N2Filler.Location = new System.Drawing.Point(238, 38);
            this.ISN_N2Filler.Name = "ISN_N2Filler";
            this.ISN_N2Filler.Size = new System.Drawing.Size(229, 29);
            this.ISN_N2Filler.TabIndex = 6;
            this.ISN_N2Filler.TextChanged += new System.EventHandler(this.Allow_N2_Start);
            // 
            // label_N2Filler
            // 
            this.label_N2Filler.AutoSize = true;
            this.label_N2Filler.Location = new System.Drawing.Point(69, 40);
            this.label_N2Filler.MinimumSize = new System.Drawing.Size(2, 3);
            this.label_N2Filler.Name = "label_N2Filler";
            this.label_N2Filler.Size = new System.Drawing.Size(152, 18);
            this.label_N2Filler.TabIndex = 5;
            this.label_N2Filler.Text = "ISN (Scan Barcode):";
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
            this.Status_Column.HeaderText = "F620 Status";
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
            // SDK_Log_Capturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 620);
            this.Controls.Add(this.tabControl);
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
        private System.Windows.Forms.Button btn_N2_upload;
        private System.Windows.Forms.Label lbl_N2_pressure;
        private System.Windows.Forms.RadioButton btnN2_manual_radio;
        private System.Windows.Forms.TextBox N2_txtProgramNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox N2_textBox2;
        private System.Windows.Forms.TextBox N2_textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView N2filler_GridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGrid_Water_ISN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loop;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGrid_Water_StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGrid_Water_EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 介質;
        private System.Windows.Forms.DataGridViewTextBoxColumn 設定壓力;
        private System.Windows.Forms.DataGridViewTextBoxColumn 產品壓力;
        private System.Windows.Forms.DataGridViewTextBoxColumn 系統真空;
        private System.Windows.Forms.DataGridViewTextBoxColumn 壓差;
        private System.Windows.Forms.DataGridViewTextBoxColumn 進口壓力;
        private System.Windows.Forms.Label lbltProgramNumber;
        private System.Windows.Forms.TextBox txtProgramNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Program;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeakRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn SFISisPassed;
    }
}

