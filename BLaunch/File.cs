using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BLaunch
{
    class File
    {
        //テキストファイルをロード
        public static string getTextFileContent(string filepath)
        {
            string body = "";
            if (filepath != null)
            {
                StreamReader sr = new StreamReader(
                    filepath,
                    System.Text.Encoding.GetEncoding("UTF-8")
                );
                body = sr.ReadToEnd();
                sr.Close();
            }

            return body;
        }

        //ファイル拡張子を判別する
        public static string getFileExtension(string filepath)
        {
            string pt = @".+(\..+)";
            Regex rgx = new Regex(pt, RegexOptions.IgnoreCase);
            Match mt = rgx.Match(filepath);
            if (mt.Success) return mt.Groups[1].Value;
            else return "";
        }

        //タブ区切りテキストからURL配列を生成
        public static ArrayList urlListDatasFromTextFile(string text)
        {
            ArrayList arr = new ArrayList();
            char[] delimiter = { '\t', ',' };
            StringReader sr = new StringReader(text);
            while (sr.Peek() > -1)
            {
                string line = sr.ReadLine();
                string[] tmp = line.Split(delimiter);
                string[] row = new string[2];
                row[0] = tmp[0];
                row[1] = tmp[1];
                arr.Add(row);
            }

            return arr;
        }


    }
}
