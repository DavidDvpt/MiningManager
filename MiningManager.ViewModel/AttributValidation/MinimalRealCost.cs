﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiningManager.ViewModel.AttributValidation
{
    //    public class MinimalRealCost : ValidationAttribute
    //    {
    //        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    //        {
    //            int qty = ((TradeMaterial)validationContext.ObjectInstance).Quantity;
    //            decimal cost = ((TradeMaterial)validationContext.ObjectInstance).Material.Value;
    //            decimal fee = ((TradeMaterial)validationContext.ObjectInstance).Fee;
    //            string ts = ((TradeMaterial)validationContext.ObjectInstance).State.Nom;

    //            if (((decimal)value >= (qty*cost + fee)) && ts != "Achat")
    //            {
    //                return ValidationResult.Success;
    //            }
    //            else
    //            {
    //                return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
    //            }
    //        }
    //    }
}
