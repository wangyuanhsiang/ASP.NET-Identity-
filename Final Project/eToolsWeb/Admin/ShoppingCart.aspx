<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ShoppingCart.aspx.cs" Inherits="Admin_ShoppingCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">

    <table class="nav-justified">
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server" DataSourceID="CartegoryDataSource" ItemType="eToolsSystem.Entities.POCOs.CategoryPOCOs" AutoGenerateColumns="False" OnSelectedIndexChanging="GridView1_SelectedIndexChanging" DataKeyNames="ID" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowCommand="GridView1_RowCommand" Height="428px">
                    <Columns>
                        <asp:TemplateField Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="ID" runat="server" Text="<%#Item.ID %>"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField>
                            <HeaderTemplate>
                                <asp:LinkButton ID="LinkButton2" runat="server" CommandName="Select">All&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;69</asp:LinkButton>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Select"><%#Item.Description_Items %></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
            <td>
                <div>
                    <h3>
                        <asp:Label ID="lbConstructing" runat="server" Text="Constructing... "></asp:Label>
                        <span class="glyphicon glyphicon-wrench"></span>

                    </h3>
                </div>
                <div>
                    <asp:Label ID="lbUserName" runat="server" Text=""></asp:Label>
                    <br />
                    <asp:Label ID="lbTrackingCookie" runat="server" Text=""></asp:Label>
                    <br/>
                    <asp:Label ID="lbCreateOn" runat="server" Text=""></asp:Label>
                </div>
                <div>
                    <asp:DataPager ID="DataPager1" runat="server" PagedControlID="ProductMenuListView">
                        <Fields>
                            <asp:NextPreviousPagerField ButtonType="Link" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                            <asp:NumericPagerField />
                            <asp:NextPreviousPagerField ButtonType="Link" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                        </Fields>
                    </asp:DataPager>
                </div>
                <asp:ListView ID="ProductMenuListView" runat="server" DataSourceID="ProductMenuDataSource" ItemType="eToolsSystem.Entities.POCOs.StockItemPOCOs" OnItemCommand="ProductMenuListView_ItemCommand" DataKeyNames="ID">
                    <ItemTemplate>

                        <asp:Button ID="AddButton" runat="server" Text="Add" Visible="true" CommandName="<%#Item.StockItemID %>" Width="60" CommandArgument="Clicked" />

                        <asp:LinkButton ID="CartButton" class="btn btn-default btn-sm" Visible="false" runat="server" Width="60" Enabled="False">
                            <asp:Label ID="lbQuantities" runat="server"></asp:Label>
                            <span class="glyphicon glyphicon-shopping-cart"></span>
                        </asp:LinkButton>
                        <asp:TextBox ID="tbSubmit" Text="1" runat="server"></asp:TextBox>
                        $ <%#Item.SellingPrice %> &nbsp;&nbsp; <%#Item.Description %>  &nbsp;&nbsp;  <%#Item.QuantityOnHand %> &nbsp;&nbsp; in stock
                        <br />
                    </ItemTemplate>
                </asp:ListView>
            </td>
    </table>
    <asp:ObjectDataSource ID="CartegoryDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="getCategoryBrowse" TypeName="eToolsSystem.BLL.TempaleControll"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="ProductMenuDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="getProductMenu" TypeName="eToolsSystem.BLL.TempaleControll">
        <SelectParameters>
            <asp:ControlParameter ControlID="GridView1" Name="id" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>

</asp:Content>

