<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="findme.aspx.vb" Inherits="Project1.findme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyBody" runat="server">
    <form  runat="server">
    <div class="post-ad-form text-center">
         
        <h2 class="head">Help us find you</h2><br/>
        <table runat="server" style="margin:initial">
                <tr>
                    <th>
                        <asp:Label ID="lblTown" runat="server" Text="Enter Name of Your Town:"></asp:Label></th>
                    <th>
                        <asp:TextBox ID="txtTown" runat="server"></asp:TextBox></th>
                </tr>
                 <tr>
                    <th>
                        <asp:Label ID="lblSurburb" runat="server" Text="Enter Name of Your Suburb:"></asp:Label></th>
                    <th>
                        <asp:TextBox ID="txtSuburb" runat="server"></asp:TextBox></th>
                </tr>

               </table>
        <input type="submit" runat="server" id="btnReg" value="Add"/>
        </div></form>

</asp:Content>
