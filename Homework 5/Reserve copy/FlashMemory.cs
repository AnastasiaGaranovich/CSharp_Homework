using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserve_copy
{
    internal class FlashMemory: Storage
    {
        private int _speedUSB3_0;
        private int _memorySize;
        private int _occupiedMemory;
        private int _timeForCopy;
        private int _information;

        public FlashMemory(string name, string model, int speed, int memory) : base(name, model)
        {
            _speedUSB3_0 = speed;
            _memorySize = memory;
        }

        public override int MemorySize()
        {
            return _memorySize;
        }

        public override string NameCarrier 
        { get => base.NameCarrier; set => base.NameCarrier = value; }

        public override string Model => base.Model;

        public override int FreeMemorySize()
        {
            return _memorySize - _occupiedMemory;
        }

        public override void MakeCopy(int info)
        {
            _information = info;
            _occupiedMemory = (_memorySize - _information) / _speedUSB3_0;
            _timeForCopy += _occupiedMemory;
        }

        public override int TimeForCopy()
        {
            return _timeForCopy;
        }

    }
}
