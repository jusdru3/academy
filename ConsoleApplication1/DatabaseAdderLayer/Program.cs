using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DatabaseLayer;
using DataLayer;
using DatabaseLayer.DAL;

namespace DatabaseAdderLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            AddComputerMetrics();
            
            Timer t = new Timer(AddComputerUsageData, null, 0, 2000);
            Console.WriteLine("monitoring data has started. press any key to stop");
            Console.ReadKey();
            t.Dispose(); // Cancel the timer now
        }

        static void AddComputerMetrics()
        {
            var fullDataManager = new FullDataManager();
            var computersummary = fullDataManager.GetComputerSummary();
            using (var _ctx = new MetricsContext())
            {
                var metrics = _ctx.ComputerMetrics.FirstOrDefault(p => p.Name == computersummary.Name);
                if (metrics == null)
                {
                    metrics = _ctx.ComputerMetrics.Create();
                    metrics.Cpu = computersummary.Cpu;
                    metrics.Ip = computersummary.Ip.ToString();
                    metrics.Name = computersummary.Name;
                    metrics.Ram = computersummary.Ram;
                    metrics.User = computersummary.User;
                    metrics.VideoCard = computersummary.VideoCard;
                    _ctx.ComputerMetrics.Add(metrics);
                    _ctx.SaveChanges();
                }
            }
        }

        static void AddComputerUsageData(Object o)
        {
            var fullDataManager = new FullDataManager();
            var computersummary = fullDataManager.GetComputerSummary();
            using (var _ctx = new MetricsContext())
            {
                var metrics = _ctx.ComputerMetrics.FirstOrDefault(p => p.Name == computersummary.Name);
                metrics.UsageDatas.Add(new UsageData()
                {
                    AvailableDiskSpaceGb = computersummary.AvailableDiskSpaceGb,
                    AverageDiskQueueLength = computersummary.AverageDiskQueueLength,
                    CpuUsage = computersummary.CpuUsage,
                    RamUsage = computersummary.RamUsage,
                    Time = DateTime.Now,
                });
                _ctx.SaveChanges();
            }
        }

    }
}
