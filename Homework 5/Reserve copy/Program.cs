using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserve_copy
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage[] arrayStorage = new Storage[5];
            arrayStorage[0] = new FlashMemory("Kingston", "Data Traveler 100 G3", 32000); //We have in 1 MB = 1000 B for easy calculations
            arrayStorage[1] = new FlashMemory("Samsung", "BAR Plus", 64000);
            arrayStorage[2] = new DVD_disk("MIREX", "UL130013A1S", DVD_disk.Type.onesided);
            arrayStorage[3] = new HDD_disk("Toshiba", "P300", 250000, 2);
            arrayStorage[4] = new HDD_disk("Samsung", "G800", 200000, 5);

            int allMemory = 0;
            for(int i = 0; i < arrayStorage.Length; i++)
            {
                Console.WriteLine($"Storage {i + 1} {arrayStorage[i]}");
                allMemory += arrayStorage[i].MemorySize();
            }
            Console.WriteLine();
            Console.WriteLine($"All memory in our storages: {allMemory} MB");
            Console.WriteLine();
            int fileSize = 780;
            int countFiles = 565000 / fileSize;
            int indexStorage = 0;
            int time = 0;
            for(int i = 0; i < countFiles; i++)
            {
                try
                {
                    arrayStorage[indexStorage].MakeCopy(fileSize);
                    time += arrayStorage[indexStorage].TimeForCopy(fileSize);
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"{arrayStorage[indexStorage]}\nStorage is full, {i} files written. Getting next storage");
                    indexStorage++;
                    arrayStorage[indexStorage].MakeCopy(fileSize);
                    time += arrayStorage[indexStorage].TimeForCopy(fileSize);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Copying finished.\nInformation: ");
            Console.WriteLine($"Time for copy files: {time} seconds");
            Console.WriteLine($"Count of storages needed for copy all files: {indexStorage + 1}");
            Console.WriteLine();
            for (int i = 0; i < arrayStorage.Length; i++)
            {
                Console.WriteLine($"Storage {i + 1} {arrayStorage[i]}");
                allMemory += arrayStorage[i].MemorySize();
            }

            Console.ReadKey();
        }
    }
}
