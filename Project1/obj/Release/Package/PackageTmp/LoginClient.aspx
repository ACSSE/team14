<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="LoginClient.aspx.vb" Inherits="Project1.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyBody" runat="server">

    <section>
			<div id="page-wrapper" class="sign-in-wrapper">
				<div class="graphs">
					<div class="sign-in-form">
						<div class="sign-in-form-top">
							<h1>Log in</h1>
						</div>
						<div class="signin">
							
							<form id="Form1" runat="server">
							<div class="log-input">
								<div class="log-input-left">
								   <input type="text" class="user" runat="server" id="txtUsername" value="Your Username" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Your Username';}"/>
								</div>
								<span class="checkbox2" hidden >
									 <label class="checkbox"  ><input type="checkbox" name="checkbox" checked=""/><i> </i></label>
								</span>
								<div class="clearfix"> </div>
							</div>
							<div class="log-input">
								<div class="log-input-left">
								   <input type="password" id="txtPassword" runat="server" class="lock" value="password" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'password';}"/>
								</div>
								<span class="checkbox2" hidden>
									 <label class="checkbox"  ><input type="checkbox" name="checkbox" checked=""/><i> </i></label>
								</span>
								<div class="clearfix"> </div>
							</div>
							
                               <input id="btnLog" runat="server" type="submit" value="Log in"/>
						</form>
                            	 <label id="lblLogin" style="align-content:center" runat="server" text=""></label>
						</div>
						<div class="new_people">
							<h2 style="align-content:center">Are You a New User</h2>
							<p style="align-content:center">Join our awesome team and find your desired HandyMan</p>
							<a href="ClientOrWorker.aspx">Register Now!</a>
						</div>
					</div>
				</div>
			</div>
		<!--footer section start-->
			<footer class="diff">
			  
			</footer>
        <!--footer section end-->
	</section>


</asp:Content>
