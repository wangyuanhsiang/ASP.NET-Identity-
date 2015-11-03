using eRestaurant.Framework.DAL.Security;
using eRestaurant.Framework.Entities.Security;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eRestaurant.Framework.DAL;

namespace eRestaurant.Framework.BLL.Security
{
    public class UserManager : UserManager<ApplicationUser>
    {
        private const string STR_DEFAULT_PASSWORD = "Pa$$word1";
        private const string STR_USERNAME_FORMAT = "{0}.{0}";
        private const string STR_EMAIL_FORMAT = "{0}@eRestaurant.tba";
        private const string STR_WEBMASTER_USERNAME = "Webmaster";
        public UserManager()
            : base(new UserStore<ApplicationUser>(new ApplicationDbContext()))
        {
            
        }

        public void AddDefaultUsers()
        {
            using (var context = new RestaurantContext())
            {
                var employees = from data in context.Waiters where !data.ReleaseDate.HasValue select data;
                foreach(var person in employees)
                {
                    if(!Users.Any(u => u.WaiterID.HasValue && u.WaiterID.Value == person.WaiterID))
                    {
                        string userName = string.Format(STR_USERNAME_FORMAT, person.FirstName, person.LastName);
                        var appUser = new ApplicationUser()
                        {
                            UserName = userName,
                            Email = string.Format(STR_EMAIL_FORMAT, userName),
                            WaiterID = person.WaiterID
                        };
                        this.Create(appUser, STR_DEFAULT_PASSWORD);
                    }
                }
            }

            if(Users.Any(u => u.UserName.Equals(STR_WEBMASTER_USERNAME)))
            {
                var webMasterAccount = new ApplicationUser()
                {
                    UserName = STR_WEBMASTER_USERNAME,
                    Email = string.Format(STR_EMAIL_FORMAT, STR_WEBMASTER_USERNAME)
                };
                this.Create(webMasterAccount, STR_DEFAULT_PASSWORD);
            }
        }
    }
}
