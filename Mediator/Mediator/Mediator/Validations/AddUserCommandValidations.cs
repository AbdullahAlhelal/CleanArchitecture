using FluentValidation;
using Mediator.Command;

namespace Mediator.Validations
{
    public class AddUserCommandValidations:AbstractValidator<AddUserCommand>
    {
        public AddUserCommandValidations()
        {
            RuleFor(o => o.Id).NotEqual(0);
            RuleFor(o => o.FirstName).NotEmpty();
            RuleFor(o => o.LastName).NotEmpty();
        }
    }
}
