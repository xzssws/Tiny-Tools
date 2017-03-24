using System;

namespace BuildData.AutoData
{
    internal class NumData : BaseData
    {
        public override string AutoData()
        {
            string Num = BuildChars(DataLibrary.NumDic, 8);
            return Num;
        }
    }
}