using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public class ComputerMetric
    {
        public ComputerMetric()
        {
            UsageDatas = new List<UsageData>();
        }
        public int ComputerMetricId { get; set; }
        public string Name { get; set; }
        public string User { get; set; }
        public string Cpu { get; set; }
        public int Ram { get; set; }
        public string VideoCard { get; set; }
        public string Ip { get; set; }
        public ICollection<UsageData> UsageDatas { get; set; }

    }
}
