using Register.Manegement.Application.Requests.UserRegister;
using Register.Manegement.Application.Responses.UserRegister;
using Register.Manegement.Domain.DTOs.Requests;
using Register.Manegement.Domain.DTOs.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.Manegement.Application.Mappers.UserRegister
{
    public class UserRegisterMapper
    {
        public static CreateUserRequestDTO PostRequestToCreateUserTDO(UserRegisterPostRequest request)
        {
            return new CreateUserRequestDTO
            {
                UserName = request.UserName,
                IsAdmin = request.IsAdmin,
            };
        }

        public static UserRegisterPostResponse CreateUserDTOToPostResponse(CreateUserResponseDTO response)
        {
            return new UserRegisterPostResponse()
            {
                AuthenticationLogin = response.AuthenticationLogin,
                AuthenticationPassWord = response.AuthenticationPassword
            };
        }
    }
}
