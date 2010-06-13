using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using BDFileHash.Properties;

namespace BDFileHash
{
    public static class FileTools
    {
        public static string MatchMD5String(string file)
        {
            int fileMax = Properties.Settings.Default.HashCompareFileMaxSize;
            string MD5RegEx = Settings.Default.MD5RegEx;
            FileInfo fi = new FileInfo(file);
            if (fileMax < fi.Length)
                return string.Empty;
            using (StreamReader sr = fi.OpenText())
            {
                //string s = sr.ReadToEnd();
                return Regex.Match(sr.ReadToEnd(), MD5RegEx).Value;
                
            }
        }

        public static string FindHashInFile(string file, HashType ht)
        {
            int fileMax = Properties.Settings.Default.HashCompareFileMaxSize;
            string HashRegEx = string.Empty;
            switch (ht)
            {
                case HashType.MD5:
                    HashRegEx = Settings.Default.MD5RegEx;
                    break;
                case HashType.SHA1:
                    HashRegEx = Settings.Default.SHA1RegEx;
                    break;
                case HashType.SHA256:
                    HashRegEx = Settings.Default.SHA256RegEx;
                    break;
            }
            FileInfo fi = new FileInfo(file);
            if (fileMax < fi.Length)
                return string.Empty;
            using (StreamReader sr = fi.OpenText())
            {
                return Regex.Match(sr.ReadToEnd(), HashRegEx, RegexOptions.IgnoreCase).Value;
            }
        }

        public enum HashType
        {
            MD5,
            SHA1,
            SHA256
        }
    }
    /* Example of grabing a chunk of a file (from bdzipper)
     * Don't forget your try/catch wrappers
     *
        using (StreamReader sr = new StreamReader(curdir + filename))
        {
            char[] stub = new char[charLength];
            sr.Read(stub, 0, charLength);
            Response.Write("<p>Reading from: " + filename + "</p>");
            for (int i = 0; i < charLength && '\0' != stub[i]; i++)
            {
                Response.Write(Server.HtmlEncode(stub[i].ToString()));
            }
        }
    */
}
