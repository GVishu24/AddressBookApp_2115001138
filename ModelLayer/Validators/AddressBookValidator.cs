using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using ModelLayer.DTO;

namespace ModelLayer.Validators
{
    public class AddressBookValidator : AbstractValidator<AddressBookDTO>
    {
        public AddressBookValidator()
        {
            RuleFor(a => a.PersonName)
                .NotEmpty().WithMessage("Person name is required")
                .MaximumLength(100);

            RuleFor(a => a.Address)
                .NotEmpty().WithMessage("Address is required");

            RuleFor(a => a.PhoneNumber)
                .NotEmpty().WithMessage("Phone number is required")
                .Matches(@"^\d{10}$").WithMessage("Phone number must be 10 digits.");

            RuleFor(a => a.Email)
                .NotEmpty().WithMessage("Email is required")
                .EmailAddress().WithMessage("Invalid email format.");
        }
    }
}