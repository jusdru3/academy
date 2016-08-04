namespace DatabaseLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UsageDatas", "ComputerMetric_ComputerMetricId", c => c.Int());
            CreateIndex("dbo.UsageDatas", "ComputerMetric_ComputerMetricId");
            AddForeignKey("dbo.UsageDatas", "ComputerMetric_ComputerMetricId", "dbo.ComputerMetrics", "ComputerMetricId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UsageDatas", "ComputerMetric_ComputerMetricId", "dbo.ComputerMetrics");
            DropIndex("dbo.UsageDatas", new[] { "ComputerMetric_ComputerMetricId" });
            DropColumn("dbo.UsageDatas", "ComputerMetric_ComputerMetricId");
        }
    }
}
