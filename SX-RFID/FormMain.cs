using SX_RFID.DataAcesss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZJPrintDLL;

namespace SX_RFID
{
    public partial class FormMain : Form
    {
        #region 私有成员
        int pageSize = 0;//每页显示行数
        int nMax = 0;//总记录数
        int pageCount = 0;//页数=总记录数/每页显示行数
        int pageCurrent = 0;//当前页号
        int nCurrent = 0;//当前记录行
        DataTable dtInfo = null;//存取当前数据源
        List<string> selecteddata = new List<string>();
        PrintLabel PrintLabel = new PrintLabel();
        bool IsInsertCheck = false;
        #endregion
        public FormMain()
        {
            InitializeComponent();
            foreach (string sPrint in PrinterSettings.InstalledPrinters)//获取所有打印机名称
            {
                this.cbx_PrintName.Items.Add(sPrint);
                if (sPrint == Properties.Settings.Default.print_name)
                {
                    this.cbx_PrintName.SelectedIndex = this.cbx_PrintName.Items.IndexOf(sPrint);
                }
            }
            txt_packingperson.Text = Properties.Settings.Default.packingperson;
        }
        /// <summary>
        /// 浏览选择文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_select_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.Filter = "Excel 03版本文件(*.xls)|*.xls|Excel 07版本文件(*.xlsx)|*.xlsx";

            if (ofg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txt_fileurl.Text = ofg.FileName;
            }
        }

        /// <summary>
        /// 分页功能实现
        /// </summary>
        public void InitDataSet()
        {
            //判断每页显示记录数是否为空，在初始话窗体时为真
            if (string.IsNullOrEmpty(txtRecordNumOfPage.Text.Trim()))
            {
                if (pageSize == 0)
                    pageSize = 20;
            }
            else
            {
                pageSize = Convert.ToInt16(txtRecordNumOfPage.Text.Trim());
            }
            //总记录数赋值
            nMax = dtInfo.Rows.Count;
            //计算页数，判断nMax对pageSize整除是否有余数，有整除数+1
            pageCount = (nMax % pageSize) == 0 ? (nMax / pageSize) : (nMax / pageSize + 1);
            pageCurrent = 1;//当前页数从1开始
            nCurrent = 0;//当前记录数从0开始
            toolStripLabel2.Text = Convert.ToString(nMax);//总记录数
            //调用显示数据方法
            LoadData();
        }

