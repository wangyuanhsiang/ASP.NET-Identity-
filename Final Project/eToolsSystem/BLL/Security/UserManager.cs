using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using eToolsSystem.Entities.Security;
using eToolsSystem.DAL.Security;
using Microsoft.AspNet.Identity;
using eToolsSystem.DAL;


namespace eToolsSystem.BLL.Security
{
    public class UserManager : UserManager<ApplicationUser>
    {
        #region Constants
        private const string STR_DEFAULT_PASSWORD = "Pa$$word1";
        /// <summary>Requires FirstName and LastName</summary>
        private const string STR_USERNAME_FORMAT = "{0}.{0}";
        /// <summary>Requires UserName</summary>
        private const string STR_EMAIL_FORMAT = "{0}@eTool.tba";
        private const string STR_WEBMASTER_USERNAME = "Webmaster";
        #endregion

        public UserManager()
            : base(new UserStore<ApplicationUser>(new ApplicationDbContext()))
        {

        }

        public void AddDefaultUsers()
        {
            using (var context = new eToolDBContext())
            {
                var onlieUser = from data in context.OnlineCustomers where data.OnlineCustomerID == 0 select data;
                foreach (var person in onlieUser)
                {
                    if (!Users.Any(u => u.OnlineCustomerID.HasValue && u.OnlineCustomerID.Value == person.OnlineCustomerID))
                    {
                        string Name = string.Format(STR_USERNAME_FORMAT, person.UserName);
                        var appUser = new ApplicationUser()
                        {
                            UserName = Name,
                            Email = string.Format(STR_EMAIL_FORMAT),
                            OnlineCustomerID = person.OnlineCustomerID
                        };
                        this.Create(appUser, STR_DEFAULT_PASSWORD);
                    }
                }
                // Add a web  master user
                if (!Users.Any(u => u.UserName.Equals(STR_WEBMASTER_USERNAME)))
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
}
