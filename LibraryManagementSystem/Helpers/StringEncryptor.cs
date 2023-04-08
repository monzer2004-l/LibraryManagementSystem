using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem2.Helpers
{
    public class StringEncryptor
    {
        private static readonly byte[] salt = Encoding.UTF8.GetBytes("9cc7d5f449a5a7f8c2a2a7e0a982173b");

        public static string Encrypt(string plainText, string password)
        {
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] key = new Rfc2898DeriveBytes(password, salt).GetBytes(32);
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.GenerateIV();
                using (ICryptoTransform encryptor = aes.CreateEncryptor())
                {
                    byte[] cipherBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);
                    byte[] ivAndCipherBytes = new byte[aes.IV.Length + cipherBytes.Length];
                    Array.Copy(aes.IV, 0, ivAndCipherBytes, 0, aes.IV.Length);
                    Array.Copy(cipherBytes, 0, ivAndCipherBytes, aes.IV.Length, cipherBytes.Length);
                    return Convert.ToBase64String(ivAndCipherBytes);
                }
            }
        }

        public static string Decrypt(string cipherText, string password)
        {
            byte[] ivAndCipherBytes = Convert.FromBase64String(cipherText);
            byte[] iv = new byte[16];
            byte[] cipherBytes = new byte[ivAndCipherBytes.Length - 16];
            Array.Copy(ivAndCipherBytes, 0, iv, 0, 16);
            Array.Copy(ivAndCipherBytes, 16, cipherBytes, 0, cipherBytes.Length);
            byte[] key = new Rfc2898DeriveBytes(password, salt).GetBytes(32);
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                using (ICryptoTransform decryptor = aes.CreateDecryptor())
                {
                    byte[] plainBytes = decryptor.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
                    return Encoding.UTF8.GetString(plainBytes);
                }
            }
        }
    }
}
