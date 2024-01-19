using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.Manegement.Domain.DTOs.Requests
{
    public class CreateUserRequestDTO
    {
        public string UserName { get; set; }
        public bool IsAdmin { get; set; }
    }
}
