using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public abstract class DataManager
    {
        public virtual string GetMetric(Hardware type)
        {
            var value = "";
            switch (type)
            {
                case Hardware.CpuUsage:
                    var searcher = new ManagementObjectSearcher("select * from Win32_PerfFormattedData_PerfOS_Processor");
                    foreach (var obj in searcher.Get().Cast<ManagementObject>())
                    {
                        value = obj["PercentProcessorTime"].ToString();
                        break;
                    }
                    break;
                case Hardware.Name:
                    value = Environment.MachineName;
                    break;
                case Hardware.User:
                    value = Environment.UserName;
                    break;
                case Hardware.Cpu:
                    using (
                        ManagementObjectSearcher win32Proc =
                            new ManagementObjectSearcher("select * from Win32_Processor"),
                            win32CompSys = new ManagementObjectSearcher("select * from Win32_ComputerSystem"),
                            win32Memory = new ManagementObjectSearcher("select * from Win32_PhysicalMemory"))
                    {
                        foreach (ManagementObject obj in win32Proc.Get())
                        {
                            value = obj["Name"].ToString();
                        }

                    }
                    break;
                case Hardware.Ram:
                    ObjectQuery wqlRAM = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
                    ManagementObjectSearcher searcherRam = new ManagementObjectSearcher(wqlRAM);
                    ManagementObjectCollection resultsRam = searcherRam.Get();
                    foreach (ManagementObject result in resultsRam)
                    {
                        value = result["TotalVisibleMemorySize"].ToString();
                    }
                    break;
                case Hardware.RamUsage:
                    ObjectQuery wqlRamUsage = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
                    ManagementObjectSearcher searcherRamUsage = new ManagementObjectSearcher(wqlRamUsage);
                    ManagementObjectCollection resultsRamUsage = searcherRamUsage.Get();
                    foreach (ManagementObject result in resultsRamUsage)
                    {
                        var temp = (ulong) result["TotalVisibleMemorySize"] - (ulong) result["FreePhysicalMemory"];
                        value = temp.ToString();
                    }
                    break;
                case Hardware.VideoCard:
                    ManagementObjectSearcher searcherGPU= new ManagementObjectSearcher("SELECT * FROM Win32_DisplayConfiguration");
                    foreach (ManagementObject mo in searcherGPU.Get())
                    {
                        foreach (PropertyData property in mo.Properties)
                        {
                            if (property.Name == "Description")
                            {
                                value = property.Value.ToString();
                            }
                        }
                    }
                    break;
                case Hardware.Ip:
                    var host = Dns.GetHostEntry(Dns.GetHostName());
                    foreach (var ip in host.AddressList)
                    {
                        if (ip.AddressFamily == AddressFamily.InterNetwork)
                        {
                            value= ip.ToString();
                        }
                    }
                    break;
                case Hardware.AvailableDiskSpaceGb:
                    long size = 0;
                    foreach (DriveInfo drive in DriveInfo.GetDrives())
                    {
                        if (drive.IsReady)
                        {
                            size+= drive.TotalSize / (1024 * 1024 * 1024);
                        }
                    }
                    value = size.ToString();
                    break;
                case Hardware.AverageDiskQueueLength:
                    var searcherAverage = new ManagementObjectSearcher("select * from Win32_PerfFormattedData_PerfDisk_PhysicalDisk");
                    foreach (var obj in searcherAverage.Get().Cast<ManagementObject>())
                    {
                        value = obj["AvgDiskReadQueueLength"].ToString();
                        break;
                    }
                    break;

                default:
                    value = "";
                    break;

            }

            return value;
        }

        public abstract ComputerSummary GetComputerSummary();
        public abstract List<string> GetApplicationList();
        public abstract List<string> GetHardwareList();
    }
}
