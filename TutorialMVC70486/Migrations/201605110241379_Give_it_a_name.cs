namespace TutorialMVC70486.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Give_it_a_name : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Curso", "Title", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Curso", "Title", c => c.String(nullable: false));
        }
    }
}
