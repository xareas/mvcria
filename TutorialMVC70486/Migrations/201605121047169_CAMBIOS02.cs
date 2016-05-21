namespace TutorialMVC70486.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CAMBIOS02 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Curso", "Fecha", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Curso", "Fecha");
        }
    }
}
