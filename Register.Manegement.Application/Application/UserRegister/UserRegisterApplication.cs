using Register.Manegement.Application.Interfaces.UserRegister;
using Register.Manegement.Application.Mappers.UserRegister;
using Register.Manegement.Application.Requests.UserRegister;
using Register.Manegement.Application.Responses.UserRegister;
using Register.Manegement.Domain.Service.Interfaces;

namespace Register.Manegement.Application.Application.UserRegister
{
    public class UserRegisterApplication : IUserRegisterApplication
    {
        private readonly IUserRegisterService _service;
        public UserRegisterApplication(IUserRegisterService service) 
        {
            _service = service;
        }

        public UserRegisterPostResponse Post(UserRegisterPostRequest request)
        {
            var userDTO = UserRegisterMapper.PostRequestToCreateUserTDO(request);
            var resultDTO = _service.CreateUser(userDTO);
            var result = UserRegisterMapper.CreateUserDTOToPostResponse(resultDTO);

            return result;
        }
    }
}
