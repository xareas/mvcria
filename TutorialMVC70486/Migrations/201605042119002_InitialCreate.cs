namespace TutorialMVC70486.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Curso",
                c => new
                    {
                        cursoID = c.Int(nullable: false),
                        Title = c.String(nullable: false),
                        credits = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cursoID);
            
            CreateTable(
                "dbo.Enrollment",
                c => new
                    {
                        enrollmentID = c.Int(nullable: false, identity: true),
                        cursoID = c.Int(nullable: false),
                        estudianteID = c.Int(nullable: false),
                        grado = c.Int(),
                    })
                .PrimaryKey(t => t.enrollmentID)
                .ForeignKey("dbo.Curso", t => t.cursoID, cascadeDelete: true)
                .ForeignKey("dbo.Estudiante", t => t.estudianteID, cascadeDelete: true)
                .Index(t => t.cursoID)
                .Index(t => t.estudianteID);
            
            CreateTable(
                "dbo.Estudiante",
                c => new
                    {
                        estudianteID = c.Int(nullable: false, identity: true),
                        lastName = c.String(nullable: false),
                        midName = c.String(nullable: false),
                        enrollmentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.estudianteID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollment", "estudianteID", "dbo.Estudiante");
            DropForeignKey("dbo.Enrollment", "cursoID", "dbo.Curso");
            DropIndex("dbo.Enrollment", new[] { "estudianteID" });
            DropIndex("dbo.Enrollment", new[] { "cursoID" });
            DropTable("dbo.Estudiante");
            DropTable("dbo.Enrollment");
            DropTable("dbo.Curso");
        }
    }
}
