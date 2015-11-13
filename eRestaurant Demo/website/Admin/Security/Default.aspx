<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Admin_Security_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">
    <div class="row jumbotron">
        <h1>Site Administration</h1>
    </div>
    <div class="row">
        <div class="col-md-9">
            <h2>Users</h2>
            <asp:ListView ID="UserListView" runat="server" ItemType="eRestaurant.Framework.Entities.Security.ApplicationUser"  >
                <EmptyDataTemplate>
                    <table  runat="server" >
                        <tr>
                            <td>
                                 No users in this site.
                           <asp:LinkButton ID="AddWaitersButton" CommandName="AddWaiters" runat="server" Text= "Add Waiters as users" />
                            </td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <ItemTemplate>
                    <tr>
                        <td>
                            <asp:LinkButton ID="EditButton" runat="server" Text="Edit" CommandName="Edit" />
                            <asp:LinkButton ID="DeleteButton" runat="server" Text="Delete" CommandName="Delete" />
                        </td>
                        <td>
                            <asp:Label ID="UserNameLabel" runat="server" Text='<%# Item.UserName %>'></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="EmailLabel" runat="server" Text='<%# Item.Email %>'>'></asp:Label>
                        </td>
                        <td>
                            <em>password is hashed</em> 
                        </td>
                        <td>
                            <asp:Label ID="WaiterIDLabel" runat="server" Text='<%# Item.WaiterID %>'>'></asp:Label>
                            <asp:DropDownList ID="WaiterIDDropDown_Item" runat="server" DataSourceID="WaiterDataSource" DataTextField="FullName" DataValueField="WaiterID"  SelectValue='<%# Item.WaiterID %>>' Enabled="False" AppendDataBoundItems="True">
                             <asp:ListItem Value=" " >[none]</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="RolesCountLabel" runat="server" Text='<%# string.Join(", ", Item.Roles.Select(x => x.RoleId).ToArray()) %>'>'></asp:Label>
                        </td>
                    </tr>
                </ItemTemplate>
                <LayoutTemplate>
                    <table runat="server" >
                        <tr runat="server" >
                            <td runat="server" >
                                <table runat="server" id="itemPlaceholderContainer" class="table table-condensed table-hover table-striped" >
                                    <tr runat="server" >
                                        <th runat="server" >Action</th>
                                        <th runat="server">User Name</th>
                                        <th runat="server">Email</th>
                                        <th runat="server">Password</th>
                                        <th runat="server">Waiter</th>
                                        <th runat="server">Roles</th>
                                    </tr>
                                   <tr runat="server" id="itemPlaceholder" ></tr>
                                </table>
                            </td>
                        </tr>
                        <tr runat="server" >
                            <td runat="server" >
                                <asp:DataPager ID="DataPager1" runat="server">
                                    <Fields>
                                        <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="true"  ShowLastPageButton="true" />
                                    </Fields>
                                </asp:DataPager>
                            </td>
                        </tr>
                    </table>
                </LayoutTemplate>
            </asp:ListView>
        </div>
        <div class="col-md-3">
            <h2>Roles</h2>
            <asp:ListView ID="RoleListView" ItemType="Microsoft.AspNet.Identity.EntityFramework.IdentityRole" runat="server">
                <EmptyDataTemplate>

                </EmptyDataTemplate>
            </asp:ListView>
        </div>
    </div>
    <%--List of Waiters--%>
    <asp:ObjectDataSource ID="WaiterDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="getAllWaiters" TypeName="eRestaurant.Framework.BLL.RestaurantAdminController"></asp:ObjectDataSource>
</asp:Content>

