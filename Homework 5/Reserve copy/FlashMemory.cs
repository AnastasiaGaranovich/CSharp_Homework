using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserve_copy
{
    internal class FlashMemory: Storage
    {
        private double _speedUSB3_0;
        private int _memorySize;

        public FlashMemory(string name, string model, double speed, int memory) : base(name, model)
        {
            _speedUSB3_0 = speed;
            _memorySize = memory;
        }
    }
}
