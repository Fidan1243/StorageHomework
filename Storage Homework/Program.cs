using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    #region Static

    

    class Program
    {
        static bool Choose(string ch, Storage.Storage dvd, Storage.Storage flash, Storage.Storage hdd)
        {
            Console.Clear();
            if (Convert.ToInt32(ch) == 1)
            {
                Console.WriteLine("1) For Copy Function");
                Console.WriteLine("2) For Print Informations");
                string cho = Console.ReadLine();
                CopyOrPrint(dvd, cho);
                return true;
            }
            else if (Convert.ToInt32(ch) == 2)
            {
                Console.WriteLine("1) For Copy Function");
                Console.WriteLine("2) For Print Informations");
                string cho = Console.ReadLine();
                CopyOrPrint(hdd, cho);
                return true;
            }
            else if (Convert.ToInt32(ch) == 3)
            {
                Console.WriteLine("1) For Copy Function");
                Console.WriteLine("2) For Print Informations");
                string cho = Console.ReadLine();
                CopyOrPrint(flash, cho);
                return true;
            }
            else
            {
                throw new Exception("Choose is invalid");
            }
        }
        static bool CopyOrPrint(Storage.Storage nh, string ch)
        {
            Console.Clear();
            if (Convert.ToInt32(ch) == 1)
            {
                Console.Write("Enter Information Capacity: ");
                nh.InformationCapacity = Convert.ToInt32(Console.ReadLine());
                nh.Copy();
                Thread.Sleep(1000);
                Console.Clear();
                return true;
            }
            else if (Convert.ToInt32(ch) == 2)
            {
                nh.PrintDeviceInfo();
                Thread.Sleep(1000);
                Console.Clear();
                return true;
            }
            else
            {
                throw new Exception("The choose is not valid!");
            }
        }
        static void Main(string[] args)
        {
           Storage.Storage Flash = new Flash.Flash
            {
                Capacity = 500,
                Model = "Flash",
                ModelName = "Adobe",
               InformationCapacity = 210
           };
            Storage.Storage HDD = new HDD.HDD
            {
                Capacity = 500,
                Model = "HDD",
                ModelName = "Samsung",
                InformationCapacity = 800

            };
            Storage.Storage DVD = new DVD.DVD
            {
                Capacity = 890,
                Model = "DVD",
                ModelName = "Adobe",
                InformationCapacity = 300
            };

            Console.WriteLine("1) For Look DVD");
            Console.WriteLine("2) For Look HDD");
            Console.WriteLine("3) For Look Flash");
            string choose = Console.ReadLine();


            while (true)
            {
                try
                {
                    Choose(choose, DVD, Flash, HDD);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Thread.Sleep(600);
                    Console.Clear();
                }
            }
            

        }
    }


    #endregion

}
