using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD
{
    class DVD : Storage.Storage
    {
        public float WriteSpeed { get; set; } = 5f;
        public float ReadSpeed { get; set; } = 9f;
        public override void Copy()
        {
            float ReadingSpeed = ReadSpeed * InformationCapacity;
            float WritingSpeed = WriteSpeed * InformationCapacity;
            ReadingSpeed /= 60;
            WritingSpeed /= 60;
            int needMediaCount = 1;
            if (Capacity < InformationCapacity)
            {
                needMediaCount = Convert.ToInt32(InformationCapacity /= Capacity);
                needMediaCount++;
            }
            Console.WriteLine($"Speed of Write in Flash is {WritingSpeed} minutes, Speed of Read in DVD is {ReadingSpeed} minutes");
            Console.WriteLine($"You need {needMediaCount} DVD memory");
        }
        public override float FreeMemory()
        {
            return base.FreeMemory();
        }
    }
}
