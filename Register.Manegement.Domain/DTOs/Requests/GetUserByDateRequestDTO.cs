﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.Manegement.Domain.DTOs.Requests
{
    public class GetUserByDateRequestDTO
    {
        public DateTime InitialDate { get; set; }
        public DateTime LastDate { get; set; }
    }
}
