namespace DatabaseLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ComputerMetrics",
                c => new
                    {
                        ComputerMetricId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        User = c.String(),
                        Cpu = c.String(),
                        Ram = c.Int(nullable: false),
                        VideoCard = c.String(),
                        Ip = c.String(),
                    })
                .PrimaryKey(t => t.ComputerMetricId);
            
            CreateTable(
                "dbo.UsageDatas",
                c => new
                    {
                        UsageDataId = c.Int(nullable: false, identity: true),
                        CpuUsage = c.Int(nullable: false),
                        RamUsage = c.Int(nullable: false),
                        AvailableDiskSpaceGb = c.Int(nullable: false),
                        AverageDiskQueueLength = c.Int(nullable: false),
                        Time = c.DateTime(),
                    })
                .PrimaryKey(t => t.UsageDataId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UsageDatas");
            DropTable("dbo.ComputerMetrics");
        }
    }
}
