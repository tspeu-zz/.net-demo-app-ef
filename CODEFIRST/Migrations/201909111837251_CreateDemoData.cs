namespace CODEFIRST.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDemoData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DemoDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        LocalTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DemoDatas");
        }
    }
}
