using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeleteFirstFewLine
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link; //重要代码：表明是链接类型的数据，比如文件路径
            else e.Effect = DragDropEffects.None;
        }

        private void FormMain_DragDrop(object sender, DragEventArgs e)
        {
            //DGV.Rows.Clear();
            int len = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).Length;
            if (len == 1)//如果拖拽的是目录 
            {
                string filePathDrag = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
                if(MyString.IsDirectory(filePathDrag))
                {
                    AddFileFromFolder(filePathDrag);
                    return;
                }
            }

            List<string> lsNewFilePath = new List<string>();
            for (int i = 0; i < len; i++)
            {
                string filePath = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(i).ToString();
                if (!MyString.IsDirectory(filePath))
                {
                    lsNewFilePath.Add(filePath);
                }
            }

            AddMemberInDGV(lsNewFilePath);
            
            DGV.ClearSelection();

        }

        /// <summary>
        /// 新添加文件进来
        /// </summary>
        /// <param name="lsNewFilePath">文件名FullPath</param>
        private void AddMemberInDGV(List<string> lsNewFilePath)
        {
            if(lsNewFilePath == null || lsNewFilePath.Count == 0)
            { return; }
            List<string> lsOldFilePath = new List<string>();

            //去除不存在的文件
            for (int i = 0; i < DGV.Rows.Count; i++)
            {
                if (!File.Exists(DGV.Rows[i].Cells["FilePath"].Value.ToString()))
                {
                    DGV.Rows.RemoveAt(i);
                    i--;
                }
            }
            int lastCount = DGV.Rows.Count;
            //合法的目录添加到List
            for (int i = 0; i < lastCount; i++)
            {
                lsOldFilePath.Add(DGV.Rows[i].Cells["FilePath"].Value.ToString());
            }

            foreach (string str in lsNewFilePath)
            {
                if (!lsOldFilePath.Contains(str))
                {
                    DGV.Rows.Add(str, System.IO.Path.GetFileName(str), "");
                }
            }           
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //checkBoxBak.Checked = true;
            //InitComboBoxDeleteLineItems();
            this.comboBoxDeleteLine.Text = "删除前后行";
            this.comboBoxSplit.Text = "拆分固定个数";
            this.comboBoxMerge.Text = "普通合并";
            this.comboBoxDeleteData.Text = "删除文本";
            this.comboBoxAddData.Text = "添加到文件的首尾";
            this.comboBoxOtherType.Text = "添加文件夹";
            InitDeleteLine_ComboBox();
            InitDGV_ContextMenuStrip();

        }

        private void InitDGV_ContextMenuStrip()
        {
            if (DGV.Rows.Count == 0)
            {
                this.删除ToolStripMenuItem.Enabled = false;
                this.全部删除ToolStripMenuItem.Enabled = false;
                this.清空状态ToolStripMenuItem.Enabled = false;
                this.删除成功行ToolStripMenuItem.Enabled = false;
                this.文件信息ToolStripMenuItem.Enabled = false;
                this.打开文件ToolStripMenuItem.Enabled = false;
                this.打开文件夹ToolStripMenuItem1.Enabled = false;
                this.统计行数ToolStripMenuItem.Enabled = false;
                this.统计字数ToolStripMenuItem.Enabled = false;
                this.清除选中状态ToolStripMenuItem.Enabled = false;
                this.整理列表ToolStripMenuItem.Enabled = false;
                return;
            }

            if (DGV.SelectedRows.Count == 0)
            {
                this.删除ToolStripMenuItem.Enabled = false;
                this.全部删除ToolStripMenuItem.Enabled = true;
                this.清空状态ToolStripMenuItem.Enabled = true;
                this.删除成功行ToolStripMenuItem.Enabled = true;
                this.文件信息ToolStripMenuItem.Enabled = false;
                this.打开文件ToolStripMenuItem.Enabled = false;
                this.打开文件夹ToolStripMenuItem1.Enabled = false;
                this.统计行数ToolStripMenuItem.Enabled = true;
                this.清除选中状态ToolStripMenuItem.Enabled = false;
                this.统计字数ToolStripMenuItem.Enabled = true;
                this.整理列表ToolStripMenuItem.Enabled = true;
                return;
            }

            if (DGV.SelectedRows.Count == 1)
            {
                this.删除ToolStripMenuItem.Enabled = true;
                this.全部删除ToolStripMenuItem.Enabled = true;
                this.清空状态ToolStripMenuItem.Enabled = true;
                this.删除成功行ToolStripMenuItem.Enabled = true;
                this.文件信息ToolStripMenuItem.Enabled = true;
                this.打开文件ToolStripMenuItem.Enabled = true;
                this.打开文件夹ToolStripMenuItem1.Enabled = true;
                this.统计行数ToolStripMenuItem.Enabled = true;
                this.清除选中状态ToolStripMenuItem.Enabled = true;
                this.统计字数ToolStripMenuItem.Enabled = true;
                this.整理列表ToolStripMenuItem.Enabled = true;
                return;
            }
            if (DGV.SelectedRows.Count > 1)
            {
                this.删除ToolStripMenuItem.Enabled = true;
                this.全部删除ToolStripMenuItem.Enabled = true;
                this.清空状态ToolStripMenuItem.Enabled = true;
                this.删除成功行ToolStripMenuItem.Enabled = true;
                this.文件信息ToolStripMenuItem.Enabled = true;
                this.打开文件ToolStripMenuItem.Enabled = false;
                this.打开文件夹ToolStripMenuItem1.Enabled = false;
                this.统计行数ToolStripMenuItem.Enabled = true;
                this.清除选中状态ToolStripMenuItem.Enabled = true;
                this.统计字数ToolStripMenuItem.Enabled = true;
                this.整理列表ToolStripMenuItem.Enabled = true;
                return;
            }


        }


        /// <summary>
        /// 开始删除前后行 开始删除连续行 开始删除数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (DGV.Rows.Count == 0)
                return;

            switch (btnStart.Text)
            {
                case "开始添加文件夹":
                    break;
                case "开始删除前后行":
                    //DeleteFrotLast();
                    DeleteLine("FrotLast");
                    break;

                case "开始删除连续行":
                    //DeleteLianXu();
                    DeleteLine("LianXu");
                    break;

                case "开始删除奇数行":
                    //DeleteEvenOddLine(false);
                    DeleteLine("Odd");
                    break;

                case "开始删除偶数行":
                    //DeleteEvenOddLine(true);
                    DeleteLine("Even");
                    break;

                case "开始删除空白行":
                    //DeleteSpaceLine();
                    DeleteLine("Space");
                    break;

                case "开始删除重复行":
                    //正在做
                    //DeleteDuplicateLine();
                    DeleteLine("Duplicate");
                    break;
                case "开始删除特定行":
                    if (txbDelLine_TeDing.Text == "")
                    {  return;  }
                    DeleteLine("NumbersLine");
                    break;

                case "开始删除含有关键字的行":
                    if (txbDelLine_TeDingData.Text == "")
                    {  return;  }
                    DeleteLine("KeyWordsLine");
                    break;

                case "开始删除数据":
                    ReplaceDeleteMulData("");
                    break;

                case "开始替换数据":
                    ReplaceDeleteMulData(this.txbDelNewData.Text);
                    //ReplaceMulData();
                    break;

                case "开始替换指定行之间":

                    DeleteLine("DealReplaceMultiLine");

                    break;

                case "开始删除行首数字":
                    DeleteLine("DeleteTopNumberOfLine");
                    break;

                case "开始删除行首字符":
                    DeleteLine("DeleteTopOfLine");
                    break;
                case "开始删除行尾字符":
                    DeleteLine("DeleteLastOfLine");
                    break;
                case "开始合并":
                    MergeFile("MergeFileNormal");
                    //MergeFile(false);
                    break;
                case "开始合并+数据":
                    //MergeFile(true);
                    MergeFile("MergeFileAddData");
                    break;
                case "开始合并+数据+文件名":
                    MergeFile("MergeFileDataFileName");
                    //MergeFileName();
                    break;
                case "开始隔行合并":
                    MergeFile("MergeFileGeHang");
                    //MergeFileGeHang();
                    break;
                case "开始左右合并(2个文件)":
                    MergeFile("MergeFileLeftRight");
                    break;

                case "拆分固定个数":
                    //SplitFileByCountAndLine(Convert.ToInt32(this.numericUpDownSplitCount.Value), true);
                    DeleteLine("SplitFileByCount");
                    break;
                case "拆分固定行数":
                    //SplitFileByCountAndLine(Convert.ToInt32(numericUpDownSplitLine.Value), false);
                    DeleteLine("SplitFileByLine");
                    break;
                case "拆分奇偶行":
                    DeleteLine("SplitFileByOddEven");
                    //SplitFileByOddEven();
                    break;

                case "开始添加到文件的首尾":
                    if(!checkBoxAddData_TopFile.Checked && ! checkBoxAddData_EndFile.Checked)
                    {  return;  }
                    if(txbAddData_TopEndOfFile.Text == "")
                    {  return;  }
                    DeleteLine("AddDataTopEndFile");
                    break;

                case "开始添加到行的首尾":
                    if(!checkBoxAddData_TopLine.Checked && !checkBoxAddData_EndLine.Checked)
                    {
                        return;
                    }
                    if (checkBoxAddData_TopLine.Checked && !checkBoxAddData_ContainNumber.Checked && txbAddData_TopLine.Text == "")
                    {
                        return;
                    }
                    if(checkBoxAddData_EndLine.Checked && txbAddData_EndLine.Text == "")
                    {
                        return;
                    }

                    DeleteLine("AddDataTopEndLine");
                    break;
                case "开始添加文件名到文件":
                    DeleteLine("AddDataFileName");
                    break;
                case "开始重命名":
                    DeleteLine("OtherRename");
                    break;
                case "开始恢复备份文件":
                    DeleteLine("OtherBak");
                    break;
                case "开始查找":
                    if(txbOtherFind.Text == "")
                    {
                        return;
                    }
                    DeleteLine("OtherFind");
                    break;
                case "开始转换编码":
                    DeleteLine("OtherChangeType");
                    break;
                case "开始排序":
                    DeleteLine("OtherSort");
                    break;
                default:
                    MessageBox.Show("还没做呢");
                    break;
            }

        }

        public void MergeFile(string type)
        {
            if (DGV.Rows.Count < 1)
            {
                return;
            }
            List<string> lsFilePath = new List<string>();
            for (int i = 0; i < DGV.Rows.Count; i++)
            {
                if (Common.IsNullTXT(DGV.Rows[i].Cells["FilePath"].Value.ToString()))
                {
                    DGV.Rows[i].Cells["State"].Value = "失败";
                    return;
                }
                lsFilePath.Add(DGV.Rows[i].Cells["FilePath"].Value.ToString());
            }
            bool bl = false;
            string mergeData = txbMerge_AddDataAmongFiles.Text;
            switch (type)
            {
                case "MergeFileNormal":
                    bl = Delete.MergeFile(lsFilePath);
                    break;
                case "MergeFileAddData":
                    bl = Delete.MergeFile(lsFilePath, mergeData);
                    break;
                case "MergeFileDataFileName":
                    bl = Delete.MergeFileName(lsFilePath, mergeData);
                    break;
                case "MergeFileGeHang":
                    bl = Delete.MergeFileGeHang(lsFilePath);
                    break;
                case "MergeFileLeftRight":
                    if (lsFilePath.Count != 2)
                    {
                        MessageBox.Show("左右合并因为需求不高，目前仅支持2个文件左右合并");
                        return;
                    }
                    string mergeDataLeftRight = this.txbMerge_LeftRightData.Text;
                    bl = Delete.MergeFileLeftRight(lsFilePath, mergeDataLeftRight);
                    break;
                default:
                    MessageBox.Show("出错了");
                    break;
            }
            for (int i = 0; i < DGV.Rows.Count; i++)
            {
                if (bl == true)
                {
                    DGV.Rows[i].Cells["State"].Value = "成功 √";
                    DGV.Rows[i].Cells["State"].Style.ForeColor = Color.Red;
                }
                else
                {
                    DGV.Rows[i].Cells["State"].Value = "失败";
                }
            }
        }

        /// <summary>
        /// DeleteMultiLine
        /// </summary>
        /// <param name="type">删除多行的类型</param>
        public void DeleteLine(string type)
        {
            bool blCheck = checkBoxBak.Checked;

            string successState = "成功 √";
            string failedState = "失败";

            for (int i = 0; i < DGV.Rows.Count; i++)
            {
                try
                {
                    string filePath = DGV.Rows[i].Cells["FilePath"].Value.ToString();
                    if (Common.IsNullTXT(filePath) || !File.Exists(filePath))
                    {
                        DGV.Rows[i].Cells["State"].Value = "无法处理";
                        continue;
                    }
                    bool bl = false;
                    switch (type)
                    {
                        case "Duplicate"://删除所有重复的行Duplicate
                            bl = Delete.DeleteDuplicateLine(filePath, blCheck);
                            successState = "删除成功";
                            failedState = "删除失败";
                            break;
                        case "Space"://删除空白的行Space
                            bl = Delete.DeleteSpaceLine(filePath, blCheck);
                            successState = "删除成功";
                            failedState = "删除失败";
                            break;
                        case "Even"://删除偶数的行Even
                            bl = Delete.DeleteFileEvenOdd(filePath, blCheck, true);
                            successState = "删除成功";
                            failedState = "删除失败";
                            break;
                        case "Odd"://删除空白的行Odd  
                            bl = Delete.DeleteFileEvenOdd(filePath, blCheck, false);
                            successState = "删除成功";
                            failedState = "删除失败";
                            break;
                        case "LianXu"://删除连续的行LianXu pos1 - pos2 
                            int firstPos = Convert.ToInt32(nudDelLine_ContinueFirst.Value);
                            int secondPos = Convert.ToInt32(nudDelLine_ContinueLast.Value);
                            if (firstPos < 1 && secondPos < 1 && firstPos > secondPos)
                            {
                                return;
                            }
                            bl = Delete.DeleteFileLianXu(firstPos, secondPos, filePath, blCheck);
                            successState = "删除成功";
                            failedState = "删除失败";
                            break;
                        case "FrotLast"://删除前后的行FrotLast nFront - nLast 
                            int nFront = Convert.ToInt32(nudDelLine_TopLineFile.Value);
                            int nLast = Convert.ToInt32(nudDelLine_LastLineFile.Value);
                            if (nFront == 0 && nLast == 0)
                            {
                                return;
                            }
                            bl = Delete.DeleteFileFrotLast(nFront, nLast, filePath, blCheck);
                            successState = "删除成功";
                            failedState = "删除失败";
                            break;
                        case "DeleteTopNumberOfLine":
                            bl = Delete.DeleteTopNumberOfLine(filePath, blCheck);
                            successState = "删除成功";
                            failedState = "删除失败";
                            break;
                        case "NumbersLine"://特定行
                            List<int> lsInt = new List<int>();
                            lsInt = MyString.GetListIntFromStr(txbDelLine_TeDing.Text);
                            if (lsInt == null || lsInt.Count == 0)
                            {
                                MessageBox.Show("输入特定行不合法！");
                                return;
                            }
                            bl = Delete.DeleteNumbersLine(filePath, lsInt, blCheck);
                            successState = "删除成功";
                            failedState = "删除失败";
                            break;

                        case "KeyWordsLine"://删除含有关键字的行
                            List<string> lsKeyWords = new List<string>(txbDelLine_TeDingData.Text.Split('+').ToArray());
                            bl = Delete.DeleteKeyWordsLine(filePath, lsKeyWords, blCheck);
                            successState = "删除成功";
                            failedState = "删除失败";
                            break;
                        case "DeleteTopOfLine":
                            int nCountZiFuTop = 0;
                            if (checkBoxDel_DataTopOfLine.Checked)
                            {
                                nCountZiFuTop = txbCountZiFu.Text.Length;
                            }
                            else
                            {
                                nCountZiFuTop = Convert.ToInt32(this.nudDelData_CountZiFu.Value);
                            }
                            if (nCountZiFuTop == 0)
                            {
                                return;
                            }
                            bl = Delete.DeleteTopOfLine(filePath, nCountZiFuTop, blCheck);
                            successState = "删除成功";
                            failedState = "删除失败";
                            break;
                        case "DeleteLastOfLine":
                            int nCountZiFuLast = 0;
                            if (checkBoxDel_DataTopOfLine.Checked)
                            {
                                nCountZiFuLast = txbCountZiFu.Text.Length;
                            }
                            else
                            {
                                nCountZiFuLast = Convert.ToInt32(this.nudDelData_CountZiFu.Value);
                            }
                            if (nCountZiFuLast == 0)
                            {
                                return;
                            }
                            bl = Delete.DeleteLastOfLine(filePath, nCountZiFuLast, blCheck);
                            successState = "删除成功";
                            failedState = "删除失败";
                            break;
                        case "SplitFileByOddEven"://拆分文件奇偶
                            bl = Delete.SplitFileByOddEven(filePath);
                            successState = "拆分成功";
                            failedState = "拆分失败";
                            break;
                        case "SplitFileByCount"://以固定个数拆分文件
                            int nCount = Convert.ToInt32(this.nudSplit_Count.Value);
                            bl = Delete.SplitFile(filePath, nCount, true);
                            successState = "拆分成功";
                            failedState = "拆分失败";
                            break;
                        case "SplitFileByLine"://以固定行数拆分文件
                            int nLine = Convert.ToInt32(nudSplit_Line.Value);
                            bl = Delete.SplitFile(filePath, nLine, false);
                            successState = "拆分成功";
                            failedState = "拆分失败";
                            break;
                        case "DealReplaceMultiLine":
                            int nStart = Convert.ToInt32(nud_startLine.Value);
                            int nEnd = Convert.ToInt32(nud_endLine.Value);
                            string strModlePath = txbFileDelete.Text;
                            bl = Delete.DeleteReplaceMultiLine(filePath, false,nStart,nEnd, strModlePath);

                            successState = "替换成功";
                            failedState = "替换失败";
                            break;

                        case "AddDataTopEndFile"://开始添加到文件的首尾

                            bl = Delete.AddDataTopEndFile(filePath, blCheck,txbAddData_TopEndOfFile.Text,
                                                          checkBoxAddData_TopFile.Checked,
                                                          checkBoxAddData_EndFile.Checked,
                                                          checkBoxAddData_OverWrite.Checked);

                            successState = "添加成功";
                            failedState = "添加失败";
                            break;

                        case "AddDataTopEndLine":
                            bl = Delete.AddDataTopEndLine(filePath, blCheck, checkBoxAddData_TopLine.Checked,
                                                          checkBoxAddData_ContainNumber.Checked, nudAddData_TopLine.Value,
                                                          txbAddData_TopLine.Text,
                                                          checkBoxAddData_EndLine.Checked,
                                                          txbAddData_EndLine.Text);
                            successState = "添加成功";
                            failedState = "添加失败";
                            break;

                        case "AddDataFileName":
                            string fileName = Common.GetFileNameOfFullName(filePath, checkBoxAddData_ContainDir.Checked,
                                                                           checkBoxAddData_ContainExtension.Checked);
                            fileName = txbAddData_FileName1.Text + fileName + txbAddData_FileName2.Text;
                            bl = Delete.AddDataFileNameOfFile(filePath, blCheck, fileName);

                            successState = "添加成功";
                            failedState = "添加失败";
                            break;
                        case "OtherRename":
                            bl = Delete.RenameAddTopLine(filePath, blCheck, checkBoxOtherOldName.Checked);
                            successState = "重命名成功";
                            failedState = "重命名失败";
                            break;
                        case "OtherBak":
                            bl = Delete.DeleteFileNameBak(filePath);
                            successState = "恢复成功";
                            failedState = "失败";
                            break;
                        case "OtherFind":
                            int countFind = Delete.CountFindDataFile(filePath, txbOtherFind.Text);
                            bl = countFind > 0 ? true : false;
                            successState = countFind.ToString() + " 个";
                            failedState = countFind.ToString() + " 个";
                            break;

                        case "OtherChangeType":
                            string fileChangeType = "";
                            if (radioBtnANSI.Checked)
                            {
                                fileChangeType = "ANSI";
                            }
                            else if (radioBtnUnicode.Checked)
                            {
                                fileChangeType = "Unicode";
                            }
                            else if (radioBtnUnicodeBigEndian.Checked)
                            {
                                fileChangeType = "UnicodeBigEndian";
                            }
                            else if (radioBtnUTF_8.Checked)
                            {
                                fileChangeType = "UTF_8";
                            }
                            else if (radioBtnUTF_8_bom.Checked)
                            {
                                fileChangeType = "UTF_8_BOM";
                            }
                            bl = Delete.ChangeTXTFileType(filePath, fileChangeType);
                            successState = "转换成功";
                            failedState = "失败";
                            break;

                        case "OtherSort":
                            bl = Delete.SortFile(filePath, this.radioBtnSortUp.Checked, this.radioBtnSortDown.Checked);
                            successState = "排序成功";
                            failedState = "失败";
                            break;

                        default:
                            break;
                    }
                    //bool bl = Delete.DeleteDuplicateLine(filePath, blCheck);
                    if (bl == true)
                    {
                        DGV.Rows[i].Cells["State"].Value = successState;
                        DGV.Rows[i].Cells["State"].Style.ForeColor = Color.Red;
                    }
                    else
                    {
                        DGV.Rows[i].Cells["State"].Value = failedState;
                    }
                }
                catch
                {
                    DGV.Rows[i].Cells["State"].Value = "失败";
                }
            }
        }

        /// <summary>
        /// 开始删除前后行
        /// </summary>
        //private void DeleteFrotLast()
        //{
        //    int nFront = Convert.ToInt32(numericUpDownFrontLine.Value);
        //    int nLast = Convert.ToInt32(numericUpDownLastLine.Value);
        //    if (nFront == 0 && nLast == 0)
        //    {
        //        return;
        //    }

        //    for (int i = 0; i < DGV.Rows.Count; i++)
        //    {
        //        DGV.Rows[i].Cells["State"].Value = "正在转换";
        //        if (Common.IsNullTXT(DGV.Rows[i].Cells["FilePath"].Value.ToString()))
        //        {
        //            DGV.Rows[i].Cells["State"].Value = "失败";
        //            continue;
        //        }
        //        bool bl = Delete.DeleteFileFrotLast(nFront, nLast,
        //                                            DGV.Rows[i].Cells["FilePath"].Value.ToString(),
        //                                            checkBoxBak.Checked);
        //        if (bl == true)
        //        {
        //            DGV.Rows[i].Cells["State"].Value = "成功 √";
        //            DGV.Rows[i].Cells["State"].Style.ForeColor = Color.Red;
        //        }
        //        else
        //        {
        //            DGV.Rows[i].Cells["State"].Value = "失败";
        //        }
        //    }
        //}

        /// <summary>
        /// 开始删除连续行
        /// </summary>
        //private void DeleteLianXu()
        //{
        //    int firstPos = Convert.ToInt32(numericUpDownContinueFirst.Value);
        //    int secondPos = Convert.ToInt32(numericUpDownContinueLast.Value);
        //    if (firstPos < 1 && secondPos < 1 && firstPos > secondPos)
        //    {
        //        return;
        //    }

        //    for (int i = 0; i < DGV.Rows.Count; i++)
        //    {

        //        DGV.Rows[i].Cells["State"].Value = "正在删除";
        //        if (Common.IsNullTXT(DGV.Rows[i].Cells["FilePath"].Value.ToString()))
        //        {
        //            DGV.Rows[i].Cells["State"].Value = "失败";
        //            continue;
        //        }
        //        bool bl = Delete.DeleteFileLianXu(firstPos, secondPos,
        //                                          DGV.Rows[i].Cells["FilePath"].Value.ToString(),
        //                                          checkBoxBak.Checked);
        //        if (bl == true)
        //        {
        //            DGV.Rows[i].Cells["State"].Value = "成功 √";
        //            DGV.Rows[i].Cells["State"].Style.ForeColor = Color.Red;
        //        }
        //        else
        //        {
        //            DGV.Rows[i].Cells["State"].Value = "失败";
        //        }
        //    }
        //}

        /// <summary>
        /// 开始删除奇数行
        /// </summary>
        //private void DeleteEvenOddLine(bool evenOdd)
        //{
        //    for (int i = 0; i < DGV.Rows.Count; i++)
        //    {

        //        DGV.Rows[i].Cells["State"].Value = "正在删除";
        //        if (Common.IsNullTXT(DGV.Rows[i].Cells["FilePath"].Value.ToString()))
        //        {
        //            DGV.Rows[i].Cells["State"].Value = "失败";
        //            continue;
        //        }
        //        bool bl = Delete.DeleteFileEvenOdd(DGV.Rows[i].Cells["FilePath"].Value.ToString(),
        //                                           checkBoxBak.Checked, evenOdd);
        //        if (bl == true)
        //        {
        //            DGV.Rows[i].Cells["State"].Value = "成功 √";
        //            DGV.Rows[i].Cells["State"].Style.ForeColor = Color.Red;
        //        }
        //        else
        //        {
        //            DGV.Rows[i].Cells["State"].Value = "失败";
        //        }
        //    }
        //}

        /// <summary>
        /// 开始删除空白行
        /// </summary>
        //private void DeleteSpaceLine()
        //{
        //    for (int i = 0; i < DGV.Rows.Count; i++)
        //    {

        //        DGV.Rows[i].Cells["State"].Value = "正在删除";
        //        if (Common.IsNullTXT(DGV.Rows[i].Cells["FilePath"].Value.ToString()))
        //        {
        //            DGV.Rows[i].Cells["State"].Value = "失败";
        //            continue;
        //        }
        //        bool bl = Delete.DeleteSpace(DGV.Rows[i].Cells["FilePath"].Value.ToString(),
        //                                     checkBoxBak.Checked);
        //        if (bl == true)
        //        {
        //            DGV.Rows[i].Cells["State"].Value = "成功 √";
        //            DGV.Rows[i].Cells["State"].Style.ForeColor = Color.Red;
        //        }
        //        else
        //        {
        //            DGV.Rows[i].Cells["State"].Value = "失败";
        //        }
        //    }
        //}

        /// <summary>
        /// 删除重复行
        /// </summary>
        //private void DeleteDuplicateLine()
        //{
        //    for (int i = 0; i < DGV.Rows.Count; i++)
        //    {
        //        string filePath = DGV.Rows[i].Cells["FilePath"].Value.ToString();
        //        if (Common.IsNullTXT(filePath))
        //        {
        //            DGV.Rows[i].Cells["State"].Value = "失败";
        //            continue;
        //        }
        //        bool bl = Delete.DeleteDuplicateLine(filePath,this.checkBoxBak.Checked);
        //        if (bl == true)
        //        {
        //            DGV.Rows[i].Cells["State"].Value = "成功 √";
        //            DGV.Rows[i].Cells["State"].Style.ForeColor = Color.Red;
        //        }
        //        else
        //        {
        //            DGV.Rows[i].Cells["State"].Value = "失败";
        //        }
        //    }

        //    //throw new NotImplementedException();
        //}

        /// <summary>
        /// 开始替换数据
        /// </summary>
        //private void ReplaceMulData()
        //{
        //    if (txbDeleteText.Text == "" || txbNewData.Text == "")
        //        return;

        //    string sourceString = txbDeleteText.Text;
        //    string newString = txbNewData.Text;

        //    for (int i = 0; i < DGV.Rows.Count; i++)
        //    {
        //        try
        //        {
        //            if (Common.IsNullTXT(DGV.Rows[i].Cells["FilePath"].Value.ToString()))
        //            {
        //                DGV.Rows[i].Cells["State"].Value = "失败";
        //                continue;
        //            }
        //            int count = Delete.ReplaceDeleteMulti(DGV.Rows[i].Cells["FilePath"].Value.ToString(), sourceString, newString, checkBoxBak.Checked);
        //            DGV.Rows[i].Cells["State"].Value = count.ToString() + "个";
        //            if (count == -1)
        //            {
        //                DGV.Rows[i].Cells["State"].Style.ForeColor = Color.Blue;
        //            }
        //            else if (count != 0)
        //            {
        //                DGV.Rows[i].Cells["State"].Style.ForeColor = Color.Red;
        //            }
        //        }
        //        catch
        //        {
        //            DGV.Rows[i].Cells["State"].Value = "失败";
        //        }
        //    }

        //}

        /// <summary>
        /// 合并文件 
        /// </summary>
        /// <param name="isIncludeMergeData"></param>
        //private void MergeFile(bool isIncludeMergeData)
        //{
        //    if (DGV.Rows.Count == 1)
        //    {
        //        return;
        //    }
        //    List<string> lsFilePath = new List<string>();
        //    for (int i = 0; i < DGV.Rows.Count; i++)
        //    {
        //        if (Common.IsNullTXT(DGV.Rows[i].Cells["FilePath"].Value.ToString()))
        //        {
        //            DGV.Rows[i].Cells["State"].Value = "失败";
        //            return;
        //        }
        //        lsFilePath.Add(DGV.Rows[i].Cells["FilePath"].Value.ToString());
        //    }
        //    bool bl = false;
        //    if (isIncludeMergeData)
        //    {
        //        string mergeData = txbAddDataAmongFiles.Text;
        //        bl = Delete.MergeFile(lsFilePath, mergeData);
        //    }
        //    else
        //    {
        //        bl = Delete.MergeFile(lsFilePath);
        //    }


        //    for (int i = 0; i < DGV.Rows.Count; i++)
        //    {
        //        if (bl == true)
        //        {
        //            DGV.Rows[i].Cells["State"].Value = "成功 √";
        //            DGV.Rows[i].Cells["State"].Style.ForeColor = Color.Red;
        //        }
        //        else
        //        {
        //            DGV.Rows[i].Cells["State"].Value = "失败";
        //        }
        //    }
        //}

        /// <summary>
        /// 合并包括名字
        /// </summary>
        //private void MergeFileName()
        //{
        //    if (DGV.Rows.Count == 1)
        //    {
        //        return;
        //    }
        //    List<string> lsFilePath = new List<string>();
        //    for (int i = 0; i < DGV.Rows.Count; i++)
        //    {
        //        if (Common.IsNullTXT(DGV.Rows[i].Cells["FilePath"].Value.ToString()))
        //        {
        //            DGV.Rows[i].Cells["State"].Value = "失败";
        //            return;
        //        }
        //        lsFilePath.Add(DGV.Rows[i].Cells["FilePath"].Value.ToString());
        //    }
        //    bool bl = false;

        //        string mergeData = txbAddDataAmongFiles.Text;
        //        //bl = Delete.MergeFile(lsFilePath, mergeData);
        //        bl = Delete.MergeFileName(lsFilePath, mergeData);

        //    for (int i = 0; i < DGV.Rows.Count; i++)
        //    {
        //        if (bl == true)
        //        {
        //            DGV.Rows[i].Cells["State"].Value = "成功 √";
        //            DGV.Rows[i].Cells["State"].Style.ForeColor = Color.Red;
        //        }
        //        else
        //        {
        //            DGV.Rows[i].Cells["State"].Value = "失败";
        //        }
        //    }
        //}

        /// <summary>
        /// 隔行合并
        /// </summary>
        //private void MergeFileGeHang()
        //{
        //    if (DGV.Rows.Count == 1)
        //    {
        //        return;
        //    }
        //    List<string> lsFilePath = new List<string>();
        //    for (int i = 0; i < DGV.Rows.Count; i++)
        //    {
        //        if (Common.IsNullTXT(DGV.Rows[i].Cells["FilePath"].Value.ToString()))
        //        {
        //            DGV.Rows[i].Cells["State"].Value = "失败";
        //            return;
        //        }
        //        lsFilePath.Add(DGV.Rows[i].Cells["FilePath"].Value.ToString());
        //    }
        //    bool bl = false;

        //    //bl = Delete.MergeFileName(lsFilePath, mergeData);
        //    bl = Delete.MergeFileGeHang(lsFilePath);

        //    for (int i = 0; i < DGV.Rows.Count; i++)
        //    {
        //        if (bl == true)
        //        {
        //            DGV.Rows[i].Cells["State"].Value = "成功 √";
        //            DGV.Rows[i].Cells["State"].Style.ForeColor = Color.Red;
        //        }
        //        else
        //        {
        //            DGV.Rows[i].Cells["State"].Value = "失败";
        //        }
        //    }
        //}

        /// <summary>
        /// 拆分文件 以奇偶方式拆分
        /// </summary>
        //private void SplitFileByOddEven()
        //{
        //    for (int i = 0; i < DGV.Rows.Count; i++)
        //    {
        //        string filePath = DGV.Rows[i].Cells["FilePath"].Value.ToString();
        //        if (Common.IsNullTXT(filePath))
        //        {
        //            DGV.Rows[i].Cells["State"].Value = "失败";
        //            continue;
        //        }
        //        bool bl = Delete.SplitFileByOddEven(filePath);
        //        if (bl == true)
        //        {
        //            DGV.Rows[i].Cells["State"].Value = "成功 √";
        //            DGV.Rows[i].Cells["State"].Style.ForeColor = Color.Red;
        //        }
        //        else
        //        {
        //            DGV.Rows[i].Cells["State"].Value = "失败";
        //        }
        //    }
        //}

        /// <summary>
        /// 拆分文本文件
        /// </summary>
        /// <param name="splitCount">Count/Line</param>
        /// <param name="blMode">true:Count  false:Line</param>
        //private void SplitFileByCountAndLine(int splitCount,bool blMode)
        //{
        //    //int splitCount = Convert.ToInt32(this.numericUpDown5.Value);
        //    if (splitCount <= 1)
        //    {
        //        return;
        //    }

        //    for (int i = 0; i < DGV.Rows.Count; i++)
        //    {
        //        if (Common.IsNullTXT(DGV.Rows[i].Cells["FilePath"].Value.ToString()))
        //        {
        //            DGV.Rows[i].Cells["State"].Value = "失败";
        //            continue;
        //        }
        //        bool bl = Delete.SplitFile(DGV.Rows[i].Cells["FilePath"].Value.ToString(), splitCount, blMode);
        //        if (bl == true)
        //        {
        //            DGV.Rows[i].Cells["State"].Value = "成功 √";
        //            DGV.Rows[i].Cells["State"].Style.ForeColor = Color.Red;
        //        }
        //        else
        //        {
        //            DGV.Rows[i].Cells["State"].Value = "失败";
        //        }
        //    }
        //}

        /// <summary>
        /// 打开多个文件
        /// </summary>
        //private void OpenFileMult()
        //{
        //    OpenFileDialog fileDialog = new OpenFileDialog();
        //    fileDialog.Multiselect = true;
        //    fileDialog.Title = "请选择文件";
        //    fileDialog.Filter = "所有文件(*.*)|*.*";
        //    if (fileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        List<string> lsFile = new List<string>(fileDialog.FileNames);
        //        AddMemberInDGV(lsFile);               
        //    }
        //}

        /// <summary>
        /// 打开文件添加到dgv
        /// </summary>
        private void OpenFileMult()
        {
            List<string> ls = MyDir.OpenFileMult();
            AddMemberInDGV(ls);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileMult();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteDGV_SelectedRows();
        }

        /// <summary>
        /// 删除DGV中选中的行
        /// </summary>
        private void DeleteDGV_SelectedRows()
        {
            if (DGV.Rows.Count < 1 || DGV.SelectedRows.Count < 1)
            {
                return;
            }

            for (int i = DGV.SelectedRows.Count; i > 0; i--)
            {
                DGV.Rows.RemoveAt(DGV.SelectedRows[i - 1].Index);
            }
        }

        /// <summary>
        /// 删除成功行
        /// </summary>
        private void DeleteDGV_SuccessRows()
        {
            for (int i = 0; i < DGV.Rows.Count; i++)
            {
                if (DGV.Rows[i].Cells["State"].Style.ForeColor == Color.Red)
                {
                    DGV.Rows.RemoveAt(i);
                    i--;
                }
            }
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    //this.Close();
                    break;
                default:
                    break;
            }

            if (e.Control && e.KeyCode == Keys.Enter)
            {
                if (DGV.SelectedRows.Count == 1)
                {
                    //打开文件夹 并且选中某个文件
                    string filePath = DGV.SelectedRows[0].Cells["FilePath"].Value.ToString();
                    if (!File.Exists(filePath))
                    {
                        MessageBox.Show("文件不存在！");
                        return;
                    }
                    MyDir.SystemOpenFolder(filePath);
                }
            }
        }


        private void 默认设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.checkBoxBak.Checked = true;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            this.DGV.Rows.Clear();
        }

        private void btnDeleteSuccess_Click(object sender, EventArgs e)
        {
            DeleteDGV_SuccessRows();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileMult();
        }

        private void btnDeleteNameBak_Click(object sender, EventArgs e)
        {
            if (DGV.Rows.Count == 0)
            {
                return;
            }
            //Delete.DeleteFileNameBak(DGV.Rows[0].Cells["FilePath"].Value.ToString());
            for (int i = 0; i < DGV.Rows.Count; i++)
            {
                bool bl = Delete.DeleteFileNameBak(DGV.Rows[i].Cells["FilePath"].Value.ToString());
                if (bl)
                {
                    DGV.Rows[i].Cells["State"].Value = "命名成功";
                    DGV.Rows[i].Cells["State"].Style.ForeColor = Color.Red;
                }
                else
                {
                    DGV.Rows[i].Cells["State"].Value = "命名失败";
                }
            }
        }

        private void 帮助HToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 打开文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAddFolder();            
        }

        private void AddFileFromFolder(string sFolder)
        {
            if(sFolder == "")
            {
                return;
            }
            try
            {
                DirectoryInfo dir = new DirectoryInfo(sFolder);

                FileInfo[] files = dir.GetFiles("*.*");

                List<string> lsFile = new List<string>();
                foreach (FileInfo fi in files)
                {
                    lsFile.Add(fi.FullName);
                }

                List<string> ls = new List<string>();
                AddMemberInDGV(lsFile);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (DGV.Rows.Count == 0)
            { return; }
            //Delete.DeleteFileNameBak(DGV.Rows[0].Cells["FilePath"].Value.ToString());

            List<string> ls = new List<string>();
            for (int i = 0; i < DGV.Rows.Count; i++)
            {
                string filePath = DGV.Rows[i].Cells["FilePath"].Value.ToString();
                string newFilePath = Common.GetFilePathWithoutExtension(filePath);

                string newFileName = Delete.GetNewFileName(filePath);
                ls.Add(newFilePath + newFileName + ".txt");

                string newFileFullName = newFilePath + newFileName + ".txt";
                // DGV.Rows[i].Cells["State"].Value = "";

                try
                {
                    if (File.Exists(newFileFullName))
                    {
                        File.Delete(newFileFullName);
                        DGV.Rows[i].Cells["State"].Style.ForeColor = Color.Blue;
                    }
                    File.Move(filePath, newFileFullName);
                    DGV.Rows[i].Cells["State"].Value = "命名成功";
                    DGV.Rows[i].Cells["State"].Style.ForeColor = Color.Red;
                }
                catch
                {
                    DGV.Rows[i].Cells["State"].Value = "命名失败";
                }
            }
            //File.WriteAllLines(@"I:\00.txt", ls.ToArray());
        }

        //开始删除数据
        private void ReplaceDeleteMulData(string newString)
        {
            if (txbDelOldData.Text == "")
            {
                return;
            }

            string sourceString = txbDelOldData.Text;

            for (int i = 0; i < DGV.Rows.Count; i++)
            {
                try
                {
                    string filePath = DGV.Rows[i].Cells["FilePath"].Value.ToString();
                    if (Common.IsNullTXT(DGV.Rows[i].Cells["FilePath"].Value.ToString()))
                    {
                        DGV.Rows[i].Cells["State"].Value = "失败";
                        continue;
                    }
                    //int count = Delete.DeleteMulti(DGV.Rows[i].Cells["FilePath"].Value.ToString(), sourceString, checkBoxBak.Checked);
                    int count = Delete.ReplaceDeleteMulti(filePath, sourceString, newString, checkBoxBak.Checked);
                    DGV.Rows[i].Cells["State"].Value = count.ToString() + "个";
                    if (count == -1)
                    {
                        DGV.Rows[i].Cells["State"].Style.ForeColor = Color.Blue;
                    }
                    else if (count != 0)
                    {
                        DGV.Rows[i].Cells["State"].Style.ForeColor = Color.Red;
                    }
                }
                catch
                {
                    DGV.Rows[i].Cells["State"].Value = "失败";
                }
            }
        }

        
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {

            ///批量删除行
            if (e.TabPage == tpDeleteLine)
            {
                InitDeleteLine_ComboBox();
                return;
            }
            ///批量删除数据
            if (e.TabPage == tpDeleteData)
            {
                InitComboBoxDeleteData();
                InitPanelFirstLastOfLine();
                return;

            }
            ///其他选项
            if (e.TabPage == tpOther)
            {
                this.btnStart.Text = "正在添加";
                InitComboBoxOther();
                if (!radioBtnANSI.Checked && !radioBtnUnicode.Checked &&
                    !radioBtnUnicodeBigEndian.Checked && !radioBtnUTF_8.Checked)
                {
                    this.radioBtnANSI.Checked = true;
                }

                if(!radioBtnSortUp.Checked && !radioBtnSortDown.Checked)
                {
                    this.radioBtnSortUp.Checked = true;
                }

                return;
            }

            ///合并
            if (e.TabPage == tpMerge)
            {
                InitMergeComboBox();
                InitMergeLeftRightData();
                return;

            }
            ///拆分
            if (e.TabPage == tpSplit)
            {
                InitComboBoxSplit();
                return;
            }
            ///添加数据
            if(e.TabPage == tpAddData)
            {
                InitAddData_ComboBox();
                return;
            }

        }

        private void InitAddData_ComboBox()
        {
            switch (this.comboBoxAddData.Text)
            {
                case "添加到文件的首尾":
                    this.panelAddData_TopEndOfFile.Show();
                    this.panelAddData_TopEndOfLine.Hide();
                    this.panelAddData_FileName.Hide();
                    this.btnStart.Text = "开始添加到文件的首尾";
                    break;
                case "添加到行的首尾":
                    this.panelAddData_TopEndOfFile.Hide();
                    this.panelAddData_TopEndOfLine.Show();
                    this.panelAddData_FileName.Hide();
                    InitCheckBoxAddDataTopLine();
                    InitCheckBoxAddDataEndLine();
                    this.btnStart.Text = "开始添加到行的首尾";
                    break;
                case "添加文件名到文件":
                    this.panelAddData_TopEndOfFile.Hide();
                    this.panelAddData_TopEndOfLine.Hide();
                    this.panelAddData_FileName.Show();
                    this.btnStart.Text = "开始添加文件名到文件";
                    break;
                default:
                    this.btnStart.Text = "还没做";
                    break;
            }
        }

        private void InitPanelFirstLastOfLine()
        {
            if (checkBoxDel_DataTopOfLine.Checked)
            {
                //this.numericUpDownCountZiFu.Enabled = false;
                //txbCountZiFu.Enabled = true;
                this.label25.Text = "您输入的是0个字符";
                this.txbCountZiFu.Text = "";
            }
            else
            {
                //txbCountZiFu.Enabled = false;
                //this.numericUpDownCountZiFu.Enabled = true;
                this.label25.Text = "：一个字母一个数字一个汉字都是一个字符";
                this.txbCountZiFu.Text = "";
            }

            this.nudDelData_CountZiFu.Enabled = !checkBoxDel_DataTopOfLine.Checked;
            this.txbCountZiFu.Enabled = checkBoxDel_DataTopOfLine.Checked;

        }

        private void InitComboBoxDeleteData()
        {
            switch (this.comboBoxDeleteData.Text)
            {
                case "删除文本":
                    InitDeleteData();
                    this.panelDeleteReplaceData.Show();
                    this.panelDelData_FirstLastOfLine.Hide();
                    break;
                case "替换文本":
                    InitReplaceData();
                    this.panelDeleteReplaceData.Show();
                    this.panelDelData_FirstLastOfLine.Hide();
                    break;
                case "删除行首数字":
                    this.panelDeleteReplaceData.Hide();
                    this.panelDelData_FirstLastOfLine.Hide();
                    this.btnStart.Text = "开始删除行首数字";
                    break;
                case "删除行首字符":
                    this.panelDeleteReplaceData.Hide();
                    this.panelDelData_FirstLastOfLine.Show();
                    this.label23.Text = "删除行首";
                    this.btnStart.Text = "开始删除行首字符";
                    break;
                case "删除行尾字符":
                    this.panelDeleteReplaceData.Hide();
                    this.panelDelData_FirstLastOfLine.Show();
                    this.label23.Text = "删除行尾";
                    this.btnStart.Text = "开始删除行尾字符";
                    break;
                default:
                    MessageBox.Show("还没做呢");
                    break;
            }
        }

        private void InitReplaceData()
        {
            this.label10.Visible = true;
            this.txbDelNewData.Visible = true;
            this.label5.Text = "要替换的原文本:";
            this.btnStart.Text = "开始替换数据";
        }

        private void InitDeleteData()
        {
            this.label10.Visible = false;
            this.txbDelNewData.Visible = false;
            this.label5.Text = "批量删除的文本:";
            this.btnStart.Text = "开始删除数据";
        }


        private void InitComboBoxSplit()
        {
            switch (this.comboBoxSplit.Text)
            {
                case "拆分固定个数":
                    InitSplitCount();
                    break;
                case "拆分固定行数":
                    InitSplitLine();
                    break;
                case "含有特定字符":
                    this.btnStart.Text = "拆分by特定字符";
                    break;
                case "拆分奇偶行":
                    this.btnStart.Text = "拆分奇偶行";
                    break;
                default:
                    this.btnStart.Text = "还没做";
                    break;
            }
        }

        private void InitSplitLine()
        {
            nudSplit_Count.Enabled = false;
            nudSplit_Line.Enabled = true;
            this.btnStart.Text = "拆分固定行数";
        }

        private void InitSplitCount()
        {
            nudSplit_Count.Enabled = true;
            nudSplit_Line.Enabled = false;
            this.btnStart.Text = "拆分固定个数";
        }

        private void btnBrowerAdd_Click(object sender, EventArgs e)
        {
            if (txbOtherFilePath.Text == "")
            {
                return;
            }
            try
            {
                if(!MyString.IsDirectory(txbOtherFilePath.Text))
                {
                    MessageBox.Show("文件夹不正确！");
                    return; 
                }
                AddFileFromFolder(txbOtherFilePath.Text);
            }
            catch
            {
                return;
            }

        }

        private void txbFilePath_Click(object sender, EventArgs e)
        {
            txbOtherFilePath.Text = Clipboard.GetText();
        }

        //初始化连续
        void InitLianXu()
        {
            nudDelLine_TopLineFile.Enabled = false;
            nudDelLine_LastLineFile.Enabled = false;
            nudDelLine_ContinueFirst.Enabled = true;
            nudDelLine_ContinueLast.Enabled = true;
            btnStart.Text = "开始删除连续行";
        }

        //初始化前后
        void InitFrotLast()
        {
            nudDelLine_TopLineFile.Enabled = true;
            nudDelLine_LastLineFile.Enabled = true;
            nudDelLine_ContinueFirst.Enabled = false;
            nudDelLine_ContinueLast.Enabled = false;
            btnStart.Text = "开始删除前后行";
        }

        private void txbDeleteText_Click(object sender, EventArgs e)
        {
            txbDelOldData.Text = Clipboard.GetText();
        }


        private void InitDeleteLine_ComboBox()
        {
            switch (this.comboBoxDeleteLine.Text)
            {
                case "删除前后行":
                    InitFrotLast();
                    this.panelDelLine1.Show();
                    this.panelDelLine_TeDing.Hide();
                    this.panelDelLine_KeyWords.Hide();
                    break;
                case "删除连续行":
                    InitLianXu();
                    this.panelDelLine1.Show();
                    this.panelDelLine_TeDing.Hide();
                    this.panelDelLine_KeyWords.Hide();
                    break;
                case "删除奇数行":
                    this.btnStart.Text = "开始删除奇数行";
                    this.panelDelLine1.Hide();
                    this.panelDelLine_TeDing.Hide();
                    this.panelDelLine_KeyWords.Hide();
                    break;
                case "删除偶数行":
                    this.btnStart.Text = "开始删除偶数行";
                    this.panelDelLine1.Hide();
                    this.panelDelLine_TeDing.Hide();
                    this.panelDelLine_KeyWords.Hide();
                    break;
                case "删除空白行":
                    this.btnStart.Text = "开始删除空白行";
                    this.panelDelLine1.Hide();
                    this.panelDelLine_TeDing.Hide();
                    this.panelDelLine_KeyWords.Hide();
                    break;
                case "删除重复行":
                    this.btnStart.Text = "开始删除重复行";
                    this.panelDelLine1.Hide();
                    this.panelDelLine_TeDing.Hide();
                    this.panelDelLine_KeyWords.Hide();
                    break;
                case "删除特定行":
                    this.btnStart.Text = "开始删除特定行";
                    this.panelDelLine1.Hide();
                    this.panelDelLine_TeDing.Show();
                    this.panelDelLine_KeyWords.Hide();
                    break;
                case "删除含有关键字的行":
                    this.btnStart.Text = "开始删除含有关键字的行";
                    this.panelDelLine1.Hide();
                    this.panelDelLine_TeDing.Hide();
                    this.panelDelLine_KeyWords.Show();
                    InitDeleteLine_CheckBoxKeyWords();
                    break;
                default:
                    break;
            }
        }

        private void btnUpMove_Click(object sender, EventArgs e)
        {
            if (DGV.Rows.Count <= 1)
            {
                return;
            }
            List<FilePathNameState> dataList = new List<FilePathNameState>();

            for (int i = 0; i < DGV.Rows.Count; i++)
            {
                FilePathNameState usIfo = new FilePathNameState();
                usIfo.FilePath = DGV.Rows[i].Cells["FilePath"].Value.ToString();
                usIfo.FileName = DGV.Rows[i].Cells["FileName"].Value.ToString();
                usIfo.State = DGV.Rows[i].Cells["State"].Value.ToString();
                dataList.Add(usIfo);
            }

            //获取当前行
            int currentRowIndex = DGV.SelectedRows[0].Index;
            //如果当前行不是第一行
            if (currentRowIndex > 0)
            {
                //获取当前行的上一行的索引

                int nextRowIndex = currentRowIndex - 1;

                //当前行绑定的数据对象
                FilePathNameState currentUserInfo = dataList[currentRowIndex];
                //下一行绑定的数据对象
                FilePathNameState nextUserInfo = dataList[nextRowIndex];

                //将数据对象位置互换
                dataList[currentRowIndex] = nextUserInfo;
                dataList[nextRowIndex] = currentUserInfo;

                DGV.Rows.Clear();
                foreach (FilePathNameState us in dataList)
                {
                    DGV.Rows.Add(us.FilePath, us.FileName, us.State);
                }
                DGV.Rows[0].Selected = false;


                DGV.Rows[nextRowIndex].Selected = true;
            }
        }

        private void btnDownMove_Click(object sender, EventArgs e)
        {
            if (DGV.Rows.Count <= 1)
            {
                return;
            }
            List<FilePathNameState> dataList = new List<FilePathNameState>();

            for (int i = 0; i < DGV.Rows.Count; i++)
            {
                FilePathNameState usIfo = new FilePathNameState();
                usIfo.FilePath = DGV.Rows[i].Cells["FilePath"].Value.ToString();
                usIfo.FileName = DGV.Rows[i].Cells["FileName"].Value.ToString();
                usIfo.State = DGV.Rows[i].Cells["State"].Value.ToString();
                dataList.Add(usIfo);
            }

            //获取当前行
            int currentRowIndex = DGV.SelectedRows[0].Index;
            //如果当前行不是第一行
            if (currentRowIndex < DGV.Rows.Count - 1)
            {
                //获取当前行的上一行的索引

                int nextRowIndex = currentRowIndex + 1;

                //当前行绑定的数据对象
                FilePathNameState currentUserInfo = dataList[currentRowIndex];
                //下一行绑定的数据对象
                FilePathNameState nextUserInfo = dataList[nextRowIndex];

                //将数据对象位置互换
                dataList[currentRowIndex] = nextUserInfo;
                dataList[nextRowIndex] = currentUserInfo;

                DGV.Rows.Clear();
                foreach (FilePathNameState us in dataList)
                {
                    DGV.Rows.Add(us.FilePath, us.FileName, us.State);
                }
                DGV.Rows[0].Selected = false;


                DGV.Rows[nextRowIndex].Selected = true;
            }
        }

        private void comboBoxModeSplit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            InitComboBoxSplit();
        }

        private void txbFileDelete_Click(object sender, EventArgs e)
        {
            txbOtherFilePath.Text = Clipboard.GetText();
        }

        private void txbFileShaiXuan_Click(object sender, EventArgs e)
        {
            txbOtherFilePath.Text = Clipboard.GetText();
        }

        private void btnFile1DeleteBrowser_Click(object sender, EventArgs e)
        {
            this.txbFileDelete.Text = MyDir.OpenFileOne();
        }

        //private string OpenFileOne()
        //{
        //    OpenFileDialog fileDialog = new OpenFileDialog();
        //    fileDialog.Multiselect = false;
        //    fileDialog.Title = "请选择文件";
        //    fileDialog.Filter = "文件(*.*)|*.*";
        //    if (fileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        return fileDialog.FileName;
        //    }
        //    else
        //    {
        //        return "";
        //    }
        //}

        private void btnFile2DeleteBrower_Click(object sender, EventArgs e)
        {
            this.txbFileShaiXuan.Text = MyDir.OpenFileOne();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            Encoding enSource = Encoding.Default;
            Encoding enFilter = Encoding.Default;
            try
            {
                enSource = FileEncoding.EncodingType.GetType(txbFileDelete.Text);
                enFilter = FileEncoding.EncodingType.GetType(txbFileShaiXuan.Text);
                List<string> lsFileSource = new List<string>(File.ReadAllLines(txbFileDelete.Text, enSource));
                List<string> lsFileFilter = new List<string>(File.ReadAllLines(txbFileShaiXuan.Text, enFilter));
                for (int i = 0; i < lsFileSource.Count; i++)
                {
                    if (ListContain(lsFileSource.ElementAt(i), ref lsFileFilter))
                    {
                        lsFileSource.RemoveAt(i);
                        i--;
                    }
                }

                File.WriteAllLines(txbFileDelete.Text + ".bak", lsFileSource.ToArray(), enSource);
                File.WriteAllLines(txbFileShaiXuan.Text + ".bak", lsFileFilter.ToArray(), enFilter);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static bool ListContain(string source, ref List<string> lsFileFilter)
        {
            for (int i = 0; i < lsFileFilter.Count; i++)
            {
                if (source.Contains(lsFileFilter.ElementAt(i)))
                {
                    lsFileFilter.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        private void checkBoxAddDataAmongFiles_Click(object sender, EventArgs e)
        {
            InitMergeData();
        }

        private void InitMergeData()
        {
            if (this.checkBoxMerge_AddDataAmongFiles.Checked)
            {
                this.btnStart.Text = "开始合并+数据";
                this.txbMerge_AddDataAmongFiles.Enabled = true;
                this.checkBoxMerge_AddFileName.Enabled = true;
            }
            else
            {
                this.btnStart.Text = "开始合并";
                this.txbMerge_AddDataAmongFiles.Text = "";
                this.checkBoxMerge_AddFileName.Enabled = false;
                this.txbMerge_AddDataAmongFiles.Enabled = false;
            }
        }

        private void 产生一个10000行数字ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 0;

            List<string> ls = new List<string>();
            for (; i < 1000; i++)
            {
                ls.Add(i.ToString());
            }

            File.WriteAllLines("d:\\o.txt", ls.ToArray());
            MessageBox.Show("d:\\o.txt生成成功!");
        }

        private void checkBoxAddFileName_Click(object sender, EventArgs e)
        {
            InitMergeAddData();
        }

        private void InitMergeAddData()
        {
            if (this.checkBoxMerge_AddFileName.Checked)
            {
                this.btnStart.Text = "开始合并+数据+文件名";
            }
            else
            {
                this.btnStart.Text = "开始合并+数据";
            }
        }

        private void comboBoxModeMerge_SelectionChangeCommitted(object sender, EventArgs e)
        {
            InitMergeComboBox();
        }

        private void InitMergeComboBox()
        {
            switch (this.comboBoxMerge.Text)
            {
                case "普通合并":
                    this.panelMerge_AddDataAmongFile.Hide();
                    this.panelMerge_GeHang.Hide();
                    this.panelMerge_LeftRight.Hide();
                    this.btnStart.Text = "开始合并";
                    break;
                case "合并+数据":
                    InitMergeAddData();
                    this.panelMerge_AddDataAmongFile.Show();
                    this.panelMerge_LeftRight.Hide();
                    this.panelMerge_GeHang.Hide();
                    break;
                case "隔行合并":
                    this.btnStart.Text = "开始隔行合并";
                    this.panelMerge_LeftRight.Hide();
                    this.panelMerge_AddDataAmongFile.Hide();
                    this.panelMerge_GeHang.Show();
                    break;
                case "左右合并":
                    this.btnStart.Text = "开始左右合并(2个文件)";
                    this.panelMerge_AddDataAmongFile.Hide();
                    this.panelMerge_LeftRight.Show();
                    this.panelMerge_GeHang.Hide();
                    break;
                default:
                    this.btnStart.Text = "还没做";
                    break;
            }
        }

        private void checkBoxMergeLeftRightAddData_Click(object sender, EventArgs e)
        {
            InitMergeLeftRightData();
        }

        private void InitMergeLeftRightData()
        {
            if (checkBoxMerge_LeftRightAddData.Checked)
            {
                this.txbMerge_LeftRightData.Enabled = true;
                this.txbMerge_LeftRightData.Text = "";
            }
            else
            {
                this.txbMerge_LeftRightData.Enabled = false;
                this.txbMerge_LeftRightData.Text = "";
            }
        }

        private void txbCountZiFu_Leave(object sender, EventArgs e)
        {
            label25.Text = "您输入的是 " + this.txbCountZiFu.Text.Length + " 个字符";
        }

        private void comboBoxDeleteData_SelectionChangeCommitted(object sender, EventArgs e)
        {
            InitComboBoxDeleteData();
        }

        private void checkBoxDeleteFirstOfLine_Click(object sender, EventArgs e)
        {
            InitPanelFirstLastOfLine();
        }

        private void btnClearState_Click(object sender, EventArgs e)
        {
            DeleteDGV_State();
        }

        private void DeleteDGV_State()
        {
            for (int i = 0; i < DGV.Rows.Count; i++)
            {
                this.DGV.Rows[i].Cells["State"].Value = "";
            }
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            OpenAddFolder();
        }

        private void OpenAddFolder()
        {
            string ss = MyDir.OpenFileFolder();
            AddFileFromFolder(ss);
        }

        private void comboBoxDeleteLine_SelectionChangeCommitted(object sender, EventArgs e)
        {
            InitDeleteLine_ComboBox();
        }

        private void checkBoxKeyWord_Click(object sender, EventArgs e)
        {
            InitDeleteLine_CheckBoxKeyWords();
        }

        private void InitDeleteLine_CheckBoxKeyWords()
        {
            if (this.checkBoxDelLine_KeyWord.Checked)
            {
                this.checkBoxDelLine_KeyWord.Text = "现在有多个关键字，删除同时含有这几个关键字的行";
                this.label32.Show();
                this.label33.Show();
            }
            else
            {
                this.checkBoxDelLine_KeyWord.Text = "现在是只有一个关键字，删除含有这个关键字的行";
                this.label32.Hide();
                this.label33.Hide();
            }
        }


        private void DGV_SelectionChanged(object sender, EventArgs e)
        {
            InitDGV_ContextMenuStrip();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteDGV_SelectedRows();
        }

        private void 全部删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DGV.Rows.Clear();
        }

        private void 删除成功行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteDGV_SuccessRows();
        }

        private void 清空状态ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteDGV_State();
        }

        private void 清除选中状态ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DGV.ClearSelection();
        }

        private void 整理列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteDGV_IllegalLine();
        }

        /// <summary>
        /// 整理列表 删除非文本文件
        /// </summary>
        private void DeleteDGV_IllegalLine()
        {
            for (int i = 0; i < DGV.Rows.Count; i++)
            {
                if (Common.IsNullTXT(DGV.Rows[i].Cells["FilePath"].Value.ToString()))
                {
                    DGV.Rows.RemoveAt(i);
                    i--;
                }
            }
        }

        private void 添加文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileMult();
        }

        private void 添加文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAddFolder();
        }

        private void 复制文件路径ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.DGV.SelectedRows[0].Cells["FilePath"].Value.ToString());
        }

        private void 复制文件名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.DGV.SelectedRows[0].Cells["FileName"].Value.ToString());
        }

        private void 文件详细信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = this.DGV.SelectedRows[0].Cells["FilePath"].Value.ToString();
            if (!File.Exists(filePath))
            {
                MessageBox.Show("文件不存在！");
                return;
            }

            FormFileData formFileData = new FormFileData(filePath);
            formFileData.ShowDialog();
        }

        private void 打开文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = this.DGV.SelectedRows[0].Cells["FilePath"].Value.ToString();
            if (!File.Exists(filePath))
            {
                MessageBox.Show("文件不存在！");
                return;
            }
            System.Diagnostics.Process.Start(filePath);
        }

        private void 打开文件夹ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string filePath = this.DGV.SelectedRows[0].Cells["FilePath"].Value.ToString();
            if (!File.Exists(filePath))
            {
                MessageBox.Show("文件不存在！");
                return;
            }
            MyDir.SystemOpenFolder(filePath);
        }

        private void 统计行数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            long sum = 0;
            string filePath = "";
            for (int i = 0; i < DGV.Rows.Count; i++)
            {
                filePath = DGV.Rows[i].Cells["FilePath"].Value.ToString();

                int count = Common.GetCountLine(filePath);
                sum += count;
                this.DGV.Rows[i].Cells["State"].Value = count.ToString() + "行";

            }
            MessageBox.Show("总共" + sum.ToString() + "行");
        }

        private void 统计字数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            long sum = 0;
            string filePath = "";
            for (int i = 0; i < DGV.Rows.Count; i++)
            {
                filePath = DGV.Rows[i].Cells["FilePath"].Value.ToString();

                long count = Common.GetCountZiFuOfFile(filePath);
                sum += count;
                this.DGV.Rows[i].Cells["State"].Value = count.ToString() + "字";

            }
            MessageBox.Show("总共" + sum.ToString() + "字");
        }

        private void comboBoxAddData_SelectionChangeCommitted(object sender, EventArgs e)
        {
            InitAddData_ComboBox();
        }

        private void InitCheckBoxAddDataTopLine()
        {
            this.txbAddData_TopLine.Enabled = checkBoxAddData_TopLine.Checked;
            this.checkBoxAddData_ContainNumber.Enabled = checkBoxAddData_TopLine.Checked;
            if(checkBoxAddData_TopLine.Checked)
            {
                InitCheckBoxIsContainNumber();
            }
            else
            {
                this.txbAddData_TopLine.Text = "";
                this.checkBoxAddData_ContainNumber.Checked = false;
                this.nudAddData_TopLine.Hide();
                this.label35.Hide();
            }
        }

        private void checkBoxIsContainNumber_Click(object sender, EventArgs e)
        {
            InitCheckBoxIsContainNumber();
        }

        private void InitCheckBoxIsContainNumber()
        {
            if (checkBoxAddData_ContainNumber.Checked)
            {
                this.nudAddData_TopLine.Show();
                this.label35.Show();
            }
            else
            {
                this.nudAddData_TopLine.Hide();
                this.label35.Hide();
            }
        }

        private void checkBoxAddDataTopLine_Click(object sender, EventArgs e)
        {
            InitCheckBoxAddDataTopLine();
        }

        private void checkBoxAddDataEndLine_Click(object sender, EventArgs e)
        {
            InitCheckBoxAddDataEndLine();
        }

        private void InitCheckBoxAddDataEndLine()
        {
            this.txbAddData_EndLine.Enabled = this.checkBoxAddData_EndLine.Checked;
            if(!checkBoxAddData_EndLine.Checked)
            {
                this.txbAddData_EndLine.Text = "";
            }
        }

        private void InitComboBoxOther()
        {
            switch (this.comboBoxOtherType.Text)
            {                  
                case "添加文件夹":
                    this.btnStart.Text = "开始添加文件夹";
                    this.panelOtherAddFolder.Show();
                    this.panelOtherRename.Hide();
                    this.panelOtherFind.Hide();
                    this.panelOtherChangeFileType.Hide();
                    this.panelOtherSort.Hide();
                    break;

                case "重命名":
                    this.btnStart.Text = "开始重命名";
                    this.panelOtherAddFolder.Hide();
                    this.panelOtherRename.Show();
                    this.panelOtherFind.Hide();
                    this.panelOtherChangeFileType.Hide();
                    this.panelOtherSort.Hide();
                    break;

                case "恢复备份文件":
                    this.btnStart.Text = "开始恢复备份文件";
                    this.panelOtherAddFolder.Hide();
                    this.panelOtherRename.Hide();
                    this.panelOtherFind.Hide();
                    this.panelOtherChangeFileType.Hide();
                    this.panelOtherSort.Hide();
                    break;

                case "查找个数":
                    this.btnStart.Text = "开始查找";
                    this.panelOtherAddFolder.Hide();
                    this.panelOtherRename.Hide();
                    this.panelOtherFind.Show();
                    this.panelOtherChangeFileType.Hide();
                    this.panelOtherSort.Hide();
                    break;            

                case "转换编码":
                    this.btnStart.Text = "开始转换编码";
                    this.panelOtherAddFolder.Hide();
                    this.panelOtherRename.Hide();
                    this.panelOtherFind.Hide();
                    this.panelOtherChangeFileType.Show();
                    this.panelOtherSort.Hide();
                    break;

                case "重新排序":
                    this.btnStart.Text = "开始排序";
                    this.panelOtherAddFolder.Hide();
                    this.panelOtherRename.Hide();
                    this.panelOtherFind.Hide();
                    this.panelOtherChangeFileType.Hide();
                    this.panelOtherSort.Show();
                    break;

                default:
                    this.btnStart.Text = "还没做";
                    break;
            }
        }

        private void comboBoxOtherType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            InitComboBoxOther();
        }

        private void 捐赠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDonate formDonate = new FormDonate();
            formDonate.ShowDialog();
        }

        private void 关于我们ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp fm = new FormHelp();
            fm.ShowDialog();
        }

        private void comboBox_DealMultiLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitDealMultiLine();
        }


        private void InitDealMultiLine()
        {
            switch (this.comboBox_DealMultiLine.Text)
            {
                case "替换指定行之间内容":
                    this.btnStart.Text = "开始替换指定行之间";
                    this.panel_dealMultiLine2.Show();
                    this.panel_DealMultiLine.Hide();
                    break;

                case "筛选文件":
                    this.btnStart.Text = "开始筛选文件";
                    this.panel_DealMultiLine.Show();
                    this.panel_dealMultiLine2.Hide();
                    break;

                default:
                    this.btnStart.Text = "还没做";
                    break;
            }
        }
    }
}

