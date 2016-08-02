using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using DataLayer;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullDataManager = new FullDataManager();
            var hardwareList = fullDataManager.GetHardwareList();
            var applicationsList = fullDataManager.GetApplicationList();
            Console.WriteLine("Hardware: ");
            foreach (var hard in hardwareList)
            {
                Console.WriteLine(hard);
            }
            Console.WriteLine("-------------------");
            Console.WriteLine("Applications:");
            foreach (var app in applicationsList)
            {
                Console.WriteLine(app);
            }
            Console.WriteLine("-------------------");
            Console.ReadLine();
        }
    }
}
