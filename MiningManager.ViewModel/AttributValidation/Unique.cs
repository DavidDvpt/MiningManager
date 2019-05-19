﻿using MiningManager.Repository;
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

            //Verification que le Nom n'existe pas avec un id different
            // si on verifie pas l'il, la notification Unique se declenche si simmple modif de l'item

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
