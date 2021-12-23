using System;
using System.Collections.Generic;
using System.Text;

namespace FluentValidation.Dto.Dto.Product
{
    public class ProductDtoValidator : AbstractValidator<ProductDto>
    {
        public ProductDtoValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Ürün Başlığını Boş Bırakmayınız");
        }
    }
}
