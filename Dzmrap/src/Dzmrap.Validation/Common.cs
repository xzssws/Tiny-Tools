using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;

namespace Dzmrap.Validation
{
    /// <summary>
    /// 常量数据
    /// </summary>
    public class Common : ICommon
    {
        private static ICommon _instance;
        /// <summary>
        /// 单例
        /// </summary>
        public static ICommon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Common();
                }
                return Common._instance;
            }

        }
        /// <summary>
        /// 获得认证码
        /// </summary>
        /// <param name="timespan">时间间隔</param>
        /// <returns></returns>
       public  bool  Validate(string str)
       {
           switch (str)
           {
               case "2A23-6EEE-4A7F-9B7A-05E0": return true;
               case "1EBC-71F9-482A-A692-8449": return true;
               case "1EBC-88F9-482A-A692-8749": return true;
               case "186A-1C87-4E1F-98E6-95F5": return true;
               case "187A-1C87-4E8F-98E6-9588": return true;
               case "186A-8C87-9E1F-00E6-95F7": return true;
               case "F2E3-CFF3-4917-9739-20DD": return true;
               default: return false;
           }
           
       }
        /// <summary>
        /// 获取认证码使用时长
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
       public  int  GetTimespan(string str)
       {
           switch (str)
           {
               case "2A23-6EEE-4A7F-9B7A-05E0": return 3;
               case "1EBC-71F9-482A-A692-8449": return 30;
               case "1EBC-88F9-482A-A692-8749": return 90;
               case "186A-1C87-4E1F-98E6-95F5": return 365;
               case "187A-1C87-4E8F-98E6-9588": return 365*3;
               case "186A-8C87-9E1F-00E6-95F7": return 365*5;
               case "F2E3-CFF3-4917-9739-20DD": return int.MaxValue;
               default: return 0;
           }
       }


        ///<summary>
        /// 获取标准北京时间2
        ///</summary>
        ///<returns></returns>
       public  DateTime GetServerTime()
       {

           return DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));

       }  

    }   
}
