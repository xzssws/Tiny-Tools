using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class EnglishList
{
    /// <summary>
    /// 序列化类
    /// </summary>
    /// <param name="src">地址路径</param>
    /// <returns>返回对象</returns>
    public static Dictionary<string, string> GetEnglishList(string src)
    {
        using (FileStream fs = new FileStream(src, FileMode.Open))
        {
            BinaryFormatter bf = new BinaryFormatter();
            Dictionary<string,string> o=(Dictionary<string,string>)bf.Deserialize(fs);
            return o;
        }
    }
}

