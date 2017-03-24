using System;
using System.Collections.Generic;
using System.Text;
using BuildData.AutoData;

namespace BuildData.DataConfig
{
    public class AutoDataHelp
    {
        private static BirthDayData birth = new BirthDayData();
        private static AddressData add = new AddressData();
        private static EmailData email = new EmailData();
        private static NameData name = new NameData();
        private static NumData num = new NumData();
        private static PassData pwd = new PassData();
        private static PhoneData phone = new PhoneData();
        private static QQNumData qq = new QQNumData();
        private static SexData sex = new SexData();
        private static AgeData age = new AgeData();
        private static GuidData guid = new GuidData();
        private static NowTimeData nowtime = new NowTimeData();
        private static ToDayData today = new ToDayData();
        //TODO:工厂方法模式 升级
        public static Dictionary<string, CustomerData<string>> customerData = new Dictionary<string, CustomerData<string>>();

        public static string GetData(Flag Flag, string CustomerID = "")
        {
            switch (Flag)
            {
                case Flag.Birth:
                    return birth.AutoData();
                case Flag.Address:
                    return add.AutoData();
                case Flag.Email:
                    return email.AutoData();
                case Flag.Name:
                    return name.AutoData();
                case Flag.Num:
                    return num.AutoData();
                case Flag.Pwd:
                    return pwd.AutoData();
                case Flag.Phone:
                    return phone.AutoData();
                case Flag.QQ:
                    return qq.AutoData();
                case Flag.Sex:
                    return sex.AutoData();
                case Flag.Age:
                    return age.AutoData();
                case Flag.Customer: //自定义数据有点特殊 取一个集合
                    return customerData[CustomerID].AutoData();
                case Flag.GUID:
                    return guid.AutoData();
                case Flag.NowTime:
                    return nowtime.AutoData();
                case Flag.ToDay:
                    return today.AutoData(); ;
                default:
                    return "";
            }
        }
    }
}
