using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
namespace FluentValidator2
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            // Set the CascadeMode for this validator
            CascadeMode = CascadeMode.Stop;

            RuleFor(user => user.Name)
                .NotEmpty().WithMessage("Name cannot be empty.")
                .MinimumLength(3).WithMessage("Name must be at least 3 characters long.");

            RuleFor(user => user.Age)
                .GreaterThan(0).WithMessage("Age must be greater than 0.")
                .LessThan(120).WithMessage("Age must be less than 120.");
        }
    }
}
