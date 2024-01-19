using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.Manegement.Domain.Entitys
{
    public class UserEntity : BaseEntity
    {
        public string UserName { get; set; }
        public bool IsAdmin { get; set; }
        public Guid AuthenticationLogin { get; set; }
        public Guid AuthenticationPassword { get; set; }
        public DateTime PasswordExpirationDate { get; set; }
    }
}
