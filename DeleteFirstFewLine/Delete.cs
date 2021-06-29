using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DeleteFirstFewLine
{
    public class Delete
    {
        public static string GetNewFileName(string filePath)
        {
            try
            {
                List<string> ls = new List<string>(File.ReadAllLines(filePath, FileEncoding.EncodingType.GetType(filePath)));
                //return ls.ElementAt(0);
                for (int i = 0; i < ls.Count; i++)
                {
                    string sName = ls.ElementAt(i);

                    sName = sName.Replace("\t", "");
                    sName = sName.Replace(" ", "");//英文空格
                    sName = sName.Replace("　", "");//中文空格
                    sName = sName.Replace("【", "");
                    sName = sName.Replace("】", "");
                    sName = sName.Replace("~", "");
                    sName = sName.Replace("《", "");
                    sName = sName.Replace("》", "");

                    sName = sName.Replace("\\", "");
                    sName = sName.Replace("/", "");
                    sName = sName.Replace(":", "");
                    sName = sName.Replace("*", "");
                    sName = sName.Replace("?", "");
                    sName = sName.Replace("\"", "");
                    sName = sName.Replace("<", "");
                    sName = sName.Replace(">", "");
                    sName = sName.Replace("|", "");
                    if (sName != "")
                        return sName;
                }
                return "";
            }
            catch
            {
                return "";
            }
        }


        //public static int DeleteMulti(string filePath, string stringSource, bool ckk)
        //{

        //    if (ckk == true)
        //    {
        //        bool bak = DoBak(filePath);
        //        if (bak == false)
        //        { return -1; }
        //    }
        //    int count = 0;

        //    Encoding en = FileEncoding.EncodingType.GetType(filePath);
        //    //List<string> ls = new List<string>(File.ReadAllLines(filePath, en));
        //    List<string> ls = MyString.GetStringFromFile(filePath);

        //    for (int i = 0; i < ls.Count; i++)
        //    {
        //        if (ls[i].Contains(stringSource))
        //        {
        //            ls[i] = ls[i].Replace(stringSource, "");
        //            count++;
        //        }
        //    }
        //    File.WriteAllLines(filePath, ls.ToArray(),en);


        //    return count;


        //}

        /// <summary>
        /// 替换多个字符串，或者删除多个字符串。
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="stringSource"></param>
        /// <param name="newString">新字符串 如果为""，则为删除</param>
        /// <param name="ckk">是否需要备份</param>
        /// <returns></returns>
        public static int ReplaceDeleteMulti(string filePath, string stringSource, string newString, bool ckk)
        {

            if (ckk == true)
            {
                bool bak = DoBak(filePath);
                if (bak == false)
                { return -1; }
            }
            int count = 0;
            Encoding en = FileEncoding.EncodingType.GetType(filePath);
            List<string> ls = new List<string>(File.ReadAllLines(filePath, en));

            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i].Contains(stringSource))
                {
                    ls[i] = ls[i].Replace(stringSource, newString);
                    count++;
                }
            }
            File.WriteAllLines(filePath, ls.ToArray(),en);

            return count;

        }

        /// <summary>
        /// 替换多个字符串，或者删除多个字符串。
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="stringSource"></param>
        /// <param name="newString">新字符串 如果为""，则为删除</param>
        /// <param name="ckk">是否需要备份</param>
        /// <returns></returns>
        public static int ReplaceDeleteMulti_regex(string filePath, string stringSource, string newString, bool ckk)
        {

            if (ckk == true)
            {
                bool bak = DoBak(filePath);
                if (bak == false)
                { return -1; }
            }
            int count = 0;
            Encoding en = FileEncoding.EncodingType.GetType(filePath);
            List<string> ls = new List<string>(File.ReadAllLines(filePath, en));

            for (int i = 0; i < ls.Count; i++)
            {
                string pattern = stringSource;
                var v = Regex.Replace(ls[i], pattern, newString);
                if(v == ls[i])
                    count++;
                else
                   ls[i] = v;
            }
            File.WriteAllLines(filePath, ls.ToArray(), en);

            return count;

        }
        public static bool DeleteFileNameBak(string filePath)
        {
            try
            {
                if(System.IO.Path.GetExtension(filePath) != ".bak")
                {
                    return false;
                }
                string newFileName = System.IO.Path.GetDirectoryName(filePath) + "\\"
                                   + System.IO.Path.GetFileNameWithoutExtension(filePath);

                if (File.Exists(newFileName))
                {
                    File.Delete(newFileName);
                }
                File.Move(filePath, newFileName);
                return true;
            }
            catch
            {
                return false;
            }

        }

        //备份文件
        public static bool DoBak(string oldFile)
        {
            try
            {
                if (File.Exists(oldFile + ".bak"))
                {
                    File.Delete(oldFile + ".bak");
                }
                File.Copy(oldFile, oldFile + ".bak");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteTopNumberOfLine(string filePath, bool ckedBak)
        {
            if (ckedBak == true)
            {
                bool bak = DoBak(filePath);
                if (bak == false)
                { return false; }
            }

            try
            {
                Encoding en = FileEncoding.EncodingType.GetType(filePath);
                List<string> ls = new List<string>(File.ReadAllLines(filePath, en));
                for (int i = 0; i < ls.Count; i++)
                {
                    ls[i] = MyString.DeleteTopNumber(ls.ElementAt(i));
                }
                File.WriteAllLines(filePath, ls.ToArray(), en);
                return true;
            }
            catch
            { return false; }
        }
        public static bool DeleteTopOfLine(string filePath, int nCountZiFu, bool ckedBak)
        {
            if (ckedBak == true)
            {
                bool bak = DoBak(filePath);
                if (bak == false)
                { return false; }
            }

            try
            {
                Encoding en = FileEncoding.EncodingType.GetType(filePath);
                List<string> ls = new List<string>(File.ReadAllLines(filePath, en));
                for (int i = 0; i < ls.Count; i++)
                {
                    ls[i] = MyString.DeleteTopFewZiFu(ls.ElementAt(i), nCountZiFu);
                }
                File.WriteAllLines(filePath, ls.ToArray(), en);
                return true;
            }
            catch
            { return false; }
        }

        public static bool DeleteLastOfLine(string filePath, int nCountZiFu, bool ckedBak)
        {
            if (ckedBak == true)
            {
                bool bak = DoBak(filePath);
                if (bak == false)
                { return false; }
            }

            try
            {
                Encoding en = FileEncoding.EncodingType.GetType(filePath);
                List<string> ls = new List<string>(File.ReadAllLines(filePath, en));
                for (int i = 0; i < ls.Count; i++)
                {
                    ls[i] = MyString.DeleteLastFewZiFu(ls.ElementAt(i), nCountZiFu);
                }
                File.WriteAllLines(filePath, ls.ToArray(), en);
                return true;
            }
            catch
            { return false; }
        }

        /// <summary>
        /// 合并文件
        /// </summary>
        /// <param name="lsFile"></param>
        /// <returns></returns>
        public static bool MergeFile(List<string> lsFile)
        {
            try
            {
                string fileName = lsFile[0];
                Encoding en = FileEncoding.EncodingType.GetType(fileName);
                string newFileName = MyString.GetNewFileName(fileName, "_合并");

                //string fileConnect = "";
                List<string> lsMax = new List<string>();
                foreach (string filePath in lsFile)
                {
                    List<string> ls = new List<string>(File.ReadAllLines(filePath, FileEncoding.EncodingType.GetType(filePath)));
                    lsMax.AddRange(ls);
                }

                File.WriteAllLines(newFileName, lsMax.ToArray(),en);
                return true;
            }
            catch
            {
                return false;
            }
        }


        public static bool MergeFile(List<string> lsFile, string mergeData)
        {
            try
            {
                if(mergeData == null || mergeData == "")
                {
                    return false;
                }

                string fileName = lsFile[0];
                Encoding en = FileEncoding.EncodingType.GetType(fileName);

                List<string> lsMax = new List<string>(File.ReadAllLines(fileName, en));
                
                string newFileName = MyString.GetNewFileName(fileName, "_合并");

                List<string> lsMergeData = MyString.ConvertToListString(mergeData);
                lsFile.RemoveAt(0);
                foreach (string filePath in lsFile)
                {
                    lsMax.AddRange(lsMergeData);
                    List<string> ls = new List<string>(File.ReadAllLines(filePath, FileEncoding.EncodingType.GetType(filePath)));
                    lsMax.AddRange(ls);
                }

                File.WriteAllLines(newFileName, lsMax.ToArray(), en);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool MergeFileGeHang(List<string> lsFile)
        {
            try
            {
                string fileName = lsFile[0];
                Encoding en = FileEncoding.EncodingType.GetType(fileName);

                List<List<string>> max = new List<List<string>>();
                List<string> lsMax = new List<string>();
                foreach(string file in lsFile)
                {
                    List<string> lsFileData = MyString.GetListStrFromFile(file);
                    max.Add(lsFileData);
                }

                string newFileName = MyString.GetNewFileName(fileName, "_隔行合并");

                while(true)
                {
                    for(int i = 0; i < max.Count; i++)
                    {
                        if(max[i].Count == 0)
                        {
                            max.RemoveAt(i);
                            i--;
                            continue;
                        }
                        lsMax.Add(max[i][0]);
                        max[i].RemoveAt(0);
                    }
                    if(max.Count == 0)
                    {
                        break;
                    }
                }


                File.WriteAllLines(newFileName, lsMax.ToArray(), en);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 合并文件 添加数据 添加文件名
        /// </summary>
        /// <param name="lsFile">多个文件</param>
        /// <param name="mergeData">合并的数据</param>
        /// <returns></returns>
        public static bool MergeFileName(List<string> lsFile, string mergeData)
        {
            try
            {
                string fileName = lsFile[0];
                Encoding en = FileEncoding.EncodingType.GetType(fileName);
                List<string> lsFileNameOnly = new List<string>();
                lsFileNameOnly.Add(System.IO.Path.GetFileName(fileName));
                List<string> lsMax = new List<string>(File.ReadAllLines(fileName, en));
                lsMax = Common.MergeList(lsFileNameOnly, lsMax);

                string newFileName = MyString.GetNewFileName(fileName, "_合并_名");

                //string fileConnect = "";
                List<string> lsMergeData = MyString.ConvertToListString(mergeData);
                lsFile.RemoveAt(0);
                foreach (string filePath in lsFile)
                {
                    lsMax.AddRange(lsMergeData);
                    lsFileNameOnly = new List<string>();
                    lsFileNameOnly.Add(System.IO.Path.GetFileName(filePath));

                    lsMax.AddRange(lsFileNameOnly);
                    List<string> ls = new List<string>(File.ReadAllLines(filePath, FileEncoding.EncodingType.GetType(filePath)));
                    lsMax.AddRange(ls);
                }

                File.WriteAllLines(newFileName, lsMax.ToArray(), en);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool MergeFileLeftRight(List<string> lsFile, string data)
        {
            try
            {
                if(lsFile.Count != 2)
                {
                    return false;
                }
                string fileName = lsFile[0];
                Encoding en = FileEncoding.EncodingType.GetType(fileName);

                string newFileName = MyString.GetNewFileName(fileName,"_左右合并");

                List<List<string>> max = new List<List<string>>();
                foreach(string file in lsFile)
                {
                    List<string> ls = MyString.GetListStrFromFile(file);
                    max.Add(ls);
                }
                List<string> lsMax = new List<string>();


                while(true)
                {
                    if(max[0].Count != 0 && max[1].Count != 0)
                    {
                        lsMax.Add(max[0][0] + data + max[1][0]);
                        max[0].RemoveAt(0);
                        max[1].RemoveAt(0);
                    }
                    else
                    {
                        if(max[0].Count == 0)
                        {
                            lsMax.AddRange(max[1]);
                            break;
                        }
                        if(max[1].Count == 0)
                        {
                            lsMax.AddRange(max[0]);
                            break;
                        }

                    }
                }

                File.WriteAllLines(newFileName, lsMax.ToArray(), en);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 拆分文件
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <param name="splitCount">Count  Line</param>
        /// <param name="blMode">true:Count  false:Line</param>
        /// <returns></returns>
        public static bool SplitFile(string filePath, int splitCount, bool blMode)
        {
            if(splitCount == 0)
            {
                return false;
            }
            string fileName = filePath;
            Encoding en = FileEncoding.EncodingType.GetType(fileName);

            //string pathNotLastName = Common.GetFilePathWithoutExtension(fileName);
            //string lastName = Common.GetFileExtension(fileName);

            List<string> ls = new List<string>(File.ReadAllLines(filePath, en));
            int fileLine = 0;
            int splitFileCount = 0;
            if(blMode)//by Count
            {

                splitFileCount = splitCount;
                if (ls.Count < splitFileCount)
                {
                    return false;
                }

                if (ls.Count % splitFileCount == 0)
                {
                    fileLine = ls.Count / splitFileCount;
                }
                else
                {
                    fileLine = (ls.Count / splitFileCount) + 1;
                }
               
            }
            else//by Line
            {
                fileLine = splitCount;
                
                if (ls.Count % fileLine == 0)
                {
                    splitFileCount = ls.Count / fileLine;
                }
                else
                {
                    splitFileCount = (ls.Count / fileLine) + 1;
                }

            }
            try
            {
                List<string> nnlist = new List<string>();
                for (int j = 0; j < splitFileCount; j++)
                {
                    for (int i = 0; i < fileLine; i++)
                    {
                        if (ls.Count > 0)
                        {
                            nnlist.Add(ls.ElementAt(0));
                            ls.RemoveAt(0);
                        }
                        else { continue; }
                    }
                    //File.WriteAllLines(pathNotLastName + "_" + (j + 1).ToString() + lastName, nnlist.ToArray(), en);
                    File.WriteAllLines(MyString.GetNewFileName(fileName, "_" + (j + 1).ToString()), nnlist.ToArray(), en);
                    nnlist.Clear();
                }
                return true;
            }
            catch
            {
                return false;
            }
          
        }

        public static bool SplitFileByOddEven(string filePath)
        {
            try
            {
                Encoding en = FileEncoding.EncodingType.GetType(filePath);
                List<string> ls = new List<string>(File.ReadAllLines(filePath, en));

                List<string> lsOdd = new List<string>();
                List<string> lsEven = new List<string>();

                for (int i = 0; i < ls.Count; ++i)
                {
                    if(i % 2 == 0)
                    {
                        lsOdd.Add(ls.ElementAt(i));
                    }
                    else
                    {
                        lsEven.Add(ls.ElementAt(i));
                    }
                }
                File.WriteAllLines(MyString.GetNewFileName(filePath, "_奇"), lsOdd.ToArray(),en);
                File.WriteAllLines(MyString.GetNewFileName(filePath, "_偶"), lsEven.ToArray(), en);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteSpaceLine(string filePath, bool ckedBak)
        {
            if (ckedBak == true)
            {
                bool bak = DoBak(filePath);
                if (bak == false)
                { return false; }
            }

            try
            {
                Encoding en = FileEncoding.EncodingType.GetType(filePath);
                List<string> ls = new List<string>(File.ReadAllLines(filePath, en));
                for (int i = 0; i < ls.Count; i++)
                {
                    if (Common.IsOnlySpace(ls[i]))
                    {
                        ls.RemoveAt(i);
                        i--;
                    }
                }
                File.WriteAllLines(filePath, ls.ToArray(),en);
                return true;
            }
            catch
            { return false; }

        }

        public static bool DeleteDuplicateLine(string filePath, bool ckedBak)
        {
            if (ckedBak == true)
            {
                bool bak = DoBak(filePath);
                if (bak == false)
                { return false; }
            }

            try
            {
                Encoding en = FileEncoding.EncodingType.GetType(filePath);
                List<string> ls = new List<string>(File.ReadAllLines(filePath, en));
                MyString.DeleteDuplicateLines(ref ls);
         
                File.WriteAllLines(filePath, ls.ToArray(),en);
                return true;
            }
            catch
            { return false; }

        }


        public static bool DeleteReplaceMultiLine(string filePath, bool ckedBak, int startline, int endline, string strModlePath)
        {
            if (ckedBak == true)
            {
                bool bak = DoBak(filePath);
                if (bak == false)
                { return false; }
            }

            try
            {
                Encoding en = FileEncoding.EncodingType.GetType(filePath);
                List<string> ls = new List<string>(File.ReadAllLines(filePath, en));
                List<string> lsModle = new List<string>(File.ReadAllLines(strModlePath, en));

                // 全部替换
                if (startline == 0 && (endline == 0 || endline > ls.Count()))
                {
                    File.WriteAllLines(filePath, lsModle.ToArray(), en);
                    return true;
                }
                if (endline <= 0 || endline > ls.Count())
                {
                    endline = ls.Count();
                }
                if ( startline > endline)//插入到指定位置
                {
                    ls.InsertRange(startline, lsModle);
                    File.WriteAllLines(filePath, ls.ToArray(), en);
                    return true;
                }

                if (startline == 0)
                    startline++;
                
                ls.RemoveRange(startline-1, endline - startline+1);
                ls.InsertRange(startline-1, lsModle);
                File.WriteAllLines(filePath, ls.ToArray(), en);

                return true;
            }
            catch
            { return false; }

        }


        public static int DeleteExtractByKeyWord(string filePath, string outputFilePath, string strModlePath, ref string abc)
        {
            try
            {
                if (!File.Exists(outputFilePath))
                    File.Create(outputFilePath);
                
                Encoding en = FileEncoding.EncodingType.GetType(outputFilePath);
                List<string> lsOLd = new List<string>(File.ReadAllLines(outputFilePath));
                List<string> ls = new List<string>(File.ReadAllLines(filePath));
                List<string> lsModle = new List<string>(File.ReadAllLines(strModlePath));
                List<string> lsOutput = new List<string>();
                StreamWriter fs = new StreamWriter(outputFilePath, true);
                    int ret = 0;
                for (int i = 0; i < ls.Count; i++)
                {
                    for (int j =0; j < lsModle.Count; j++)
                    {
                        if (lsModle[j] == null || lsModle[j] == "")
                            continue;
                        if (ls[i].Contains(lsModle[j]))
                        {
                            //lsOutput.Add(ls[i]);
                         {
                             fs.WriteLine(ls[i]);
                         }
                            ret++;
                        }
                    }
                }
                //lsOLd = lsOLd.Concat(lsOutput).ToList<string>();
                //File.WriteAllLines(outputFilePath, lsOLd.ToArray(), en);

                return ret;
            }
            catch(Exception e)
            {
                abc = e.Message;
                return -1; }

        }
        public static bool DeleteFileEvenOdd(string filePath, bool ckedBak, bool evenOdd)
        {
            if (ckedBak == true)
            {
                bool bak = DoBak(filePath);
                if (bak == false)
                { return false; }
            }
            try
            {
                Encoding en = FileEncoding.EncodingType.GetType(filePath);
                List<string> ls = new List<string>(File.ReadAllLines(filePath, en));
                if (ls.Count == 0)
                    return true;
                int countOfline = ls.Count;

                countOfline--;
                if (countOfline % 2 != Convert.ToInt32(evenOdd))
                { countOfline--; }

                for (int i = countOfline; i >= 0; i -= 2)
                {
                    ls.RemoveAt(i);
                }
                File.WriteAllLines(filePath, ls.ToArray(),en);
                return true;
            }
            catch
            { return false; }
        }
        public static bool DeleteFileLianXu(int nFirst, int nLast, string filePath, bool ckedBak)
        {
            if (ckedBak == true)
            {
                bool bak = DoBak(filePath);
                if (bak == false)
                { return false; }
            }
            Encoding en = FileEncoding.EncodingType.GetType(filePath);
            List<string> ls = new List<string>(File.ReadAllLines(filePath, en));

            if (nFirst > ls.Count)
            {
                return false;
            }
            try
            {
                if (nFirst + nLast > ls.Count)
                {
                    nLast = ls.Count;
                }
                nFirst--;
                for (int i = nFirst; i < nLast; i++)
                {
                    ls.RemoveAt(nFirst);
                }
                File.WriteAllLines(filePath, ls.ToArray(),en);
                return true;
            }
            catch
            { return false; }
        }

        /// <summary>
        /// ls.Add(cBox_mail.Checked);
        /// ls.Add(cBox_qqNum.Checked);
        /// ls.Add(cBox_PhoneNum.Checked);
        /// ls.Add(cBox_idNum.Checked);
        /// ls.Add(cBox_link.Checked);
        /// ls.Add(cBox_word.Checked);
        /// ls.Add(cBox_Regex.Checked);
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="ls"></param>
        /// <param name="text">正则式子</param>
        /// <returns></returns>
        public static int ExtractText(string filePath, List<bool> lsBool, string text, string outputFilePath)
        {
            try
            {

                Encoding en = FileEncoding.EncodingType.GetType(outputFilePath);
                List<string> lsOLd = new List<string>(File.ReadAllLines(outputFilePath));
                string content = File.ReadAllText(filePath);
                List<string> lsOutput = new List<string>();
                int ret = 0;

                if(lsBool[0]) // 邮箱
                {
                    MatchCollection matche = Regex.Matches(content, @"[a-zA-Z0-9_.]+@([a-zA-Z0-9]+(\.[a-zA-Z0-9]+){1,})");

                    foreach (Match item in matche)
                    {
                        Console.WriteLine(item.Value + "==========" + item.Groups[1].Value);
                        lsOutput.Add(item.Value);
                        ret++;
                    }
                }
                if (lsBool[1]) // QQ号
                {
                    MatchCollection matche 
                        = Regex.Matches(content, @"\b[1-9][0-9]{4,9}\b");

                    foreach (Match item in matche)
                    {
                        Console.WriteLine(item.Value + "==========" + item.Groups[1].Value);
                        lsOutput.Add(item.Value);
                        ret++;
                    }
                }
                if (lsBool[2]) // 手机号
                {
                    MatchCollection matche = Regex.Matches(content, @"\b1[0-9]{10}\b");

                    foreach (Match item in matche)
                    {
                        Console.WriteLine(item.Value + "==========" + item.Groups[1].Value);
                        lsOutput.Add(item.Value);
                        ret++;
                    }
                }
                if (lsBool[3]) // 身份证号
                {
                    MatchCollection matche = Regex.Matches(content, @"\b\d{17}[0-9xX]\b");

                    foreach (Match item in matche)
                    {
                        Console.WriteLine(item.Value + "==========" + item.Groups[1].Value);
                        lsOutput.Add(item.Value);
                        ret++;
                    }
                }
                if (lsBool[4]) // 超链接网址
                {
                    MatchCollection matche = Regex.Matches(content, @"[a-zA-z]+://[^\s]*");

                    foreach (Match item in matche)
                    {
                        Console.WriteLine(item.Value + "==========" + item.Groups[1].Value);
                        lsOutput.Add(item.Value);
                        ret++;
                    }
                }

                if (lsBool[5]) // 单词
                {
                    MatchCollection matche = Regex.Matches(content, @"\b[a-zA-Z]\b");

                    foreach (Match item in matche)
                    {
                        Console.WriteLine(item.Value + "==========" + item.Groups[1].Value);
                        lsOutput.Add(item.Value);
                        ret++;
                    }
                }
                if (lsBool[6]) // 正则式子
                {
                    MatchCollection matche = Regex.Matches(content, text);

                    foreach (Match item in matche)
                    {
                        Console.WriteLine(item.Value + "==========" + item.Groups[1].Value);
                        lsOutput.Add(item.Value);
                        ret++;
                    }
                }



                lsOLd = lsOLd.Concat(lsOutput).ToList<string>();
                File.WriteAllLines(outputFilePath, lsOLd.ToArray(), en);

                return ret;
            }
            catch(Exception e)
            { return -1; }
        }

        public static bool DeleteFileFrotLast(int nFirst, int nLast, string filePath, bool ckedBak)
        {
            if (ckedBak == true)
            {
                bool bak = DoBak(filePath);
                if (bak == false)
                { return false; }
            }

            Encoding en = FileEncoding.EncodingType.GetType(filePath);
            //List<string> ls = new List<string>(File.ReadAllLines(filePath,Encoding.UTF8));
            List<string> ls = new List<string>(File.ReadAllLines(filePath, en));

            if (ls.Count < nFirst + nLast)
            {
                ls.Clear();
            }
            try
            {
                for (int i = 0; i < nLast; i++)
                {
                    ls.RemoveAt(ls.Count - 1);
                }

                for (int i = 0; i < nFirst; i++)
                {
                    ls.RemoveAt(0);
                }

                File.WriteAllLines(filePath, ls.ToArray(),en);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteNumbersLine(string filePath, List<int> lsInt, bool ckedBak)
        {
            if (ckedBak == true)
            {
                bool bak = DoBak(filePath);
                if (bak == false)
                { return false; }
            }

            try
            {
                if(lsInt.Count == 0)
                {
                    return false;
                }
                Encoding en = FileEncoding.EncodingType.GetType(filePath);
                List<string> ls = new List<string>(File.ReadAllLines(filePath, en));
                int countLineOfFile = ls.Count;
                for (int i = 0; i < lsInt.Count; i++ )
                {
                    if(lsInt.ElementAt(i) > countLineOfFile)
                    {
                        lsInt.RemoveAt(i);
                        i--;
                    }
                }
                    int flag = 1;
                    for (int i = 0; i < ls.Count; i++,flag++)
                    {
                        if(lsInt.Count == 0)
                        { break; }

                        if(flag == lsInt.ElementAt(0))
                        {
                            ls.RemoveAt(i);
                            i--;
                            lsInt.RemoveAt(0);
                        }
                    }
                File.WriteAllLines(filePath, ls.ToArray(), en);
                return true;
            }
            catch
            { return false; }
        }


        public static bool DeleteKeyWordsLine(string filePath, List<string> lsKeyWords, bool ckedBak)
        {
            if (ckedBak == true)
            {
                bool bak = DoBak(filePath);
                if (bak == false)
                { return false; }
            }

            try
            {
                for(int i = 0; i < lsKeyWords.Count; i++)
                {
                    if(lsKeyWords.ElementAt(i) == "")
                    {
                        lsKeyWords.RemoveAt(i);
                        i--;
                    }
                }
                if(lsKeyWords.Count == 0)
                {
                    return false;
                }
                Encoding en = FileEncoding.EncodingType.GetType(filePath);
                List<string> ls = new List<string>(File.ReadAllLines(filePath, en));
                int countLineOfFile = ls.Count;
                int flag = 0;
                for (int i = 0; i < ls.Count; i++)
                {
                    if(Common.ContainListString(ls[i],lsKeyWords))
                    {
                        ls.RemoveAt(i);
                        flag++;
                        i--;
                    }
                }
                if (flag == 0)
                {
                    return true;
                }
                File.WriteAllLines(filePath, ls.ToArray(), en);
                return true;
            }
            catch
            { return false; }
        }
        public static bool IsUtf8BomFile(string fileFullPath)
        {
            var fs = File.OpenRead(fileFullPath);
            var binnaryReader = new BinaryReader(fs);
            

            byte[] u8bom = {0xEF,0xBB,0xBF };

            for (int i = 0; i < 3; i++)
            {
                byte[] arr = binnaryReader.ReadBytes(1);
                if (arr[0] == u8bom[i])
                    continue;
                else
                {
                    binnaryReader.Close();
                    return false;
                }
            }
            binnaryReader.Close();
            return true;
        }

        public static bool AddDataTopEndFile(string filePath, bool ckedBak, string data, bool blTop, bool blEnd, bool blOverWrite)
        {
            if (ckedBak == true)
            {
                bool bak = DoBak(filePath);
                if (bak == false)
                { return false; }
            }
            List<string> lsData = MyString.ConvertToListString(data);
            

            try
            {              
                Encoding en = FileEncoding.EncodingType.GetType(filePath);

                List<string> ls = new List<string>(File.ReadAllLines(filePath, en));

                if(blOverWrite)
                {
                    if (blTop && !Common.IsContainTopByList(ls, lsData))
                    {
                        ls = Common.MergeList(lsData, ls);
                    }
                    if(blEnd && !Common.IsContainEndByList(ls, lsData))
                    {
                        ls.AddRange(lsData);
                    }
                }
                else
                {
                    if (blTop)
                    {
                        ls = Common.MergeList(lsData, ls);
                    }
                    if (blEnd)
                    {
                        ls.AddRange(lsData);
                    }
                }

                File.WriteAllLines(filePath, ls.ToArray(), en);
                return true;
            }
            catch(Exception e)
            { return false; }
        }

        public static bool AddDataTopEndLine(string filePath, bool ckedBak, 
                                             bool blTopLine, bool isContainNumber, decimal number, string dataTop, 
                                             bool blEndLine, string dataEnd)
        {
            if (ckedBak == true)
            {
                bool bak = DoBak(filePath);
                if (bak == false)
                { return false; }
            }

            try
            {
                Encoding en = FileEncoding.EncodingType.GetType(filePath);
                List<string> ls = new List<string>(File.ReadAllLines(filePath, en));
                int num = Convert.ToInt32(number);

                if(blTopLine && blEndLine)//行首和行尾
                {
                    if(isContainNumber)
                    {
                        for (int i = 0; i < ls.Count; i++,num++)
                        {
                            ls[i] = num.ToString() + dataTop + ls[i] + dataEnd;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < ls.Count; i++)
                        {
                            ls[i] = dataTop + ls[i] + dataEnd;
                        }
                    }
                }
                else
                    if(blTopLine && !blEndLine)//行首
                    {
                        if (isContainNumber)
                        {
                            for (int i = 0; i < ls.Count; i++, num++)
                            {
                                ls[i] = num.ToString() + dataTop + ls[i];
                            }
                        }
                        else
                        {
                            for (int i = 0; i < ls.Count; i++)
                            {
                                ls[i] = dataTop + ls[i];
                            }
                        }
                    }
                    else
                        if (!blTopLine && blEndLine)//行尾
                        {
                            for(int i = 0; i < ls.Count; i++)
                            {
                                ls[i] = ls[i] + dataEnd;
                            }
                        }

                File.WriteAllLines(filePath, ls.ToArray(), en);
                return true;
            }
            catch
            { return false; }
        }

        public static bool AddDataFileNameOfFile(string filePath, bool ckedBak, string dataAddTopOfFile)
        {
            if (ckedBak == true)
            {
                bool bak = DoBak(filePath);
                if (bak == false)
                { return false; }
            }

            try
            {
                Encoding en = FileEncoding.EncodingType.GetType(filePath);
                List<string> ls = new List<string>(File.ReadAllLines(filePath, en));

                ls = Common.MergeList(dataAddTopOfFile, ls);

                File.WriteAllLines(filePath, ls.ToArray(), en);
                return true;
            }
            catch
            { return false; }
        }

        public static bool RenameAddTopLine(string filePath, bool ckedBak, bool isIncludeOldName)
        {
            if (ckedBak == true)
            {
                bool bak = DoBak(filePath);
                if (bak == false)
                { return false; }
            }
            try
            {
                string extension = System.IO.Path.GetExtension(filePath);
                string newFileName = Delete.GetNewFileName(filePath);
                if (newFileName == "")
                {
                    return false;
                }
                string fileDir = "";
                if (isIncludeOldName)
                {
                    fileDir = System.IO.Path.GetDirectoryName(filePath) + "\\"
                            + System.IO.Path.GetFileNameWithoutExtension(filePath);
                }
                else
                {
                    fileDir = System.IO.Path.GetDirectoryName(filePath) + "\\";
                }
                string newFileFullName = fileDir + newFileName;

                if (File.Exists(newFileFullName))
                {
                    File.Delete(newFileFullName);
                }
                File.Move(filePath, newFileFullName);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static int CountFindDataFile(string filePath,string data)
        {
            try
            {
                Encoding en = FileEncoding.EncodingType.GetType(filePath);
                List<string> ls = new List<string>(File.ReadAllLines(filePath, en));

                int count = 0;
                for (int i = 0; i < ls.Count; i++)
                {
                    count += MyString.CountContainString(ls[i], data);
                }

                return count;
            }
            catch
            { return 0; }

        }

        public static Encoding GetFileEncoding(string filePath)
        {
            try
            {
                Encoding en = FileEncoding.EncodingType.GetType(filePath);
                return en;
            }
            catch
            { return Encoding.ASCII; }

        }

        public static bool ChangeTXTFileType(string filePath, string fileChangeType)
        {
            try
            {
                Encoding en = FileEncoding.EncodingType.GetType(filePath); 
                string strContent = File.ReadAllText(filePath, en);
                string fileNewName = "";

                Encoding enNew = Encoding.Default;
                fileNewName = MyString.GetNewFileName(filePath, "");
                switch (fileChangeType)
                {
                    case "ANSI":
                        //fileNewName = MyString.GetNewFileName(filePath, "_ANSI");
                        enNew = Encoding.Default;
                        break;

                    case "Unicode":
                        //fileNewName = MyString.GetNewFileName(filePath, "_Unicode");
                        enNew = Encoding.Unicode;
                        break;

                    case "UnicodeBigEndian":
                        //fileNewName = MyString.GetNewFileName(filePath, "_UnicodeBigEndian");
                        enNew = Encoding.BigEndianUnicode;
                        break;

                    case "UTF_8":
                        //fileNewName = MyString.GetNewFileName(filePath, "_UTF_8");
                        enNew = new UTF8Encoding(false);
                        break;
                    case "UTF_8_BOM":
                        //fileNewName = MyString.GetNewFileName(filePath, "_UTF_8_BOM");
                        
                        enNew = Encoding.UTF8;
                        break;
                        
                    default:
                        break;
                }

                File.WriteAllText(fileNewName, strContent, enNew);
                
                File.Delete(fileNewName + ".bak");
                return true;
            }
            catch
            { return false; }
            
        }

        public static bool SortFile(string filePath, bool blUp, bool blDown)
        {

            if(blUp && blDown)
            {
                return false;
            }
            if(!blUp && !blDown)
            {
                return false;
            }

            try
            {
                Encoding en = FileEncoding.EncodingType.GetType(filePath);
                List<string> ls = new List<string>(File.ReadAllLines(filePath, en));

                ls.Sort();
                if (blDown)
                {
                    ls.Reverse();
                }

                File.WriteAllLines(filePath, ls.ToArray(), en);
                return true;
            }
            catch
            { return false; }
        }

    }
}
