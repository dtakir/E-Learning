using Entities.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CourseValidator: AbstractValidator<Course>
    {
        public CourseValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Name).Length(3,50);
            RuleFor(c => c.Price).NotEmpty();
            RuleFor(c => c.Price).GreaterThan(0);
            RuleFor(c => c.Description).MaximumLength(500);
        }
    }
}
