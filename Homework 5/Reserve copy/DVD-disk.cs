using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserve_copy
{
    internal class DVD_disk : Storage
    {   
        public enum Type
        {
            onesided,
            twosided
        }
        private Type _type;

        public override string NameCarrier
        { get => _nameCarrier; set => _nameCarrier = value; }

        public override string Model => _model;

        public DVD_disk(string name, string model, Type type) : base(name, model)
        {
            _type = type;
        }

        public override int WriteSpeed()
        {
            return 1;
        }

        public override int MemorySize()
        {
            if (_type == Type.onesided)
            {
                return 4700;
            }
            else
            {
                return 9000;
            }
        }

        public override void MakeCopy(int infoSize)
        {
            if (FreeMemorySize() < infoSize)
            {
                throw new InsufficientMemoryException();
            }
            _occupiedMemory += infoSize;
        }
    }
}
