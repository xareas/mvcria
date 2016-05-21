using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime;
using System.Web;

namespace TutorialMVC70486.Models
{
    public class Estudiante
    {
        public int estudianteID { get; set; }
        [Required, Display(Name = "Nombre")]
        public string midName { get; set; }

        [Required,Display(Name = "Apellidos")]
        public string lastName { get; set; }
    

        [Display(Name ="Fecha Inscrito")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime enrollmentDate { get; set; }
        public virtual ICollection<Enrollment> enrollments { get; set; }

    }
}