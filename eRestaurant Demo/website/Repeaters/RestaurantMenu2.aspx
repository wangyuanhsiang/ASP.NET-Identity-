<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RestaurantMenu2.aspx.cs" Inherits="Repeaters_RestaurantMenu2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="row col-md-12" >
        <h3>Restauant Menu 2</h3>
    <asp:Repeater ID="MenuItemRepeater" runat="server" DataSourceID="MenuItemDataSource" ItemType="eRestaurant.Framework.Entities.DTOs.CategoryDTO">
        <ItemTemplate>
            <div>
                <image src="http://placehold.it/150x100/" />
                <%# Item.Description %>
                <asp:Repeater ID="ItemDetailRepeater" runat="server" DataSource="<%# Item.MenuItems %>" ItemType="eRestaurant.Framework.Entities.DTOs.MenuItemDTO">
                    <ItemTemplate>
                        <div>
                            <%# Item.Description %>  
                             &mdash;                        
                            <%# Item.Calories %>
                             &mdash;
                            <%# Item.Price.ToString("C") %>
                            <br />
                            <%# Item.Comment %>
                        </div>
                    </ItemTemplate>
                    <SeparatorTemplate>
                        <hr />
                    </SeparatorTemplate>
                </asp:Repeater>
            </div>
        </ItemTemplate>
    </asp:Repeater>
        <asp:ObjectDataSource ID="MenuItemDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="ListMenuItem" TypeName="eRestaurant.Framework.BLL.MenuController"></asp:ObjectDataSource>
    </div>
</asp:Content>

