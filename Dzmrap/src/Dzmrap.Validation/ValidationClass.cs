using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;

namespace Dzmrap.Validation
{
    /// <summary>
    /// 进行认证
    /// </summary>
    public class ValidationClass : IValidate
    {
        private static IValidate _instance;
        /// <summary>
        /// 单例
        /// </summary>
        public static IValidate Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ValidationClass();
                }
                return ValidationClass._instance;
            }

        }
        public bool IsValidated()
        {
            if (File.Exists("db.db"))
            {
                List<string> strarray=new List<string>();
                strarray = File.ReadLines("db.db").ToList<string>();
                DecodeInfo = new List<string>();
                foreach (var item in strarray)
                {
                    DecodeInfo.Add(Security.Instance.Decode(item));
                }
                if (strarray.Count == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        private List<string> DecodeInfo;
        public bool IsExpired()
        {
            //if (IsValidated())
            //{
                List<string> strarray = File.ReadLines("db.db").ToList<string>();
                DecodeInfo = new List<string>();
                foreach (var item in strarray)
                {
                    DecodeInfo.Add(Security.Instance.Decode(item));
                }
                if (DecodeInfo.Count == 2)
                {
                    DateTime CurrentTime = DateTime.Parse(Common.Instance.GetServerTime().ToString());
                    int timespan = Common.Instance.GetTimespan(DecodeInfo[0]);
                    DateTime firsttime = DateTime.Parse(DecodeInfo[1]);
                    if ((CurrentTime - firsttime).Days > timespan)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            //}
            //else
            //{
            //    return false;
            //}
        }

        public bool ValidateMethod(string str)
        {
            
            //认证成功
            if (Common.Instance.Validate(str))
            {
                //if (File.Exists("db.db"))
                //{
                    if (IsValidated())
                    {
                        if (DecodeInfo.Contains(str))
                        {
                            return true;
                        }
                    }
                    List<string> strarray = new List<string>();
                    strarray.Add(Security.Instance.Encode(str));
                    strarray.Add(Security.Instance.Encode(Common.Instance.GetServerTime().ToString()));
                    File.WriteAllLines("db.db",strarray.ToArray<string>());
                    return true;
                //}
            }
            //认证失败
            return false;
        }
    }
}
