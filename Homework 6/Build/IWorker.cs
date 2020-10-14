using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build
{
    interface IWorker
    {
        void Build(House part);
    }
}
