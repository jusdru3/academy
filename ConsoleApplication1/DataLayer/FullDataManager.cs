using System;
using System.Collections.Generic;
using System.Management;
using System.Net;

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

        public List<string> GetHardwareListFromRemote()
        {
            var list = new List<string>();
            ManagementScope scope = new ManagementScope();
            try
            {
                //get the credentials to connect to this computer with
                ConnectionOptions options = new ConnectionOptions();
                options.Username = "academy";
                options.Password = "academy";
                options.EnablePrivileges = true;
                options.Authority = "ntlmdomain: ";
                //Create the scope that will connect to the default root for WMI
                scope = new ManagementScope(@"\\dazgen-wpc\root\CIMV2″, options");
                scope.Connect();
                //query the computer for the OS information
                SelectQuery query = new SelectQuery("SELECT * FROM Win32_OperatingSystem");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
                using (ManagementObjectCollection queryCollection = searcher.Get())
                {
                    foreach (ManagementObject m in queryCollection)
                    {
                        // Display the remote computer’s information in our labels
                         list.Add(string.Format(";Computer Name: { 0}", m["csname"]));
                        //Label1.Text = string.Format(“Windows Directory: { 0}”, m[“WindowsDirectory”]);
                        //Label1.Text = string.Format(“Operating System: { 0}”, m[“Caption”]);
                        //Label1.Text = string.Format(“Version: { 0}”, m[“Version”]);
                        //Label1.Text = string.Format(“Manufacturer: { 0}”, m[“Manufacturer”]);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }



            

            return list;
        }
    }
}
