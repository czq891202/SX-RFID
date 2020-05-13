namespace SX_RFID
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tab_information = new System.Windows.Forms.TabControl();
            this.tab_import = new System.Windows.Forms.TabPage();
            this.gb_inport = new System.Windows.Forms.GroupBox();
            this.btn_import = new System.Windows.Forms.Button();
            this.chb_printall = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_searchwhere = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.txt_fileurl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_inportdata = new System.Windows.Forms.GroupBox();
            this.inport_data = new System.Windows.Forms.DataGridView();
            this.bd_inport = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.btn_selectAll = new System.Windows.Forms.ToolStripButton();
            this.btn_clear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.txtRecordNumOfPage = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.txtCurrentPage = new System.Windows.Forms.ToolStripTextBox();
            this.btnPage = new System.Windows.Forms.ToolStripButton();
            this.tab_input = new System.Windows.Forms.TabPage();
            this.tab_settings = new System.Windows.Forms.TabPage();
            this.btn_savesettings = new System.Windows.Forms.Button();
            this.cbx_PrintName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_packingperson = new System.Windows.Forms.TextBox();
            this.lbl_packingperson1 = new System.Windows.Forms.Label();
            this.bdSource = new System.Windows.Forms.BindingSource(this.components);
            this.tab_information.SuspendLayout();
            this.tab_import.SuspendLayout();
            this.gb_inport.SuspendLayout();
            this.gb_inportdata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inport_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_inport)).BeginInit();
            this.bd_inport.SuspendLayout();
            this.tab_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_information
            // 
            this.tab_information.Controls.Add(this.tab_import);
            this.tab_information.Controls.Add(this.tab_input);
            this.tab_information.Controls.Add(this.tab_settings);
            this.tab_information.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_information.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tab_information.Location = new System.Drawing.Point(0, 0);
            this.tab_information.Name = "tab_information";
            this.tab_information.SelectedIndex = 0;
            this.tab_information.Size = new System.Drawing.Size(850, 511);
            this.tab_information.TabIndex = 0;
            // 
            // tab_import
            // 
            this.tab_import.Controls.Add(this.gb_inport);
            this.tab_import.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tab_import.Location = new System.Drawing.Point(4, 29);
            this.tab_import.Name = "tab_import";
            this.tab_import.Padding = new System.Windows.Forms.Padding(3);
            this.tab_import.Size = new System.Drawing.Size(842, 478);
            this.tab_import.TabIndex = 0;
            this.tab_import.Text = "批量导入";
            this.tab_import.UseVisualStyleBackColor = true;
            // 
            // gb_inport
            // 
            this.gb_inport.Controls.Add(this.btn_import);
            this.gb_inport.Controls.Add(this.chb_printall);
            this.gb_inport.Controls.Add(this.label3);
            this.gb_inport.Controls.Add(this.txt_searchwhere);
            this.gb_inport.Controls.Add(this.label2);
            this.gb_inport.Controls.Add(this.btn_select);
            this.gb_inport.Controls.Add(this.btn_save);
            this.gb_inport.Controls.Add(this.btn_print);
            this.gb_inport.Controls.Add(this.txt_fileurl);
            this.gb_inport.Controls.Add(this.label1);
            this.gb_inport.Controls.Add(this.gb_inportdata);
            this.gb_inport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_inport.Location = new System.Drawing.Point(3, 3);
            this.gb_inport.Name = "gb_inport";
            this.gb_inport.Size = new System.Drawing.Size(836, 472);
            this.gb_inport.TabIndex = 0;
            this.gb_inport.TabStop = false;
            // 
            // btn_import
            // 
            this.btn_import.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_import.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_import.Location = new System.Drawing.Point(543, 13);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(75, 26);
            this.btn_import.TabIndex = 24;
            this.btn_import.Text = "导入数据";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // chb_printall
            // 
            this.chb_printall.AutoSize = true;
            this.chb_printall.Checked = true;
            this.chb_printall.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_printall.Location = new System.Drawing.Point(718, 50);
            this.chb_printall.Name = "chb_printall";
            this.chb_printall.Size = new System.Drawing.Size(15, 14);
            this.chb_printall.TabIndex = 23;
            this.chb_printall.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(639, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "全部打印:";
            // 
            // txt_searchwhere
            // 
            this.txt_searchwhere.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_searchwhere.Location = new System.Drawing.Point(107, 45);
            this.txt_searchwhere.Name = "txt_searchwhere";
            this.txt_searchwhere.Size = new System.Drawing.Size(511, 24);
            this.txt_searchwhere.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "箱号搜索:";
            // 
            // btn_select
            // 
            this.btn_select.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_select.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_select.Location = new System.Drawing.Point(477, 13);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(50, 26);
            this.btn_select.TabIndex = 19;
            this.btn_select.Text = "浏览";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_save.Location = new System.Drawing.Point(738, 13);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 26);
            this.btn_save.TabIndex = 18;
            this.btn_save.Text = "存储数据";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_print
            // 
            this.btn_print.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_print.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_print.Location = new System.Drawing.Point(641, 13);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(91, 26);
            this.btn_print.TabIndex = 17;
            this.btn_print.Text = "打印/补打";
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // txt_fileurl
            // 
            this.txt_fileurl.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_fileurl.Location = new System.Drawing.Point(107, 15);
            this.txt_fileurl.Name = "txt_fileurl";
            this.txt_fileurl.Size = new System.Drawing.Size(371, 24);
            this.txt_fileurl.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "选择文件:";
            // 
            // gb_inportdata
            // 
            this.gb_inportdata.Controls.Add(this.inport_data);
            this.gb_inportdata.Controls.Add(this.bd_inport);
            this.gb_inportdata.Location = new System.Drawing.Point(0, 96);
            this.gb_inportdata.Name = "gb_inportdata";
            this.gb_inportdata.Size = new System.Drawing.Size(839, 355);
            this.gb_inportdata.TabIndex = 0;
            this.gb_inportdata.TabStop = false;
            this.gb_inportdata.Text = "数据集";
            // 
            // inport_data
            // 
            this.inport_data.AllowUserToAddRows = false;
            this.inport_data.AllowUserToDeleteRows = false;
            this.inport_data.BackgroundColor = System.Drawing.Color.White;
            this.inport_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inport_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inport_data.Location = new System.Drawing.Point(3, 22);
            this.inport_data.Name = "inport_data";
            this.inport_data.RowTemplate.Height = 23;
            this.inport_data.Size = new System.Drawing.Size(833, 305);
            this.inport_data.TabIndex = 4;
            // 
            // bd_inport
            // 
            this.bd_inport.AddNewItem = null;
            this.bd_inport.CountItem = this.bindingNavigatorCountItem;
            this.bd_inport.DeleteItem = null;
            this.bd_inport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bd_inport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_selectAll,
            this.btn_clear,
            this.toolStripSeparator2,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripLabel3,
            this.toolStripLabel4,
            this.txtRecordNumOfPage,
            this.toolStripLabel5,
            this.toolStripSeparator1,
            this.toolStripLabel6,
            this.txtCurrentPage,
            this.btnPage});
            this.bd_inport.Location = new System.Drawing.Point(3, 327);
            this.bd_inport.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bd_inport.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bd_inport.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bd_inport.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bd_inport.Name = "bd_inport";
            this.bd_inport.PositionItem = this.bindingNavigatorPositionItem;
            this.bd_inport.Size = new System.Drawing.Size(833, 25);
            this.bd_inport.TabIndex = 3;
            this.bd_inport.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // btn_selectAll
            // 
            this.btn_selectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_selectAll.Image = ((System.Drawing.Image)(resources.GetObject("btn_selectAll.Image")));
            this.btn_selectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_selectAll.Name = "btn_selectAll";
            this.btn_selectAll.Size = new System.Drawing.Size(36, 22);
            this.btn_selectAll.Text = "全选";
            // 
            // btn_clear
            // 
            this.btn_clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.Image")));
            this.btn_clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(36, 22);
            this.btn_clear.Text = "取消";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "首页";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "上一页";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "下一页";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "尾页";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel1.Text = "共";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(15, 22);
            this.toolStripLabel2.Text = "0";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(52, 22);
            this.toolStripLabel3.Text = "条记录  ";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel4.Text = "/每页";
            // 
            // txtRecordNumOfPage
            // 
            this.txtRecordNumOfPage.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.txtRecordNumOfPage.Name = "txtRecordNumOfPage";
            this.txtRecordNumOfPage.Size = new System.Drawing.Size(30, 25);
            this.txtRecordNumOfPage.Text = "20";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel5.Text = "条记录";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel6.Text = "跳转到：";
            // 
            // txtCurrentPage
            // 
            this.txtCurrentPage.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.txtCurrentPage.Name = "txtCurrentPage";
            this.txtCurrentPage.Size = new System.Drawing.Size(30, 25);
            // 
            // btnPage
            // 
            this.btnPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPage.Image = ((System.Drawing.Image)(resources.GetObject("btnPage.Image")));
            this.btnPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPage.Name = "btnPage";
            this.btnPage.Size = new System.Drawing.Size(36, 22);
            this.btnPage.Text = "跳转";
            // 
            // tab_input
            // 
            this.tab_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tab_input.Location = new System.Drawing.Point(4, 29);
            this.tab_input.Name = "tab_input";
            this.tab_input.Padding = new System.Windows.Forms.Padding(3);
            this.tab_input.Size = new System.Drawing.Size(842, 478);
            this.tab_input.TabIndex = 1;
            this.tab_input.Text = "手动输入";
            this.tab_input.UseVisualStyleBackColor = true;
            // 
            // tab_settings
            // 
            this.tab_settings.Controls.Add(this.btn_savesettings);
            this.tab_settings.Controls.Add(this.cbx_PrintName);
            this.tab_settings.Controls.Add(this.label4);
            this.tab_settings.Controls.Add(this.txt_packingperson);
            this.tab_settings.Controls.Add(this.lbl_packingperson1);
            this.tab_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tab_settings.Location = new System.Drawing.Point(4, 29);
            this.tab_settings.Name = "tab_settings";
            this.tab_settings.Size = new System.Drawing.Size(842, 478);
            this.tab_settings.TabIndex = 2;
            this.tab_settings.Text = "配置";
            this.tab_settings.UseVisualStyleBackColor = true;
            // 
            // btn_savesettings
            // 
            this.btn_savesettings.Location = new System.Drawing.Point(735, 18);
            this.btn_savesettings.Name = "btn_savesettings";
            this.btn_savesettings.Size = new System.Drawing.Size(85, 28);
            this.btn_savesettings.TabIndex = 12;
            this.btn_savesettings.Text = "保存";
            this.btn_savesettings.UseVisualStyleBackColor = true;
            this.btn_savesettings.Click += new System.EventHandler(this.btn_savesettings_Click);
            // 
            // cbx_PrintName
            // 
            this.cbx_PrintName.FormattingEnabled = true;
            this.cbx_PrintName.Location = new System.Drawing.Point(100, 72);
            this.cbx_PrintName.Name = "cbx_PrintName";
            this.cbx_PrintName.Size = new System.Drawing.Size(237, 28);
            this.cbx_PrintName.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "打印机";
            // 
            // txt_packingperson
            // 
            this.txt_packingperson.Location = new System.Drawing.Point(100, 17);
            this.txt_packingperson.Name = "txt_packingperson";
            this.txt_packingperson.Size = new System.Drawing.Size(237, 26);
            this.txt_packingperson.TabIndex = 9;
            // 
            // lbl_packingperson1
            // 
            this.lbl_packingperson1.AutoSize = true;
            this.lbl_packingperson1.Location = new System.Drawing.Point(15, 18);
            this.lbl_packingperson1.Name = "lbl_packingperson1";
            this.lbl_packingperson1.Size = new System.Drawing.Size(73, 20);
            this.lbl_packingperson1.TabIndex = 8;
            this.lbl_packingperson1.Text = "装箱人员";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 511);
            this.Controls.Add(this.tab_information);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "打印盘点";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tab_information.ResumeLayout(false);
            this.tab_import.ResumeLayout(false);
            this.gb_inport.ResumeLayout(false);
            this.gb_inport.PerformLayout();
            this.gb_inportdata.ResumeLayout(false);
            this.gb_inportdata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inport_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_inport)).EndInit();
            this.bd_inport.ResumeLayout(false);
            this.bd_inport.PerformLayout();
            this.tab_settings.ResumeLayout(false);
            this.tab_settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_information;
        private System.Windows.Forms.TabPage tab_import;
        private System.Windows.Forms.TabPage tab_input;
        private System.Windows.Forms.TabPage tab_settings;
        private System.Windows.Forms.GroupBox gb_inport;
        private System.Windows.Forms.GroupBox gb_inportdata;
        private System.Windows.Forms.BindingNavigator bd_inport;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton btn_selectAll;
        private System.Windows.Forms.ToolStripButton btn_clear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox txtRecordNumOfPage;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripTextBox txtCurrentPage;
        private System.Windows.Forms.ToolStripButton btnPage;
        private System.Windows.Forms.DataGridView inport_data;
        private System.Windows.Forms.CheckBox chb_printall;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_searchwhere;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.TextBox txt_fileurl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.BindingSource bdSource;
        private System.Windows.Forms.Button btn_savesettings;
        private System.Windows.Forms.ComboBox cbx_PrintName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_packingperson;
        private System.Windows.Forms.Label lbl_packingperson1;
    }
}