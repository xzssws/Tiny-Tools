using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanException
{
    public class planException:Exception
    {
        public planException(string message)
            : base(message)
        {
           
        }

    }
}
