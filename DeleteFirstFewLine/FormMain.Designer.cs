namespace DeleteFirstFewLine
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menu1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.默认设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenu_DGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除成功行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.清空状态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除选中状态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.整理列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.添加文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.文件信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制文件路径ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制文件名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件详细信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件夹ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.统计行数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.统计字数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDGV_Deal = new System.Windows.Forms.Panel();
            this.btnDGV_ClearState = new System.Windows.Forms.Button();
            this.btnDGV_DeleteSuccess = new System.Windows.Forms.Button();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnDGV_ClearAll = new System.Windows.Forms.Button();
            this.btnDGV_Delete = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpDeleteLine = new System.Windows.Forms.TabPage();
            this.panelDelLine_KeyWords = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.checkBoxDelLine_KeyWord = new System.Windows.Forms.CheckBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txbDelLine_TeDingData = new System.Windows.Forms.TextBox();
            this.panelDelLine_TeDing = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.txbDelLine_TeDing = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.panelDelLine1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nudDelLine_TopLineFile = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudDelLine_ContinueLast = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudDelLine_ContinueFirst = new System.Windows.Forms.NumericUpDown();
            this.nudDelLine_LastLineFile = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxDeleteLine = new System.Windows.Forms.ComboBox();
            this.tpDeleteData = new System.Windows.Forms.TabPage();
            this.panelDelData_FirstLastOfLine = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txbCountZiFu = new System.Windows.Forms.TextBox();
            this.checkBoxDel_DataTopOfLine = new System.Windows.Forms.CheckBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.nudDelData_CountZiFu = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBoxDeleteData = new System.Windows.Forms.ComboBox();
            this.panelDeleteReplaceData = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txbDelNewData = new System.Windows.Forms.TextBox();
            this.txbDelOldData = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tpMerge = new System.Windows.Forms.TabPage();
            this.panelMerge_LeftRight = new System.Windows.Forms.Panel();
            this.checkBoxMerge_LeftRightAddData = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txbMerge_LeftRightData = new System.Windows.Forms.TextBox();
            this.panelMerge_GeHang = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBoxMerge = new System.Windows.Forms.ComboBox();
            this.panelMerge_AddDataAmongFile = new System.Windows.Forms.Panel();
            this.checkBoxMerge_AddFileName = new System.Windows.Forms.CheckBox();
            this.txbMerge_AddDataAmongFiles = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBoxMerge_AddDataAmongFiles = new System.Windows.Forms.CheckBox();
            this.btnDownMove = new System.Windows.Forms.Button();
            this.btnUpMove = new System.Windows.Forms.Button();
            this.tpSplit = new System.Windows.Forms.TabPage();
            this.nudSplit_Line = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBoxSplit = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.nudSplit_Count = new System.Windows.Forms.NumericUpDown();
            this.tpAddData = new System.Windows.Forms.TabPage();
            this.panelAddData_FileName = new System.Windows.Forms.Panel();
            this.label37 = new System.Windows.Forms.Label();
            this.checkBoxAddData_ContainExtension = new System.Windows.Forms.CheckBox();
            this.checkBoxAddData_ContainDir = new System.Windows.Forms.CheckBox();
            this.txbAddData_FileName2 = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.txbAddData_FileName1 = new System.Windows.Forms.TextBox();
            this.panelAddData_TopEndOfLine = new System.Windows.Forms.Panel();
            this.txbAddData_EndLine = new System.Windows.Forms.TextBox();
            this.checkBoxAddData_EndLine = new System.Windows.Forms.CheckBox();
            this.label35 = new System.Windows.Forms.Label();
            this.nudAddData_TopLine = new System.Windows.Forms.NumericUpDown();
            this.checkBoxAddData_ContainNumber = new System.Windows.Forms.CheckBox();
            this.txbAddData_TopLine = new System.Windows.Forms.TextBox();
            this.checkBoxAddData_TopLine = new System.Windows.Forms.CheckBox();
            this.panelAddData_TopEndOfFile = new System.Windows.Forms.Panel();
            this.checkBoxAddData_OverWrite = new System.Windows.Forms.CheckBox();
            this.checkBoxAddData_EndFile = new System.Windows.Forms.CheckBox();
            this.checkBoxAddData_TopFile = new System.Windows.Forms.CheckBox();
            this.txbAddData_TopEndOfFile = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.comboBoxAddData = new System.Windows.Forms.ComboBox();
            this.tpDeleteLineFromFile = new System.Windows.Forms.TabPage();
            this.btnFile2DeleteBrower = new System.Windows.Forms.Button();
            this.btnFile1DeleteBrowser = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txbFileShaiXuan = new System.Windows.Forms.TextBox();
            this.txbFileDelete = new System.Windows.Forms.TextBox();
            this.tpOther = new System.Windows.Forms.TabPage();
            this.panelOtherChangeFileType = new System.Windows.Forms.Panel();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.radioBtnUTF_8 = new System.Windows.Forms.RadioButton();
            this.radioBtnUnicodeBigEndian = new System.Windows.Forms.RadioButton();
            this.radioBtnUnicode = new System.Windows.Forms.RadioButton();
            this.radioBtnANSI = new System.Windows.Forms.RadioButton();
            this.panelOtherFind = new System.Windows.Forms.Panel();
            this.label42 = new System.Windows.Forms.Label();
            this.txbOtherFind = new System.Windows.Forms.TextBox();
            this.panelOtherRename = new System.Windows.Forms.Panel();
            this.label41 = new System.Windows.Forms.Label();
            this.checkBoxOtherOldName = new System.Windows.Forms.CheckBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.panelOtherAddFolder = new System.Windows.Forms.Panel();
            this.txbOtherFilePath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOtherAddDGV = new System.Windows.Forms.Button();
            this.label38 = new System.Windows.Forms.Label();
            this.comboBoxOtherType = new System.Windows.Forms.ComboBox();
            this.panelStart = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.checkBoxBak = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panelOtherSort = new System.Windows.Forms.Panel();
            this.radioBtnSortDown = new System.Windows.Forms.RadioButton();
            this.radioBtnSortUp = new System.Windows.Forms.RadioButton();
            this.关于我们ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.捐赠ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu1.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.contextMenu_DGV.SuspendLayout();
            this.panelDGV_Deal.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpDeleteLine.SuspendLayout();
            this.panelDelLine_KeyWords.SuspendLayout();
            this.panelDelLine_TeDing.SuspendLayout();
            this.panelDelLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelLine_TopLineFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelLine_ContinueLast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelLine_ContinueFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelLine_LastLineFile)).BeginInit();
            this.tpDeleteData.SuspendLayout();
            this.panelDelData_FirstLastOfLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelData_CountZiFu)).BeginInit();
            this.panelDeleteReplaceData.SuspendLayout();
            this.tpMerge.SuspendLayout();
            this.panelMerge_LeftRight.SuspendLayout();
            this.panelMerge_AddDataAmongFile.SuspendLayout();
            this.tpSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSplit_Line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSplit_Count)).BeginInit();
            this.tpAddData.SuspendLayout();
            this.panelAddData_FileName.SuspendLayout();
            this.panelAddData_TopEndOfLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddData_TopLine)).BeginInit();
            this.panelAddData_TopEndOfFile.SuspendLayout();
            this.tpDeleteLineFromFile.SuspendLayout();
            this.tpOther.SuspendLayout();
            this.panelOtherChangeFileType.SuspendLayout();
            this.panelOtherFind.SuspendLayout();
            this.panelOtherRename.SuspendLayout();
            this.panelOtherAddFolder.SuspendLayout();
            this.panelStart.SuspendLayout();
            this.panelOtherSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu1
            // 
            this.menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(695, 25);
            this.menu1.TabIndex = 0;
            this.menu1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.默认设置ToolStripMenuItem,
            this.退出ToolStripMenuItem,
            this.打开文件夹ToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 默认设置ToolStripMenuItem
            // 
            this.默认设置ToolStripMenuItem.Name = "默认设置ToolStripMenuItem";
            this.默认设置ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.默认设置ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.默认设置ToolStripMenuItem.Text = "默认设置";
            this.默认设置ToolStripMenuItem.Click += new System.EventHandler(this.默认设置ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 打开文件夹ToolStripMenuItem
            // 
            this.打开文件夹ToolStripMenuItem.Name = "打开文件夹ToolStripMenuItem";
            this.打开文件夹ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.打开文件夹ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.打开文件夹ToolStripMenuItem.Text = "打开文件夹";
            this.打开文件夹ToolStripMenuItem.Click += new System.EventHandler(this.打开文件夹ToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于我们ToolStripMenuItem,
            this.捐赠ToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            this.帮助HToolStripMenuItem.Click += new System.EventHandler(this.帮助HToolStripMenuItem_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.DGV);
            this.panelMain.Controls.Add(this.panelDGV_Deal);
            this.panelMain.Controls.Add(this.tabControl1);
            this.panelMain.Controls.Add(this.panelStart);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 25);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(695, 427);
            this.panelMain.TabIndex = 1;
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilePath,
            this.FileName,
            this.State});
            this.DGV.ContextMenuStrip = this.contextMenu_DGV;
            this.DGV.Location = new System.Drawing.Point(7, 124);
            this.DGV.Name = "DGV";
            this.DGV.RowTemplate.Height = 23;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(569, 249);
            this.DGV.TabIndex = 1;
            this.DGV.SelectionChanged += new System.EventHandler(this.DGV_SelectionChanged);
            // 
            // FilePath
            // 
            this.FilePath.HeaderText = "路径";
            this.FilePath.Name = "FilePath";
            this.FilePath.Visible = false;
            this.FilePath.Width = 200;
            // 
            // FileName
            // 
            this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FileName.HeaderText = "文件名称";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // State
            // 
            this.State.HeaderText = "状态";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Width = 150;
            // 
            // contextMenu_DGV
            // 
            this.contextMenu_DGV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem,
            this.全部删除ToolStripMenuItem,
            this.删除成功行ToolStripMenuItem,
            this.toolStripSeparator4,
            this.清空状态ToolStripMenuItem,
            this.清除选中状态ToolStripMenuItem,
            this.整理列表ToolStripMenuItem,
            this.toolStripSeparator1,
            this.添加文件ToolStripMenuItem,
            this.添加文件夹ToolStripMenuItem,
            this.toolStripSeparator2,
            this.文件信息ToolStripMenuItem,
            this.打开文件ToolStripMenuItem,
            this.打开文件夹ToolStripMenuItem1,
            this.toolStripSeparator3,
            this.统计行数ToolStripMenuItem,
            this.统计字数ToolStripMenuItem});
            this.contextMenu_DGV.Name = "contextMenuStrip1";
            this.contextMenu_DGV.Size = new System.Drawing.Size(149, 314);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.删除ToolStripMenuItem.Text = "删除选中行";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 全部删除ToolStripMenuItem
            // 
            this.全部删除ToolStripMenuItem.Name = "全部删除ToolStripMenuItem";
            this.全部删除ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.全部删除ToolStripMenuItem.Text = "删除全部";
            this.全部删除ToolStripMenuItem.Click += new System.EventHandler(this.全部删除ToolStripMenuItem_Click);
            // 
            // 删除成功行ToolStripMenuItem
            // 
            this.删除成功行ToolStripMenuItem.Name = "删除成功行ToolStripMenuItem";
            this.删除成功行ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.删除成功行ToolStripMenuItem.Text = "删除成功行";
            this.删除成功行ToolStripMenuItem.Click += new System.EventHandler(this.删除成功行ToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(145, 6);
            // 
            // 清空状态ToolStripMenuItem
            // 
            this.清空状态ToolStripMenuItem.Name = "清空状态ToolStripMenuItem";
            this.清空状态ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.清空状态ToolStripMenuItem.Text = "清空状态";
            this.清空状态ToolStripMenuItem.Click += new System.EventHandler(this.清空状态ToolStripMenuItem_Click);
            // 
            // 清除选中状态ToolStripMenuItem
            // 
            this.清除选中状态ToolStripMenuItem.Name = "清除选中状态ToolStripMenuItem";
            this.清除选中状态ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.清除选中状态ToolStripMenuItem.Text = "清除选中状态";
            this.清除选中状态ToolStripMenuItem.Click += new System.EventHandler(this.清除选中状态ToolStripMenuItem_Click);
            // 
            // 整理列表ToolStripMenuItem
            // 
            this.整理列表ToolStripMenuItem.Name = "整理列表ToolStripMenuItem";
            this.整理列表ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.整理列表ToolStripMenuItem.Text = "整理列表";
            this.整理列表ToolStripMenuItem.Click += new System.EventHandler(this.整理列表ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // 添加文件ToolStripMenuItem
            // 
            this.添加文件ToolStripMenuItem.Name = "添加文件ToolStripMenuItem";
            this.添加文件ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.添加文件ToolStripMenuItem.Text = "添加文件";
            this.添加文件ToolStripMenuItem.Click += new System.EventHandler(this.添加文件ToolStripMenuItem_Click);
            // 
            // 添加文件夹ToolStripMenuItem
            // 
            this.添加文件夹ToolStripMenuItem.Name = "添加文件夹ToolStripMenuItem";
            this.添加文件夹ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.添加文件夹ToolStripMenuItem.Text = "添加文件夹";
            this.添加文件夹ToolStripMenuItem.Click += new System.EventHandler(this.添加文件夹ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // 文件信息ToolStripMenuItem
            // 
            this.文件信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制文件路径ToolStripMenuItem,
            this.复制文件名ToolStripMenuItem,
            this.文件详细信息ToolStripMenuItem});
            this.文件信息ToolStripMenuItem.Name = "文件信息ToolStripMenuItem";
            this.文件信息ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.文件信息ToolStripMenuItem.Text = "文件信息";
            // 
            // 复制文件路径ToolStripMenuItem
            // 
            this.复制文件路径ToolStripMenuItem.Name = "复制文件路径ToolStripMenuItem";
            this.复制文件路径ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.复制文件路径ToolStripMenuItem.Text = "复制文件路径";
            this.复制文件路径ToolStripMenuItem.Click += new System.EventHandler(this.复制文件路径ToolStripMenuItem_Click);
            // 
            // 复制文件名ToolStripMenuItem
            // 
            this.复制文件名ToolStripMenuItem.Name = "复制文件名ToolStripMenuItem";
            this.复制文件名ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.复制文件名ToolStripMenuItem.Text = "复制文件名";
            this.复制文件名ToolStripMenuItem.Click += new System.EventHandler(this.复制文件名ToolStripMenuItem_Click);
            // 
            // 文件详细信息ToolStripMenuItem
            // 
            this.文件详细信息ToolStripMenuItem.Name = "文件详细信息ToolStripMenuItem";
            this.文件详细信息ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.文件详细信息ToolStripMenuItem.Text = "文件详细信息";
            this.文件详细信息ToolStripMenuItem.Click += new System.EventHandler(this.文件详细信息ToolStripMenuItem_Click);
            // 
            // 打开文件ToolStripMenuItem
            // 
            this.打开文件ToolStripMenuItem.Name = "打开文件ToolStripMenuItem";
            this.打开文件ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.打开文件ToolStripMenuItem.Text = "打开文件";
            this.打开文件ToolStripMenuItem.Click += new System.EventHandler(this.打开文件ToolStripMenuItem_Click);
            // 
            // 打开文件夹ToolStripMenuItem1
            // 
            this.打开文件夹ToolStripMenuItem1.Name = "打开文件夹ToolStripMenuItem1";
            this.打开文件夹ToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.打开文件夹ToolStripMenuItem1.Text = "打开文件夹";
            this.打开文件夹ToolStripMenuItem1.Click += new System.EventHandler(this.打开文件夹ToolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(145, 6);
            // 
            // 统计行数ToolStripMenuItem
            // 
            this.统计行数ToolStripMenuItem.Name = "统计行数ToolStripMenuItem";
            this.统计行数ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.统计行数ToolStripMenuItem.Text = "统计行数";
            this.统计行数ToolStripMenuItem.Click += new System.EventHandler(this.统计行数ToolStripMenuItem_Click);
            // 
            // 统计字数ToolStripMenuItem
            // 
            this.统计字数ToolStripMenuItem.Name = "统计字数ToolStripMenuItem";
            this.统计字数ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.统计字数ToolStripMenuItem.Text = "统计字数";
            this.统计字数ToolStripMenuItem.Click += new System.EventHandler(this.统计字数ToolStripMenuItem_Click);
            // 
            // panelDGV_Deal
            // 
            this.panelDGV_Deal.Controls.Add(this.btnDGV_ClearState);
            this.panelDGV_Deal.Controls.Add(this.btnDGV_DeleteSuccess);
            this.panelDGV_Deal.Controls.Add(this.btnAddFolder);
            this.panelDGV_Deal.Controls.Add(this.btnAddFile);
            this.panelDGV_Deal.Controls.Add(this.btnDGV_ClearAll);
            this.panelDGV_Deal.Controls.Add(this.btnDGV_Delete);
            this.panelDGV_Deal.Location = new System.Drawing.Point(575, 124);
            this.panelDGV_Deal.Name = "panelDGV_Deal";
            this.panelDGV_Deal.Size = new System.Drawing.Size(112, 249);
            this.panelDGV_Deal.TabIndex = 11;
            // 
            // btnDGV_ClearState
            // 
            this.btnDGV_ClearState.Location = new System.Drawing.Point(7, 184);
            this.btnDGV_ClearState.Name = "btnDGV_ClearState";
            this.btnDGV_ClearState.Size = new System.Drawing.Size(101, 28);
            this.btnDGV_ClearState.TabIndex = 8;
            this.btnDGV_ClearState.Text = "清除状态";
            this.btnDGV_ClearState.UseVisualStyleBackColor = true;
            this.btnDGV_ClearState.Click += new System.EventHandler(this.btnClearState_Click);
            // 
            // btnDGV_DeleteSuccess
            // 
            this.btnDGV_DeleteSuccess.Location = new System.Drawing.Point(7, 116);
            this.btnDGV_DeleteSuccess.Name = "btnDGV_DeleteSuccess";
            this.btnDGV_DeleteSuccess.Size = new System.Drawing.Size(101, 28);
            this.btnDGV_DeleteSuccess.TabIndex = 7;
            this.btnDGV_DeleteSuccess.Text = "删除成功行";
            this.btnDGV_DeleteSuccess.UseVisualStyleBackColor = true;
            this.btnDGV_DeleteSuccess.Click += new System.EventHandler(this.btnDeleteSuccess_Click);
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(8, 37);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(101, 28);
            this.btnAddFolder.TabIndex = 3;
            this.btnAddFolder.Text = "添加文件夹";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(8, 3);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(101, 28);
            this.btnAddFile.TabIndex = 2;
            this.btnAddFile.Text = "添加文件";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDGV_ClearAll
            // 
            this.btnDGV_ClearAll.Location = new System.Drawing.Point(7, 150);
            this.btnDGV_ClearAll.Name = "btnDGV_ClearAll";
            this.btnDGV_ClearAll.Size = new System.Drawing.Size(101, 28);
            this.btnDGV_ClearAll.TabIndex = 6;
            this.btnDGV_ClearAll.Text = "清空列表";
            this.btnDGV_ClearAll.UseVisualStyleBackColor = true;
            this.btnDGV_ClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnDGV_Delete
            // 
            this.btnDGV_Delete.Location = new System.Drawing.Point(7, 82);
            this.btnDGV_Delete.Name = "btnDGV_Delete";
            this.btnDGV_Delete.Size = new System.Drawing.Size(101, 28);
            this.btnDGV_Delete.TabIndex = 3;
            this.btnDGV_Delete.Text = "删除选中行";
            this.btnDGV_Delete.UseVisualStyleBackColor = true;
            this.btnDGV_Delete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpDeleteLine);
            this.tabControl1.Controls.Add(this.tpDeleteData);
            this.tabControl1.Controls.Add(this.tpMerge);
            this.tabControl1.Controls.Add(this.tpSplit);
            this.tabControl1.Controls.Add(this.tpAddData);
            this.tabControl1.Controls.Add(this.tpDeleteLineFromFile);
            this.tabControl1.Controls.Add(this.tpOther);
            this.tabControl1.Location = new System.Drawing.Point(7, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(681, 105);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tpDeleteLine
            // 
            this.tpDeleteLine.Controls.Add(this.panelDelLine_KeyWords);
            this.tpDeleteLine.Controls.Add(this.panelDelLine_TeDing);
            this.tpDeleteLine.Controls.Add(this.panelDelLine1);
            this.tpDeleteLine.Controls.Add(this.label11);
            this.tpDeleteLine.Controls.Add(this.comboBoxDeleteLine);
            this.tpDeleteLine.Location = new System.Drawing.Point(4, 22);
            this.tpDeleteLine.Name = "tpDeleteLine";
            this.tpDeleteLine.Padding = new System.Windows.Forms.Padding(3);
            this.tpDeleteLine.Size = new System.Drawing.Size(673, 79);
            this.tpDeleteLine.TabIndex = 0;
            this.tpDeleteLine.Text = "批量删除行";
            this.tpDeleteLine.UseVisualStyleBackColor = true;
            // 
            // panelDelLine_KeyWords
            // 
            this.panelDelLine_KeyWords.Controls.Add(this.label33);
            this.panelDelLine_KeyWords.Controls.Add(this.label32);
            this.panelDelLine_KeyWords.Controls.Add(this.checkBoxDelLine_KeyWord);
            this.panelDelLine_KeyWords.Controls.Add(this.label31);
            this.panelDelLine_KeyWords.Controls.Add(this.txbDelLine_TeDingData);
            this.panelDelLine_KeyWords.Location = new System.Drawing.Point(1, 3);
            this.panelDelLine_KeyWords.Name = "panelDelLine_KeyWords";
            this.panelDelLine_KeyWords.Size = new System.Drawing.Size(473, 67);
            this.panelDelLine_KeyWords.TabIndex = 15;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.ForeColor = System.Drawing.Color.Red;
            this.label33.Location = new System.Drawing.Point(324, 46);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(131, 12);
            this.label33.TabIndex = 6;
            this.label33.Text = "例如：我爱你+520+祖国";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(348, 16);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(119, 12);
            this.label32.TabIndex = 6;
            this.label32.Text = "关键词之间用+号间隔";
            // 
            // checkBoxDelLine_KeyWord
            // 
            this.checkBoxDelLine_KeyWord.AutoSize = true;
            this.checkBoxDelLine_KeyWord.Location = new System.Drawing.Point(17, 45);
            this.checkBoxDelLine_KeyWord.Name = "checkBoxDelLine_KeyWord";
            this.checkBoxDelLine_KeyWord.Size = new System.Drawing.Size(288, 16);
            this.checkBoxDelLine_KeyWord.TabIndex = 7;
            this.checkBoxDelLine_KeyWord.Text = "现在是只有一个关键字，删除含有这个关键字的行";
            this.checkBoxDelLine_KeyWord.UseVisualStyleBackColor = true;
            this.checkBoxDelLine_KeyWord.Click += new System.EventHandler(this.checkBoxKeyWord_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(15, 19);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(47, 12);
            this.label31.TabIndex = 6;
            this.label31.Text = "关键字:";
            // 
            // txbDelLine_TeDingData
            // 
            this.txbDelLine_TeDingData.Location = new System.Drawing.Point(68, 16);
            this.txbDelLine_TeDingData.Name = "txbDelLine_TeDingData";
            this.txbDelLine_TeDingData.Size = new System.Drawing.Size(274, 21);
            this.txbDelLine_TeDingData.TabIndex = 6;
            // 
            // panelDelLine_TeDing
            // 
            this.panelDelLine_TeDing.Controls.Add(this.label30);
            this.panelDelLine_TeDing.Controls.Add(this.txbDelLine_TeDing);
            this.panelDelLine_TeDing.Controls.Add(this.label29);
            this.panelDelLine_TeDing.Controls.Add(this.label28);
            this.panelDelLine_TeDing.Controls.Add(this.label27);
            this.panelDelLine_TeDing.Controls.Add(this.label26);
            this.panelDelLine_TeDing.Location = new System.Drawing.Point(3, 3);
            this.panelDelLine_TeDing.Name = "panelDelLine_TeDing";
            this.panelDelLine_TeDing.Size = new System.Drawing.Size(473, 67);
            this.panelDelLine_TeDing.TabIndex = 14;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(228, 44);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(89, 12);
            this.label30.TabIndex = 5;
            this.label30.Text = "例如：1,3,7,10";
            // 
            // txbDelLine_TeDing
            // 
            this.txbDelLine_TeDing.Location = new System.Drawing.Point(211, 9);
            this.txbDelLine_TeDing.Name = "txbDelLine_TeDing";
            this.txbDelLine_TeDing.Size = new System.Drawing.Size(259, 21);
            this.txbDelLine_TeDing.TabIndex = 4;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.Color.Red;
            this.label29.Location = new System.Drawing.Point(7, 34);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(131, 12);
            this.label29.TabIndex = 3;
            this.label29.Text = "2、输入的数字不能重复";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.Red;
            this.label28.Location = new System.Drawing.Point(7, 51);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(167, 12);
            this.label28.TabIndex = 2;
            this.label28.Text = "3、数字之间用英语的逗号间隔";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.Red;
            this.label27.Location = new System.Drawing.Point(7, 20);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(173, 12);
            this.label27.TabIndex = 1;
            this.label27.Text = "1、输入递增的数字，非负整数.";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(7, 7);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(77, 12);
            this.label26.TabIndex = 0;
            this.label26.Text = "特定行注意：";
            // 
            // panelDelLine1
            // 
            this.panelDelLine1.Controls.Add(this.label1);
            this.panelDelLine1.Controls.Add(this.nudDelLine_TopLineFile);
            this.panelDelLine1.Controls.Add(this.label9);
            this.panelDelLine1.Controls.Add(this.label2);
            this.panelDelLine1.Controls.Add(this.nudDelLine_ContinueLast);
            this.panelDelLine1.Controls.Add(this.label4);
            this.panelDelLine1.Controls.Add(this.label7);
            this.panelDelLine1.Controls.Add(this.nudDelLine_ContinueFirst);
            this.panelDelLine1.Controls.Add(this.nudDelLine_LastLineFile);
            this.panelDelLine1.Controls.Add(this.label8);
            this.panelDelLine1.Controls.Add(this.label3);
            this.panelDelLine1.Location = new System.Drawing.Point(6, 3);
            this.panelDelLine1.Name = "panelDelLine1";
            this.panelDelLine1.Size = new System.Drawing.Size(479, 73);
            this.panelDelLine1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "删除文件前:";
            // 
            // nudDelLine_TopLineFile
            // 
            this.nudDelLine_TopLineFile.Location = new System.Drawing.Point(98, 14);
            this.nudDelLine_TopLineFile.Name = "nudDelLine_TopLineFile";
            this.nudDelLine_TopLineFile.Size = new System.Drawing.Size(40, 21);
            this.nudDelLine_TopLineFile.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(378, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "行";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "行";
            // 
            // nudDelLine_ContinueLast
            // 
            this.nudDelLine_ContinueLast.Location = new System.Drawing.Point(332, 29);
            this.nudDelLine_ContinueLast.Name = "nudDelLine_ContinueLast";
            this.nudDelLine_ContinueLast.Size = new System.Drawing.Size(40, 21);
            this.nudDelLine_ContinueLast.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "删除文件后:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "行到第";
            // 
            // nudDelLine_ContinueFirst
            // 
            this.nudDelLine_ContinueFirst.Location = new System.Drawing.Point(239, 29);
            this.nudDelLine_ContinueFirst.Name = "nudDelLine_ContinueFirst";
            this.nudDelLine_ContinueFirst.Size = new System.Drawing.Size(40, 21);
            this.nudDelLine_ContinueFirst.TabIndex = 9;
            // 
            // nudDelLine_LastLineFile
            // 
            this.nudDelLine_LastLineFile.Location = new System.Drawing.Point(98, 49);
            this.nudDelLine_LastLineFile.Name = "nudDelLine_LastLineFile";
            this.nudDelLine_LastLineFile.Size = new System.Drawing.Size(40, 21);
            this.nudDelLine_LastLineFile.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(192, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "删除第";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "行";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(625, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 16;
            this.label11.Text = "模式";
            // 
            // comboBoxDeleteLine
            // 
            this.comboBoxDeleteLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeleteLine.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxDeleteLine.FormattingEnabled = true;
            this.comboBoxDeleteLine.Items.AddRange(new object[] {
            "删除前后行",
            "删除连续行",
            "删除奇数行",
            "删除偶数行",
            "删除空白行",
            "删除重复行",
            "删除特定行",
            "删除含有关键字的行"});
            this.comboBoxDeleteLine.Location = new System.Drawing.Point(491, 13);
            this.comboBoxDeleteLine.Name = "comboBoxDeleteLine";
            this.comboBoxDeleteLine.Size = new System.Drawing.Size(128, 22);
            this.comboBoxDeleteLine.TabIndex = 15;
            this.comboBoxDeleteLine.SelectionChangeCommitted += new System.EventHandler(this.comboBoxDeleteLine_SelectionChangeCommitted);
            // 
            // tpDeleteData
            // 
            this.tpDeleteData.Controls.Add(this.panelDelData_FirstLastOfLine);
            this.tpDeleteData.Controls.Add(this.label22);
            this.tpDeleteData.Controls.Add(this.comboBoxDeleteData);
            this.tpDeleteData.Controls.Add(this.panelDeleteReplaceData);
            this.tpDeleteData.Location = new System.Drawing.Point(4, 22);
            this.tpDeleteData.Name = "tpDeleteData";
            this.tpDeleteData.Padding = new System.Windows.Forms.Padding(3);
            this.tpDeleteData.Size = new System.Drawing.Size(673, 79);
            this.tpDeleteData.TabIndex = 1;
            this.tpDeleteData.Text = "批量删除文本";
            this.tpDeleteData.UseVisualStyleBackColor = true;
            // 
            // panelDelData_FirstLastOfLine
            // 
            this.panelDelData_FirstLastOfLine.Controls.Add(this.button1);
            this.panelDelData_FirstLastOfLine.Controls.Add(this.txbCountZiFu);
            this.panelDelData_FirstLastOfLine.Controls.Add(this.checkBoxDel_DataTopOfLine);
            this.panelDelData_FirstLastOfLine.Controls.Add(this.label25);
            this.panelDelData_FirstLastOfLine.Controls.Add(this.label24);
            this.panelDelData_FirstLastOfLine.Controls.Add(this.label23);
            this.panelDelData_FirstLastOfLine.Controls.Add(this.nudDelData_CountZiFu);
            this.panelDelData_FirstLastOfLine.Location = new System.Drawing.Point(3, 3);
            this.panelDelData_FirstLastOfLine.Name = "panelDelData_FirstLastOfLine";
            this.panelDelData_FirstLastOfLine.Size = new System.Drawing.Size(484, 73);
            this.panelDelData_FirstLastOfLine.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txbCountZiFu
            // 
            this.txbCountZiFu.Location = new System.Drawing.Point(177, 43);
            this.txbCountZiFu.Name = "txbCountZiFu";
            this.txbCountZiFu.Size = new System.Drawing.Size(242, 21);
            this.txbCountZiFu.TabIndex = 5;
            this.txbCountZiFu.Leave += new System.EventHandler(this.txbCountZiFu_Leave);
            // 
            // checkBoxDel_DataTopOfLine
            // 
            this.checkBoxDel_DataTopOfLine.AutoSize = true;
            this.checkBoxDel_DataTopOfLine.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxDel_DataTopOfLine.Location = new System.Drawing.Point(20, 45);
            this.checkBoxDel_DataTopOfLine.Name = "checkBoxDel_DataTopOfLine";
            this.checkBoxDel_DataTopOfLine.Size = new System.Drawing.Size(120, 16);
            this.checkBoxDel_DataTopOfLine.TabIndex = 4;
            this.checkBoxDel_DataTopOfLine.Text = "不知道多少个字符";
            this.checkBoxDel_DataTopOfLine.UseVisualStyleBackColor = true;
            this.checkBoxDel_DataTopOfLine.Click += new System.EventHandler(this.checkBoxDeleteFirstOfLine_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(168, 15);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(233, 12);
            this.label25.TabIndex = 3;
            this.label25.Text = "：一个字母一个数字一个汉字都是一个字符";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(133, 15);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(29, 12);
            this.label24.TabIndex = 2;
            this.label24.Text = "字符";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(18, 15);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 12);
            this.label23.TabIndex = 1;
            this.label23.Text = "删除行首";
            // 
            // nudDelData_CountZiFu
            // 
            this.nudDelData_CountZiFu.Location = new System.Drawing.Point(77, 13);
            this.nudDelData_CountZiFu.Name = "nudDelData_CountZiFu";
            this.nudDelData_CountZiFu.Size = new System.Drawing.Size(50, 21);
            this.nudDelData_CountZiFu.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(623, 11);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 12);
            this.label22.TabIndex = 23;
            this.label22.Text = "模式";
            // 
            // comboBoxDeleteData
            // 
            this.comboBoxDeleteData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeleteData.Font = new System.Drawing.Font("宋体", 10.5F);
            this.comboBoxDeleteData.FormattingEnabled = true;
            this.comboBoxDeleteData.Items.AddRange(new object[] {
            "删除文本",
            "替换文本",
            "删除行首数字",
            "删除行首字符",
            "删除行尾字符"});
            this.comboBoxDeleteData.Location = new System.Drawing.Point(496, 8);
            this.comboBoxDeleteData.Name = "comboBoxDeleteData";
            this.comboBoxDeleteData.Size = new System.Drawing.Size(121, 22);
            this.comboBoxDeleteData.TabIndex = 22;
            this.comboBoxDeleteData.SelectionChangeCommitted += new System.EventHandler(this.comboBoxDeleteData_SelectionChangeCommitted);
            // 
            // panelDeleteReplaceData
            // 
            this.panelDeleteReplaceData.Controls.Add(this.label5);
            this.panelDeleteReplaceData.Controls.Add(this.txbDelNewData);
            this.panelDeleteReplaceData.Controls.Add(this.txbDelOldData);
            this.panelDeleteReplaceData.Controls.Add(this.label10);
            this.panelDeleteReplaceData.Location = new System.Drawing.Point(6, 3);
            this.panelDeleteReplaceData.Name = "panelDeleteReplaceData";
            this.panelDeleteReplaceData.Size = new System.Drawing.Size(484, 73);
            this.panelDeleteReplaceData.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "批量删除的文本:";
            // 
            // txbDelNewData
            // 
            this.txbDelNewData.Location = new System.Drawing.Point(138, 37);
            this.txbDelNewData.Name = "txbDelNewData";
            this.txbDelNewData.Size = new System.Drawing.Size(341, 21);
            this.txbDelNewData.TabIndex = 3;
            // 
            // txbDelOldData
            // 
            this.txbDelOldData.Location = new System.Drawing.Point(138, 10);
            this.txbDelOldData.Name = "txbDelOldData";
            this.txbDelOldData.Size = new System.Drawing.Size(341, 21);
            this.txbDelOldData.TabIndex = 1;
            this.txbDelOldData.Click += new System.EventHandler(this.txbDeleteText_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "替换的新文本:";
            // 
            // tpMerge
            // 
            this.tpMerge.Controls.Add(this.panelMerge_LeftRight);
            this.tpMerge.Controls.Add(this.panelMerge_GeHang);
            this.tpMerge.Controls.Add(this.label20);
            this.tpMerge.Controls.Add(this.comboBoxMerge);
            this.tpMerge.Controls.Add(this.panelMerge_AddDataAmongFile);
            this.tpMerge.Controls.Add(this.btnDownMove);
            this.tpMerge.Controls.Add(this.btnUpMove);
            this.tpMerge.Location = new System.Drawing.Point(4, 22);
            this.tpMerge.Name = "tpMerge";
            this.tpMerge.Size = new System.Drawing.Size(673, 79);
            this.tpMerge.TabIndex = 3;
            this.tpMerge.Text = "合并";
            this.tpMerge.UseVisualStyleBackColor = true;
            // 
            // panelMerge_LeftRight
            // 
            this.panelMerge_LeftRight.Controls.Add(this.checkBoxMerge_LeftRightAddData);
            this.panelMerge_LeftRight.Controls.Add(this.label21);
            this.panelMerge_LeftRight.Controls.Add(this.txbMerge_LeftRightData);
            this.panelMerge_LeftRight.Location = new System.Drawing.Point(3, 3);
            this.panelMerge_LeftRight.Name = "panelMerge_LeftRight";
            this.panelMerge_LeftRight.Size = new System.Drawing.Size(484, 73);
            this.panelMerge_LeftRight.TabIndex = 13;
            // 
            // checkBoxMerge_LeftRightAddData
            // 
            this.checkBoxMerge_LeftRightAddData.AutoSize = true;
            this.checkBoxMerge_LeftRightAddData.Location = new System.Drawing.Point(45, 18);
            this.checkBoxMerge_LeftRightAddData.Name = "checkBoxMerge_LeftRightAddData";
            this.checkBoxMerge_LeftRightAddData.Size = new System.Drawing.Size(72, 16);
            this.checkBoxMerge_LeftRightAddData.TabIndex = 2;
            this.checkBoxMerge_LeftRightAddData.Text = "添加数据";
            this.checkBoxMerge_LeftRightAddData.UseVisualStyleBackColor = true;
            this.checkBoxMerge_LeftRightAddData.Click += new System.EventHandler(this.checkBoxMergeLeftRightAddData_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(25, 51);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(107, 12);
            this.label21.TabIndex = 1;
            this.label21.Text = "左右合并添加数据:";
            // 
            // txbMerge_LeftRightData
            // 
            this.txbMerge_LeftRightData.Location = new System.Drawing.Point(138, 48);
            this.txbMerge_LeftRightData.Name = "txbMerge_LeftRightData";
            this.txbMerge_LeftRightData.Size = new System.Drawing.Size(256, 21);
            this.txbMerge_LeftRightData.TabIndex = 0;
            // 
            // panelMerge_GeHang
            // 
            this.panelMerge_GeHang.Location = new System.Drawing.Point(3, 3);
            this.panelMerge_GeHang.Name = "panelMerge_GeHang";
            this.panelMerge_GeHang.Size = new System.Drawing.Size(484, 73);
            this.panelMerge_GeHang.TabIndex = 12;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(620, 14);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 12);
            this.label20.TabIndex = 22;
            this.label20.Text = "模式";
            // 
            // comboBoxMerge
            // 
            this.comboBoxMerge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMerge.Font = new System.Drawing.Font("宋体", 10.5F);
            this.comboBoxMerge.FormattingEnabled = true;
            this.comboBoxMerge.Items.AddRange(new object[] {
            "普通合并",
            "合并+数据",
            "隔行合并",
            "左右合并"});
            this.comboBoxMerge.Location = new System.Drawing.Point(493, 11);
            this.comboBoxMerge.Name = "comboBoxMerge";
            this.comboBoxMerge.Size = new System.Drawing.Size(121, 22);
            this.comboBoxMerge.TabIndex = 21;
            this.comboBoxMerge.SelectionChangeCommitted += new System.EventHandler(this.comboBoxModeMerge_SelectionChangeCommitted);
            // 
            // panelMerge_AddDataAmongFile
            // 
            this.panelMerge_AddDataAmongFile.Controls.Add(this.checkBoxMerge_AddFileName);
            this.panelMerge_AddDataAmongFile.Controls.Add(this.txbMerge_AddDataAmongFiles);
            this.panelMerge_AddDataAmongFile.Controls.Add(this.label12);
            this.panelMerge_AddDataAmongFile.Controls.Add(this.checkBoxMerge_AddDataAmongFiles);
            this.panelMerge_AddDataAmongFile.Location = new System.Drawing.Point(3, 3);
            this.panelMerge_AddDataAmongFile.Name = "panelMerge_AddDataAmongFile";
            this.panelMerge_AddDataAmongFile.Size = new System.Drawing.Size(484, 73);
            this.panelMerge_AddDataAmongFile.TabIndex = 11;
            // 
            // checkBoxMerge_AddFileName
            // 
            this.checkBoxMerge_AddFileName.AutoSize = true;
            this.checkBoxMerge_AddFileName.Location = new System.Drawing.Point(12, 40);
            this.checkBoxMerge_AddFileName.Name = "checkBoxMerge_AddFileName";
            this.checkBoxMerge_AddFileName.Size = new System.Drawing.Size(132, 16);
            this.checkBoxMerge_AddFileName.TabIndex = 5;
            this.checkBoxMerge_AddFileName.Text = "文件之间添加文件名";
            this.checkBoxMerge_AddFileName.UseVisualStyleBackColor = true;
            this.checkBoxMerge_AddFileName.Click += new System.EventHandler(this.checkBoxAddFileName_Click);
            // 
            // txbMerge_AddDataAmongFiles
            // 
            this.txbMerge_AddDataAmongFiles.Location = new System.Drawing.Point(186, 12);
            this.txbMerge_AddDataAmongFiles.Multiline = true;
            this.txbMerge_AddDataAmongFiles.Name = "txbMerge_AddDataAmongFiles";
            this.txbMerge_AddDataAmongFiles.Size = new System.Drawing.Size(221, 44);
            this.txbMerge_AddDataAmongFiles.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(151, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "数据:";
            // 
            // checkBoxMerge_AddDataAmongFiles
            // 
            this.checkBoxMerge_AddDataAmongFiles.AutoSize = true;
            this.checkBoxMerge_AddDataAmongFiles.Location = new System.Drawing.Point(12, 12);
            this.checkBoxMerge_AddDataAmongFiles.Name = "checkBoxMerge_AddDataAmongFiles";
            this.checkBoxMerge_AddDataAmongFiles.Size = new System.Drawing.Size(120, 16);
            this.checkBoxMerge_AddDataAmongFiles.TabIndex = 2;
            this.checkBoxMerge_AddDataAmongFiles.Text = "文件之间添加数据";
            this.checkBoxMerge_AddDataAmongFiles.UseVisualStyleBackColor = true;
            this.checkBoxMerge_AddDataAmongFiles.Click += new System.EventHandler(this.checkBoxAddDataAmongFiles_Click);
            // 
            // btnDownMove
            // 
            this.btnDownMove.Font = new System.Drawing.Font("宋体", 15F);
            this.btnDownMove.Location = new System.Drawing.Point(622, 39);
            this.btnDownMove.Name = "btnDownMove";
            this.btnDownMove.Size = new System.Drawing.Size(27, 37);
            this.btnDownMove.TabIndex = 1;
            this.btnDownMove.Text = "↓";
            this.btnDownMove.UseVisualStyleBackColor = true;
            this.btnDownMove.Click += new System.EventHandler(this.btnDownMove_Click);
            // 
            // btnUpMove
            // 
            this.btnUpMove.Font = new System.Drawing.Font("宋体", 15F);
            this.btnUpMove.Location = new System.Drawing.Point(577, 39);
            this.btnUpMove.Name = "btnUpMove";
            this.btnUpMove.Size = new System.Drawing.Size(27, 37);
            this.btnUpMove.TabIndex = 0;
            this.btnUpMove.Text = "↑";
            this.btnUpMove.UseVisualStyleBackColor = true;
            this.btnUpMove.Click += new System.EventHandler(this.btnUpMove_Click);
            // 
            // tpSplit
            // 
            this.tpSplit.Controls.Add(this.nudSplit_Line);
            this.tpSplit.Controls.Add(this.label17);
            this.tpSplit.Controls.Add(this.label15);
            this.tpSplit.Controls.Add(this.label16);
            this.tpSplit.Controls.Add(this.comboBoxSplit);
            this.tpSplit.Controls.Add(this.label14);
            this.tpSplit.Controls.Add(this.label13);
            this.tpSplit.Controls.Add(this.nudSplit_Count);
            this.tpSplit.Location = new System.Drawing.Point(4, 22);
            this.tpSplit.Name = "tpSplit";
            this.tpSplit.Size = new System.Drawing.Size(673, 79);
            this.tpSplit.TabIndex = 4;
            this.tpSplit.Text = "拆分";
            this.tpSplit.UseVisualStyleBackColor = true;
            // 
            // nudSplit_Line
            // 
            this.nudSplit_Line.Location = new System.Drawing.Point(138, 44);
            this.nudSplit_Line.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nudSplit_Line.Name = "nudSplit_Line";
            this.nudSplit_Line.Size = new System.Drawing.Size(58, 21);
            this.nudSplit_Line.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(399, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 12);
            this.label17.TabIndex = 20;
            this.label17.Text = "模式:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(202, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 12);
            this.label15.TabIndex = 19;
            this.label15.Text = "行";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(68, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 18;
            this.label16.Text = "行数拆分：";
            // 
            // comboBoxSplit
            // 
            this.comboBoxSplit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSplit.Font = new System.Drawing.Font("宋体", 10.5F);
            this.comboBoxSplit.FormattingEnabled = true;
            this.comboBoxSplit.Items.AddRange(new object[] {
            "拆分固定个数",
            "拆分固定行数",
            "含有特定字符",
            "拆分奇偶行"});
            this.comboBoxSplit.Location = new System.Drawing.Point(434, 10);
            this.comboBoxSplit.Name = "comboBoxSplit";
            this.comboBoxSplit.Size = new System.Drawing.Size(121, 22);
            this.comboBoxSplit.TabIndex = 16;
            this.comboBoxSplit.SelectionChangeCommitted += new System.EventHandler(this.comboBoxModeSplit_SelectionChangeCommitted);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(189, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 2;
            this.label14.Text = "个";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(68, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 1;
            this.label13.Text = "个数拆分：";
            // 
            // nudSplit_Count
            // 
            this.nudSplit_Count.Location = new System.Drawing.Point(139, 10);
            this.nudSplit_Count.Name = "nudSplit_Count";
            this.nudSplit_Count.Size = new System.Drawing.Size(44, 21);
            this.nudSplit_Count.TabIndex = 0;
            // 
            // tpAddData
            // 
            this.tpAddData.Controls.Add(this.panelAddData_FileName);
            this.tpAddData.Controls.Add(this.panelAddData_TopEndOfLine);
            this.tpAddData.Controls.Add(this.panelAddData_TopEndOfFile);
            this.tpAddData.Controls.Add(this.label34);
            this.tpAddData.Controls.Add(this.comboBoxAddData);
            this.tpAddData.Location = new System.Drawing.Point(4, 22);
            this.tpAddData.Name = "tpAddData";
            this.tpAddData.Size = new System.Drawing.Size(673, 79);
            this.tpAddData.TabIndex = 6;
            this.tpAddData.Text = "添加数据";
            this.tpAddData.UseVisualStyleBackColor = true;
            // 
            // panelAddData_FileName
            // 
            this.panelAddData_FileName.Controls.Add(this.label37);
            this.panelAddData_FileName.Controls.Add(this.checkBoxAddData_ContainExtension);
            this.panelAddData_FileName.Controls.Add(this.checkBoxAddData_ContainDir);
            this.panelAddData_FileName.Controls.Add(this.txbAddData_FileName2);
            this.panelAddData_FileName.Controls.Add(this.label36);
            this.panelAddData_FileName.Controls.Add(this.txbAddData_FileName1);
            this.panelAddData_FileName.Location = new System.Drawing.Point(3, 0);
            this.panelAddData_FileName.Name = "panelAddData_FileName";
            this.panelAddData_FileName.Size = new System.Drawing.Size(484, 73);
            this.panelAddData_FileName.TabIndex = 16;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(253, 14);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(101, 12);
            this.label37.TabIndex = 13;
            this.label37.Text = "加入到文件的首行";
            // 
            // checkBoxAddData_ContainExtension
            // 
            this.checkBoxAddData_ContainExtension.AutoSize = true;
            this.checkBoxAddData_ContainExtension.Location = new System.Drawing.Point(14, 36);
            this.checkBoxAddData_ContainExtension.Name = "checkBoxAddData_ContainExtension";
            this.checkBoxAddData_ContainExtension.Size = new System.Drawing.Size(120, 16);
            this.checkBoxAddData_ContainExtension.TabIndex = 12;
            this.checkBoxAddData_ContainExtension.Text = "文件名包含扩展名";
            this.checkBoxAddData_ContainExtension.UseVisualStyleBackColor = true;
            // 
            // checkBoxAddData_ContainDir
            // 
            this.checkBoxAddData_ContainDir.AutoSize = true;
            this.checkBoxAddData_ContainDir.Location = new System.Drawing.Point(14, 12);
            this.checkBoxAddData_ContainDir.Name = "checkBoxAddData_ContainDir";
            this.checkBoxAddData_ContainDir.Size = new System.Drawing.Size(108, 16);
            this.checkBoxAddData_ContainDir.TabIndex = 11;
            this.checkBoxAddData_ContainDir.Text = "文件名包含路径";
            this.checkBoxAddData_ContainDir.UseVisualStyleBackColor = true;
            // 
            // txbAddData_FileName2
            // 
            this.txbAddData_FileName2.Location = new System.Drawing.Point(327, 41);
            this.txbAddData_FileName2.Name = "txbAddData_FileName2";
            this.txbAddData_FileName2.Size = new System.Drawing.Size(93, 21);
            this.txbAddData_FileName2.TabIndex = 10;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(268, 44);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(53, 12);
            this.label36.TabIndex = 9;
            this.label36.Text = "+文件名+";
            // 
            // txbAddData_FileName1
            // 
            this.txbAddData_FileName1.Location = new System.Drawing.Point(169, 41);
            this.txbAddData_FileName1.Name = "txbAddData_FileName1";
            this.txbAddData_FileName1.Size = new System.Drawing.Size(93, 21);
            this.txbAddData_FileName1.TabIndex = 8;
            // 
            // panelAddData_TopEndOfLine
            // 
            this.panelAddData_TopEndOfLine.Controls.Add(this.txbAddData_EndLine);
            this.panelAddData_TopEndOfLine.Controls.Add(this.checkBoxAddData_EndLine);
            this.panelAddData_TopEndOfLine.Controls.Add(this.label35);
            this.panelAddData_TopEndOfLine.Controls.Add(this.nudAddData_TopLine);
            this.panelAddData_TopEndOfLine.Controls.Add(this.checkBoxAddData_ContainNumber);
            this.panelAddData_TopEndOfLine.Controls.Add(this.txbAddData_TopLine);
            this.panelAddData_TopEndOfLine.Controls.Add(this.checkBoxAddData_TopLine);
            this.panelAddData_TopEndOfLine.Location = new System.Drawing.Point(6, 3);
            this.panelAddData_TopEndOfLine.Name = "panelAddData_TopEndOfLine";
            this.panelAddData_TopEndOfLine.Size = new System.Drawing.Size(484, 73);
            this.panelAddData_TopEndOfLine.TabIndex = 15;
            // 
            // txbAddData_EndLine
            // 
            this.txbAddData_EndLine.Location = new System.Drawing.Point(107, 43);
            this.txbAddData_EndLine.Name = "txbAddData_EndLine";
            this.txbAddData_EndLine.Size = new System.Drawing.Size(173, 21);
            this.txbAddData_EndLine.TabIndex = 8;
            // 
            // checkBoxAddData_EndLine
            // 
            this.checkBoxAddData_EndLine.AutoSize = true;
            this.checkBoxAddData_EndLine.Location = new System.Drawing.Point(17, 45);
            this.checkBoxAddData_EndLine.Name = "checkBoxAddData_EndLine";
            this.checkBoxAddData_EndLine.Size = new System.Drawing.Size(84, 16);
            this.checkBoxAddData_EndLine.TabIndex = 7;
            this.checkBoxAddData_EndLine.Text = "添加到行尾";
            this.checkBoxAddData_EndLine.UseVisualStyleBackColor = true;
            this.checkBoxAddData_EndLine.Click += new System.EventHandler(this.checkBoxAddDataEndLine_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(325, 31);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(89, 12);
            this.label35.TabIndex = 6;
            this.label35.Text = "自定义首行数字";
            // 
            // nudAddData_TopLine
            // 
            this.nudAddData_TopLine.Location = new System.Drawing.Point(377, 7);
            this.nudAddData_TopLine.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudAddData_TopLine.Name = "nudAddData_TopLine";
            this.nudAddData_TopLine.Size = new System.Drawing.Size(37, 21);
            this.nudAddData_TopLine.TabIndex = 5;
            this.nudAddData_TopLine.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBoxAddData_ContainNumber
            // 
            this.checkBoxAddData_ContainNumber.AutoSize = true;
            this.checkBoxAddData_ContainNumber.Location = new System.Drawing.Point(107, 12);
            this.checkBoxAddData_ContainNumber.Name = "checkBoxAddData_ContainNumber";
            this.checkBoxAddData_ContainNumber.Size = new System.Drawing.Size(78, 16);
            this.checkBoxAddData_ContainNumber.TabIndex = 4;
            this.checkBoxAddData_ContainNumber.Text = "递增数字+";
            this.checkBoxAddData_ContainNumber.UseVisualStyleBackColor = true;
            this.checkBoxAddData_ContainNumber.Click += new System.EventHandler(this.checkBoxIsContainNumber_Click);
            // 
            // txbAddData_TopLine
            // 
            this.txbAddData_TopLine.Location = new System.Drawing.Point(191, 7);
            this.txbAddData_TopLine.Name = "txbAddData_TopLine";
            this.txbAddData_TopLine.Size = new System.Drawing.Size(160, 21);
            this.txbAddData_TopLine.TabIndex = 3;
            // 
            // checkBoxAddData_TopLine
            // 
            this.checkBoxAddData_TopLine.AutoSize = true;
            this.checkBoxAddData_TopLine.Location = new System.Drawing.Point(17, 12);
            this.checkBoxAddData_TopLine.Name = "checkBoxAddData_TopLine";
            this.checkBoxAddData_TopLine.Size = new System.Drawing.Size(84, 16);
            this.checkBoxAddData_TopLine.TabIndex = 2;
            this.checkBoxAddData_TopLine.Text = "添加到行首";
            this.checkBoxAddData_TopLine.UseVisualStyleBackColor = true;
            this.checkBoxAddData_TopLine.Click += new System.EventHandler(this.checkBoxAddDataTopLine_Click);
            // 
            // panelAddData_TopEndOfFile
            // 
            this.panelAddData_TopEndOfFile.Controls.Add(this.checkBoxAddData_OverWrite);
            this.panelAddData_TopEndOfFile.Controls.Add(this.checkBoxAddData_EndFile);
            this.panelAddData_TopEndOfFile.Controls.Add(this.checkBoxAddData_TopFile);
            this.panelAddData_TopEndOfFile.Controls.Add(this.txbAddData_TopEndOfFile);
            this.panelAddData_TopEndOfFile.Location = new System.Drawing.Point(3, 6);
            this.panelAddData_TopEndOfFile.Name = "panelAddData_TopEndOfFile";
            this.panelAddData_TopEndOfFile.Size = new System.Drawing.Size(484, 70);
            this.panelAddData_TopEndOfFile.TabIndex = 14;
            // 
            // checkBoxAddData_OverWrite
            // 
            this.checkBoxAddData_OverWrite.AutoSize = true;
            this.checkBoxAddData_OverWrite.Location = new System.Drawing.Point(17, 51);
            this.checkBoxAddData_OverWrite.Name = "checkBoxAddData_OverWrite";
            this.checkBoxAddData_OverWrite.Size = new System.Drawing.Size(162, 16);
            this.checkBoxAddData_OverWrite.TabIndex = 3;
            this.checkBoxAddData_OverWrite.Text = "如果已经存在 则跳过添加";
            this.checkBoxAddData_OverWrite.UseVisualStyleBackColor = true;
            // 
            // checkBoxAddData_EndFile
            // 
            this.checkBoxAddData_EndFile.AutoSize = true;
            this.checkBoxAddData_EndFile.Location = new System.Drawing.Point(17, 29);
            this.checkBoxAddData_EndFile.Name = "checkBoxAddData_EndFile";
            this.checkBoxAddData_EndFile.Size = new System.Drawing.Size(96, 16);
            this.checkBoxAddData_EndFile.TabIndex = 2;
            this.checkBoxAddData_EndFile.Text = "添加到文件尾";
            this.checkBoxAddData_EndFile.UseVisualStyleBackColor = true;
            // 
            // checkBoxAddData_TopFile
            // 
            this.checkBoxAddData_TopFile.AutoSize = true;
            this.checkBoxAddData_TopFile.Location = new System.Drawing.Point(17, 7);
            this.checkBoxAddData_TopFile.Name = "checkBoxAddData_TopFile";
            this.checkBoxAddData_TopFile.Size = new System.Drawing.Size(96, 16);
            this.checkBoxAddData_TopFile.TabIndex = 1;
            this.checkBoxAddData_TopFile.Text = "添加到文件首";
            this.checkBoxAddData_TopFile.UseVisualStyleBackColor = true;
            // 
            // txbAddData_TopEndOfFile
            // 
            this.txbAddData_TopEndOfFile.Location = new System.Drawing.Point(196, 9);
            this.txbAddData_TopEndOfFile.Multiline = true;
            this.txbAddData_TopEndOfFile.Name = "txbAddData_TopEndOfFile";
            this.txbAddData_TopEndOfFile.Size = new System.Drawing.Size(254, 58);
            this.txbAddData_TopEndOfFile.TabIndex = 0;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(637, 17);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(29, 12);
            this.label34.TabIndex = 22;
            this.label34.Text = "模式";
            // 
            // comboBoxAddData
            // 
            this.comboBoxAddData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAddData.Font = new System.Drawing.Font("宋体", 10.5F);
            this.comboBoxAddData.FormattingEnabled = true;
            this.comboBoxAddData.Items.AddRange(new object[] {
            "添加到文件的首尾",
            "添加到行的首尾",
            "添加文件名到文件"});
            this.comboBoxAddData.Location = new System.Drawing.Point(493, 12);
            this.comboBoxAddData.Name = "comboBoxAddData";
            this.comboBoxAddData.Size = new System.Drawing.Size(138, 22);
            this.comboBoxAddData.TabIndex = 21;
            this.comboBoxAddData.SelectionChangeCommitted += new System.EventHandler(this.comboBoxAddData_SelectionChangeCommitted);
            // 
            // tpDeleteLineFromFile
            // 
            this.tpDeleteLineFromFile.Controls.Add(this.btnFile2DeleteBrower);
            this.tpDeleteLineFromFile.Controls.Add(this.btnFile1DeleteBrowser);
            this.tpDeleteLineFromFile.Controls.Add(this.label19);
            this.tpDeleteLineFromFile.Controls.Add(this.label18);
            this.tpDeleteLineFromFile.Controls.Add(this.txbFileShaiXuan);
            this.tpDeleteLineFromFile.Controls.Add(this.txbFileDelete);
            this.tpDeleteLineFromFile.Location = new System.Drawing.Point(4, 22);
            this.tpDeleteLineFromFile.Name = "tpDeleteLineFromFile";
            this.tpDeleteLineFromFile.Size = new System.Drawing.Size(673, 79);
            this.tpDeleteLineFromFile.TabIndex = 5;
            this.tpDeleteLineFromFile.Text = "删除多行从文件";
            this.tpDeleteLineFromFile.UseVisualStyleBackColor = true;
            // 
            // btnFile2DeleteBrower
            // 
            this.btnFile2DeleteBrower.Location = new System.Drawing.Point(596, 41);
            this.btnFile2DeleteBrower.Name = "btnFile2DeleteBrower";
            this.btnFile2DeleteBrower.Size = new System.Drawing.Size(50, 32);
            this.btnFile2DeleteBrower.TabIndex = 8;
            this.btnFile2DeleteBrower.Text = "浏览";
            this.btnFile2DeleteBrower.UseVisualStyleBackColor = true;
            this.btnFile2DeleteBrower.Click += new System.EventHandler(this.btnFile2DeleteBrower_Click);
            // 
            // btnFile1DeleteBrowser
            // 
            this.btnFile1DeleteBrowser.Location = new System.Drawing.Point(596, 7);
            this.btnFile1DeleteBrowser.Name = "btnFile1DeleteBrowser";
            this.btnFile1DeleteBrowser.Size = new System.Drawing.Size(50, 32);
            this.btnFile1DeleteBrowser.TabIndex = 7;
            this.btnFile1DeleteBrowser.Text = "浏览";
            this.btnFile1DeleteBrowser.UseVisualStyleBackColor = true;
            this.btnFile1DeleteBrowser.Click += new System.EventHandler(this.btnFile1DeleteBrowser_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 44);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 12);
            this.label19.TabIndex = 6;
            this.label19.Text = "要筛选的文件:";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 12);
            this.label18.TabIndex = 5;
            this.label18.Text = "要处理的文件:";
            // 
            // txbFileShaiXuan
            // 
            this.txbFileShaiXuan.Location = new System.Drawing.Point(88, 41);
            this.txbFileShaiXuan.Name = "txbFileShaiXuan";
            this.txbFileShaiXuan.Size = new System.Drawing.Size(502, 21);
            this.txbFileShaiXuan.TabIndex = 4;
            this.txbFileShaiXuan.Click += new System.EventHandler(this.txbFileShaiXuan_Click);
            // 
            // txbFileDelete
            // 
            this.txbFileDelete.Location = new System.Drawing.Point(88, 14);
            this.txbFileDelete.Name = "txbFileDelete";
            this.txbFileDelete.Size = new System.Drawing.Size(502, 21);
            this.txbFileDelete.TabIndex = 3;
            this.txbFileDelete.Click += new System.EventHandler(this.txbFileDelete_Click);
            // 
            // tpOther
            // 
            this.tpOther.Controls.Add(this.panelOtherSort);
            this.tpOther.Controls.Add(this.panelOtherChangeFileType);
            this.tpOther.Controls.Add(this.panelOtherFind);
            this.tpOther.Controls.Add(this.panelOtherRename);
            this.tpOther.Controls.Add(this.panelOtherAddFolder);
            this.tpOther.Controls.Add(this.label38);
            this.tpOther.Controls.Add(this.comboBoxOtherType);
            this.tpOther.Location = new System.Drawing.Point(4, 22);
            this.tpOther.Name = "tpOther";
            this.tpOther.Size = new System.Drawing.Size(673, 79);
            this.tpOther.TabIndex = 2;
            this.tpOther.Text = "其他处理方式";
            this.tpOther.UseVisualStyleBackColor = true;
            // 
            // panelOtherChangeFileType
            // 
            this.panelOtherChangeFileType.Controls.Add(this.label44);
            this.panelOtherChangeFileType.Controls.Add(this.label43);
            this.panelOtherChangeFileType.Controls.Add(this.radioBtnUTF_8);
            this.panelOtherChangeFileType.Controls.Add(this.radioBtnUnicodeBigEndian);
            this.panelOtherChangeFileType.Controls.Add(this.radioBtnUnicode);
            this.panelOtherChangeFileType.Controls.Add(this.radioBtnANSI);
            this.panelOtherChangeFileType.Location = new System.Drawing.Point(0, 0);
            this.panelOtherChangeFileType.Name = "panelOtherChangeFileType";
            this.panelOtherChangeFileType.Size = new System.Drawing.Size(484, 73);
            this.panelOtherChangeFileType.TabIndex = 19;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.ForeColor = System.Drawing.Color.Red;
            this.label44.Location = new System.Drawing.Point(281, 52);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(179, 12);
            this.label44.TabIndex = 5;
            this.label44.Text = "新文件名 = 旧名 + type + 后缀";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(24, 52);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(251, 12);
            this.label43.TabIndex = 4;
            this.label43.Text = "四种编码类型Windows自带记事本都能正常打开";
            // 
            // radioBtnUTF_8
            // 
            this.radioBtnUTF_8.AutoSize = true;
            this.radioBtnUTF_8.Location = new System.Drawing.Point(367, 18);
            this.radioBtnUTF_8.Name = "radioBtnUTF_8";
            this.radioBtnUTF_8.Size = new System.Drawing.Size(53, 16);
            this.radioBtnUTF_8.TabIndex = 3;
            this.radioBtnUTF_8.TabStop = true;
            this.radioBtnUTF_8.Text = "UTF-8";
            this.radioBtnUTF_8.UseVisualStyleBackColor = true;
            // 
            // radioBtnUnicodeBigEndian
            // 
            this.radioBtnUnicodeBigEndian.AutoSize = true;
            this.radioBtnUnicodeBigEndian.Location = new System.Drawing.Point(211, 18);
            this.radioBtnUnicodeBigEndian.Name = "radioBtnUnicodeBigEndian";
            this.radioBtnUnicodeBigEndian.Size = new System.Drawing.Size(131, 16);
            this.radioBtnUnicodeBigEndian.TabIndex = 2;
            this.radioBtnUnicodeBigEndian.TabStop = true;
            this.radioBtnUnicodeBigEndian.Text = "Unicode big endian";
            this.radioBtnUnicodeBigEndian.UseVisualStyleBackColor = true;
            // 
            // radioBtnUnicode
            // 
            this.radioBtnUnicode.AutoSize = true;
            this.radioBtnUnicode.Location = new System.Drawing.Point(122, 18);
            this.radioBtnUnicode.Name = "radioBtnUnicode";
            this.radioBtnUnicode.Size = new System.Drawing.Size(65, 16);
            this.radioBtnUnicode.TabIndex = 1;
            this.radioBtnUnicode.TabStop = true;
            this.radioBtnUnicode.Text = "Unicode";
            this.radioBtnUnicode.UseVisualStyleBackColor = true;
            // 
            // radioBtnANSI
            // 
            this.radioBtnANSI.AutoSize = true;
            this.radioBtnANSI.Location = new System.Drawing.Point(56, 18);
            this.radioBtnANSI.Name = "radioBtnANSI";
            this.radioBtnANSI.Size = new System.Drawing.Size(47, 16);
            this.radioBtnANSI.TabIndex = 0;
            this.radioBtnANSI.TabStop = true;
            this.radioBtnANSI.Text = "ANSI";
            this.radioBtnANSI.UseVisualStyleBackColor = true;
            // 
            // panelOtherFind
            // 
            this.panelOtherFind.Controls.Add(this.label42);
            this.panelOtherFind.Controls.Add(this.txbOtherFind);
            this.panelOtherFind.Location = new System.Drawing.Point(0, 0);
            this.panelOtherFind.Name = "panelOtherFind";
            this.panelOtherFind.Size = new System.Drawing.Size(456, 73);
            this.panelOtherFind.TabIndex = 19;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(15, 22);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(41, 12);
            this.label42.TabIndex = 2;
            this.label42.Text = "查找：";
            // 
            // txbOtherFind
            // 
            this.txbOtherFind.Location = new System.Drawing.Point(62, 19);
            this.txbOtherFind.Name = "txbOtherFind";
            this.txbOtherFind.Size = new System.Drawing.Size(213, 21);
            this.txbOtherFind.TabIndex = 0;
            // 
            // panelOtherRename
            // 
            this.panelOtherRename.Controls.Add(this.label41);
            this.panelOtherRename.Controls.Add(this.checkBoxOtherOldName);
            this.panelOtherRename.Controls.Add(this.label40);
            this.panelOtherRename.Controls.Add(this.label39);
            this.panelOtherRename.Location = new System.Drawing.Point(6, 1);
            this.panelOtherRename.Name = "panelOtherRename";
            this.panelOtherRename.Size = new System.Drawing.Size(484, 73);
            this.panelOtherRename.TabIndex = 18;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(174, 40);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(47, 12);
            this.label41.TabIndex = 3;
            this.label41.Text = "+新名称";
            // 
            // checkBoxOtherOldName
            // 
            this.checkBoxOtherOldName.AutoSize = true;
            this.checkBoxOtherOldName.Location = new System.Drawing.Point(96, 39);
            this.checkBoxOtherOldName.Name = "checkBoxOtherOldName";
            this.checkBoxOtherOldName.Size = new System.Drawing.Size(72, 16);
            this.checkBoxOtherOldName.TabIndex = 2;
            this.checkBoxOtherOldName.Text = "旧文件名";
            this.checkBoxOtherOldName.UseVisualStyleBackColor = true;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(24, 39);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(65, 12);
            this.label40.TabIndex = 1;
            this.label40.Text = "新文件名：";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(6, 10);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(401, 12);
            this.label39.TabIndex = 0;
            this.label39.Text = "重命名：将文本文件的第一行作为新文件名. 如果第一行是空的读取第二行";
            // 
            // panelOtherAddFolder
            // 
            this.panelOtherAddFolder.Controls.Add(this.txbOtherFilePath);
            this.panelOtherAddFolder.Controls.Add(this.label6);
            this.panelOtherAddFolder.Controls.Add(this.btnOtherAddDGV);
            this.panelOtherAddFolder.Location = new System.Drawing.Point(3, 3);
            this.panelOtherAddFolder.Name = "panelOtherAddFolder";
            this.panelOtherAddFolder.Size = new System.Drawing.Size(484, 73);
            this.panelOtherAddFolder.TabIndex = 17;
            // 
            // txbOtherFilePath
            // 
            this.txbOtherFilePath.Location = new System.Drawing.Point(62, 12);
            this.txbOtherFilePath.Name = "txbOtherFilePath";
            this.txbOtherFilePath.Size = new System.Drawing.Size(393, 21);
            this.txbOtherFilePath.TabIndex = 2;
            this.txbOtherFilePath.Click += new System.EventHandler(this.txbFilePath_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "文件夹:";
            // 
            // btnOtherAddDGV
            // 
            this.btnOtherAddDGV.Location = new System.Drawing.Point(370, 39);
            this.btnOtherAddDGV.Name = "btnOtherAddDGV";
            this.btnOtherAddDGV.Size = new System.Drawing.Size(73, 32);
            this.btnOtherAddDGV.TabIndex = 4;
            this.btnOtherAddDGV.Text = "加入列表";
            this.btnOtherAddDGV.UseVisualStyleBackColor = true;
            this.btnOtherAddDGV.Click += new System.EventHandler(this.btnBrowerAdd_Click);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(637, 13);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(29, 12);
            this.label38.TabIndex = 23;
            this.label38.Text = "模式";
            // 
            // comboBoxOtherType
            // 
            this.comboBoxOtherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOtherType.Font = new System.Drawing.Font("宋体", 10.5F);
            this.comboBoxOtherType.FormattingEnabled = true;
            this.comboBoxOtherType.Items.AddRange(new object[] {
            "添加文件夹",
            "重命名",
            "恢复备份文件",
            "查找个数",
            "转换编码",
            "重新排序"});
            this.comboBoxOtherType.Location = new System.Drawing.Point(510, 8);
            this.comboBoxOtherType.Name = "comboBoxOtherType";
            this.comboBoxOtherType.Size = new System.Drawing.Size(121, 22);
            this.comboBoxOtherType.TabIndex = 22;
            this.comboBoxOtherType.SelectionChangeCommitted += new System.EventHandler(this.comboBoxOtherType_SelectionChangeCommitted);
            // 
            // panelStart
            // 
            this.panelStart.Controls.Add(this.btnStart);
            this.panelStart.Controls.Add(this.checkBoxBak);
            this.panelStart.Location = new System.Drawing.Point(6, 379);
            this.panelStart.Name = "panelStart";
            this.panelStart.Size = new System.Drawing.Size(682, 41);
            this.panelStart.TabIndex = 10;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(436, 6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(134, 32);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "开始删除";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // checkBoxBak
            // 
            this.checkBoxBak.AutoSize = true;
            this.checkBoxBak.Location = new System.Drawing.Point(4, 13);
            this.checkBoxBak.Name = "checkBoxBak";
            this.checkBoxBak.Size = new System.Drawing.Size(96, 16);
            this.checkBoxBak.TabIndex = 4;
            this.checkBoxBak.Text = "生成备份文件";
            this.checkBoxBak.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panelOtherSort
            // 
            this.panelOtherSort.Controls.Add(this.radioBtnSortDown);
            this.panelOtherSort.Controls.Add(this.radioBtnSortUp);
            this.panelOtherSort.Location = new System.Drawing.Point(0, 0);
            this.panelOtherSort.Name = "panelOtherSort";
            this.panelOtherSort.Size = new System.Drawing.Size(484, 73);
            this.panelOtherSort.TabIndex = 24;
            // 
            // radioBtnSortDown
            // 
            this.radioBtnSortDown.AutoSize = true;
            this.radioBtnSortDown.Location = new System.Drawing.Point(142, 18);
            this.radioBtnSortDown.Name = "radioBtnSortDown";
            this.radioBtnSortDown.Size = new System.Drawing.Size(71, 16);
            this.radioBtnSortDown.TabIndex = 2;
            this.radioBtnSortDown.TabStop = true;
            this.radioBtnSortDown.Text = "字母降序";
            this.radioBtnSortDown.UseVisualStyleBackColor = true;
            // 
            // radioBtnSortUp
            // 
            this.radioBtnSortUp.AutoSize = true;
            this.radioBtnSortUp.Location = new System.Drawing.Point(39, 18);
            this.radioBtnSortUp.Name = "radioBtnSortUp";
            this.radioBtnSortUp.Size = new System.Drawing.Size(71, 16);
            this.radioBtnSortUp.TabIndex = 1;
            this.radioBtnSortUp.TabStop = true;
            this.radioBtnSortUp.Text = "字母升序";
            this.radioBtnSortUp.UseVisualStyleBackColor = true;
            // 
            // 关于我们ToolStripMenuItem
            // 
            this.关于我们ToolStripMenuItem.Name = "关于我们ToolStripMenuItem";
            this.关于我们ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.关于我们ToolStripMenuItem.Text = "关于我们";
            this.关于我们ToolStripMenuItem.Click += new System.EventHandler(this.关于我们ToolStripMenuItem_Click);
            // 
            // 捐赠ToolStripMenuItem
            // 
            this.捐赠ToolStripMenuItem.Name = "捐赠ToolStripMenuItem";
            this.捐赠ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.捐赠ToolStripMenuItem.Text = "捐赠";
            this.捐赠ToolStripMenuItem.Click += new System.EventHandler(this.捐赠ToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 452);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menu1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menu1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "删除多行";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.menu1.ResumeLayout(false);
            this.menu1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.contextMenu_DGV.ResumeLayout(false);
            this.panelDGV_Deal.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpDeleteLine.ResumeLayout(false);
            this.tpDeleteLine.PerformLayout();
            this.panelDelLine_KeyWords.ResumeLayout(false);
            this.panelDelLine_KeyWords.PerformLayout();
            this.panelDelLine_TeDing.ResumeLayout(false);
            this.panelDelLine_TeDing.PerformLayout();
            this.panelDelLine1.ResumeLayout(false);
            this.panelDelLine1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelLine_TopLineFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelLine_ContinueLast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelLine_ContinueFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelLine_LastLineFile)).EndInit();
            this.tpDeleteData.ResumeLayout(false);
            this.tpDeleteData.PerformLayout();
            this.panelDelData_FirstLastOfLine.ResumeLayout(false);
            this.panelDelData_FirstLastOfLine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelData_CountZiFu)).EndInit();
            this.panelDeleteReplaceData.ResumeLayout(false);
            this.panelDeleteReplaceData.PerformLayout();
            this.tpMerge.ResumeLayout(false);
            this.tpMerge.PerformLayout();
            this.panelMerge_LeftRight.ResumeLayout(false);
            this.panelMerge_LeftRight.PerformLayout();
            this.panelMerge_AddDataAmongFile.ResumeLayout(false);
            this.panelMerge_AddDataAmongFile.PerformLayout();
            this.tpSplit.ResumeLayout(false);
            this.tpSplit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSplit_Line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSplit_Count)).EndInit();
            this.tpAddData.ResumeLayout(false);
            this.tpAddData.PerformLayout();
            this.panelAddData_FileName.ResumeLayout(false);
            this.panelAddData_FileName.PerformLayout();
            this.panelAddData_TopEndOfLine.ResumeLayout(false);
            this.panelAddData_TopEndOfLine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddData_TopLine)).EndInit();
            this.panelAddData_TopEndOfFile.ResumeLayout(false);
            this.panelAddData_TopEndOfFile.PerformLayout();
            this.tpDeleteLineFromFile.ResumeLayout(false);
            this.tpDeleteLineFromFile.PerformLayout();
            this.tpOther.ResumeLayout(false);
            this.tpOther.PerformLayout();
            this.panelOtherChangeFileType.ResumeLayout(false);
            this.panelOtherChangeFileType.PerformLayout();
            this.panelOtherFind.ResumeLayout(false);
            this.panelOtherFind.PerformLayout();
            this.panelOtherRename.ResumeLayout(false);
            this.panelOtherRename.PerformLayout();
            this.panelOtherAddFolder.ResumeLayout(false);
            this.panelOtherAddFolder.PerformLayout();
            this.panelStart.ResumeLayout(false);
            this.panelStart.PerformLayout();
            this.panelOtherSort.ResumeLayout(false);
            this.panelOtherSort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpDeleteLine;
        private System.Windows.Forms.TabPage tpDeleteData;
        private System.Windows.Forms.Button btnDGV_ClearAll;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnDGV_Delete;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudDelLine_TopLineFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxBak;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudDelLine_LastLineFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem 默认设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Button btnDGV_DeleteSuccess;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件夹ToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txbDelOldData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelStart;
        private System.Windows.Forms.TabPage tpOther;
        private System.Windows.Forms.Button btnOtherAddDGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbOtherFilePath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudDelLine_ContinueLast;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudDelLine_ContinueFirst;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbDelNewData;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxDeleteLine;
        private System.Windows.Forms.TabPage tpMerge;
        private System.Windows.Forms.Button btnDownMove;
        private System.Windows.Forms.Button btnUpMove;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbMerge_AddDataAmongFiles;
        private System.Windows.Forms.CheckBox checkBoxMerge_AddDataAmongFiles;
        private System.Windows.Forms.TabPage tpSplit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudSplit_Count;
        private System.Windows.Forms.ComboBox comboBoxSplit;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tpDeleteLineFromFile;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txbFileShaiXuan;
        private System.Windows.Forms.TextBox txbFileDelete;
        private System.Windows.Forms.Button btnFile2DeleteBrower;
        private System.Windows.Forms.Button btnFile1DeleteBrowser;
        private System.Windows.Forms.NumericUpDown nudSplit_Line;
        private System.Windows.Forms.CheckBox checkBoxMerge_AddFileName;
        private System.Windows.Forms.Panel panelMerge_AddDataAmongFile;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboBoxMerge;
        private System.Windows.Forms.Panel panelMerge_GeHang;
        private System.Windows.Forms.Panel panelMerge_LeftRight;
        private System.Windows.Forms.CheckBox checkBoxMerge_LeftRightAddData;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txbMerge_LeftRightData;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboBoxDeleteData;
        private System.Windows.Forms.Panel panelDeleteReplaceData;
        private System.Windows.Forms.Panel panelDelData_FirstLastOfLine;
        private System.Windows.Forms.TextBox txbCountZiFu;
        private System.Windows.Forms.CheckBox checkBoxDel_DataTopOfLine;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown nudDelData_CountZiFu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelDGV_Deal;
        private System.Windows.Forms.Button btnDGV_ClearState;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.Panel panelDelLine1;
        private System.Windows.Forms.Panel panelDelLine_TeDing;
        private System.Windows.Forms.TextBox txbDelLine_TeDing;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Panel panelDelLine_KeyWords;
        private System.Windows.Forms.CheckBox checkBoxDelLine_KeyWord;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txbDelLine_TeDingData;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ContextMenuStrip contextMenu_DGV;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件夹ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 清空状态ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除成功行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 统计行数ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 统计字数ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文件信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制文件路径ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制文件名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 清除选中状态ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 整理列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文件详细信息ToolStripMenuItem;
        private System.Windows.Forms.TabPage tpAddData;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ComboBox comboBoxAddData;
        private System.Windows.Forms.Panel panelAddData_TopEndOfFile;
        private System.Windows.Forms.CheckBox checkBoxAddData_EndFile;
        private System.Windows.Forms.CheckBox checkBoxAddData_TopFile;
        private System.Windows.Forms.TextBox txbAddData_TopEndOfFile;
        private System.Windows.Forms.CheckBox checkBoxAddData_OverWrite;
        private System.Windows.Forms.Panel panelAddData_TopEndOfLine;
        private System.Windows.Forms.TextBox txbAddData_EndLine;
        private System.Windows.Forms.CheckBox checkBoxAddData_EndLine;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.NumericUpDown nudAddData_TopLine;
        private System.Windows.Forms.CheckBox checkBoxAddData_ContainNumber;
        private System.Windows.Forms.TextBox txbAddData_TopLine;
        private System.Windows.Forms.CheckBox checkBoxAddData_TopLine;
        private System.Windows.Forms.Panel panelAddData_FileName;
        private System.Windows.Forms.CheckBox checkBoxAddData_ContainExtension;
        private System.Windows.Forms.CheckBox checkBoxAddData_ContainDir;
        private System.Windows.Forms.TextBox txbAddData_FileName2;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txbAddData_FileName1;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.Panel panelOtherAddFolder;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.ComboBox comboBoxOtherType;
        private System.Windows.Forms.Panel panelOtherRename;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.CheckBox checkBoxOtherOldName;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Panel panelOtherFind;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txbOtherFind;
        private System.Windows.Forms.Panel panelOtherChangeFileType;
        private System.Windows.Forms.RadioButton radioBtnANSI;
        private System.Windows.Forms.RadioButton radioBtnUnicode;
        private System.Windows.Forms.RadioButton radioBtnUTF_8;
        private System.Windows.Forms.RadioButton radioBtnUnicodeBigEndian;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Panel panelOtherSort;
        private System.Windows.Forms.RadioButton radioBtnSortDown;
        private System.Windows.Forms.RadioButton radioBtnSortUp;
        private System.Windows.Forms.ToolStripMenuItem 关于我们ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 捐赠ToolStripMenuItem;

    }
}

