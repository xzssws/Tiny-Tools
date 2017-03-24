using System;
using System.Collections.Generic;
using System.Text;

namespace BuildData.AutoData
{
    class PhoneData : BaseData
    {
        public override string AutoData()
        {
            string[] PhoneHead = GetSwitch() ? DataLibrary.PhoneHead_LT : DataLibrary.PhoneHead_YD;
            return BuildStrings(PhoneHead)+BuildNumbers(13230000,99323343);
        }

    }
}
