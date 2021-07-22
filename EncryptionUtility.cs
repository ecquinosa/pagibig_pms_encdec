using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pagibig_pms_encdec
{
    public static class EncryptionUtility
    {
        const string Key = "@llc@rdtech@rlo!";
        private static string Salt = "4976616E204D65647665646576";
        public static string EncryptText(string clearText)
        {
            const string EncryptionKey = Key;
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
                    73,
                    118,
                    97,
                    110,
                    32,
                    77,
                    101,
                    100,
                    118,
                    101,
                    100,
                    101,
                    118});
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }

                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }
        public static string DecryptText(string cipherText)
        {
            const string EncryptionKey = Key;
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes decryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
                    73,
                    118,
                    97,
                    110,
                    32,
                    77,
                    101,
                    100,
                    118,
                    101,
                    100,
                    101,
                    118});
                decryptor.Key = pdb.GetBytes(32);
                decryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close(); cipherText = Encoding.Unicode.GetString(ms.ToArray());
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
        public static string AESEncryptString(string val)
        {
            string ReturnStr = "";
            byte[] encryptedBytes = null;
            byte[] bytesToBeEncrypted = ASCIIEncoding.Unicode.GetBytes(val);
            byte[] saltBytes = CHexToByte(Salt);

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(Key, saltBytes);
                    AES.Key = key.GetBytes(32);
                    AES.IV = key.GetBytes(16);

                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                    ReturnStr = Convert.ToBase64String(ms.ToArray());
                }
            }
            return ReturnStr;
        }
        private static byte[] CHexToByte(string hexStringData)
        {
            var data = Spacer(hexStringData, 2).Split(' ');
            var returnbyte = new byte[data.Length - 1];
            var counter = 0;

            for (var i = 0; i < returnbyte.Length; i++)
            {
                string str = data[i];
                str = str.Replace("", "");
                if (!string.IsNullOrEmpty(str))
                {
                    try
                    {
                        byte floatVals = Convert.ToByte(str, 16);
                        returnbyte[counter] = floatVals;
                    }
                    catch
                    {
                        // ignored
                    }
                }
                counter++;
            }
            return returnbyte;
        }
        private static string Spacer(string str, int b4space)
        {
            string temp = null;
            string s = null;
            if (str != null)
            {
                for (int i = 0; i <= str.Length - 2; i += b4space)
                {
                    temp = str.Substring(i, b4space) + "";
                    s = s + temp;
                }
                if (s != null)
                {
                    str = s.Trim();
                }
            }
            return str + "";
        }
    }
}
