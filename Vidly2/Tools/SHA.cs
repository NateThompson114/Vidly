using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Vidly2.Tools
{
    internal static class Sha
    {
        internal static string Sha128(string inputString)
        {
            return Hasher(SHA1.Create(), inputString);
        }

        internal static string Sha256(string inputString)
        {
            return Hasher(SHA256.Create(), inputString);
        }

        internal static string Sha384(string inputString)
        {
            return Hasher(SHA384.Create(), inputString);
        }

        internal static string Sha512(string inputString)
        {
            return Hasher(SHA512.Create(), inputString);
        }

        /// <summary>
        /// Hasher takes in a dynamic Class
        /// </summary>
        /// <param name="sha">Use SHA1.Create(), SHA256.Create(), SHA384.Create(), SHA512.Create()</param>
        /// <param name="inputString"></param>
        /// <returns></returns>
        internal static string Hasher(dynamic sha, string inputString)
        {
            using (sha)
            {
                var bytes = Encoding.UTF8.GetBytes(inputString);
                var hash = sha.ComputeHash(bytes);
                return GetStringFromHash(hash);
            }
        }

        public static string HashThis(this string inputString, dynamic sha)
        {
            using (sha)
            {
                var bytes = Encoding.UTF8.GetBytes(inputString);
                var hash = sha.ComputeHash(bytes);
                return GetStringFromHash(hash);
            }
        }

        private static string GetStringFromHash(IEnumerable<byte> hash)
        {
            var result = new StringBuilder();

            foreach (var b in hash)
                result.Append(b.ToString("X2"));

            return result.ToString();
        }
    }
}