using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.Manegement.Application.Requests.UserRegister
{
    public class UserRegisterGetRequest
    {
        public DateTime InitialDate {  get; set; }
        public DateTime LastDate { get; set; }
    }
}
