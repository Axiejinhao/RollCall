namespace RollCall
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelSource = new System.Windows.Forms.Label();
            this.labelTeach = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.labelAttendance = new System.Windows.Forms.Label();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.richTextBoxWithClass = new System.Windows.Forms.RichTextBox();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SkinsList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDetail = new System.Windows.Forms.Button();
            this.richTextBoxWithRecords = new System.Windows.Forms.RichTextBox();
            this.buttonShowStyle = new System.Windows.Forms.Button();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonShowHideRecords = new System.Windows.Forms.Button();
            this.buttonShowHideClass = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonImport
            // 
            this.buttonImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonImport.BackColor = System.Drawing.Color.Transparent;
            this.buttonImport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonImport.Location = new System.Drawing.Point(27, 477);
            this.buttonImport.Margin = new System.Windows.Forms.Padding(4);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(200, 46);
            this.buttonImport.TabIndex = 0;
            this.buttonImport.Text = "导入名单";
            this.buttonImport.UseVisualStyleBackColor = false;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            this.buttonImport.MouseEnter += new System.EventHandler(this.buttonImport_MouseEnter);
            this.buttonImport.MouseLeave += new System.EventHandler(this.buttonImport_MouseLeave);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonStart.Location = new System.Drawing.Point(27, 624);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(300, 46);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "开始随机抽答";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStop.BackColor = System.Drawing.Color.Transparent;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonStop.Location = new System.Drawing.Point(27, 686);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(300, 46);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "停止随机抽答";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExport.BackColor = System.Drawing.Color.Transparent;
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonExport.Location = new System.Drawing.Point(1135, 686);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(250, 46);
            this.buttonExport.TabIndex = 3;
            this.buttonExport.Text = "记录为旷课";
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 409);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(348, 55);
            this.comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(382, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(382, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 45);
            this.label2.TabIndex = 6;
            this.label2.Text = "学号：";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(382, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 45);
            this.label3.TabIndex = 7;
            this.label3.Text = "班级：";
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.labelName.Location = new System.Drawing.Point(596, 14);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(50, 45);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "   ";
            // 
            // labelNumber
            // 
            this.labelNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelNumber.AutoSize = true;
            this.labelNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelNumber.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.labelNumber.Location = new System.Drawing.Point(596, 98);
            this.labelNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(50, 45);
            this.labelNumber.TabIndex = 9;
            this.labelNumber.Text = "   ";
            // 
            // labelClass
            // 
            this.labelClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelClass.AutoSize = true;
            this.labelClass.BackColor = System.Drawing.Color.Transparent;
            this.labelClass.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.labelClass.Location = new System.Drawing.Point(596, 180);
            this.labelClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(50, 45);
            this.labelClass.TabIndex = 10;
            this.labelClass.Text = "   ";
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.BackColor = System.Drawing.Color.Transparent;
            this.labelSource.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSource.Location = new System.Drawing.Point(45, 14);
            this.labelSource.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(66, 50);
            this.labelSource.TabIndex = 12;
            this.labelSource.Text = "    ";
            // 
            // labelTeach
            // 
            this.labelTeach.AutoSize = true;
            this.labelTeach.BackColor = System.Drawing.Color.Transparent;
            this.labelTeach.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTeach.Location = new System.Drawing.Point(45, 62);
            this.labelTeach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTeach.Name = "labelTeach";
            this.labelTeach.Size = new System.Drawing.Size(66, 50);
            this.labelTeach.TabIndex = 13;
            this.labelTeach.Text = "    ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(348, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 45);
            this.label4.TabIndex = 15;
            this.label4.Text = "出勤率：";
            // 
            // labelAttendance
            // 
            this.labelAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelAttendance.AutoSize = true;
            this.labelAttendance.BackColor = System.Drawing.Color.Transparent;
            this.labelAttendance.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.labelAttendance.Location = new System.Drawing.Point(596, 265);
            this.labelAttendance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAttendance.Name = "labelAttendance";
            this.labelAttendance.Size = new System.Drawing.Size(50, 45);
            this.labelAttendance.TabIndex = 16;
            this.labelAttendance.Text = "   ";
            // 
            // buttonOrder
            // 
            this.buttonOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOrder.BackColor = System.Drawing.Color.Transparent;
            this.buttonOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonOrder.Location = new System.Drawing.Point(316, 330);
            this.buttonOrder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(300, 46);
            this.buttonOrder.TabIndex = 17;
            this.buttonOrder.Text = "开始顺序点名";
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer2.Margin = new System.Windows.Forms.Padding(10);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Padding = new System.Windows.Forms.Padding(10);
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(67, 52);
            this.axWindowsMediaPlayer2.TabIndex = 19;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // richTextBoxWithClass
            // 
            this.richTextBoxWithClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxWithClass.Font = new System.Drawing.Font("宋体", 15F);
            this.richTextBoxWithClass.Location = new System.Drawing.Point(1085, 62);
            this.richTextBoxWithClass.Name = "richTextBoxWithClass";
            this.richTextBoxWithClass.ReadOnly = true;
            this.richTextBoxWithClass.Size = new System.Drawing.Size(324, 204);
            this.richTextBoxWithClass.TabIndex = 20;
            this.richTextBoxWithClass.Text = "";
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SkinsList});
            this.dataGridView1.Location = new System.Drawing.Point(54, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(234, 339);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SkinsList
            // 
            this.SkinsList.HeaderText = "Skins";
            this.SkinsList.MinimumWidth = 6;
            this.SkinsList.Name = "SkinsList";
            this.SkinsList.ReadOnly = true;
            this.SkinsList.Width = 125;
            // 
            // buttonDetail
            // 
            this.buttonDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDetail.BackColor = System.Drawing.Color.Transparent;
            this.buttonDetail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonDetail.Location = new System.Drawing.Point(1167, 624);
            this.buttonDetail.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDetail.Name = "buttonDetail";
            this.buttonDetail.Size = new System.Drawing.Size(200, 46);
            this.buttonDetail.TabIndex = 21;
            this.buttonDetail.Text = "详细信息";
            this.buttonDetail.UseVisualStyleBackColor = false;
            this.buttonDetail.Click += new System.EventHandler(this.buttonDetail_Click);
            // 
            // richTextBoxWithRecords
            // 
            this.richTextBoxWithRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxWithRecords.Location = new System.Drawing.Point(1192, 330);
            this.richTextBoxWithRecords.Name = "richTextBoxWithRecords";
            this.richTextBoxWithRecords.ReadOnly = true;
            this.richTextBoxWithRecords.Size = new System.Drawing.Size(183, 254);
            this.richTextBoxWithRecords.TabIndex = 22;
            this.richTextBoxWithRecords.Text = "";
            // 
            // buttonShowStyle
            // 
            this.buttonShowStyle.BackColor = System.Drawing.Color.Transparent;
            this.buttonShowStyle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonShowStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonShowStyle.Location = new System.Drawing.Point(113, 131);
            this.buttonShowStyle.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowStyle.Name = "buttonShowStyle";
            this.buttonShowStyle.Size = new System.Drawing.Size(124, 35);
            this.buttonShowStyle.TabIndex = 23;
            this.buttonShowStyle.Text = "show";
            this.buttonShowStyle.UseVisualStyleBackColor = false;
            this.buttonShowStyle.Click += new System.EventHandler(this.buttonShowStyle_Click);
            // 
            // buttonSkip
            // 
            this.buttonSkip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSkip.BackColor = System.Drawing.Color.Transparent;
            this.buttonSkip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.buttonSkip.Location = new System.Drawing.Point(1319, 13);
            this.buttonSkip.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(90, 30);
            this.buttonSkip.TabIndex = 24;
            this.buttonSkip.Text = "Skip";
            this.buttonSkip.UseVisualStyleBackColor = false;
            this.buttonSkip.Click += new System.EventHandler(this.buttonSkip_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSelect.BackColor = System.Drawing.Color.Transparent;
            this.buttonSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonSelect.Location = new System.Drawing.Point(392, 624);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(200, 46);
            this.buttonSelect.TabIndex = 25;
            this.buttonSelect.Text = "选择文件";
            this.buttonSelect.UseVisualStyleBackColor = false;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(21, 421);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 36);
            this.label7.TabIndex = 11;
            this.label7.Text = "选择：";
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSaveFile.BackColor = System.Drawing.Color.Transparent;
            this.buttonSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonSaveFile.Location = new System.Drawing.Point(392, 686);
            this.buttonSaveFile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(200, 46);
            this.buttonSaveFile.TabIndex = 26;
            this.buttonSaveFile.Text = "保存文件";
            this.buttonSaveFile.UseVisualStyleBackColor = false;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // buttonShowHideRecords
            // 
            this.buttonShowHideRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowHideRecords.BackColor = System.Drawing.Color.Transparent;
            this.buttonShowHideRecords.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonShowHideRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buttonShowHideRecords.Location = new System.Drawing.Point(1167, 286);
            this.buttonShowHideRecords.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowHideRecords.Name = "buttonShowHideRecords";
            this.buttonShowHideRecords.Size = new System.Drawing.Size(242, 37);
            this.buttonShowHideRecords.TabIndex = 27;
            this.buttonShowHideRecords.Text = "显示/隐藏记录";
            this.buttonShowHideRecords.UseVisualStyleBackColor = false;
            this.buttonShowHideRecords.Click += new System.EventHandler(this.buttonShowHideRecords_Click);
            // 
            // buttonShowHideClass
            // 
            this.buttonShowHideClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowHideClass.BackColor = System.Drawing.Color.Transparent;
            this.buttonShowHideClass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonShowHideClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buttonShowHideClass.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonShowHideClass.Location = new System.Drawing.Point(1135, 13);
            this.buttonShowHideClass.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowHideClass.Name = "buttonShowHideClass";
            this.buttonShowHideClass.Size = new System.Drawing.Size(240, 37);
            this.buttonShowHideClass.TabIndex = 28;
            this.buttonShowHideClass.Text = "显示/隐藏班级出勤率";
            this.buttonShowHideClass.UseVisualStyleBackColor = false;
            this.buttonShowHideClass.Click += new System.EventHandler(this.buttonShowHideClass_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(25, 536);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 27);
            this.label5.TabIndex = 29;
            this.label5.Text = "导入文件格式:class+数字.csv";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1422, 763);
            this.Controls.Add(this.buttonSkip);
            this.Controls.Add(this.axWindowsMediaPlayer2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonShowStyle);
            this.Controls.Add(this.buttonShowHideClass);
            this.Controls.Add(this.buttonShowHideRecords);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.richTextBoxWithRecords);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelAttendance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelTeach);
            this.Controls.Add(this.labelSource);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonDetail);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.richTextBoxWithClass);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "点名程序";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.Label labelTeach;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelAttendance;
        private System.Windows.Forms.Button buttonOrder;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.RichTextBox richTextBoxWithClass;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkinsList;
        private System.Windows.Forms.RichTextBox richTextBoxWithRecords;
        private System.Windows.Forms.Button buttonShowStyle;
        private System.Windows.Forms.Button buttonSkip;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.Button buttonShowHideRecords;
        private System.Windows.Forms.Button buttonShowHideClass;
        private System.Windows.Forms.Label label5;
    }
}

