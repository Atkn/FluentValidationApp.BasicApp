using FluentValidation.ConsoleUI.App.Persistence;
using FluentValidation.Dto.Dto;
using FluentValidation.Dto.Dto.Product;
using System;

namespace FluentValidation.ConsoleUI.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //products
            var product = new ProductDto
            {
                Id = Guid.NewGuid(),
                Title = "",
            };
            var product2 = new ProductDto
            {
                Id = Guid.NewGuid(),
                Title = "Products 2",
            };

            //validation Check
            var dtoValidCheck = new DtoValidationCheck();
           

            //product valid options
            var productValid = new ProductDtoValidator();


            //errors check for product
            dtoValidCheck.HasError(product, productValid.Validate(product));
            

            //errors check for product2
            dtoValidCheck.HasError(product2, productValid.Validate(product2));

            //end app
            Console.ReadLine();
            
        }

        
    }

}
