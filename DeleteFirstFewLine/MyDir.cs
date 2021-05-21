using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace DeleteFirstFewLine
{
    public class MyDir
    {
        public static List<string> OpenFileMult()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                List<string> lsFile = new List<string>(fileDialog.FileNames);
                return lsFile;
            }
            else
            {
                return new List<string>();
            }         
        }

        public static void SystemOpenFolder(string filePath)
        {
            string args = string.Format("/Select, {0}", filePath);

            ProcessStartInfo pfi = new ProcessStartInfo("Explorer.exe", args);
            System.Diagnostics.Process.Start(pfi);
        }

        public static string OpenFileFolder()
        {
            FolderBrowserDialog browse = new FolderBrowserDialog();
            browse.Description = "请选择文件路径";

            if (browse.ShowDialog() == DialogResult.OK)
            {
               return browse.SelectedPath;              
            }
            return "";
        }

        public static string OpenFileOne()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "文件(*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                return fileDialog.FileName;
            }
            else
            {
                return "";
            }
        }
    }
}
