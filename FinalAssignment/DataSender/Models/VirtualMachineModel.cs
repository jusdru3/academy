using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSender.Models
{
    public class VirtualMachineModel
    {
        public int VirtualMachineId { get; set; }
        public int HostId { get; set; }
        public string Name { get; set; }
        public int State { get; set; }
        public int VirtualProcessorCount { get; set; }
        public VirtualMemory VirtualMemory { get; set; }
    }

    public class VirtualMemory
    {
        public int value { get; set; }
        public int unit { get; set; }
    }
    
}
