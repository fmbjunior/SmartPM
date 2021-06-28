using FluentValidation;
using SmartPM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPM.Service.Validators
{
    public class ImageProductValidator : AbstractValidator<ImageProduct>
    {
        public ImageProductValidator()
        {
            RuleFor(c => c.Path)
                .NotEmpty().WithMessage("Path cannot be empty.")
                .NotNull().WithMessage("Path cannot be null.");
            
            RuleFor(c => c.ProductId)
                .GreaterThan(0).WithMessage("ProductId must be great than 0");
        }
    }
}
