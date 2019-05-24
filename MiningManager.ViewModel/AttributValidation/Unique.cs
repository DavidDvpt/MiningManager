using MiningManager.Repository;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MiningManager.ViewModel.AttributValidation
{
    public class Unique : ValidationAttribute
    {
        // Tester les annotations plutot que API fluent
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Type t = validationContext.ObjectType;
            MiningContext ctx = new MiningContext();
            // Recuperation de l'id de l'item
            int actualId;
            actualId = ((CommunEditViewData)validationContext.ObjectInstance).Id > 0 ? ((CommunEditViewData)validationContext.ObjectInstance).Id : 0;
            
            if (validationContext.DisplayName == "Code")
            {
                // Verification du doublon de code
                if ((string)value == "" || (string)value == null)
                    return ValidationResult.Success;
                var containsCode = ctx.Unstackables.Any(x => x.Code == value.ToString() && x.Id != actualId);

                if (containsCode)
                {
                    return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
                }
                else
                {
                    return ValidationResult.Success;
                }
            }
            else
            {
                // Verification du doublon de nom
                var contains = ctx.Communs.Any(x => x.Nom == value.ToString() && x.Id != actualId);
                if (contains)
                {
                    return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
                }
                else
                {
                    return ValidationResult.Success;
                }
            }
            }


    }
}
