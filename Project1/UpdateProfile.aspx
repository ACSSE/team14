<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site2.Master" CodeBehind="UpdateProfile.aspx.vb" Inherits="Project1.UpdateProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <form id="Form1" runat="server">
   <div class="product-desc">
       <div class="col-md-7 product-view">
        <h4>UserName :<label id="lblUsername" runat="server" text=""/></h4> <p></p>
         <input type="text" class="user" id="txtUsername" runat="server"  onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Your Username';}"/> <p></p>
          <h4>Password :*******</h4> <p></p>
         <input type="text" class="user" id="txtPassword" runat="server"  onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Your Username';}"/> <p></p>
       
		<h4>Name :<label id="lblName" runat="server" text=""/></h4> <p></p>
         <input type="text" class="user" id="txtName" runat="server"  onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Your Username';}"/> <p></p>
        <h4>Surname :<label id="lblSurname" runat="server" text=""/></h4> <p></p>
        <input type="text" class="user" id="txtSurname" runat="server"  onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Your Username';}"/> <p></p>
        <h4>Contact Number : <strong><label id="lblNumber" runat="server" text=""/></strong></h4> <p></p>
        <input type="text" class="user" id="txtNumber" runat="server"  onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Your Username';}"/>
		<h4>Email : <strong><label id="lblEmail" runat="server" text=""/></strong></h4> <p></p>
	    <input type="text" class="user" id="txtEmail" runat="server"  onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Your Username';}"/> <p></p>
    </div></div>

     <div class="product-desc" runat="server" >
         <div class="col-md-7 product-view">
        <h4>Address : </h4>
         <p id="lblAddress" runat="server"></p>
         <input type="text" class="user" id="txtAddress" runat="server"  onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Your Username';}"/>
       </div>
    </div>

     <div class="product-desc" runat="server" >
         <div class="col-md-7 product-view">
         <h4>Job Title : <strong><label id="lblTitle" runat="server" text=""/></strong></h4>
        <input type="text" class="user" id="txtTitle" runat="server"  onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Your Username';}"/>
		<h4>Description : <strong><label runat="server" text=""/></strong></h4>
        <p id="lblDescription" runat="server"></p>
	    <input type="text" class="user" id="txtDescription" runat="server"  onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Your Username';}"/>
        
         </div></div>
     <input id="btnSave" runat="server" type="submit" value="Save"/>
            </form>


    </label>
    </label>
    </label>
    </label>


    </a>
    </label>
    </label>
    </label>


</asp:Content>
