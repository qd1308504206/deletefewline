using System;
using System.IO;
using System.Windows.Forms;

namespace DeleteFirstFewLine
{
    public partial class FormFileData : Form
    {

        public FormFileData(string filePath)
        {
            InitializeComponent();
            this.filePath = filePath;
        }

        private string filePath = "";
        private void btnConform_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormFileData_Load(object sender, EventArgs e)
        {
            string fileName = System.IO.Path.GetFileName(filePath);
            string fileType = System.IO.Path.GetExtension(filePath);
            FileInfo fi = new FileInfo(filePath);

            if(fi.Length < 1024)
            {
                this.labelFileSize.Text = labelFileSize.Text + fi.Length.ToString() + "B";
            }
            if(fi.Length >= 1024 && fi.Length < 1024 * 1024)
            {
                string fileSize = Math.Round(fi.Length / 1024.0, 2).ToString();
                this.labelFileSize.Text = labelFileSize.Text + fileSize.ToString() + "KB";               
            }

            if (fi.Length >=  1024 * 1024)
            {
                string fileSize = Math.Round((fi.Length / 1024.0)/1024.0, 2).ToString();
                this.labelFileSize.Text = labelFileSize.Text + fileSize.ToString() + "MB";
            }
            
            string fileCountZiFu = Common.GetCountZiFuOfFile(filePath).ToString();
            string fileCountLine = Common.GetCountLine(filePath).ToString();

            this.labelFilePath.Text = labelFilePath.Text + filePath;
            this.labelFileName.Text = labelFileName.Text + fileName;
            
            this.labelFileType.Text = labelFileType.Text + fileType + "文件";
            this.labelFileCountLine.Text = labelFileCountLine.Text + fileCountLine + "行";
            this.labelFileCountZiShu.Text = labelFileCountZiShu.Text + fileCountZiFu + "字";

        }
    }
}
