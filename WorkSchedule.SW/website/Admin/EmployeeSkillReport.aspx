<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EmployeeSkillReport.aspx.cs" Inherits="Admin_EmployeeSkillReport" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div>
        <rsweb:ReportViewer ID="EmployeeSkillViewer" runat="server" Font-Names="Verdana" Font-Size="8pt" Height="800px" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="100%">
            <LocalReport ReportPath="Reports\EmployeeSkillPOCOs.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="ReportDataSource" Name="EmployeeSkillDS" />
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>
    </div>
    <asp:ObjectDataSource ID="ReportDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="getEmployeeSkillPOCOs" TypeName="ScheduleDemo.BLL.ReportController"></asp:ObjectDataSource>
</asp:Content>

