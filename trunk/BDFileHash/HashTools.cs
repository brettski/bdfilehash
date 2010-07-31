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
            FileToHash = file;
            return FileCheck();
        }
        private bool FileCheck()
        {
            FileInfo fi = new FileInfo(FileToHash);
            if (!fi.Exists)
            {
                string f2h;
                if (string.IsNullOrEmpty(FileToHash))
                    f2h = "(Empty)";
                else
                    f2h = FileToHash;
                ErrorMsg = string.Format("File Doesn't Exist, {0}", f2h);
                InError = true;
                return false;
            }
            InError = false;
            PathToFileToHash = fi.Directory.FullName;
            return true;
        }

        // Methods (public)

        /// <summary>
        /// Public method to hash files.  
        /// </summary>
        /// <returns>Result Boolean</returns>
        public bool CreateFileHash(string file, HashType ht)
        {
            // verify file exists and write it to property;
            if (!FileCheck(file))
                return false;
            return CreateFileHash(ht);
        }
        /// <summary>
        /// Public method to hash files.
        /// </summary>
        /// <returns>Result Boolean</returns>
        public bool CreateFileHash(HashType ht)
        {
            // checking file, don't like it may be done twice :(
            if (!FileCheck())
                return false;
            bool rv = false;
            switch (ht)
            {
                case HashType.MD5:
                    rv = CreateMD5FileHash();
                    break;
                case HashType.SHA1:
                    rv =  CreateSHA1FileHash();
                    break;
                case HashType.SHA256:
                    rv = CreateSHA256FileHash();
                    break;
                default:
                    rv = false;
                    break;
            }
            return rv;
        }

        private bool CreateMD5FileHash()
        {
            try
            {
                using (FileStream fs = new FileStream(FileToHash , FileMode.Open, FileAccess.Read))
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

        private bool CreateSHA1FileHash()
        {
            try
            {
                using (FileStream fs = new FileStream(FileToHash, FileMode.Open, FileAccess.Read))
                {
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

        private bool CreateSHA256FileHash()
        {
            try
            {
                using (FileStream fs = new FileStream(FileToHash, FileMode.Open, FileAccess.Read))
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
        /// <summary>
        /// Search for text type file with like name of the hashed file.  If file is found
        /// check it for a hash string.  Often publisher hashes are stored in a text file with the
        /// same name as the binary, iso, etc.
        /// Uses FileToHash property
        /// </summary>
        /// <returns>Result if file was found</returns>
        public bool FindTextHashFile(HashType ht)
        {
            TextFileFound = string.Empty;
            if (!FileCheck())
                return false;
            FileInfo fi = new FileInfo(FileToHash);
            string[] files = Directory.GetFiles(fi.DirectoryName, Path.GetFileNameWithoutExtension(fi.FullName) + "*");
            if (files.Length < 1)
                return false;
            for (int i = 0; i < files.Length; i++)
            {
                if (FileToHash != files[i])
                {
                    TextFileHashFound = FileTools.FindHashInFile(files[i], ht);
                    if (TextFileHashFound.Length > 0)
                    {
                        TextFileFound = files[i];
                        i = files.Length + 1;
                    }
                }
            }
            return TextFileHashFound.Length > 0;
        }

        // Properties
        public bool InError { get; private set; }
        public string ErrorMsg { get; private set; }
        public string FileToHash { get; set; }
        public  string Hash { get; private set; }
        public byte[] ByteHash { get; private set; }
        public string TextFileFound { get; private set; }
        public string TextFileHashFound { get; private set; }
        public string PathToFileToHash { get; private set; }
    }
}
