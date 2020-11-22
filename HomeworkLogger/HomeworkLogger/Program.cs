using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;

namespace HomeworkLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.Logger.WriteLog("log test", MessageType.Test);
            Logger.Logger.WriteLog("warning log", MessageType.Warning);
            Logger.Logger.WriteLog("information log", MessageType.Info);

            Console.ReadKey();
        }
    }
}
