using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build
{
    internal class Roof: IPart
    {
        private int _buildProgress = 0;
        public int BuildProgress => _buildProgress;
        public bool BuildIsFinished => BuildProgress == 100;

        public void Build()
        {
            if (BuildIsFinished)
            {
                throw new Exception("Roof build is already finished");
            }
            _buildProgress += 20;
        }
    }
}
