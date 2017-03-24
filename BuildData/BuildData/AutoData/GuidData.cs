using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildData.AutoData
{
    public class GuidData:BaseData
    {
        public override string AutoData()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
