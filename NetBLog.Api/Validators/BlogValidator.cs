using FluentValidation;
using NetBLog.Contract;
using NetBLog.Resources;

namespace NetBLog.Api.Validators
{
    public class BlogValidator : AbstractValidator<BlogContract>
    {
        public BlogValidator()
        {
            RuleFor(x => x.Title).NotNull().NotEmpty().MinimumLength(3).MaximumLength(150);
            RuleFor(x => x.Body).NotNull().NotEmpty().MinimumLength(10);
            RuleFor(x => x.Tags).NotNull().NotEmpty().Custom((x, context) =>
            {
                foreach (var item in x.Split(','))
                {
                    if (string.IsNullOrWhiteSpace(item) || !item.StartsWith("#"))
                    {
                        context.AddFailure(ValidatorMessages.TagTemplateIsNotValidMessage);
                        break;
                    }

                    if (item.Length < 3 || item.Length > 50)
                    {
                        context.AddFailure(string.Format(ValidatorMessages.TagLengthLimitMessage, 3, 50));
                        break;
                    }
                }
            });
        }
    }
}
