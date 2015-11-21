﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Admin_Security_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="row jumbotron">
        <h1>Site Administration</h1>
    </div>
    <div class="row">
        <div class="col-md-9">
            <h2>Users</h2>
            <asp:ListView ID="UserListView" runat="server" ItemType="eRestaurant.Framework.Entities.Security.ApplicationUser" OnItemCommand="UserListView_ItemCommand"  >
                <LayoutTemplate>
                    <table class="table table-hover">
                        <tr>
                            <th>Action</th>
                            <th>User Name</th>
                            <th>Email</th>
                        </tr>
                        <tr runat="server" id="itemPlaceholder" ></tr>
                    </table>
                </LayoutTemplate>
                <ItemTemplate>
                    <tr>
                        <td>
                            Edit/Delete
                        </td>
                        <td>
                            <asp:Label ID="UserNameLabel" runat="server" Text="<%# Item.UserName %>">
                            </asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="EmailLabel" runat="server" Text="<%# Item.Email %>"></asp:Label>
                        </td>
                    </tr>
                </ItemTemplate>
                <EmptyDataTemplate>
                      <tr>
                          <td colspan="3">
                              No users in this site.
                              <asp:LinkButton ID="AddDefaultUsersButton" runat="server" Text="Add default security users" CommandName="AddDefaultUsers" />
                          </td>
                      </tr>
                </EmptyDataTemplate>
            </asp:ListView>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <h2>Roles</h2>
            <asp:ListView ID="RolesListView" runat="server" ItemType="Microsoft.AspNet.Identity.EntityFramework.IdentityRole" OnItemCommand="RolesListView_ItemCommand" >
                <LayoutTemplate>
                    <table>
                        <tr>
                            <th>Role Name</th>
                        </tr>
                        <tr runat="server" id="itemPlaceholder"></tr>
                    </table>
                </LayoutTemplate>
                 <ItemTemplate>
                     <tr>
                         <td>
                             <asp:Label ID="NameLabel" runat="server" Text="<%# Item.Name %>">"></asp:Label>
                         </td>
                     </tr>
                 </ItemTemplate>         
                <EmptyDataTemplate>
                    <tr>
                        <td>
                            No roles in this sites.
                            <asp:LinkButton runat="server" ID="AddDefaultRolesButton" Text="Add default security roles" />
                        </td>
                    </tr>
                </EmptyDataTemplate>
            </asp:ListView>
        </div>
    </div>
</asp:Content>

