<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MessageUserControl.ascx.cs" Inherits="UserControls_MessageUserControl" %>
<asp:Panel ID="MessagePanel" runat="server">
    <div class ="plane-heading">
        <asp:Label ID="MessageTitleIcon" runat="server"></asp:Label>
        <br />
        <asp:Label ID="MessageTitle" runat="server"></asp:Label>
    </div>
    <div class="panel-body" >
        <asp:Label ID="MessageLabel" runat="server"></asp:Label>
        <asp:Repeater ID="MessageDetailsRepeater" runat="server">
            <HeaderTemplate>
                 <ul>
            </HeaderTemplate>
            <FooterTemplate>
                </ul>
            </FooterTemplate>
            <ItemTemplate>
                <li><%# Eval("Error") %></li>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Panel>
