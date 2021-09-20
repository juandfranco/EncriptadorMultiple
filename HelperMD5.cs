using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncriptadorMultiple
{
    public static class HelperMD5
    {
        private static MD5 Hanlder { get; } = new MD5CryptoServiceProvider();

        public static string GetMd5Str(string source)
        {
            var data = Encoding.UTF8.GetBytes(source);
            var security = Hanlder.ComputeHash(data);
            var sb = new StringBuilder();
            foreach (var b in security)
            {
                sb.Append(b.ToString("X2"));
            }

            return sb.ToString();
        }
    }
}
