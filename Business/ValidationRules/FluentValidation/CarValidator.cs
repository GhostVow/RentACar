﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Kilometer).NotEmpty();
            
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(5);
            
            RuleFor(c => c.Description).MinimumLength(10);

            RuleFor(c => c.ModelYear).NotEmpty();
        }
    }
}
