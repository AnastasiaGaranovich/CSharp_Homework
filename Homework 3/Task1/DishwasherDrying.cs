using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
     internal partial class Dishwasher
     {
        public void DryingMode(ref double operatingTime)
        {
            _operatingTime = operatingTime;
            _powerConsumption = 0.60 * operatingTime;
        }
     }
}
