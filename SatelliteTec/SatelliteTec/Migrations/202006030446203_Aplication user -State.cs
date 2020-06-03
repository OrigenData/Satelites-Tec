namespace SatelliteTec.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AplicationuserState : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "State", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "State");
        }
    }
}
