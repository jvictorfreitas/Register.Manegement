using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.Manegement.Domain.DTOs.Responses
{
    public class CreateUserResponseDTO
    {
        public Guid AuthenticationLogin { get; set; }
        public Guid AuthenticationPassword { get; set; }
    }
}
