using Register.Manegement.Domain.DTOs.Requests;
using Register.Manegement.Domain.DTOs.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.Manegement.Domain.Service.Interfaces
{
    public interface IUserRegisterService
    {
        public CreateUserResponseDTO CreateUser(CreateUserRequestDTO request);
        public GetUserByDateResponseDTO GetByDate(GetUserByDateRequestDTO request, Guid login, Guid password);
    }
}
