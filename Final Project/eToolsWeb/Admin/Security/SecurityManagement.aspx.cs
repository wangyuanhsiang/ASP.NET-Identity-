using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using eToolsSystem.BLL.Security;


public partial class Admin_Security_SecurityManager : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataBindUserList();
            DataBindRoleList();
        }
    }

    private void DataBindRoleList()
    {
        RolesListView.DataSource = new RoleManager().Roles.ToList();
        RolesListView.DataBind();
    }

    private void DataBindUserList()
    {
        UserListView.DataSource = new UserManager().Users.ToList();
        UserListView.DataBind();
    }

    protected void UserListView_ItemCommand(object sender, ListViewCommandEventArgs e)
    {
        if (e.CommandName == "AddDefaultUsers")
        {
            var controller = new UserManager();
            controller.AddDefaultUsers();
            DataBindUserList();
        }   
    }
    protected void RolesListView_ItemCommand(object sender, ListViewCommandEventArgs e)
    {
        if (e.CommandName == "AddDefaultRoles")
        {
            var controller = new RoleManager();
            controller.AddDefaultRoles();
            DataBindRoleList();
        }
    }
}