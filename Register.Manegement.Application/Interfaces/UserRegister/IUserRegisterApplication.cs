using Register.Manegement.Application.Requests.UserRegister;
using Register.Manegement.Application.Responses.UserRegister;

namespace Register.Manegement.Application.Interfaces.UserRegister
{
    public interface IUserRegisterApplication
    {
        public UserRegisterPostResponse Post(UserRegisterPostRequest request);
    }
}
