using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Linq;

namespace NetBLog.Api.Aspects
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class ParameterValidatorAttribute : ActionFilterAttribute
    {
        private readonly IValidator _validator;
        public ParameterValidatorAttribute(Type validatorType)
        {
            _validator = Activator.CreateInstance(validatorType) as IValidator;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.ActionArguments != null && context.ActionArguments.Count > 0)
            {
                foreach (var item in context.ActionArguments)
                {
                    var input = item.Value;
                    if (_validator.CanValidateInstancesOfType(input.GetType()))
                    {
                        var result = _validator.Validate(input);
                        if (!result.IsValid)
                        {
                            context.Result = new BadRequestObjectResult(new { errors = result.Errors.Select(x => x.ErrorMessage).ToArray() });
                        }
                    }
                }
            }
        }
    }
}
