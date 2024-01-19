using System.ComponentModel.DataAnnotations;

namespace Register.Manegement.Application.Requests.UserRegister
{
    public class UserRegisterPostRequest
    {
        public string UserName { get; }
        public bool IsAdmin { get; } = false;
    }
}
