using System;
using System.Collections.Generic;

namespace DeleteFirstFewLine
{
    public class Common
    {



        public static bool IsContainTopByList(List<string> lsSource, List<string> lsAdd)
        {
            if (lsSource == null || lsSource.Count == 0 || lsAdd == null || lsSource.Count < lsAdd.Count)
            {
                return false;
            }
            if (lsAdd.Count == 0)
            {
                return true;
            }
            for (int i = 0; i < lsAdd.Count; i++)
            {
                if(lsAdd[i] != lsSource[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsContainEndByList(List<string> lsSource, List<string> lsAdd)
        {
            if (lsSource == null || lsSource.Count == 0 || lsAdd == null || lsSource.Count < lsAdd.Count)
            {
                return false;
            }
            if (lsAdd.Count == 0)
            {
                return true;
            }
            int sourceCount = lsSource.Count;
            int addCount = lsAdd.Count;
            sourceCount--;
            addCount--;

            for (; addCount > 0; sourceCount--,addCount-- )
            {
                if(lsSource[sourceCount] != lsAdd[addCount])
                {
                    return false;
                }
            }
                return true;
        }
        public static int GetCountLine(string filePath)
        {
            List<string> ls = MyString.GetListStrFromFile(filePath);
            return ls.Count;
        }
        public static long GetCountZiFuOfFile(string filePath)
        {
            List<string> ls = MyString.GetListStrFromFile(filePath);
            if (ls.Count == 0)
            {
                return 0;
            }
            long ll = 0;
            foreach (string str in ls)
            {
                ll += str.Length;
            }
            return ll;

        }
        public static bool ContainListString(string str, List<string> ls)
        {
            if (str == null || str == "")
            {
                return false;
            }
            try
            {
                foreach (string s in ls)
                {
                    if (!str.Contains(s))
                    {
                        return false;
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        //public static string GetFileNameFromPath(string path)
        //{
        //    //string fileName = "";

        //    //int pos = path.LastIndexOf("\\");

        //    //if (pos == -1)
        //    //{ return ""; }

        //    //fileName = path.Substring(pos + 1);
        //    //return fileName;
        //    return System.IO.Path.GetFileName(path);
        //}

        public static string GetFolderFromPath(string path)
        {
            string fileFolder = "";

            int pos = path.LastIndexOf("\\");

            if (pos == -1)
            { return ""; }

            fileFolder = path.Substring(0, pos);
            return fileFolder;
        }

        /// <summary>
        /// 获得文件的full路径 除了 后缀名。
        /// </summary>
        /// <param name="filePath">文件原始路径</param>
        /// <returns></returns>
        public static string GetFilePathWithoutExtension(string filePath)
        {
            //int pos = filePath.LastIndexOf(".");
            ////做到这里了。这里有问题pos判断
            //string newFilePath = filePath.Substring(0, pos);
            //return newFilePath;
            try
            {
                return System.IO.Path.GetDirectoryName(filePath) + "\\"
                    + System.IO.Path.GetFileNameWithoutExtension(filePath);
            }
            catch
            {
                return "";
            }
        }

        public static bool IsNullTXT(string path)
        {
            int pos = path.LastIndexOf(".");
            path = path.Substring(pos + 1);
            path = path.ToLower();
            if (path == "exe" || path == "rar" || path == "zip" || path == "iso" || path == "pdf" ||
               path == "doc" || path == "docx" || path == "xls" || path == "xlsx" || path == "ppt" ||
               path == "pptx" || path == "lnk" || path == "mp3" || path == "wav" || path == "mp4" ||
               path == "swf" || path == "png" || path == "bmp" || path == "avi" || path == "gif" ||
               path == "jpg" || path == "rmvb" || path == "csf" || path == "sys" || path == "dll" ||
               path == "wmv" || path == "wav" || path == "ico")
            { return true; }
            else { return false; }

        }

        public static bool IsIntOfString(string str)
        {
            try
            {
                Convert.ToInt32(str);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool IsOnlySpace(string source)
        {
            source = source.Replace("\t", "");
            source = source.Replace(" ", "");
            source = source.Replace("　", "");
            if (source == "")
            { return true; }
            else
            { return false; }
        }

        public static List<string> MergeList(List<string> list1, List<string> list2)
        {
            if (list1.Count == 0)
            {
                return list2;
            }
            if (list2.Count == 0)
            {
                return list1;
            }
            list1.AddRange(list2);
            return list1;
        }

        public static List<string> MergeList(string str, List<string> list1)
        {
            if (str == null)
            {
                return list1;
            }
            List<string> ls = new List<string>();
            ls.Add(str);
            ls.AddRange(list1);
            return ls;
        }

        public static string GetFileNameOfFullName(string filePath, bool IsContainDir, bool IsContainExtension)
        {
            try
            {
                if(IsContainDir && IsContainExtension)
                {
                    return filePath;
                }
                if(IsContainDir && !IsContainExtension)
                {
                    return System.IO.Path.GetDirectoryName(filePath) + "\\" + System.IO.Path.GetFileNameWithoutExtension(filePath);
                }
                if(!IsContainDir && IsContainExtension)
                {
                    return System.IO.Path.GetFileName(filePath);
                }
                if(!IsContainDir && !IsContainExtension)
                {
                    return System.IO.Path.GetFileNameWithoutExtension(filePath);
                }
                return "";
            }
            catch
            {
                return "";
            }
        }
    }
}
