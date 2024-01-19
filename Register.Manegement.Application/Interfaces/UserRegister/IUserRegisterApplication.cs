using Register.Manegement.Application.Requests.UserRegister;
using Register.Manegement.Application.Responses;
using Register.Manegement.Application.Responses.UserRegister;

namespace Register.Manegement.Application.Interfaces.UserRegister
{
    public interface IUserRegisterApplication
    {
        public BaseResponse Post(UserRegisterPostRequest request);
        public BaseResponse Get(UserRegisterGetRequest request, Guid login, Guid password);
        public BaseResponse Get(Guid userLogin, Guid login, Guid password);
        public BaseResponse Put(UserRegisterPutRequest request,Guid userLogin, Guid login, Guid password);
        public BaseResponse Delete(Guid userLogin, Guid login, Guid password);
    }
}
