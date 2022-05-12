using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DeleteFirstFewLine
{
    public class MyString
    {
        public static int CountContainString(string source, string dataFind)
        {
            if (source == null || source == "" || dataFind == null || dataFind == "")
            {
                return 0;
            }
            int count = 0;
            int lenFind = dataFind.Length;
            while (source.Contains(dataFind))
            {
                count++;
                int pos = source.IndexOf(dataFind);
                source = source.Substring(pos + lenFind);
            }
            return count;
        }

        public static bool IsDirectory(string filePath)
        {
            if (File.Exists(filePath))//是文件
            {
                return false;
            }
            else if (Directory.Exists(filePath))//是文件夹
            {
                return true;
            }
            else//什么也不是
            {
                return false;
            }
        }

        //1,2,4,6,8,10获取 List<int>
        public static List<int> GetListIntFromStr(string s)
        {

            if(s == null || s == "")
            {
                return new List<int>();
            }
            List<int> ls = new List<int>();
            try
            {
                List<string> lsStr = new List<string>(s.Split(',').ToArray());
                    
                foreach(string str in lsStr)
                {
                    if(IsIntOfString(str))
                    {
                        ls.Add(Convert.ToInt32(str));
                    }
                }

                for (int i = 0; i < ls.Count - 1; i++ )
                {
                    if(ls[i] >= ls[i+1])
                    {
                        return new List<int>();
                    }
                }

                    return ls;
            }
            catch
            {

                return new List<int>();
            }
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
        /// <summary>
        /// 获取新名称 
        /// </summary>
        /// <param name="fileFullName">源名称 包括完整路径</param>
        /// <param name="adder">添加到原名称的字符，在后缀名前面</param>
        /// <returns>返回新的新名称 如果存在，则备份文件，返回新名称</returns>
        public static string GetNewFileName(string fileFullName, string adder)
        {
            try
            {
                string fileNameWithoutExtension = System.IO.Path.GetDirectoryName(fileFullName) + "\\"
                                                + System.IO.Path.GetFileNameWithoutExtension(fileFullName);
                string fileExtension = System.IO.Path.GetExtension(fileFullName);

                string fileNewFullName =  fileNameWithoutExtension + adder + fileExtension;
                if(File.Exists(fileNewFullName))
                {
                    File.Move(fileNewFullName, fileNewFullName + ".bak");
                }
                return fileNewFullName;
            }
            catch(Exception e)
            {              
                throw e;
            }
        }


        /// <summary>
        /// 获取新名称 
        /// </summary>
        /// <param name="fileFullName">源名称 包括完整路径</param>
        /// <param name="adder">添加到原名称的字符，在后缀名前面</param>
        /// <returns>返回新的新名称 如果存在，则备份文件，返回新名称</returns>
        public static string GetNewFileNameOnly(string fileFullName, string adder)
        {
            try
            {
                string fileNameWithoutExtension = System.IO.Path.GetDirectoryName(fileFullName) + "\\"
                                                + System.IO.Path.GetFileNameWithoutExtension(fileFullName);
                string fileExtension = System.IO.Path.GetExtension(fileFullName);

                string fileNewFullName = fileNameWithoutExtension + adder + fileExtension;
                
                return fileNewFullName;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static string DeleteTopNumber(string str)
        {
            if (str == null || str == "")
            {
                return "";
            }
            string numbers = "0123456789";

            int pos = FindFirstAnyNotOf(str,numbers);
            if(pos != -1)
            {
                str = str.Substring(pos);
                return str;
            }
            else
            {
                return str;
            }
            


        }

        public static int FindFirstAnyNotOf(string source, string numbers)
        {
            if(source == null || source == "")
            {
                return -1;
            }
            if(numbers == null || numbers == "")
            {
                return -1;
            }

            for(int i = 0; i < source.Length; i++)
            {
                if(numbers.Contains(source[i]))
                {
                    continue;
                }
                else
                {
                    return i;
                }
            }
            return -1;
        }
        public static string DeleteTopFewZiFu(string str, int topCount)
        {
            if(str == null || str == "")
            {
                return "";
            }
            if(topCount <= 0)
            {
                return str;
            }
            if(topCount > str.Length)
            {
                return "";
            }
            str = str.Substring(topCount);
            return str;
        }

        public static string DeleteLastFewZiFu(string str, int lastCount)
        {
            if (str == null || str == "")
            {
                return "";
            }
            if (lastCount <= 0)
            {
                return str;
            }
            if (lastCount > str.Length)
            {
                return "";
            }
            str = str.Substring(0, str.Length - lastCount);
            return str;
        }



        /// <summary>
        /// String转换为ListString 以"\r\n"为换行标识符
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static List<string> ConvertToListString(string str)
        {

            List<string> ls = new List<string>(); 
            if (str == null || str == "")
            {
                return ls;
            }
            string strFirst = "";
            while (str.Contains("\r\n"))
            {
                int pos = str.IndexOf("\r\n");
                strFirst = str.Substring(0, pos);
                ls.Add(strFirst);
                str = str.Substring(pos + 2);
            }
            ls.Add(str);
            return ls;
        }
        /// <summary>
        /// remove 重复行
        /// </summary>
        /// <param name="ls">源文件</param>
        /// <returns>输出删除之后的</returns>
        public static List<string> DeleteDuplicateLines(ref List<string> ls)
        {
            List<string> ls2 = new List<string>(ls);
            ls2.Sort();
            List<string> lsRepeat = new List<string>();
            for (int i = 0; i < ls2.Count - 1; )
            {
                if (ls2.ElementAt(i) == ls2.ElementAt(i + 1))
                {
                    lsRepeat.Add(ls2.ElementAt(i));
                }
                ls2.RemoveAt(i);
            }
            for (int i = 0; i < lsRepeat.Count; i++)
            {
                string u = lsRepeat.ElementAt(i);
                bool IsFirst = false;
                for (int j = 0; j < ls.Count; j++)
                {
                    if (ls.ElementAt(j) == u)
                    {
                        if (!IsFirst)
                        {
                            IsFirst = true;
                            continue;
                        }
                        else
                        {
                            ls.RemoveAt(j);
                            j--;
                        }
                    }
                }

            }
            return ls;
        }

        /// <summary>
        /// 读取文本文件中的String
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static List<string> GetListStrFromFile(string filePath)
        {
            try
            {
                List<string> ls = new List<string>(File.ReadAllLines(filePath, FileEncoding.EncodingType.GetType(filePath)));
                return ls;
            }
            catch
            {
                return new List<string>();
            }
        }
        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="p_Text"></param>
        /// <param name="p_Path"></param>

        public static void SaveFileString(string p_Path, string p_Text)
        {
            if (File.Exists(p_Path))
            {
                File.Delete(p_Path);
            }

            System.IO.StreamWriter _StreamWriter = new System.IO.StreamWriter(p_Path);
            _StreamWriter.Write(p_Text);
            _StreamWriter.Close();
        }
        /// <summary>
        /// 新建文件 如果存在 直接覆盖
        /// </summary>
        /// <param name="path"></param>
        /// <param name="ls"></param>
        public static void SaveFileString(string path, List<string> ls)
        {          
            File.WriteAllLines(path, ls.ToArray());           
        }
        /// <summary>
        /// 新建文件，如果存在 覆盖。不保留副本 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="ls"></param>
        /// <param name="overWrite"></param>
        public static void SaveFileString(string path, List<string> ls, bool overWrite)
        {
            if(!overWrite)
            {
                if(File.Exists(path + ".bak"))
                {
                    File.Delete(path + ".bak");
                }
                if (File.Exists(path))
                {
                    File.Move(path, path + ".bak");
                }
            }
            File.WriteAllLines(path, ls.ToArray());
        }

        public static void SaveFileString(string path, List<string> ls, Encoding en)
        {
            if (File.Exists(path + ".bak"))
            {
                File.Delete(path + ".bak");
            }
            if (File.Exists(path))
            {
                File.Move(path, path + ".bak");
            }
            File.WriteAllLines(path, ls.ToArray(),en);

        }
        /// <summary>
        /// 是否只含有空格和\t
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool IsOnlySpaceOrTable(string source)
        {
            source = source.Replace("\t", "");
            source = source.Replace(" ", "");
            source = source.Replace("　", "");
            if (source == "")
            { return true; }
            else
            { return false; }
        }

        /// <summary>
        /// 获得中间的字符串
        /// </summary>
        /// <param name="source">源文件</param>
        /// <param name="sFirstLeft">左边的第一个string</param>
        /// <param name="sFirstRight">左边的String之后 出现第一次的地方</param>
        /// <returns>中间的string</returns>
        public static string GetInSideString(string source, string sFirstLeft, string sFirstRight)
        {
            int posS1 = source.IndexOf(sFirstLeft);

            if (posS1 == -1)
            {
                return "";
            }

            source = source.Substring(posS1 + sFirstLeft.Length);

            int posS2 = source.IndexOf(sFirstRight);
            if (posS2 == -1)
            { return ""; }

            source = source.Substring(0, posS2);
            return source;

        }

        public static string GetLastNameFromUrl(string url)
        {
            int pos = url.LastIndexOf(".");
            if (pos == -1)
            {
                return "";
            }
            string lastName = url.Substring(pos);
            if (lastName.Length > 6)
            { return ""; }
            return lastName;
        }

        public static string GetFolderFromPath(string path)
        {
            string fileFolder = "";

            int pos = path.LastIndexOf("\\");

            if (pos == -1)
            { return ""; }

            fileFolder = path.Substring(0, pos);
            return fileFolder;
        }

        public static List<string> GetFileInfoFromDir(string path)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(path);

                FileInfo[] fis = di.GetFiles();
                List<string> ls = new List<string>();

                foreach (FileInfo fi in fis)
                {
                    ls.Add(fi.FullName);
                }
                return ls;
            }
            catch
            {
                return new List<string>();
            }
            

        }
    }
}
