using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TutorialMVC70486.Models
{
    public class Curso : IValidatableObject
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cursoID { get; set; }

        [Required]
        [StringLength(200)]
        [MaxWords(2)]
        public string Title { get; set; }

        [Required]
        [Range(1,10)]
        [Remote("ValidaCredito","Curso",ErrorMessage = "El {0} no debe tener el valor de cinco")]
        public int credits { get; set; }

        [Display(Name = "FechaApertura")]
        [UIHint("Fecha")]
        public DateTime Fecha { get; set; }
        public virtual ICollection<Enrollment> enrollments { get; set; }
        
        #region Implementado la interfaz IValidatableObject
            public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
            {
                var memberNames= new List<string>();
                if (Title.Length == 5 && credits == 2)
                {
                   memberNames.Add(nameof(Title));
                   yield return new ValidationResult("!!!ding ding ding...error fatal",memberNames); 
                }

                if (Title.Length == 5 && credits == 3)
                {
                  memberNames.Add(nameof(credits));
                  yield return new ValidationResult("Si titulo igual cinco y credito igual 3, problema",memberNames);
                }
            }
       #endregion
    }
}