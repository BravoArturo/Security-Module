namespace DATOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asfasf : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.informes", "hsagregoU", c => c.String());
            DropColumn("dbo.informes", "hsmodificarG");
        }
        
        public override void Down()
        {
            AddColumn("dbo.informes", "hsmodificarG", c => c.String());
            DropColumn("dbo.informes", "hsagregoU");
        }
    }
}
