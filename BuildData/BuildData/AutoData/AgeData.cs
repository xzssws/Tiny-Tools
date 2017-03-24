using System;
using System.Collections.Generic;
using System.Text;

namespace BuildData.AutoData
{
    class AgeData:BaseData
    {
        public override string AutoData()
        {
            return BuildNumbers(16, 100).ToString();
        }
    }
}
