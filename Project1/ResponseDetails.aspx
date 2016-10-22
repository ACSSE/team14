<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="ResponseDetails.aspx.vb" Inherits="Project1.ResponseDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyBody" runat="server">
 <div class="single-page main-grid-border">

    <form id="Form1" runat="server">
    <div class="single-page main-grid-border">
		<div class="container">
            <div class="post-ad-form">
            <h2 class="head" id = "AdHeading" runat="server"></h2>
            
            <div id="ClientInfo" runat="server"></div>
            <div id="AdInfo" runat="server"></div>
            
            
            <h3 id="handymanDet" runat="server"></h3>
            
            <h3>Messeges:</h3> <br />
            <div id="messagesHistory" class="submit-ad main-grid-border" runat="server">
</div>
            <textarea id="txtComment" runat="server"></textarea>
            <br />
            <br />
            <input id="btnConfirm" runat="server" type="submit" value="Confirm"/>
            </div>
		</div>
    </div>


    </form>
        </div>
</asp:Content>
