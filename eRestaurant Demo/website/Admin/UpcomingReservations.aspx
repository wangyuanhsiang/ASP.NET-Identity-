<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="UpcomingReservations.aspx.cs" Inherits="Admin_UpcomingReservations" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">
    <div class ="row">
        <div class ="col-md-12">
            <h1>Upcoming Reservations</h1>
            <asp:ObjectDataSource ID="ActiveEventDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="listActiveEvents" TypeName="eRestaurant.Framework.BLL.ReservationController"></asp:ObjectDataSource>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ActiveEventDataSource" DataTextField="Description" DataValueField="Code"></asp:DropDownList>
        </div>
       
    </div>
</asp:Content>

