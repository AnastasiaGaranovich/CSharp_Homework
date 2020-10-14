using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build
{
    interface IPart
    {
        int BuildProgress
        {
            get;
        }

        bool BuildIsFinished
        {
            get;
        }

        void Build();
    }
}
