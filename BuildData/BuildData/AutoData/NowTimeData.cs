using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildData.AutoData
{
    public class NowTimeData:BaseData
    {
        public override string AutoData()
        {
            return DateTime.Now.ToString();
        }
    }
}
