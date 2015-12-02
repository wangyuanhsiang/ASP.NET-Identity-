<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EmployeeSkillList.aspx.cs" Inherits="Repeaters_EmployeeSkillList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class ="row col-md-12"  >
        <h3>Employee Skill List </h3>
        <asp:Repeater ID="DescriptionRepeaters" runat="server" ItemType ="ScheduleDemo.Entities.DTOs.SkillDTO" DataSourceID="EmployeeListSkillDataSource">
            <ItemTemplate>
                <div>
                   <asp:Label ID="Label2" runat="server">Description : <%# Item.Description %>
                       <br />
                       <asp:Label ID="Label3" runat="server"> Employee : </asp:Label>  
                   </asp:Label><asp:Repeater ID="EmployeeRepeater" DataSource ="<%#Item.Employees%>" ItemType ="ScheduleDemo.Entities.DTOs.EmployeeDTO" runat="server">
                        <ItemTemplate>
                            <div>
                                <asp:Label ID="Label1" runat="server">Name :</asp:Label>  <%#Item.Name %>
                            <br /> 
                            <asp:Label ID="Label4" runat="server">Level :</asp:Label>  <%#Item.Level %>
                            <br />
                            <asp:Label ID="Label5" runat="server">YearsExperience :</asp:Label>  <%#Item.YearsExperience %>
                            <br />
                            <br />
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
                <hr />
            </ItemTemplate>
        </asp:Repeater>
    </div>
    <asp:ObjectDataSource ID="EmployeeListSkillDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="ListEmployees" TypeName="ScheduleDemo.BLL.RepeatersController"></asp:ObjectDataSource>
</asp:Content>

