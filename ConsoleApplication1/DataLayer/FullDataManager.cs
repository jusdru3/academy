using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class FullDataManager : DataManager
    {
        public override ComputerSummary GetComputerSummary()
        {
            
            var computerSummary = new ComputerSummary();
            try
            {
                computerSummary.Name = GetMetric(Hardware.Name);
                computerSummary.CpuUsage = int.Parse(GetMetric(Hardware.CpuUsage));
                computerSummary.User = GetMetric(Hardware.User);
                computerSummary.Cpu = GetMetric(Hardware.Cpu);
                computerSummary.Ram = int.Parse(GetMetric(Hardware.Ram));
                computerSummary.RamUsage = int.Parse(GetMetric(Hardware.RamUsage));
                computerSummary.VideoCard = GetMetric(Hardware.VideoCard);
                computerSummary.Ip = IPAddress.Parse(GetMetric(Hardware.Ip));
                computerSummary.AvailableDiskSpaceGb = int.Parse(GetMetric(Hardware.AvailableDiskSpaceGb));
                computerSummary.AverageDiskQueueLength = int.Parse(GetMetric(Hardware.AverageDiskQueueLength));
            }
            catch (Exception e)
            {
                Console.Write(e.StackTrace);
            }



            return computerSummary;
        }

        public override List<string> GetApplicationList()
        {
            throw new NotImplementedException();
        }

        public override List<string> GetHardwareList()
        {
            throw new NotImplementedException();
        }
    }
}
