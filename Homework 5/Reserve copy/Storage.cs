using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserve_copy
{
    internal abstract class Storage
    {
        private string _nameCarrier;
        private string _model;

        public abstract string NameCarrier { get; set; }
        public string Model => _model;

        public Storage(string name, string model) : base()
        {
            _nameCarrier = name;
            _model = model;
        }

        public abstract int MemorySize();

        public abstract int FreeMemorySize();

        public abstract void MakeCopy();

        public abstract int TimeForCopy();

        public abstract void CountStorage();

        public override string ToString() //get info
        {
            return $"Name carrier: {_nameCarrier}, Model: {_model}";
        }

    }
}
