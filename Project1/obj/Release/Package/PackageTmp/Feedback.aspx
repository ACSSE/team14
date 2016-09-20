<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site2.Master" CodeBehind="Feedback.aspx.vb" Inherits="Project1.Feedback" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyBody" runat="server">

    <div class="feedback main-grid-border">
		<div class="container">
			<h2 class="head">Feedback</h2>
			<div class="feed-back">
				<h3>Tell us what you think of us</h3>
				
				<div class="feed-back-form">
					<form>
					<span>User Details</span>
							<input type="text" value="First Name" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'First Name';}">
							<input type="text" value="Last Name" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Last Name';}">
							<input type="text" value="Email" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Email';}">
							<input type="text" value="Phone No" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Phone No';}">
							<span>Is there anything you would like to tell us?</span>
							<textarea type="text" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Message...';}" required="">Message...</textarea>
							<input type="submit" value="submit">
						</form>
				</div>
			</div>
		</div>	
	</div>

</asp:Content>
