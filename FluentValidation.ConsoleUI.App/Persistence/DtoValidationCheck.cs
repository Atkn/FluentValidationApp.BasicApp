using FluentValidation.Dto.Dto;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluentValidation.ConsoleUI.App.Persistence
{
    public class DtoValidationCheck
    {
        public void HasError(ProductDto product, ValidationResult result)
        {
            Console.WriteLine($"Product Id: {product.Id}, Product Name: {product.Title}");
            if (!result.IsValid)
                Console.ForegroundColor = ConsoleColor.Red;
            ((List<FluentValidation.Results.ValidationFailure>)result.Errors).ForEach(e => Console.WriteLine(e.ErrorMessage));
            else
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{product.Id} - {product.Title} Başarıyla Oluştu");
        }
    }
}
