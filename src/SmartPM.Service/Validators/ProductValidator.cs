using FluentValidation;
using SmartPM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPM.Service.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Name cannot be empty.")
                .NotNull().WithMessage("Name cannot be null.");
            
            RuleFor(c => c.SalePrice)
                .GreaterThan(0).WithMessage("SalePrice must be great than 0");
            
            RuleFor(c => c.Description)
                .NotEmpty().WithMessage("Description cannot be empty.")
                .NotNull().WithMessage("Description cannot be null.");
            
            RuleFor(c => c.CategoryId)
                .GreaterThan(0).WithMessage("CategoryId must be great than 0");
        }
    }
}
