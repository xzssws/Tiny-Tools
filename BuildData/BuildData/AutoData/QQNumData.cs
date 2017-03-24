using System;
using System.Collections.Generic;
using System.Text;

namespace BuildData.AutoData
{
    class QQNumData : BaseData
    {
        public override string AutoData()
        {
            return BuildNumbers(71111111, 2067894839).ToString();
        }
    }
}
