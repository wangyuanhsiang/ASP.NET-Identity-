<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RestaurantMenu3.aspx.cs" Inherits="Repeaters_RestaurantMenu3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">
    <div class="row col-md-12">
        <h3>Restauant Menu 3</h3>
        <asp:Repeater ID="MenuItemRepeater" runat="server" DataSourceID="MenuItemDataSource" ItemType="eRestaurant.Framework.Entities.DTOs.CategoryDTO">
            <ItemTemplate>
                <div>
                    <h3>
                        <image src= '<%# "/Images/" +Item.Description+ "-1.png" %>' />
                        <%# Item.Description %>
                    </h3>
                    <div class="well">
                        <asp:Repeater ID="ItemDetailRepeater" runat="server" DataSource="<%# Item.MenuItems %>" ItemType="eRestaurant.Framework.Entities.DTOs.MenuItemDTO">
                            <ItemTemplate>
                                <div>
                                    <h4>
                                    <%# Item.Description %> 
                                        <span class="badge">  <%# Item.Calories %></span>  
                                          <%# Item.Price.ToString("C") %>
                                        </h4> 
                                   </div>
                                    <%# Item.Comment %>
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

