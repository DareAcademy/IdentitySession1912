using IdentitySession1912.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentitySession1912.services
{
    public interface IAccountService
    {
        Task<IdentityResult> Create(SignUpModel model);

        Task<SignInResult> SignIn(SignInModel model);

        Task<IdentityResult> AddRole(RoleModel model);

        List<IdentityRole> GetRole();
    }
}
