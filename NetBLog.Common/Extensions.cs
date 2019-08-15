using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;

namespace NetBLog.Common
{
    public static class Extensions
    {
        public static string ToMD5(this string str)
        {
            using (var md5 = MD5.Create())
            {
                byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(str));

                StringBuilder sBuilder = new StringBuilder();

                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                return sBuilder.ToString();
            }
        }

        public static string ToJson(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static T JsonToObject<T>(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return default;

            return JsonConvert.DeserializeObject<T>(str);
        }

        public static object JsonToObject(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return default;

            return JsonConvert.DeserializeObject(str);
        }

        public static byte[] ToByteArray(this object obj)
        {
            if (obj == null)
                return null;

            var binaryFormatter = new BinaryFormatter();
            using (var memoryStream = new MemoryStream())
            {
                binaryFormatter.Serialize(memoryStream, obj);
                return memoryStream.ToArray();
            }
        }

        public static object ToObject(this byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
                return null;

            var binaryFormatter = new BinaryFormatter();
            using (var memoryStream = new MemoryStream(byteArray))
            {
                try
                {
                    return binaryFormatter.Deserialize(memoryStream);
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
