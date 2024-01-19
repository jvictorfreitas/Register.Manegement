using Register.Manegement.Application.Interfaces.UserRegister;
using Register.Manegement.Application.Mappers.UserRegister;
using Register.Manegement.Application.Requests.UserRegister;
using Register.Manegement.Application.Responses;
using Register.Manegement.Application.Responses.UserRegister;
using Register.Manegement.Application.Validators.UserRegister;
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

        public BaseResponse Post(UserRegisterPostRequest request)
        {
            var validator = new UserRegisterPostRequestValidator();
            var resultValidator = validator.Validate(request);
            if (resultValidator.Errors.Any())
                return new BaseResponse(false, resultValidator.Errors);

            var userDTO = UserRegisterMapper.PostRequestToCreateUserTDO(request);
            var resultDTO = _service.CreateUser(userDTO);
            var result = UserRegisterMapper.CreateUserDTOToPostResponse(resultDTO);

            return result;
        }

        public BaseResponse Get(UserRegisterGetRequest request, Guid login, Guid password) 
        {
            throw new NotImplementedException();
        }

        public BaseResponse Get(Guid userLogin, Guid login, Guid password)
        {
            throw new NotImplementedException();
        }

        public BaseResponse Put(UserRegisterPutRequest request, Guid userLogin, Guid login, Guid password)
        {
            throw new NotImplementedException();
        }

        public BaseResponse Delete(Guid userLogin, Guid login, Guid password)
        {
            throw new NotImplementedException();
        }
    }
}
