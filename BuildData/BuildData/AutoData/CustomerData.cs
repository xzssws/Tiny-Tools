using System;
using System.Collections.Generic;
using System.Text;

namespace BuildData.AutoData
{
    public class CustomerData<T> : BaseData
    {
        public override string AutoData()
        {
            return BuildList<T>(DataSource).ToString();
        }
        public CustomerData(T[] Data)
        {
            this.DataSource = Data;
        }
        private T[] DataSource;
    }
}
