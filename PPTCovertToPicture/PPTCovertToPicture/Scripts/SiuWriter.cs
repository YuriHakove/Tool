using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security;
using System.Security.Cryptography; //cryptography n.	密码使用法，密码系统，密码术;
using System.IO;

namespace SiuStream
{
    public class SiuStreamWriter : StreamWriter
    {
        private StreamWriter mStreamWriter;

        public SiuStreamWriter(StreamWriter sw)
            : base(sw.BaseStream, sw.Encoding)
        {

        }
        public SiuStreamWriter(Stream stream)
            : base(stream)
        { }
        public SiuStreamWriter(string path)
            : base(path)
        { }
        public SiuStreamWriter(Stream stream, Encoding encoding)
            : base(stream, encoding)
        { }
        public SiuStreamWriter(string path, bool append)
            : base(path, append)
        { }
        public SiuStreamWriter(Stream stream, Encoding encoding, int bufferSize)
            : base(stream, encoding, bufferSize)
        { }
        public SiuStreamWriter(string path, bool append, Encoding encoding)
            : base(path, append, encoding)
        { }
        public SiuStreamWriter(string path, bool append, Encoding encoding, int bufferSize)
            : base(path, append, encoding, bufferSize)
        { }


        public override void WriteLine(string value)
        {
            value = EncryptandDecryptTool.EncryptDES(value, EncryptandDecryptTool.SiuKey);
            //WriteLine会调用Write函数  若都加密,会造成双重加密
            base.WriteLine(value);
        }
        public override void Write(string value)
        {
            //value = EncryptandDecryptTool.EncryptDES(value, EncryptandDecryptTool.SiuKey);
            //梯图不加密
            base.Write(value);
        }
    }

    public class SiuStreamReader : StreamReader
    {
        public SiuStreamReader(StreamReader sr)
            : base(sr.BaseStream, sr.CurrentEncoding)
        { }
        public SiuStreamReader(Stream stream)
            : base(stream)
        { }
        public SiuStreamReader(string path)
            : base(path)
        { }
        public SiuStreamReader(Stream stream, bool detectEncodingFromByteOrderMarks)
            : base(stream, detectEncodingFromByteOrderMarks)
        { }
        public SiuStreamReader(Stream stream, Encoding encoding)
            : base(stream, encoding)
        { }
        public SiuStreamReader(string path, bool detectEncodingFromByteOrderMarks)
            : base(path, detectEncodingFromByteOrderMarks)
        { }
        public SiuStreamReader(string path, Encoding encoding)
            : base(path, encoding)
        { }
        public SiuStreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks)
            : base(stream, encoding, detectEncodingFromByteOrderMarks)
        { }
        public SiuStreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks)
            : base(path, encoding, detectEncodingFromByteOrderMarks)
        { }
        public SiuStreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
            : base(stream, encoding, detectEncodingFromByteOrderMarks, bufferSize)
        { }
        public SiuStreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
            : base(path, encoding, detectEncodingFromByteOrderMarks, bufferSize)
        { }

        public override string ReadLine()
        {
            string value = base.ReadLine();
            return EncryptandDecryptTool.DecryptDES(value, EncryptandDecryptTool.SiuKey);
        }
    }


    static class EncryptandDecryptTool
    {
        //默认的密钥
        public const string SiuKey = "SiuKey88";
        //默认密钥向量
        private static byte[] Keys = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
        /// DES加密字符串        
        /// 待加密的字符串
        /// 加密密钥,要求为8位
        /// 加密成功返回加密后的字符串，失败返回源串 
        public static string EncryptDES(string encryptString, string encryptKey)
        {
            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));
                byte[] rgbIV = Keys;
                byte[] inputByteArray = Encoding.UTF8.GetBytes(encryptString);
                DESCryptoServiceProvider dCSP = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, dCSP.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Convert.ToBase64String(mStream.ToArray());
            }
            catch
            {
                return encryptString;
            }
        }
        /// 
        /// DES解密字符串        
        /// 待解密的字符串
        /// 解密密钥,要求为8位,和加密密钥相同
        /// 解密成功返回解密后的字符串，失败返源串
        public static string DecryptDES(string decryptString, string decryptKey)
        {
            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(decryptKey);
                byte[] rgbIV = Keys;
                byte[] inputByteArray = Convert.FromBase64String(decryptString);
                DESCryptoServiceProvider DCSP = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, DCSP.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Encoding.UTF8.GetString(mStream.ToArray());
            }
            catch
            {
                return decryptString;
            }
        }
    }
}