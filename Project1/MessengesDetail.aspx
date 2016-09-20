<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="MessengesDetail.aspx.vb" Inherits="Project1.MessagesDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyBody" runat="server">
<form runat="server">



<div class="container">
 <h2  class="head">Conversation</h2>

 <div id="messagesHistory" class="submit-ad main-grid-border" runat="server">
</div>
    <div class="post-add-form">
    <asp:TextBox ID="txtMessage" runat="server" Height="109px" TextMode="MultiLine" 
        Width="264px"></asp:TextBox>
 

    <button type="submit" id="btnSend" runat="server">Send Messenge
         </button>
    </div>
    </div>
        
</form>
</asp:Content>
