using Register.Manegement.Domain.DTOs.Requests;
using Register.Manegement.Domain.DTOs.Responses;
using Register.Manegement.Domain.Entitys;
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
            var entity = new UserEntity()
            {
                UserName = request.UserName,
                IsAdmin = request.IsAdmin,
                AuthenticationLogin = Guid.NewGuid(),
                AuthenticationPassword = Guid.NewGuid(),
                PasswordExpirationDate = DateTime.Now.AddMonths(3),
            };

            //salvar Entity no banco de dados

            return new CreateUserResponseDTO()
            {
                AuthenticationLogin = entity.AuthenticationLogin,
                AuthenticationPassword = entity.AuthenticationPassword,
            };
        }

        public GetUserByDateResponseDTO GetByDate(GetUserByDateRequestDTO request, Guid login,Guid password)
        {
            throw new NotImplementedException();
        }

        public void GetById(Guid request, Guid login, Guid password)
        {
            throw new NotImplementedException();
        }
    }
}
