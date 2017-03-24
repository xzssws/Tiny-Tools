using System;
using System.Collections.Generic;
using System.Text;

namespace BuildData.AutoData
{
    class SexData : BaseData
    {
        public override string AutoData()
        {
            return GetSwitch()? "男" : "女";
        }
    }
}
