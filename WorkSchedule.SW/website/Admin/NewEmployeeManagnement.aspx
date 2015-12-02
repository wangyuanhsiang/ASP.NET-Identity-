<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="NewEmployeeManagnement.aspx.cs" Inherits="Admin_NewEmployeeManagnement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    

    <table class="nav-justified">
        <tr>
            <td>
                <asp:DropDownList ID="DropDownList" runat="server" DataSourceID="DropDownListDataSource" DataTextField="Descripotion" DataValueField="ID"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:ListView ID="ListView" runat="server"></asp:ListView>
            </td>
        </tr>
    </table>
    <asp:ObjectDataSource ID="DropDownListDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="getDropDwonList" TypeName="ScheduleDemo.BLL.ListViewController"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="ListViewDataSource" runat="server"></asp:ObjectDataSource>
</asp:Content>

