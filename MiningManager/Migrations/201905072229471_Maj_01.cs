namespace MiningManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Maj_01 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Setup", new[] { "FinderAmplifierId" });
            AlterColumn("dbo.Unstackable", "Code", c => c.String(maxLength: 10));
            AlterColumn("dbo.Setup", "FinderAmplifierId", c => c.Int());
            AlterColumn("dbo.Setup", "DepthEnhancerQty", c => c.Short());
            AlterColumn("dbo.Setup", "RangeEnhancerQty", c => c.Short());
            AlterColumn("dbo.Setup", "SkillEnhancerQty", c => c.Short());
            CreateIndex("dbo.Setup", "FinderAmplifierId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Setup", new[] { "FinderAmplifierId" });
            AlterColumn("dbo.Setup", "SkillEnhancerQty", c => c.Short(nullable: false));
            AlterColumn("dbo.Setup", "RangeEnhancerQty", c => c.Short(nullable: false));
            AlterColumn("dbo.Setup", "DepthEnhancerQty", c => c.Short(nullable: false));
            AlterColumn("dbo.Setup", "FinderAmplifierId", c => c.Int(nullable: false));
            AlterColumn("dbo.Unstackable", "Code", c => c.String());
            CreateIndex("dbo.Setup", "FinderAmplifierId");
        }
    }
}
