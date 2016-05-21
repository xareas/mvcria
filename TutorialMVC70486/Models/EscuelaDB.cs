using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace TutorialMVC70486.Models
{
    public class EscuelaDB :DbContext
    {
        public EscuelaDB() : base("EscuelaCnn")
        {
        }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Curso> Cursos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }


    }
}