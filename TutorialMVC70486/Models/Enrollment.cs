using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TutorialMVC70486.Models
{
    public enum Grado
    {
        A,B,C,D,F
    }

    public class Enrollment
    {
        public virtual int enrollmentID { get; set; }
        public virtual int cursoID { get; set; }
        public virtual int estudianteID { get; set; }
        public Grado? grado { get; set; }
        public virtual Curso curso { get; set; }
        public virtual Estudiante estudiante { get; set; }
    }
}