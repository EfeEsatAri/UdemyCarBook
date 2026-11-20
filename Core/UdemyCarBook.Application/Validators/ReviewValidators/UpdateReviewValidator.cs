using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Commands.ReviewCommands;

namespace UdemyCarBook.Application.Validators.ReviewValidators
{
    public class UpdateReviewValidator:AbstractValidator<UpdateReviewCommand>
    {
        public UpdateReviewValidator()
        {
            RuleFor(x=> x.CustomerName).NotEmpty().WithMessage("Lütfen müşteri adını boş geçmeyiniz");
            RuleFor(x => x.CustomerName).MinimumLength(5).WithMessage("Lütfen en az 5 karakter girişi yapınız");
            RuleFor(x => x.CustomerImage).NotEmpty().WithMessage("Lütfen müşteri resmini boş geçmeyiniz");
            RuleFor(x => x.Comment).NotEmpty().WithMessage("Lütfen yorum kısmını boş geçmeyiniz");
            RuleFor(x => x.RaytingValue).NotEmpty().WithMessage("Lütfen puan kısmını boş geçmeyiniz");
            RuleFor(x => x.ReviewDate).NotEmpty().WithMessage("Lütfen tarih kısmını boş geçmeyiniz");
            RuleFor(x => x.CarID).NotEmpty().WithMessage("Lütfen araç ID'sini boş geçmeyiniz");
        }
    }
}
