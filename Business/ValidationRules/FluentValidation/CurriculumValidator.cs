using Entities.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CurriculumValidator: AbstractValidator<Curriculum>
    {
        public CurriculumValidator()
        {
            RuleFor(c=>c.Name).NotEmpty();
            RuleFor(c => c.Duration).NotEmpty();

        }
    }
}
