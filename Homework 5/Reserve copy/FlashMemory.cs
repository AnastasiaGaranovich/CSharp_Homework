using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserve_copy
{
    internal class FlashMemory: Storage
    {

        public FlashMemory(string name, string model, int memory) : base(name, model)
        {
            _memorySize = memory;
        }

        public override int MemorySize()
        {
            return _memorySize;
        }

        public override string NameCarrier 
        { get => _nameCarrier; set => _nameCarrier = value; }

        public override string Model => _model;

        public override void MakeCopy(int infoSize)
        {
            if(FreeMemorySize() < infoSize)
            {
                throw new InsufficientMemoryException();
            }
            _occupiedMemory += infoSize;
        }

        public override int WriteSpeed()
        {
            return 500;
        }
    }
}
