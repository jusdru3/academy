using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
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
            var list = new List<string>();
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_Product");
            foreach (ManagementObject mo in mos.Get())
            {
                if (mo["Name"] != null)
                {
                    list.Add(mo["Name"]?.ToString());
                }
            }
            return list;
        }

        public override List<string> GetHardwareList()
        {
            var list = new List<string>();
            var computerSummary = GetComputerSummary();
            list.Add($"Computer Name: {computerSummary.Name}");
            list.Add($"Computer User: {computerSummary.User}");
            list.Add($"Computer CPU: {computerSummary.Cpu}");
            list.Add($"Computer RAM: {computerSummary.Ram}");
            list.Add($"Computer GPU: {computerSummary.VideoCard}");
            list.Add($"Computer IP: {computerSummary.Ip.ToString()}");
            list.Add($"Computer CPU usage: {computerSummary.CpuUsage}");
            list.Add($"Computer Ram used: {computerSummary.RamUsage}");
            list.Add($"Computer Availabe disk space in GB: {computerSummary.AvailableDiskSpaceGb}");
            list.Add($"Computer average disk queue length: {computerSummary.AverageDiskQueueLength}");
            return list;
        }
    }
}
