using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SX_RFID.DataAcesss;
using System.IO;
using ZJPrintDLL;
using System.Drawing.Printing;
using System.Threading;

namespace SX_RFID
{
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
            foreach (string sPrint in PrinterSettings.InstalledPrinters)//获取所有打印机名称
            {
                this.cbx_print.Items.Add(sPrint);
                if (sPrint == "SATO CL4NX 203dpi")
                {
                    this.cbx_print.SelectedIndex = this.cbx_print.Items.IndexOf(sPrint);
                }
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
                Source_Data.DataSource = bdSource;
                if (!IsInsertCheck)
                {
                    DataGridViewCheckBoxColumn checkbox = new DataGridViewCheckBoxColumn();
                    Source_Data.Columns.Insert(0, checkbox);
                    IsInsertCheck = true;
                }
                for (var i = 0; i < this.Source_Data.Rows.Count; i++)
                {
                    if (selecteddata.Contains(this.Source_Data[2, i].Value.ToString()))
                    {
                        this.Source_Data[0, i].Value = true;
                    }
                }
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.Filter = "Excel 03版本文件(*.xls)|*.xls|Excel 07版本文件(*.xlsx)|*.xlsx";

            if (ofg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txt_fileurl.Text = ofg.FileName;
            }
        }

        private void btn_fileimport_Click(object sender, EventArgs e)
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

