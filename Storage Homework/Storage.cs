using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    abstract class Storage
    {
        public string Model { get; set; }
        public string ModelName { get; set; }
        public float Capacity { get; set; }
        public float InformationCapacity { get; set; }


        public abstract void Copy();
        public virtual float FreeMemory()
        {
            if (Capacity > InformationCapacity)
            {
                return Capacity - InformationCapacity;
            }
            return 0;
        }
        public virtual float ReservedMemory()
        {
            if (Capacity < InformationCapacity)
            {
                return Capacity;
            }
            return InformationCapacity;
        }
        public virtual void PrintDeviceInfo()
        {
            Console.WriteLine("===============================");
            Console.WriteLine($"Model : {Model}");
            Console.WriteLine($"Model Name : {ModelName}");
            Console.WriteLine($"Model Capacity : {Capacity}");
            Console.WriteLine($"Model Free memory : {FreeMemory()}");
            Console.WriteLine($"Model Rezerved memory : {ReservedMemory()}");
        }
    }
}
