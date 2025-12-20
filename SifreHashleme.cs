using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace RandevuEkranı
{
    public static class SifreHashleme
    {
        public static string HashSifre(string password)
        {
            using (var deriveBytes = new Rfc2898DeriveBytes(password, 16, 10000))
            {
                byte[] salt = deriveBytes.Salt;
                byte[] key = deriveBytes.GetBytes(32);

                byte[] hashBytes = new byte[48];
                Buffer.BlockCopy(salt, 0, hashBytes, 0, 16);
                Buffer.BlockCopy(key, 0, hashBytes, 16, 32);

                return Convert.ToBase64String(hashBytes);
            }
        }

        public static bool VerifyPassword(string password, string storedHash)
        {
            byte[] hashBytes = Convert.FromBase64String(storedHash);

            byte[] salt = new byte[16];
            Buffer.BlockCopy(hashBytes, 0, salt, 0, 16);

            using (var deriveBytes = new Rfc2898DeriveBytes(password, salt, 10000))
            {
                byte[] key = deriveBytes.GetBytes(32);

                for (int i = 0; i < 32; i++)
                {
                    if (hashBytes[i + 16] != key[i])
                        return false;
                }
                return true;
            }
        }
    }
}