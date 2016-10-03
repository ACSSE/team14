
<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="generateQuotation.aspx.vb" Inherits="Project1.generateQuotation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyBody" runat="server">

    <form  runat="server">
    <div class="post-ad-form text-center">
         
        <h2 class="head">Quotation</h2><br/>
        <table runat="server" style="margin:initial">
                <tr>
                    <th>
                        <asp:Label ID="lblQuoteDescription" runat="server" Text="Enter Your Description:"></asp:Label></th>
                    <th>
                        <asp:TextBox ID="txtQuoteDescription" runat="server" MaxLength="200" Rows="3" TextMode="MultiLine"></asp:TextBox></th>
                </tr>
                 <tr>
                    <th>
                        <asp:Label ID="lblQuoteHours" runat="server" Text="Enter Estimated Amount of Hours:"></asp:Label></th>
                    <th>
                        <asp:TextBox ID="txtQuoteHours" runat="server" TextMode="Number"></asp:TextBox></th>
                </tr>

                <tr>
                    <th>
                        <asp:Label ID="lblQuoteAmount" runat="server" Text="Enter Estimated Amount R"></asp:Label></th>
                    <th>
                        <asp:TextBox ID="txtQuoteAmount" runat="server" TextMode="Number"></asp:TextBox></th>
                </tr>

               </table>
        <input type="submit" runat="server" id="btnReg" value="Add"/>
        </div></form>

</asp:Content>
