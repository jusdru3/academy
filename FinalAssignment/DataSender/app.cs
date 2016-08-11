using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DataSender.Models;
using DataSender.Services;

namespace DataSender
{
    class App
    {
        private DataSenderService _dataSenderSerivce;
        private WMIService _wmiService;

        public App(WMIService wmiService, DataSenderService dataSenderSerivce)
        {
            _wmiService = wmiService;
            _dataSenderSerivce = dataSenderSerivce;
        }

        public void main()
        {

            Timer t = new Timer(AddComputerUsageData, null, 0, 5000);
            Console.ReadKey();

        }

        private void AddComputerUsageData(object state)
        {
            var cm = new ComputerModel();
            cm.ProcessorUsage = Int32.Parse(_wmiService.getCPUUsage());
            cm.MemoryUsage = Int32.Parse(_wmiService.getRamUsage());
            cm.TimeStamp = DateTime.Now;
             _dataSenderSerivce.SendToApi(cm);
            Console.WriteLine("send data with timestamp:"+cm.TimeStamp.ToString());
        }
    }
}
