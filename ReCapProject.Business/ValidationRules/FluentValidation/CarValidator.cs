using FluentValidation;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.Description).MinimumLength(2);
            RuleFor(p => p.DailyPrice).GreaterThan(200);
            RuleFor(p => p.Description).Must(StartWithX);
        }

        private bool StartWithX(string arg)
        {
            return arg.StartsWith("X");
        }

    }
}
