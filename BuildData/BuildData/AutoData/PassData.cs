using System;
using System.Collections.Generic;
using System.Text;

namespace BuildData.AutoData
{
    class PassData : BaseData
    {
        public override string AutoData()
        {
            string Pass = BuildChars(DataLibrary.AllDic, 8);
            return Pass;
        }
    }
}
