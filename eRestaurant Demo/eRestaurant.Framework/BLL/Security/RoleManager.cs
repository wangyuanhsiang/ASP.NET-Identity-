using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using eRestaurant.Framework.DAL.Security;
using eRestaurant.Framework.Entities.Security;

namespace eRestaurant.Framework.BLL.Security
{
    public class RoleManager : RoleManager<IdentityRole>
    {
        public RoleManager() : base(new RoleStore<IdentityRole>(new ApplicationDbContext()))
        { }

        public void AddDefaultRoles()
        {
            foreach (string rolename in SecurityRoles.DefaultSecurityRoles)
            {
                if(Roles.Any(r => r.Name == rolename))
                {
                    this.Create(new IdentityRole(rolename));
                }
            }
        }
    }
}
