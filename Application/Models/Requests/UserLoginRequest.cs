﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Requests
{

    public class UserLoginRequest
    {
        [Required]
        public string? UserNameOrEmail { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}

