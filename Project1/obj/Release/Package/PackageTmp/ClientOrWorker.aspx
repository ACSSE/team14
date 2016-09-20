<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site2.Master" CodeBehind="ClientOrWorker.aspx.vb" Inherits="Project1.ClientOrWorker" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyBody" runat="server">


    <div class="content">
			<div class="category">
				<div class="container">
					<div class="col-md-2 focus-grid" >
						<a href="RegisterClient.aspx">
							<div class="focus-border" >
								<div class="focus-layout">
									<div class="focus-image"><i class="fa fa-user"></i></div>
									<h4 class="clrchg">Client</h4>
								</div>
							</div>
						</a>
					</div>
					<div class="col-md-2 focus-grid">
						<a href="RegisterWorker.aspx">
							<div class="focus-border">
								<div class="focus-layout">
									<div class="focus-image"><i class="fa fa-user-secret"></i></div>
									<h4 class="clrchg">Worker</h4>
								</div>
							</div>
						</a>
					</div>
					
					<div class="clearfix"></div>
				</div>
			</div>

        



    </div>
</asp:Content>
