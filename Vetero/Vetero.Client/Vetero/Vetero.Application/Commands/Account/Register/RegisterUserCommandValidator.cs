using FluentValidation;

namespace Vetero.Application.Commands.Account.Register
{
    public class RegisterUserCommandValidator : AbstractValidator<RegisterUserCommand>
    {
        public RegisterUserCommandValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress();

            RuleFor(x => x.Password).MinimumLength(6);

            RuleFor(x => x.ConfirmPassword).Equal(e => e.Password);

            //RuleFor(x => x.Email)
            //    .Custom((value, context) =>
            //    {
            //        var isEmailInUse = context.Users.Any(u => u.Email == value);
            //        if (isEmailInUse)
            //            context.AddFailure("Email", "That email is taken");
            //    });
        }
    }
}
