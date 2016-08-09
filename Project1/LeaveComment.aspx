<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="LeaveComment.aspx.vb" Inherits="Project1.LeaveComment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyBody" runat="server">

    <div class="feedback main-grid-border">
		<div class="container">
            <form runat="server">
			<h2 class="head">Feedback</h2>
			<div class="feed-back">
				<h3>Leave a Comment</h3>
				<p></p>
				<div class="feed-back-form">
					<form>
					<span>User Details</span>
							<%--<input type="text" runat="server" value="First Name" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'First Name';}"/>
							<input type="text" runat="server" value="Last Name" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Last Name';}"/>
							<input type="text" runat="server" value="Email" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Email';}"/>
							<input type="text" runat="server" value="Phone No" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Phone No';}"/>
							--%>
                            <span>Is there anything you would like to say about your client?</span>
							<textarea runat="server" id="txtComment" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Message...';}" required="">Message...</textarea>
							<input runat="server" id="btnSubmit" type="submit" value="submit"/>
						</form>
				</div>
			</div>
                </form>
		</div>	
	</div>

</asp:Content>
