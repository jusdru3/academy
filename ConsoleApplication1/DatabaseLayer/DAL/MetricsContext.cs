using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.DAL
{
    public class MetricsContext : DbContext
    {
        public MetricsContext() : base()
    {
  /*          var cs = ConfigurationManager.ConnectionStrings["DefaultConnection"]
                                         .ConnectionString;
*/
            this.Database.Connection.ConnectionString = "Data Source =.; Database = Academy; Integrated Security = True";
        }

        public DbSet<ComputerMetric> ComputerMetrics { get; set; }
        public DbSet<UsageData> UsageDatas { get; set; }
    }
}

