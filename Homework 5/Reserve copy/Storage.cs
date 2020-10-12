using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserve_copy
{
    internal abstract class Storage
    {
        protected string _nameCarrier;
        protected string _model;
        protected int _memorySize;
        protected int _occupiedMemory;

        public abstract string NameCarrier { get; set; }
        public virtual string Model => _model;

        public Storage(string name, string model) : base()
        {
            _nameCarrier = name;
            _model = model;
            _occupiedMemory = 0;
        }

        public abstract int WriteSpeed(); //speed MB/s

        public abstract int MemorySize();

        public abstract void MakeCopy(int infoSize);

        public virtual int TimeForCopy(int memorySize)
        {
            return memorySize / WriteSpeed();
        }

        public virtual int FreeMemorySize()
        {
            return MemorySize() - _occupiedMemory;
        }

        public override string ToString() //get info
        {
            return $"Name carrier: {NameCarrier}, Model: {Model}, Memory: {MemorySize()} MB, Occupied memory: {_occupiedMemory} MB, Free memory: {FreeMemorySize()} MB";
        }

    }
}
