namespace Consultancy.Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hello : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Consultancies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Logo = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        lng = c.Double(nullable: false),
                        lat = c.Double(nullable: false),
                        AddedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Consultancies");
        }
    }
}
