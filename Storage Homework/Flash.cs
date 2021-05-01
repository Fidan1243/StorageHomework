using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flash
{
    class Flash : Storage.Storage {
        public float ReadWriteSpeed { get; set; } = 3;
        public override void Copy()
        {
            float Speed = ReadWriteSpeed * InformationCapacity;
            Speed /= 60;
            int needMediaCount = 1;
            if (Capacity < InformationCapacity)
            {
                needMediaCount = Convert.ToInt32(InformationCapacity /= Capacity);
                needMediaCount++;
            }
            Console.WriteLine($"Speed of Read and Write in Flash is {Speed} minutes");
            Console.WriteLine($"You need {needMediaCount} flash memory");
        }
        public override float FreeMemory()
        {
            return base.FreeMemory();
        }
    }

}
