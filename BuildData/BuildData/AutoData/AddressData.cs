using System;
using System.Collections.Generic;
using System.Text;

namespace BuildData.AutoData
{
    class AddressData : BaseData
    {
        public override string AutoData()
        {
            return BuildStrings(DataLibrary.Address_CN);
        }
    }
}
