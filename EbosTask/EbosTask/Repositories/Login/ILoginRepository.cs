using EbosTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EbosTask.Repositories.Login
{
    public interface ILoginRepository
    {
        int LoginCheck(LoginModel user);
        List<Roles> GetRoles();
    }
}
