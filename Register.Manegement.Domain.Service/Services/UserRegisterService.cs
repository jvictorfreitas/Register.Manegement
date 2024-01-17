using Register.Manegement.Domain.DTOs;
using Register.Manegement.Domain.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.Manegement.Domain.Service.Services
{
    public class UserRegisterService : IUserRegisterService
    {
        public CreateUserResponseDTO CreateUser(CreateUserRequestDTO request)
        {
            return new CreateUserResponseDTO() { Id = "OK"};
        }
    }
}
