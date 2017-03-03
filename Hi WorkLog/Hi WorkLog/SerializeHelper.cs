using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Hi_WorkLog
{
    public class SerializeHelper
    {
        /// <summary>
        /// 序列化到文件[二进制]
        /// </summary>
        /// <param name="obj">对象</param>
        public static void ToBinaryPath(string filepath, object obj)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(filepath, FileMode.Create))
            {
                bf.Serialize(fs, obj);
                fs.Close();
            }
        }
        /// <summary>
        /// 从文件中反序列化[二进制]
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="filepath">文件路径</param>
        /// <returns>获得的反序列化对象</returns>
        public static T FromBinaryPath<T>(string filepath)
        {
            if (!File.Exists(filepath)) return default(T);
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(filepath, FileMode.Open))
            {
                fs.Position = 0;
                T result = (T)bf.Deserialize(fs);
                return result;
            }
        }
    }
}
