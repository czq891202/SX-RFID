namespace SX_RFID
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_print = new System.Windows.Forms.ComboBox();
            this.txt_packingperson = new System.Windows.Forms.TextBox();
            this.lbl_packingperson = new System.Windows.Forms.Label();
            this.lbl_Print = new System.Windows.Forms.Label();
            this.btn_select = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.bdNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.Source_Data = new System.Windows.Forms.DataGridView();
            this.btn_exportdata = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_fileimport = new System.Windows.Forms.Button();
            this.txt_fileurl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bdSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txt_searchwhere = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chb_printall = new System.Windows.Forms.CheckBox();
            this.GroupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdNavigator)).BeginInit();
            this.bdNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Source_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.chb_printall);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.txt_searchwhere);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.cbx_print);
            this.GroupBox1.Controls.Add(this.txt_packingperson);
            this.GroupBox1.Controls.Add(this.lbl_packingperson);
            this.GroupBox1.Controls.Add(this.lbl_Print);
            this.GroupBox1.Controls.Add(this.btn_select);
            this.GroupBox1.Controls.Add(this.tabControl1);
            this.GroupBox1.Controls.Add(this.btn_exportdata);
            this.GroupBox1.Controls.Add(this.btn_print);
            this.GroupBox1.Controls.Add(this.btn_fileimport);
            this.GroupBox1.Controls.Add(this.txt_fileurl);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox1.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(850, 511);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            // 
            // cbx_print
            // 
            this.cbx_print.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbx_print.FormattingEnabled = true;
            this.cbx_print.Location = new System.Drawing.Point(97, 42);
            this.cbx_print.Name = "cbx_print";
            this.cbx_print.Size = new System.Drawing.Size(182, 28);
            this.cbx_print.TabIndex = 7;
            // 
            // txt_packingperson
            // 
            this.txt_packingperson.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_packingperson.Location = new System.Drawing.Point(364, 46);
            this.txt_packingperson.Name = "txt_packingperson";
            this.txt_packingperson.Size = new System.Drawing.Size(245, 26);
            this.txt_packingperson.TabIndex = 10;
            // 
            // lbl_packingperson
            // 
            this.lbl_packingperson.AutoSize = true;
            this.lbl_packingperson.Location = new System.Drawing.Point(285, 46);
            this.lbl_packingperson.Name = "lbl_packingperson";
            this.lbl_packingperson.Size = new System.Drawing.Size(73, 20);
            this.lbl_packingperson.TabIndex = 9;
            this.lbl_packingperson.Text = "装箱人员:";
            // 
            // lbl_Print
            // 
            this.lbl_Print.AutoSize = true;
            this.lbl_Print.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Print.Location = new System.Drawing.Point(7, 50);
            this.lbl_Print.Name = "lbl_Print";
            this.lbl_Print.Size = new System.Drawing.Size(96, 16);
            this.lbl_Print.TabIndex = 8;
            this.lbl_Print.Text = "选择打印机:";
            // 
            // btn_select
            // 
            this.btn_select.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_select.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_select.Location = new System.Drawing.Point(429, 14);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(50, 26);
            this.btn_select.TabIndex = 6;
            this.btn_select.Text = "浏览";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 97);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(847, 394);
            this.tabControl1.TabIndex = 5;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.bdNavigator);
            this.TabPage1.Controls.Add(this.Source_Data);
            this.TabPage1.Location = new System.Drawing.Point(4, 29);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(839, 361);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "数据集";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // bdNavigator
            // 
            this.bdNavigator.AddNewItem = null;
            this.bdNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bdNavigator.DeleteItem = null;
            this.bdNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bdNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bdNavigator.Location = new System.Drawing.Point(3, 333);
            this.bdNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdNavigator.Name = "bdNavigator";
            this.bdNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bdNavigator.Size = new System.Drawing.Size(833, 25);
            this.bdNavigator.TabIndex = 1;
            this.bdNavigator.Text = "bindingNavigator1";
            this.bdNavigator.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.bdNavigator_ItemClicked);
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
            this.btn_selectAll.Click += new System.EventHandler(this.btn_selectAll_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.Image")));
            this.btn_clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(36, 22);
            this.btn_clear.Text = "取消";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
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
            this.txtRecordNumOfPage.Name = "txtRecordNumOfPage";
            this.txtRecordNumOfPage.Size = new System.Drawing.Size(30, 25);
            this.txtRecordNumOfPage.Text = "20";
            this.txtRecordNumOfPage.TextChanged += new System.EventHandler(this.txtRecordNumOfPage_TextChanged);
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
            this.txtCurrentPage.Name = "txtCurrentPage";
            this.txtCurrentPage.Size = new System.Drawing.Size(30, 25);
            this.txtCurrentPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurrentPage_KeyPress);
            this.txtCurrentPage.TextChanged += new System.EventHandler(this.txtCurrentPage_TextChanged);
            // 
            // btnPage
            // 
            this.btnPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPage.Image = ((System.Drawing.Image)(resources.GetObject("btnPage.Image")));
            this.btnPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPage.Name = "btnPage";
            this.btnPage.Size = new System.Drawing.Size(36, 22);
            this.btnPage.Text = "跳转";
            this.btnPage.Click += new System.EventHandler(this.btnPage_Click);
            // 
            // Source_Data
            // 
            this.Source_Data.AllowUserToAddRows = false;
            this.Source_Data.AllowUserToDeleteRows = false;
            this.Source_Data.BackgroundColor = System.Drawing.Color.White;
            this.Source_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Source_Data.Location = new System.Drawing.Point(3, 3);
            this.Source_Data.Name = "Source_Data";
            this.Source_Data.RowTemplate.Height = 23;
            this.Source_Data.Size = new System.Drawing.Size(834, 329);
            this.Source_Data.TabIndex = 0;
            this.Source_Data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Source_Data_CellContentClick);
            // 
            // btn_exportdata
            // 
            this.btn_exportdata.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_exportdata.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_exportdata.Location = new System.Drawing.Point(772, 15);
            this.btn_exportdata.Name = "btn_exportdata";
            this.btn_exportdata.Size = new System.Drawing.Size(75, 26);
            this.btn_exportdata.TabIndex = 4;
            this.btn_exportdata.Text = "导出任务";
            this.btn_exportdata.UseVisualStyleBackColor = true;
            this.btn_exportdata.Click += new System.EventHandler(this.btn_exportdata_Click);
            // 
            // btn_print
            // 
            this.btn_print.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_print.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_print.Location = new System.Drawing.Point(691, 15);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 26);
            this.btn_print.TabIndex = 3;
            this.btn_print.Text = "打印标签";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_fileimport
            // 
            this.btn_fileimport.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_fileimport.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_fileimport.Location = new System.Drawing.Point(610, 15);
            this.btn_fileimport.Name = "btn_fileimport";
            this.btn_fileimport.Size = new System.Drawing.Size(75, 26);
            this.btn_fileimport.TabIndex = 2;
            this.btn_fileimport.Text = "导入数据";
            this.btn_fileimport.UseVisualStyleBackColor = true;
            this.btn_fileimport.Click += new System.EventHandler(this.btn_fileimport_Click);
            // 
            // txt_fileurl
            // 
            this.txt_fileurl.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_fileurl.Location = new System.Drawing.Point(97, 15);
            this.txt_fileurl.Name = "txt_fileurl";
            this.txt_fileurl.Size = new System.Drawing.Size(333, 24);
            this.txt_fileurl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择文件:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "箱号搜索:";
            // 
            // txt_searchwhere
            // 
            this.txt_searchwhere.Location = new System.Drawing.Point(98, 74);
            this.txt_searchwhere.Name = "txt_searchwhere";
            this.txt_searchwhere.Size = new System.Drawing.Size(511, 27);
            this.txt_searchwhere.TabIndex = 12;
            this.txt_searchwhere.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_searchwhere_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(629, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "全部打印:";
            // 
            // chb_printall
            // 
            this.chb_printall.AutoSize = true;
            this.chb_printall.Checked = true;
            this.chb_printall.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_printall.Location = new System.Drawing.Point(708, 56);
            this.chb_printall.Name = "chb_printall";
            this.chb_printall.Size = new System.Drawing.Size(15, 14);
            this.chb_printall.TabIndex = 14;
            this.chb_printall.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 511);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "打印盘点";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdNavigator)).EndInit();
            this.bdNavigator.ResumeLayout(false);
            this.bdNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Source_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPage1;
        private System.Windows.Forms.Button btn_exportdata;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_fileimport;
        private System.Windows.Forms.TextBox txt_fileurl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.DataGridView Source_Data;
        private System.Windows.Forms.BindingSource bdSource;
        private System.Windows.Forms.BindingNavigator bdNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
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
        private System.Windows.Forms.ToolStripButton btn_selectAll;
        private System.Windows.Forms.ToolStripButton btn_clear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ComboBox cbx_print;
        private System.Windows.Forms.TextBox txt_packingperson;
        private System.Windows.Forms.Label lbl_packingperson;
        private System.Windows.Forms.Label lbl_Print;
        private System.Windows.Forms.TextBox txt_searchwhere;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chb_printall;
        private System.Windows.Forms.Label label3;
    }
}

