using System;
using System.Collections.Generic;
using System.Text;

namespace BuildData.AutoData
{
    class EmailData : BaseData
    {
        //邮箱字典
        public override string AutoData()
        {
            return BuildChars(DataLibrary.ABCDic, 13, 6) + BuildStrings(DataLibrary.MailDic) + ".com";
        }
    }
}
