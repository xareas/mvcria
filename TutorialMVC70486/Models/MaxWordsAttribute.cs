using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace TutorialMVC70486.Models
{
    public class MaxWordsAttribute: ValidationAttribute,IClientValidatable
    {
        private readonly int _maxwords;
        public MaxWordsAttribute(int noWords) :base("El {0} admite un maximo de " + noWords + " palabras ")
        {
            _maxwords = noWords;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var strvalue = value.ToString();
                var noPalabras = strvalue.Split(' ').Length;
                var fieldName = validationContext.DisplayName;
                var fld = nameof(fieldName); //no se usa para nada es solo prueba
                if (noPalabras > _maxwords)
                {
                    
                    var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                    ErrorMessage = $"debe tener al menos {noPalabras} palabras ,en el campo {fieldName}";
                    return new ValidationResult(errorMessage);
                }
                return ValidationResult.Success;
            }
            return ValidationResult.Success;
        }


        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            var rule = new ModelClientValidationRule
            {
                ErrorMessage = FormatErrorMessage(metadata.GetDisplayName()),
                ValidationType = "maxwords"
            };

            rule.ValidationParameters.Add("wordcount",_maxwords);
            rule.ValidationParameters.Add("hijo1","jonathan");
            rule.ValidationParameters.Add("hijo2","Kenneth");
            rule.ValidationParameters.Add("esposa","nora");
            yield return rule;
        }
    }
}