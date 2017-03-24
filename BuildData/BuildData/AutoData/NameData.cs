using System;
using System.Collections.Generic;
using System.Text;

namespace BuildData.AutoData
{
    class NameData : BaseData
    {
        public override string AutoData()
        {
            return GetSwitch() ? BoyName() : GirlName();
        }
        /// <summary>
        /// 男生姓名
        /// </summary>
        /// <returns></returns>
        public string BoyName()
        {
            return BuildStrings(DataLibrary.FirstName_CN) + BuildStrings(DataLibrary.XLastName_CN);
        }
        /// <summary>
        /// 女生姓名
        /// </summary>
        /// <returns></returns>
        public string GirlName()
        {
            return BuildStrings(DataLibrary.FirstName_CN) + BuildStrings(DataLibrary.OLastName_CN);
        }
    }
}