        // <summary>
        /// 判断DataTale中判断某个字段中包含某个数据
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="columnName"></param>
        /// <param name="fieldData"></param>
        /// <returns></returns>
        public Boolean IsColumnIncludeData(DataTable dt, String columnName, string fieldData)
        {
            if (dt == null)
            {
                return false;
            }
            else
            {
                DataRow[] dataRows = dt.Select(columnName + "='" + fieldData + "'");
                if (dataRows.Length.Equals(1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void ShowData()
        {
            MessageBox.Show("草你妈!");
        }

        private void bdNavigator_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "上一页")
            {
                pageCurrent--;
                if (pageCurrent <= 0)
                {
                    MessageBox.Show("已经是第一页，请点击\"下一页\"查看！");
                    pageCurrent++;
                    return;
                }
                else
                {
                    nCurrent = pageSize * (pageCurrent - 1);
                }
                LoadData();
            }
            if (e.ClickedItem.Text == "下一页")
            {
                pageCurrent++;
                if (pageCurrent > pageCount)
                {
                    MessageBox.Show("已经是最后一页，请点击\"上一页\"查看！");
                    pageCurrent++;
                    return;
                }
                else
                {
                    nCurrent = pageSize * (pageCurrent - 1);
                }
                LoadData();
            }
            if (e.ClickedItem.Text == "首页")
            {
                pageCurrent = 1;
                nCurrent = 0;
                LoadData();
            }
            if (e.ClickedItem.Text == "尾页")
            {
                pageCurrent = pageCount;
                nCurrent = pageSize * (pageCurrent - 1);
                LoadData();
            }
        }

        private void btnPage_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCurrentPage.Text.Trim()))
            {
                pageCurrent = Convert.ToInt16(txtCurrentPage.Text.Trim());
                //若输入页号大于最大显示页号，则跳转到最大页
                if (pageCurrent > pageCount)
                {
                    pageCurrent = pageCount;
                    nCurrent = pageSize * (pageCurrent - 1);
                }
                else if (pageCurrent < 1)//若输入页号小于1，则跳转到第一页
                {
                    pageCurrent = 1;
                    nCurrent = 0;
                }
                else //跳转到输入页号
                {
                    nCurrent = pageSize * (pageCurrent - 1);
                }
                LoadData();
            }
        }
        //当前页输入字符限制
        private void txtCurrentPage_TextChanged(object sender, EventArgs e)
        {
            bool IsNum = true;
            foreach (char c in txtCurrentPage.Text.Trim())
            {
                if (!char.IsNumber(c))
                {
                    IsNum = false;
                    break;
                }
            }
            if (!IsNum)
            {
                txtCurrentPage.Text = pageCurrent.ToString();
            }
        }

        //当前页回车事件调用跳转页的操作
        private void txtCurrentPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnPage_Click(sender, e);
            }
        }

        //每页显示记录数变更事件
        private void txtRecordNumOfPage_TextChanged(object sender, EventArgs e)
        {
            bool IsNum = true;
            //输入限制
            foreach (char c in txtRecordNumOfPage.Text.Trim())
            {
                if (!char.IsNumber(c))
                {
                    IsNum = false;
                    break;
                }
            }
            if (!IsNum)
            {
                txtRecordNumOfPage.Text = pageSize.ToString();
            }
            //判断输入的每页显示条数是否为空或是否为0，输入长度是否大于4位等情况
            if (string.IsNullOrEmpty(txtRecordNumOfPage.Text.Trim()) || Convert.ToInt32(txtRecordNumOfPage.Text.Trim()) == 0 || txtRecordNumOfPage.Text.Trim().Length > 4)
            {
                txtRecordNumOfPage.Text = pageSize.ToString();
            }
            //规避了特殊情况后直接调用显示数据方法
            InitDataSet();
        }
        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_selectAll_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < this.Source_Data.Rows.Count; i++)
            {
                this.Source_Data[0, i].Value = true;
                if (!selecteddata.Contains(this.Source_Data[2, i].Value.ToString()))
                {
                    selecteddata.Add(this.Source_Data[2, i].Value.ToString());
                }
            }
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clear_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < this.Source_Data.Rows.Count; i++)
            {
                this.Source_Data[0, i].Value = false;
                if (selecteddata.Contains(this.Source_Data[2, i].Value.ToString()))
                {
                    selecteddata.Remove(this.Source_Data[2, i].Value.ToString());
                }
            }
        }
        /// <summary>
        /// checkbox选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Source_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                if (this.Source_Data.Rows[e.RowIndex].Cells[0].EditedFormattedValue.ToString() == "True")
                {
                    if (!selecteddata.Contains(this.Source_Data[2, e.RowIndex].Value.ToString()))
                    {
                        selecteddata.Add(this.Source_Data[2, e.RowIndex].Value.ToString());
                    }
                }
                else
                {
                    selecteddata.Remove(this.Source_Data[2, e.RowIndex].Value.ToString());
                }
            }
        }
        /// <summary>
        /// 打印
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_print_Click(object sender, EventArgs e)
        {
            try
            {
                if (chb_printall.Checked)
                {
                    if (MessageBox.Show("请确认是否需要全部打印？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    {
                        return;
                    }
                    else if (string.IsNullOrEmpty(this.txt_packingperson.Text.Trim()))
                    {
                        MessageBox.Show("请填写装箱人员！");
                        return;
                    }
                    else if (string.IsNullOrEmpty(this.cbx_print.Text.Trim()))
                    {
                        MessageBox.Show("请选择打印机！");
                        return;
                    }
                    else
                    {
                        #region 全部打印
                        for (var i = 0; i < dtInfo.Rows.Count; i++)
                        {
                            string epc_code = dtInfo.Rows[i]["生成机构"].ToString().Substring(2) + dtInfo.Rows[i]["保管机构"].ToString().Substring(2, 1) + dtInfo.Rows[i]["存放位置"].ToString().Split('-')[1].Substring(0, 3) + dtInfo.Rows[i]["存放位置"].ToString().Split('-')[2].Substring(0, 4) + dtInfo.Rows[i]["存放位置"].ToString().Split('-')[3].Substring(0, 4);
                            string[] arr = new string[8];
                            arr[0] = dtInfo.Rows[i]["箱号"].ToString();//箱号
                            arr[1] = dtInfo.Rows[i]["保管年限"].ToString();//保管期限
                            arr[2] = dtInfo.Rows[i]["档案数量"].ToString();//档案数量
                            arr[3] = dtInfo.Rows[i]["业务种类"].ToString() + '-' + dtInfo.Rows[i]["档案类别"].ToString();//凭证类型
                            arr[4] = dtInfo.Rows[i]["开始日期"].ToString() + '-' + dtInfo.Rows[i]["截止日期"].ToString();//档案日期
                            arr[5] = this.txt_packingperson.Text.Trim();//装箱人员
                            arr[6] = epc_code;//EPC数据
                            Thread.Sleep(5000);
                            PrintMark(arr);
                        }
                        #endregion
                    }
                }
                else
                {
                    #region 选择打印
                    if (selecteddata.Count < 1)
                    {
                        MessageBox.Show("请选择要打印的数据！");
                        return;
                    }
                    if (string.IsNullOrEmpty(this.txt_packingperson.Text.Trim()))
                    {
                        MessageBox.Show("请填写装箱人员！");
                        return;
                    }
                    if (string.IsNullOrEmpty(this.cbx_print.Text.Trim()))
                    {
                        MessageBox.Show("请选择打印机！");
                        return;
                    }
                    for (var i = 0; i < dtInfo.Rows.Count; i++)
                    {
                        if (selecteddata.Contains(dtInfo.Rows[i]["箱号"]))
                        {
                            string epc_code = dtInfo.Rows[i]["生成机构"].ToString().Substring(2) + dtInfo.Rows[i]["保管机构"].ToString().Substring(2, 1) + dtInfo.Rows[i]["存放位置"].ToString().Split('-')[1].Substring(0, 3) + dtInfo.Rows[i]["存放位置"].ToString().Split('-')[2].Substring(0, 4) + dtInfo.Rows[i]["存放位置"].ToString().Split('-')[3].Substring(0, 4);
                            string[] arr = new string[8];
                            arr[0] = dtInfo.Rows[i]["箱号"].ToString();//箱号
                            arr[1] = dtInfo.Rows[i]["保管年限"].ToString();//保管期限
                            arr[2] = dtInfo.Rows[i]["档案数量"].ToString();//档案数量
                            arr[3] = dtInfo.Rows[i]["业务种类"].ToString() + '-' + dtInfo.Rows[i]["档案类别"].ToString();//凭证类型
                            arr[4] = dtInfo.Rows[i]["开始日期"].ToString() + '-' + dtInfo.Rows[i]["截止日期"].ToString();//档案日期
                            arr[5] = this.txt_packingperson.Text.Trim();//装箱人员
                            arr[6] = epc_code;//EPC数据
                            Thread.Sleep(5000);
                            PrintMark(arr);
                        }
                    }
                    selecteddata.Clear();
                    #endregion
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误信息:" + ex.Message);
            }
        }

        private void PrintMark(string[] arr)
        {
            string printdata = PrintLabel.GetCommonLabelData(arr, "1");
            if (string.IsNullOrEmpty(printdata))
            {
                MessageBox.Show("传入数据项不完整！！");
                return;
            }
            PrintLabel.PrintMark(printdata, cbx_print.Text);
        }

        private void btn_exportdata_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtInfo == null || dtInfo.Rows.Count <= 0)
                {
                    MessageBox.Show("请先加载数据!");
                    return;
                }
                List<string> contents = new List<string>();
                int num = 1;
                foreach (DataRow dr in dtInfo.Rows)
                {
                    string epc_code = dr["生成机构"].ToString().Substring(2) + dr["保管机构"].ToString().Substring(2, 1) + dr["存放位置"].ToString().Split('-')[1].Substring(0, 3) + dr["存放位置"].ToString().Split('-')[2].Substring(0, 4) + dr["存放位置"].ToString().Split('-')[3].Substring(0, 4);
                    string[] arr = new string[8];
                    contents.Add(num++ + "||||||||||||" + epc_code.PadRight(18, '0') + "|会计档案箱电子化校验00000000|||");
                }
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "文本文件(*.txt)|*.txt";
                sfd.FileName = "rfid_mission";
                sfd.DefaultExt = "txt";
                sfd.AddExtension = true;
                sfd.RestoreDirectory = true;

                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    FileHelper.ExportFile(sfd.FileName, contents);
                    MessageBox.Show("导出盘点任务成功!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误信息:" + ex.Message);
            }
        }

        private void txt_searchwhere_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)13)
                {
                    if (string.IsNullOrEmpty(txt_searchwhere.Text.Trim()))
                    {
                        btn_fileimport_Click(sender, e);
                    }
                    else
                    {
                        btn_fileimport_Click(sender, e);
                        DataTable newdt = new DataTable();
                        newdt = dtInfo.Clone();
                        DataRow[] drinfo = dtInfo.Select("箱号 like'%" + txt_searchwhere.Text.Trim() + "%'");
                        foreach (DataRow dr in drinfo)
                        {
                            newdt.ImportRow((DataRow)dr);
                        }
                        dtInfo.Clear();
                        dtInfo = newdt;
                        InitDataSet();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误信息:" + ex.Message);
            }
        }
    }
}
