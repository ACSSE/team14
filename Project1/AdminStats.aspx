<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="AdminStats.aspx.vb" Inherits="Project1.AdminStats1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style>
table {
    font-family: arial, sans-serif;
    border-collapse: collapse;
    width: 100%;
}

td, th {
    border: 1px solid #dddddd;
    text-align: left;
    padding: 8px;
}

tr:nth-child(even) {
    background-color: #dddddd;
}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyBody" runat="server">
    <h2>Website Statistics</h2>
    <br /><br /><br />
    <h3>New Users</h3>
    <div id="VisiterStats" runat="server"></div>
    <br /><br />
    <div id="TotalUsers" runat="server"></div>
    <br /><br />
    <div id="WeekStats" runat="server"></div>
</asp:Content>
