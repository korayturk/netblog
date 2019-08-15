using FluentValidation;
using NetBLog.Contract;
using NetBLog.Resources;

namespace NetBLog.Api.Validators
{
    public class LoginValidator : AbstractValidator<LoginContract>
    {
        public LoginValidator()
        {
            RuleFor(x => x.Email).NotEmpty().NotNull().EmailAddress().WithMessage(ValidatorMessages.LoginEmailErrorMessage);
            RuleFor(x => x.Password).NotNull().NotEmpty().WithMessage(ValidatorMessages.LoginPasswordErrorMessage);
        }
    }
}
