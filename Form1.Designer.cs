
namespace SDK_Log_Capture_Tool
{
    partial class SDK_Log_Capturer
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.ATEQ_F620_TabPage = new System.Windows.Forms.TabPage();
            this.btn_upload_SFIS = new System.Windows.Forms.Button();
            this.is_manual = new System.Windows.Forms.RadioButton();
            this.is_auto = new System.Windows.Forms.RadioButton();
            this.dgvFIFOATEQ = new System.Windows.Forms.DataGridView();
            this.ISN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Program = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeakRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStatusATEQ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLeakATEQ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPressureATEQ = new System.Windows.Forms.TextBox();
            this.Pressure = new System.Windows.Forms.Label();
            this.lblISNStatusATEQ = new System.Windows.Forms.Label();
            this.txtISNATEQ = new System.Windows.Forms.TextBox();
            this.label_ISN_F620 = new System.Windows.Forms.Label();
            this.Water_Bath_tabPage = new System.Windows.Forms.TabPage();
            this.dataGrid_Water = new System.Windows.Forms.DataGridView();
            this.dataGrid_Water_ISN = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_loop1UploadSFISWater = new System.Windows.Forms.Button();
            this.label_loop1ISNWater = new System.Windows.Forms.Label();
            this.txt_loop1ISNWater = new System.Windows.Forms.TextBox();
            this.lbl_loop1_start = new System.Windows.Forms.Label();
            this.N2_Filler_tabPage = new System.Windows.Forms.TabPage();
            this.btn_reset_N2Filler = new System.Windows.Forms.Button();
            this.btn_start_N2Filler = new System.Windows.Forms.Button();
            this.label_hint_N2Filler = new System.Windows.Forms.Label();
            this.textBox_N2Filler = new System.Windows.Forms.TextBox();
            this.label_N2Filler = new System.Windows.Forms.Label();
            this.ATEQ_groupBox = new System.Windows.Forms.GroupBox();
            this.tabControl.SuspendLayout();
            this.ATEQ_F620_TabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFIFOATEQ)).BeginInit();
            this.Water_Bath_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Water)).BeginInit();
            this.group_loop4.SuspendLayout();
            this.group_loop3.SuspendLayout();
            this.group_loop2.SuspendLayout();
            this.group_loop1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.N2_Filler_tabPage.SuspendLayout();
            this.ATEQ_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.ATEQ_F620_TabPage);
            this.tabControl.Controls.Add(this.Water_Bath_tabPage);
            this.tabControl.Controls.Add(this.N2_Filler_tabPage);
            this.tabControl.Location = new System.Drawing.Point(23, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1514, 499);
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
            this.ATEQ_F620_TabPage.Size = new System.Drawing.Size(1506, 467);
            this.ATEQ_F620_TabPage.TabIndex = 0;
            this.ATEQ_F620_TabPage.Text = "ATEQ F620";
            this.ATEQ_F620_TabPage.UseVisualStyleBackColor = true;
            // 
            // btn_upload_SFIS
            // 
            this.btn_upload_SFIS.Enabled = false;
            this.btn_upload_SFIS.Location = new System.Drawing.Point(71, 288);
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
            this.is_manual.Size = new System.Drawing.Size(105, 22);
            this.is_manual.TabIndex = 13;
            this.is_manual.TabStop = true;
            this.is_manual.Text = "手動模式";
            this.is_manual.UseVisualStyleBackColor = true;
            this.is_manual.CheckedChanged += new System.EventHandler(this.is_manual_CheckedChanged);
            // 
            // is_auto
            // 
            this.is_auto.AutoSize = true;
            this.is_auto.Checked = true;
            this.is_auto.Location = new System.Drawing.Point(78, 40);
            this.is_auto.Name = "is_auto";
            this.is_auto.Size = new System.Drawing.Size(105, 22);
            this.is_auto.TabIndex = 12;
            this.is_auto.TabStop = true;
            this.is_auto.Text = "自動模式";
            this.is_auto.UseVisualStyleBackColor = true;
            this.is_auto.CheckedChanged += new System.EventHandler(this.is_auto_CheckedChanged);
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
            this.Status_Column});
            this.dgvFIFOATEQ.Location = new System.Drawing.Point(72, 89);
            this.dgvFIFOATEQ.Name = "dgvFIFOATEQ";
            this.dgvFIFOATEQ.RowHeadersWidth = 62;
            this.dgvFIFOATEQ.RowTemplate.Height = 31;
            this.dgvFIFOATEQ.Size = new System.Drawing.Size(820, 349);
            this.dgvFIFOATEQ.TabIndex = 11;
            this.dgvFIFOATEQ.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFIFOATEQ_CellContentClick);
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
            this.Column1.HeaderText = "Pressure";
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
            this.Status_Column.HeaderText = "Status";
            this.Status_Column.MinimumWidth = 8;
            this.Status_Column.Name = "Status_Column";
            this.Status_Column.ToolTipText = "Status";
            this.Status_Column.Width = 150;
            // 
            // txtStatusATEQ
            // 
            this.txtStatusATEQ.Location = new System.Drawing.Point(239, 214);
            this.txtStatusATEQ.Name = "txtStatusATEQ";
            this.txtStatusATEQ.ReadOnly = true;
            this.txtStatusATEQ.Size = new System.Drawing.Size(191, 29);
            this.txtStatusATEQ.TabIndex = 10;
            this.txtStatusATEQ.TextChanged += new System.EventHandler(this.CheckTextBoxes);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Test Status:";
            // 
            // txtLeakATEQ
            // 
            this.txtLeakATEQ.Location = new System.Drawing.Point(239, 157);
            this.txtLeakATEQ.Name = "txtLeakATEQ";
            this.txtLeakATEQ.ReadOnly = true;
            this.txtLeakATEQ.Size = new System.Drawing.Size(191, 29);
            this.txtLeakATEQ.TabIndex = 8;
            this.txtLeakATEQ.TextChanged += new System.EventHandler(this.CheckTextBoxes);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Leak Rate (cm³/min):";
            // 
            // txtPressureATEQ
            // 
            this.txtPressureATEQ.Location = new System.Drawing.Point(239, 105);
            this.txtPressureATEQ.Name = "txtPressureATEQ";
            this.txtPressureATEQ.ReadOnly = true;
            this.txtPressureATEQ.Size = new System.Drawing.Size(191, 29);
            this.txtPressureATEQ.TabIndex = 6;
            this.txtPressureATEQ.TextChanged += new System.EventHandler(this.CheckTextBoxes);
            // 
            // Pressure
            // 
            this.Pressure.AutoSize = true;
            this.Pressure.Location = new System.Drawing.Point(75, 108);
            this.Pressure.Name = "Pressure";
            this.Pressure.Size = new System.Drawing.Size(106, 18);
            this.Pressure.TabIndex = 5;
            this.Pressure.Text = "Pressure (Pa):";
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
            this.txtISNATEQ.Location = new System.Drawing.Point(238, 37);
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
            this.Water_Bath_tabPage.Size = new System.Drawing.Size(1506, 467);
            this.Water_Bath_tabPage.TabIndex = 1;
            this.Water_Bath_tabPage.Text = "恒溫水槽";
            this.Water_Bath_tabPage.UseVisualStyleBackColor = true;
            this.Water_Bath_tabPage.Click += new System.EventHandler(this.Water_Bath_tabPage_Click);
            // 
            // dataGrid_Water
            // 
            this.dataGrid_Water.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Water.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGrid_Water_ISN,
            this.dataGrid_Water_StartTime,
            this.dataGrid_Water_EndTime});
            this.dataGrid_Water.Location = new System.Drawing.Point(955, 34);
            this.dataGrid_Water.Name = "dataGrid_Water";
            this.dataGrid_Water.RowHeadersWidth = 62;
            this.dataGrid_Water.RowTemplate.Height = 31;
            this.dataGrid_Water.Size = new System.Drawing.Size(515, 395);
            this.dataGrid_Water.TabIndex = 14;
            // 
            // dataGrid_Water_ISN
            // 
            this.dataGrid_Water_ISN.HeaderText = "ISN";
            this.dataGrid_Water_ISN.MinimumWidth = 8;
            this.dataGrid_Water_ISN.Name = "dataGrid_Water_ISN";
            this.dataGrid_Water_ISN.Width = 150;
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
            this.group_loop4.Location = new System.Drawing.Point(25, 355);
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
            this.loop4_STARTTime.Location = new System.Drawing.Point(469, 38);
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
            this.txt_loop4ISNWater.Location = new System.Drawing.Point(187, 38);
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
            this.group_loop3.Location = new System.Drawing.Point(25, 239);
            this.group_loop3.Name = "group_loop3";
            this.group_loop3.Size = new System.Drawing.Size(750, 98);
            this.group_loop3.TabIndex = 12;
            this.group_loop3.TabStop = false;
            this.group_loop3.Text = "Loop 3";
            // 
            // btn_loop3ResetSFISWater
            // 
            this.btn_loop3ResetSFISWater.Location = new System.Drawing.Point(640, 61);
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
            this.btn_loop3UploadSFISWater.Location = new System.Drawing.Point(640, 25);
            this.btn_loop3UploadSFISWater.Name = "btn_loop3UploadSFISWater";
            this.btn_loop3UploadSFISWater.Size = new System.Drawing.Size(94, 30);
            this.btn_loop3UploadSFISWater.TabIndex = 19;
            this.btn_loop3UploadSFISWater.Text = "Upload";
            this.btn_loop3UploadSFISWater.UseVisualStyleBackColor = true;
            this.btn_loop3UploadSFISWater.Click += new System.EventHandler(this.btn3UploadSFISWater_Click);
            // 
            // loop3_STARTTime
            // 
            this.loop3_STARTTime.Location = new System.Drawing.Point(469, 38);
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
            this.txt_loop3ISNWater.Location = new System.Drawing.Point(187, 38);
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
            this.group_loop2.Location = new System.Drawing.Point(25, 126);
            this.group_loop2.Name = "group_loop2";
            this.group_loop2.Size = new System.Drawing.Size(750, 95);
            this.group_loop2.TabIndex = 13;
            this.group_loop2.TabStop = false;
            this.group_loop2.Text = "Loop 2";
            // 
            // btn_loop2ResetSFISWater
            // 
            this.btn_loop2ResetSFISWater.Location = new System.Drawing.Point(640, 55);
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
            this.btn_loop2UploadSFISWater.Location = new System.Drawing.Point(640, 19);
            this.btn_loop2UploadSFISWater.Name = "btn_loop2UploadSFISWater";
            this.btn_loop2UploadSFISWater.Size = new System.Drawing.Size(94, 30);
            this.btn_loop2UploadSFISWater.TabIndex = 17;
            this.btn_loop2UploadSFISWater.Text = "Upload";
            this.btn_loop2UploadSFISWater.UseVisualStyleBackColor = true;
            this.btn_loop2UploadSFISWater.Click += new System.EventHandler(this.btn2UploadSFISWater_Click);
            // 
            // loop2_STARTTime
            // 
            this.loop2_STARTTime.Location = new System.Drawing.Point(469, 41);
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
            this.txt_loop2ISNWater.Location = new System.Drawing.Point(187, 40);
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
            this.group_loop1.Controls.Add(this.groupBox2);
            this.group_loop1.Controls.Add(this.btn_loop1UploadSFISWater);
            this.group_loop1.Controls.Add(this.label_loop1ISNWater);
            this.group_loop1.Controls.Add(this.txt_loop1ISNWater);
            this.group_loop1.Controls.Add(this.lbl_loop1_start);
            this.group_loop1.Location = new System.Drawing.Point(25, 16);
            this.group_loop1.Name = "group_loop1";
            this.group_loop1.Size = new System.Drawing.Size(750, 94);
            this.group_loop1.TabIndex = 11;
            this.group_loop1.TabStop = false;
            this.group_loop1.Text = "Loop 1";
            this.group_loop1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_loop1ResetSFISWater
            // 
            this.btn_loop1ResetSFISWater.Location = new System.Drawing.Point(640, 55);
            this.btn_loop1ResetSFISWater.Name = "btn_loop1ResetSFISWater";
            this.btn_loop1ResetSFISWater.Size = new System.Drawing.Size(94, 30);
            this.btn_loop1ResetSFISWater.TabIndex = 16;
            this.btn_loop1ResetSFISWater.Text = "Reset";
            this.btn_loop1ResetSFISWater.UseVisualStyleBackColor = true;
            this.btn_loop1ResetSFISWater.Click += new System.EventHandler(this.btn1ResetSFISWater_Click);
            // 
            // loop1_STARTTime
            // 
            this.loop1_STARTTime.Location = new System.Drawing.Point(469, 38);
            this.loop1_STARTTime.Name = "loop1_STARTTime";
            this.loop1_STARTTime.ReadOnly = true;
            this.loop1_STARTTime.Size = new System.Drawing.Size(152, 29);
            this.loop1_STARTTime.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(8, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(750, 169);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loop 1";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(547, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 42);
            this.button2.TabIndex = 10;
            this.button2.Text = "Upload to SFIS";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 55);
            this.label7.MinimumSize = new System.Drawing.Size(2, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "ISN (Scan Barcode):";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(187, 52);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(152, 29);
            this.textBox3.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(376, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "(Scan to validate)";
            // 
            // btn_loop1UploadSFISWater
            // 
            this.btn_loop1UploadSFISWater.Enabled = false;
            this.btn_loop1UploadSFISWater.Location = new System.Drawing.Point(640, 19);
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
            this.txt_loop1ISNWater.Location = new System.Drawing.Point(187, 39);
            this.txt_loop1ISNWater.Name = "txt_loop1ISNWater";
            this.txt_loop1ISNWater.Size = new System.Drawing.Size(152, 29);
            this.txt_loop1ISNWater.TabIndex = 6;
            this.txt_loop1ISNWater.TextChanged += new System.EventHandler(this.loop1ISNWater_TextChanged);
            // 
            // lbl_loop1_start
            // 
            this.lbl_loop1_start.AutoSize = true;
            this.lbl_loop1_start.Location = new System.Drawing.Point(376, 43);
            this.lbl_loop1_start.Name = "lbl_loop1_start";
            this.lbl_loop1_start.Size = new System.Drawing.Size(87, 18);
            this.lbl_loop1_start.TabIndex = 7;
            this.lbl_loop1_start.Text = "Start time: ";
            this.lbl_loop1_start.Click += new System.EventHandler(this.lblISNStatusWater_Click);
            // 
            // N2_Filler_tabPage
            // 
            this.N2_Filler_tabPage.Controls.Add(this.btn_reset_N2Filler);
            this.N2_Filler_tabPage.Controls.Add(this.btn_start_N2Filler);
            this.N2_Filler_tabPage.Controls.Add(this.label_hint_N2Filler);
            this.N2_Filler_tabPage.Controls.Add(this.textBox_N2Filler);
            this.N2_Filler_tabPage.Controls.Add(this.label_N2Filler);
            this.N2_Filler_tabPage.Location = new System.Drawing.Point(4, 28);
            this.N2_Filler_tabPage.Name = "N2_Filler_tabPage";
            this.N2_Filler_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.N2_Filler_tabPage.Size = new System.Drawing.Size(1086, 467);
            this.N2_Filler_tabPage.TabIndex = 2;
            this.N2_Filler_tabPage.Text = "N₂ Filler";
            this.N2_Filler_tabPage.UseVisualStyleBackColor = true;
            // 
            // btn_reset_N2Filler
            // 
            this.btn_reset_N2Filler.Location = new System.Drawing.Point(858, 27);
            this.btn_reset_N2Filler.Name = "btn_reset_N2Filler";
            this.btn_reset_N2Filler.Size = new System.Drawing.Size(159, 46);
            this.btn_reset_N2Filler.TabIndex = 9;
            this.btn_reset_N2Filler.Text = "Reset";
            this.btn_reset_N2Filler.UseVisualStyleBackColor = true;
            // 
            // btn_start_N2Filler
            // 
            this.btn_start_N2Filler.Enabled = false;
            this.btn_start_N2Filler.Location = new System.Drawing.Point(670, 27);
            this.btn_start_N2Filler.Name = "btn_start_N2Filler";
            this.btn_start_N2Filler.Size = new System.Drawing.Size(173, 46);
            this.btn_start_N2Filler.TabIndex = 8;
            this.btn_start_N2Filler.Text = "Start Leak Test";
            this.btn_start_N2Filler.UseVisualStyleBackColor = true;
            // 
            // label_hint_N2Filler
            // 
            this.label_hint_N2Filler.AutoSize = true;
            this.label_hint_N2Filler.Location = new System.Drawing.Point(494, 41);
            this.label_hint_N2Filler.Name = "label_hint_N2Filler";
            this.label_hint_N2Filler.Size = new System.Drawing.Size(131, 18);
            this.label_hint_N2Filler.TabIndex = 7;
            this.label_hint_N2Filler.Text = "(Scan to validate)";
            // 
            // textBox_N2Filler
            // 
            this.textBox_N2Filler.Location = new System.Drawing.Point(238, 38);
            this.textBox_N2Filler.Name = "textBox_N2Filler";
            this.textBox_N2Filler.Size = new System.Drawing.Size(229, 29);
            this.textBox_N2Filler.TabIndex = 6;
            // 
            // label_N2Filler
            // 
            this.label_N2Filler.AutoSize = true;
            this.label_N2Filler.Location = new System.Drawing.Point(69, 41);
            this.label_N2Filler.MinimumSize = new System.Drawing.Size(2, 3);
            this.label_N2Filler.Name = "label_N2Filler";
            this.label_N2Filler.Size = new System.Drawing.Size(152, 18);
            this.label_N2Filler.TabIndex = 5;
            this.label_N2Filler.Text = "ISN (Scan Barcode):";
            // 
            // ATEQ_groupBox
            // 
            this.ATEQ_groupBox.Controls.Add(this.is_auto);
            this.ATEQ_groupBox.Controls.Add(this.btn_upload_SFIS);
            this.ATEQ_groupBox.Controls.Add(this.Pressure);
            this.ATEQ_groupBox.Controls.Add(this.is_manual);
            this.ATEQ_groupBox.Controls.Add(this.txtPressureATEQ);
            this.ATEQ_groupBox.Controls.Add(this.label2);
            this.ATEQ_groupBox.Controls.Add(this.txtLeakATEQ);
            this.ATEQ_groupBox.Controls.Add(this.txtStatusATEQ);
            this.ATEQ_groupBox.Controls.Add(this.label6);
            this.ATEQ_groupBox.Location = new System.Drawing.Point(937, 40);
            this.ATEQ_groupBox.Name = "ATEQ_groupBox";
            this.ATEQ_groupBox.Size = new System.Drawing.Size(502, 358);
            this.ATEQ_groupBox.TabIndex = 15;
            this.ATEQ_groupBox.TabStop = false;
            // 
            // SDK_Log_Capturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1580, 564);
            this.Controls.Add(this.tabControl);
            this.Name = "SDK_Log_Capturer";
            this.Text = "SDK Log Capturer";
            this.tabControl.ResumeLayout(false);
            this.ATEQ_F620_TabPage.ResumeLayout(false);
            this.ATEQ_F620_TabPage.PerformLayout();
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.N2_Filler_tabPage.ResumeLayout(false);
            this.N2_Filler_tabPage.PerformLayout();
            this.ATEQ_groupBox.ResumeLayout(false);
            this.ATEQ_groupBox.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox_N2Filler;
        private System.Windows.Forms.Label label_N2Filler;
        private System.Windows.Forms.TextBox txtPressureATEQ;
        private System.Windows.Forms.Label Pressure;
        private System.Windows.Forms.TextBox txtStatusATEQ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLeakATEQ;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGrid_Water_ISN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGrid_Water_StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGrid_Water_EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Program;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeakRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status_Column;
        private System.Windows.Forms.GroupBox ATEQ_groupBox;
    }
}

