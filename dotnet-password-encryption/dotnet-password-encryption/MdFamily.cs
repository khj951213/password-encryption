using System.Security.Cryptography;
using System.Text;

namespace dotnet_password_encryption
{
    public static class MdFamily
    {
        public static string ComputeMd5(string input)
        {
            var result = "";
            using (var hash = MD5.Create())
            {
                result = string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(input)).Select(x => x.ToString("x2")));
            }
            return result;
        }
    }
}
