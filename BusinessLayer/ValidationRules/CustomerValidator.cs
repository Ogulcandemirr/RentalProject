using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.IdentityNumber).NotEmpty().WithMessage("Bu alanı boş geçemezsiniz!");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Bu alanı boş geçemezsiniz!");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Bu alanı boş geçemezsiniz!");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Bu alanı boş geçemezsiniz!");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Bu alanı boş geçemezsiniz!");
            RuleFor(x => x.BirthDate).NotEmpty().WithMessage("Bu alanı boş geçemezsiniz!");
            RuleFor(x => x.City).NotEmpty().WithMessage("Bu alanı boş geçemezsiniz!");
            RuleFor(x => x.LicenceNumber).NotEmpty().WithMessage("Bu alanı boş geçemezsiniz!");
            RuleFor(x => x.Adress).MaximumLength(50).WithMessage("Bu alanı boş geçemezsiniz!");
        }
    }
}