        private void LoadData()
        {
            int nStartPos = 0;//当前页面开始记录行
            int nEndPos = 0;//当前页面结束记录行
            //判断查询记过是否为空
            if (dtInfo.Rows.Count == 0)
            {
                bdSource.DataSource = null;
                return;
            }
            else
            {
                DataTable dtTemp = dtInfo.Clone();//克隆dtInfo结构，即将字段名称进行复制
                if (pageCurrent == 1)
                {
                    bindingNavigatorMoveFirstItem.Enabled = false;
                    bindingNavigatorMovePreviousItem.Enabled = false;
                }
                else
                {
                    bindingNavigatorMoveFirstItem.Enabled = true;
                    bindingNavigatorMovePreviousItem.Enabled = true;
                }
                if (pageCurrent == pageCount)
                {
                    nEndPos = nMax;
                    bindingNavigatorMoveLastItem.Enabled = false;
                    bindingNavigatorMoveNextItem.Enabled = false;
                }
                else
                {
                    bindingNavigatorMoveLastItem.Enabled = true;
                    bindingNavigatorMoveNextItem.Enabled = true;
                    nEndPos = pageSize * pageCurrent;
                }

                nStartPos = nCurrent;
                bindingNavigatorCountItem.Text = pageCount.ToString();//显示总页数
                bindingNavigatorPositionItem.Text = Convert.ToString(pageCurrent);//当前页数
                txtCurrentPage.Text = Convert.ToString(pageCurrent);//跳转到页数的显示

                //从元数据源复制记录行
                for (var i = nStartPos; i < nEndPos; i++)
                {
                    dtTemp.ImportRow(dtInfo.Rows[i]);
                    nCurrent++;
                }
                bdSource.DataSource = dtTemp;
                inport_data.DataSource = bdSource;
                if (!IsInsertCheck)
                {
                    DataGridViewCheckBoxColumn checkbox = new DataGridViewCheckBoxColumn();
                    inport_data.Columns.Insert(0, checkbox);
                    IsInsertCheck = true;
                }
                for (var i = 0; i < this.inport_data.Rows.Count; i++)
                {
                    if (selecteddata.Contains(this.inport_data[2, i].Value.ToString()))
                    {
                        this.inport_data[0, i].Value = true;
                    }
                }
            }
        }
        /// <summary>
        /// 导入数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_import_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_fileurl.Text.Trim()))
                {
                    MessageBox.Show("请选择待加载的文件!");
                }
                else
                {
                    FileHelper fileHelper = new FileHelper(this.txt_fileurl.Text.Trim());
                    DataTable dt = fileHelper.ExcelToDataTable(null, true);
                    dt.Columns.Remove("档案编号");
                    DataColumn column = new DataColumn();
                    column.ColumnName = "档案数量";
                    dt.Columns.Add(column);
                    dt.Columns.Add("箱号").SetOrdinal(1);
                    dtInfo = new DataTable();
                    dtInfo = dt.Clone();
                    foreach (DataRow dr in dt.Rows)
                    {
                        string boxnumber = dr["生成机构"].ToString().Substring(2) + dr["保管机构"].ToString() + dr["存放位置"].ToString().Split('-')[1].Substring(0, 3) + dr["存放位置"].ToString().Split('-')[2].Substring(0, 4) + dr["存放位置"].ToString().Split('-')[3].Substring(0, 4);
                        if (dtInfo.Select("箱号='" + boxnumber + "'").Count() == 0)
                        {
                            var count = dt.Select("存放位置='" + dr["存放位置"].ToString() + "' and 保管机构='" + dr["保管机构"].ToString() + "' and 生成机构='" + dr["生成机构"].ToString() + "'").Count();
                            dr["开始日期"] = dt.Select("存放位置='" + dr["存放位置"].ToString() + "' and 保管机构='" + dr["保管机构"].ToString() + "' and 生成机构='" + dr["生成机构"].ToString() + "'", "开始日期 ASC")[0]["开始日期"];
                            dr["截止日期"] = dt.Select("存放位置='" + dr["存放位置"].ToString() + "' and 保管机构='" + dr["保管机构"].ToString() + "' and 生成机构='" + dr["生成机构"].ToString() + "'", "截止日期 DESC")[0]["截止日期"];
                            dr["档案数量"] = count;
                            dr["箱号"] = boxnumber;
                            dtInfo.Rows.Add(dr.ItemArray);
                        }
                    }
                    selecteddata.Clear();
                    InitDataSet();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误信息:" + ex.Message);
            }
        }
        /// <summary>
        /// 保存配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_savesettings_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.print_name = cbx_PrintName.Text.Trim();
                Properties.Settings.Default.packingperson = txt_packingperson.Text.Trim();
                Properties.Settings.Default.Save();
                MessageBox.Show("保存配置成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch
            {
                MessageBox.Show("保存配置失败!", "错误消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            string filepath = ConfigurationManager.AppSettings["db_FilePath"];
            if (string.IsNullOrEmpty(filepath))
            {
                filepath = System.Windows.Forms.Application.StartupPath + "\\info.db";
            }
            if (!File.Exists(filepath))
            {
                string CommandText = "drop table if exists `t_box`;CREATE TABLE [t_box]([Id] NVARCHAR(50) PRIMARY KEY NOT NULL,[box_location] VARCHAR(500),[box_number] VARCHAR(18),[start_date] NVARCHAR(38),[end_date] NVARCHAR(38),[packingperson] NVARCHAR(50),[archive_type] NVARCHAR(50),[custodydate] INT,[archive_number] INT,[rfid_code] VARCHAR(18),[print_date] NVARCHAR(38));";
                SQLiteHelper.ExecuteNonQuery(CommandText, null);
            }
        }
    }
}
