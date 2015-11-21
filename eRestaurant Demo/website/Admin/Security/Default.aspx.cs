using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using eRestaurant.Framework.BLL.Security;
public partial class Admin_Security_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            DataBindUserList();
            DataBlindRoleList();
        }
    }


    private void DataBlindRoleList()
    {
        RoleListView.DataSource = new RoleManager().Roles.ToList();
        RoleListView.DataBind();
    }

    private void  DataBindUserList()
    {
        RoleListView.DataSource = new UserManager().Users.ToList();
        RoleListView.DataBind();
    }


    protected void UserListView_ItemCommand(object sender, ListViewCommandEventArgs e)
    {
        switch(e.CommandName)
        {
            case "AddWaiters":
                new UserManager().AddDefaultUsers();
                DataBindUserList();
                break;
            default:
                break;
        }
    }


    protected void RoleListView_ItemCommand(object sender, ListViewCommandEventArgs e)
    {
        switch(e.CommandName)
        {
            case "AddDefaultRoles":
                new RoleManager().AddDefaultRoles();
                DataBlindRoleList();
                break;
            default:
                break;

        }
    }
}