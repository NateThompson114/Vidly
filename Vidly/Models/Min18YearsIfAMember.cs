using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer) validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknown ||
                customer.MembershipTypeId == MembershipType.PayAsYouGo)
            {
                return ValidationResult.Success;
            }
                

            if (customer.Birthdate == null)
                return new ValidationResult("Birthdate is required for Paid Memberships.");

            var age = CalculateAge(customer.Birthdate.Value);

            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Customer must be at least 18 to have a membership.");
        }

        internal int CalculateAge(DateTime birthDate)
        {
            var now = DateTime.Now;
            var age = now.Year - birthDate.Year;

            if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
            {
                age--;
            }

            return age;
        }
    }
}