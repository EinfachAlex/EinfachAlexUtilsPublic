using System.Security.Cryptography;
using System.Text;

namespace EinfachAlex.Utils.HashGenerator
{
    public class HashGenerator
    {
        public static Hash generateSHA256(string data)
        {
            byte[] bytes = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(data));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }

            Hash hash = new Hash(builder.ToString());

            return hash;
        }

        public static Hash generateSHA512(string data)
        {
            byte[] bytes = SHA512.Create().ComputeHash(Encoding.UTF8.GetBytes(data));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }

            Hash hash = new Hash(builder.ToString());

            return hash;
        }
    }
}
