﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentitySession1912.Models
{
    public class SignInModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Boolean rememberMe { get; set; }
    }
}
