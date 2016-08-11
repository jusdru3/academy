using System.Linq;
using System.Management;

namespace DataSender.Services
{
    public class WMIService
    {
        public string getCPUUsage()
        {
            string value ="";
            var searcher = new ManagementObjectSearcher("select * from Win32_PerfFormattedData_PerfOS_Processor");
            foreach (var obj in searcher.Get().Cast<ManagementObject>())
            {
                value = obj["PercentProcessorTime"].ToString();
            }
            return value;
        }

        public string getRamUsage()
        {
            string value = "";
            ObjectQuery wqlRamUsage = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcherRamUsage = new ManagementObjectSearcher(wqlRamUsage);
            ManagementObjectCollection resultsRamUsage = searcherRamUsage.Get();
            foreach (ManagementObject result in resultsRamUsage)
            {
                var temp = (ulong)result["FreePhysicalMemory"] /(ulong)result["TotalVisibleMemorySize"] ;
                value = temp.ToString();
            }
            return value;
        }
    }
}