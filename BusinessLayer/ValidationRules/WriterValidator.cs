using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı - Soyadı Boş Geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Yazar Mail Adresi Boş Geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Yazar Şifresi Boş Geçilemez");

            RuleFor(n => n.WriterName).MinimumLength(2).WithMessage("En Az 2 karakter yazınız.");
            RuleFor(m => m.WriterName).MaximumLength(15).WithMessage("En Fazla 15 Karakter Yazınız");

        }

    }
}
