using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataSender.Services;

namespace DataSender
{
    class Program
    {
        static  void Main(string[] args)
        {
            var url = "http://192.168.10.106/";
            var dataSenderService = new DataSenderService(url);
            var app = new App(new WMIService(), dataSenderService);
            app.main();
        }
    }
}
