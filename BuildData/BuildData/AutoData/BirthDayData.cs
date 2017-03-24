using System;
using System.Collections;

namespace BuildData.AutoData
{
    internal class BirthDayData : BaseData
    {
        /// <summary>
        /// 时间最小限度
        /// </summary>
        DateTime DateMin = new DateTime(1934, 1, 1);
        /// <summary>
        /// 时间最大限度
        /// </summary>
        DateTime DateMax = new DateTime(2004, 12, 31);

        public override string AutoData()
        {
            int Dayb = BuildNumbers(9, (DateMax - DateMin).Days);
            string BirthDay = DateMin.AddDays(Dayb).ToString("yyyy-MM-dd");
            return BirthDay;
        }
    }

}
