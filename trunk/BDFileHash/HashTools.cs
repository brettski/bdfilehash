using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security;
using System.Security.Cryptography;

namespace BDFileHash
{
    /// <summary>
    /// All of our hashing tools, wrapers, etc.
    /// </summary>
    public class HashTools
    {
        public HashTools()
        {
            InError = false;
        }
        // Methods
        private bool FileCheck(string file)
        {
            if (!File.Exists(file))
            {
                InError = true;
                ErrorMsg = string.Format("File Doesn't Exist, {0}", file);
                InError = true;
                return false;
            }
            return true;
        }
        public bool CreateMD5FileHash(string file)
        {
            InError = false;
            if (!FileCheck(file))
                return false;
            try
            {
                using (FileStream fs = new FileStream(file, FileMode.Open))
                {
                    MD5 md5 = new MD5CryptoServiceProvider();
                    ByteHash = md5.ComputeHash(fs);
                    fs.Close();
                }
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < ByteHash.Length; i++)
                {
                    sb.Append(ByteHash[i].ToString("x2"));
                }
                Hash = sb.ToString();
            }
            catch (Exception e)
            {
                ErrorMsg = e.ToString();
                return false;
            }
            return true;
        }

        public bool CreateSHA1FileHash(string file)
        {
            InError = false;
            if (!FileCheck(file))
                return false;
            try
            {
                using (FileStream fs = new FileStream(file, FileMode.Open))
                {
                    //SHA1 sha1 = new SHA1CryptoServiceProvider(); // Seam managed lib should be used
                    SHA1Managed sha1 = new SHA1Managed();
                    ByteHash = sha1.ComputeHash(fs);
                    fs.Close();
                }
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < ByteHash.Length; i++)
                {
                    sb.Append(ByteHash[i].ToString("x2"));
                }
                Hash = sb.ToString();
            }
            catch (Exception e)
            {
                ErrorMsg = e.ToString();
                InError = true;
                return false;
            }
            return true ;
        }

        public bool CreateSHA256FileHash(string file)
        {
            InError = false;
            if (!FileCheck(file))
                return false;
            try
            {
                using (FileStream fs = new FileStream(file, FileMode.Open))
                {
                    SHA256Managed sha256 = new SHA256Managed();
                    ByteHash = sha256.ComputeHash(fs);
                    fs.Close();
                }
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < ByteHash.Length; i++)
                {
                    sb.Append(ByteHash[i].ToString("x2"));
                }
                Hash = sb.ToString();
            }
            catch (Exception e)
            {
                ErrorMsg = e.ToString();
                InError = true;
                return false;
            }
            return true;
        }

        // Properties
        public bool InError { get; private set; }
        public string ErrorMsg { get; private set; }
        public string FileToHash { get; set; }
        public  string Hash { get; private set; }
        public byte[] ByteHash { get; private set; }
    }
}
