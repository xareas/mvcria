using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TutorialMVC70486.Models
{
    public class EscuelaDbInit :DropCreateDatabaseIfModelChanges<EscuelaDB>
    {
        protected override void Seed(EscuelaDB context)
        {
            var students = new List<Estudiante>
            {
            new Estudiante{midName= "Francisco",lastName= "Areas",enrollmentDate= DateTime.Parse("2015-09-01")},
            new Estudiante{midName="Jonathan",lastName="Alonso",enrollmentDate=DateTime.Parse("2015-09-01")},
            new Estudiante{midName="Arturo",lastName="Tres Pelos",enrollmentDate=DateTime.Parse("2015-09-01")},
            new Estudiante{midName="Kenneth",lastName="Areas",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName="Ivania",lastName="Duarte",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName="Domingo",lastName="Ortiz",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName="Laura",lastName="Antonia",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName="Manuel",lastName="Rivera",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName= "Francisco2",lastName= "Areas",enrollmentDate= DateTime.Parse("2015-09-01")},
            new Estudiante{midName="Jonathan2",lastName="Alonso",enrollmentDate=DateTime.Parse("2015-09-01")},
            new Estudiante{midName="Arturo2",lastName="Tres Pelos",enrollmentDate=DateTime.Parse("2015-09-01")},
            new Estudiante{midName="Kenneth2",lastName="Areas",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName="Ivania2",lastName="Duarte",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName="Domingo2",lastName="Ortiz",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName="Laura2",lastName="Antonia",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName="Manuel2",lastName="Rivera",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName= "Francisco3",lastName= "Areas",enrollmentDate= DateTime.Parse("2015-09-01")},
            new Estudiante{midName="Jonathan3",lastName="Alonso",enrollmentDate=DateTime.Parse("2015-09-01")},
            new Estudiante{midName="Arturo3",lastName="Tres Pelos",enrollmentDate=DateTime.Parse("2015-09-01")},
            new Estudiante{midName="Kenneth3",lastName="Areas",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName="Ivania3",lastName="Duarte",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName="Domingo3",lastName="Ortiz",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName="Laura3",lastName="Antonia",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName="Manuel3",lastName="Rivera",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName= "Francisco4",lastName= "Areas",enrollmentDate= DateTime.Parse("2015-09-01")},
            new Estudiante{midName="Jonathan4",lastName="Alonso",enrollmentDate=DateTime.Parse("2015-09-01")},
            new Estudiante{midName="Arturo4",lastName="Tres Pelos",enrollmentDate=DateTime.Parse("2015-09-01")},
            new Estudiante{midName="Kenneth4",lastName="Areas",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName="Ivania4",lastName="Duarte",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName="Domingo4",lastName="Ortiz",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName="Laura4",lastName="Antonia",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName="Manuel4",lastName="Rivera",enrollmentDate=DateTime.Parse("2016-09-01")},
             new Estudiante{midName= "Francisco5",lastName= "Areas",enrollmentDate= DateTime.Parse("2015-09-01")},
            new Estudiante{midName="Jonathan5",lastName="Alonso",enrollmentDate=DateTime.Parse("2015-09-01")},
            new Estudiante{midName="Arturo5",lastName="Tres Pelos",enrollmentDate=DateTime.Parse("2015-09-01")},
            new Estudiante{midName="Kenneth5",lastName="Areas",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName="Ivania5",lastName="Duarte",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName="Domingo5",lastName="Ortiz",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName="Laura5",lastName="Antonia",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName="Manuel5",lastName="Rivera",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName= "Francisco6",lastName= "Areas",enrollmentDate= DateTime.Parse("2015-09-01")},
            new Estudiante{midName="Jonathan6",lastName="Alonso",enrollmentDate=DateTime.Parse("2015-09-01")},
            new Estudiante{midName="Arturo6",lastName="Tres Pelos",enrollmentDate=DateTime.Parse("2015-09-01")},
            new Estudiante{midName="Kenneth6",lastName="Areas",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName="Ivania6",lastName="Duarte",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName="Domingo6",lastName="Ortiz",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName="Laura6",lastName="Antonia",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName="Manuel6",lastName="Rivera",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName= "Francisco7",lastName= "Areas",enrollmentDate= DateTime.Parse("2015-09-01")},
            new Estudiante{midName="Jonathan7",lastName="Alonso",enrollmentDate=DateTime.Parse("2015-09-01")},
            new Estudiante{midName="Arturo7",lastName="Tres Pelos",enrollmentDate=DateTime.Parse("2015-09-01")},
            new Estudiante{midName="Kenneth7",lastName="Areas",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName="Ivania7",lastName="Duarte",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName="Domingo7",lastName="Ortiz",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName="Laura7",lastName="Antonia",enrollmentDate=DateTime.Parse("2016-09-01")},
            new Estudiante{midName="Manuel7",lastName="Rivera",enrollmentDate=DateTime.Parse("2016-09-01")}


            };
           
            students.ForEach(s => context.Estudiantes.Add(s));
            context.SaveChanges();


            var courses = new List<Curso>
            {
            new Curso{cursoID= 1050,Title="Quimica",credits= 3,},
            new Curso{cursoID= 4022,Title="MicroEconomia",credits=3,},
            new Curso{cursoID=4041,Title="Calculo",credits=3,},
            new Curso{cursoID=1045,Title="Inteligencia Artificial",credits=4,},
            new Curso{cursoID=3141,Title="Patrones de Software",credits=4,},
            new Curso{cursoID=2021,Title="Arquitectura de Software",credits=3,},
            new Curso{cursoID=2042,Title="Inteligencia de Negocios",credits=4,}
            };

            courses.ForEach(s => context.Cursos.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
            new Enrollment{estudianteID=1,cursoID= 1050,grado=Grado.A},
            new Enrollment{estudianteID=1,cursoID=4022,grado=Grado.C},
            new Enrollment{estudianteID=1,cursoID=4041,grado=Grado.B},
            new Enrollment{estudianteID=2,cursoID=1045,grado=Grado.B},
            new Enrollment{estudianteID=2,cursoID=3141,grado=Grado.F},
            new Enrollment{estudianteID=2,cursoID=2021,grado=Grado.F},
            new Enrollment{estudianteID=3,cursoID=1050},
            new Enrollment{estudianteID=4,cursoID=1050,},
            new Enrollment{estudianteID=4,cursoID=4022,grado=Grado.F},
            new Enrollment{estudianteID=5,cursoID=4041,grado=Grado.C},
            new Enrollment{estudianteID=6,cursoID=1045},
            new Enrollment{estudianteID=7,cursoID=3141,grado=Grado.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();

            base.Seed(context);
        }
    }
}