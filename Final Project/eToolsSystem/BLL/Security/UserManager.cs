using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using eToolsSystem.Entities.Security;
using eToolsSystem.DAL.Security;
using Microsoft.AspNet.Identity;

namespace eToolsSystem.BLL.Security
{
    public class UserManager : UserManager<ApplicationUser>
    {
        public UserManager()
            : base(new UserStore<ApplicationUser>(new ApplicationDbContext()))
        {
        }
    }
}
