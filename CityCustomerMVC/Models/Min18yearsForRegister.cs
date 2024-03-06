using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CityCustomerMVC.Models
{
    public class Min18yearsForRegister : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer=(Customer) validationContext.ObjectInstance;

            if (customer.DateTime == null)
                return new ValidationResult("You have to put your birthdate");


            var age = DateTime.Today.Year-customer.DateTime.Year;

            if (age >= 18)
            {
                return ValidationResult.Success;
            }
            else
                return new ValidationResult("You must be at least 18 years old to register");

            
        }

    }
} 