using FluentValidation;
using Register.Manegement.Application.Requests.UserRegister;

namespace Register.Manegement.Application.Validators.UserRegister
{
    public class UserRegisterPostRequestValidator : AbstractValidator<UserRegisterPostRequest>
    {
        public UserRegisterPostRequestValidator() 
        {
            RuleFor(postRequest => postRequest.UserName)
                .NotEmpty()
                .MaximumLength(18)
                .MinimumLength(6)
                .WithMessage("MaximumLeght 18 and MinimumLength 6");
        }
    }
}
