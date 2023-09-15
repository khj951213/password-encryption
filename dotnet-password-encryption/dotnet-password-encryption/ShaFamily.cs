using System.Security.Cryptography;
using System.Text;

namespace dotnet_password_encryption
{
    public static class ShaFamily
    {
        public static string ComputeSha1(string input)
        {
            string res;
            using (var hash = SHA1.Create())
            {
                res = string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(input)).Select(e => e.ToString("x2")));
            }
            return res;
        }

        public static string ComputeSha256(string input)
        {
            string res;
            using (var hash = SHA256.Create())
            {
                res = string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(input)).Select(e => e.ToString("x2")));
            }
            return res;
        }

        public static string ComputeSha512(string input)
        {
            string res;
            using (var hash = SHA512.Create())
            {
                res = string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(input)).Select(e => e.ToString("x2")));
            }
            return res;
        }
    }
}
