using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserve_copy
{
    internal class HDD_disk: Storage
    {
        private int _countSections;
        private int _sizeOfSections;

        public override string NameCarrier
        { get => _nameCarrier; set => _nameCarrier = value; }

        public override string Model => _model;

        public HDD_disk(string name, string model, int sizeSections, int countSections) : base(name, model)
        {
            _sizeOfSections = sizeSections;
            _countSections = countSections;
        }
        public override void MakeCopy(int infoSize)
        {
            if (FreeMemorySize() < infoSize)
            {
                throw new InsufficientMemoryException();
            }
            _occupiedMemory += infoSize;
        }

        public override int MemorySize()
        {
            return _sizeOfSections * _countSections;
        }

        public override int WriteSpeed()
        {
            return 60;
        }
    }
}
