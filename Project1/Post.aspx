
﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="Post.aspx.vb" Inherits="Project1.Post" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyBody" runat="server">


   <div class="regions main-grid-border">
		<div class="container">
			<h2 class="head">Posts</h2>
            <a href="PostAdClient.aspx"><small style="color:#FBCC33">Post Additional Ads</small></a>
		</div>

		
		
		
		
		<div class="region-block">
			<div class="container">
				<div class="state col-md-3">
					<h3>Pool Specialist</h3>
				</div>
				<div class="sun-regions col-md-9">
					<ul>
						<li><a href="#"> Dirty Pool </a></li>
						<li><a href="#"> Pump not working  </a></li>
						<li><a href="#"> Dowerglen  </a></li>
						<li><input id="btnLog" runat="server" type="submit" value="Confirm"/></li>
					</ul>
				</div>
				<div class="clearfix"></div>
			</div>
		</div>
		<div class="region-block">
			<div class="container">
				<div class="state col-md-3">
					<h3>Pool Specialist</h3>
				</div>
				<div class="sun-regions col-md-9">
					<ul>
						<li><a href="#"> Dirty Pool </a></li>
						<li><a href="#"> Pump not working  </a></li>
						<li><a href="#"> Dowerglen  </a></li>
						<li><input id="Submit1" runat="server" type="submit" value="Confirm"/></li>
					</ul>
				</div>
				<div class="clearfix"></div>
			</div>
		</div>
		<div class="region-block">
			<div class="container">
				<div class="state col-md-3">
					<h3>Garden and Landscaping</h3>
				</div>
				<div class="sun-regions col-md-9">
					<ul>
						<li><a href="#"> Dirty garden </a></li>
						<li><a href="#"> Flowers are dying  </a></li>
						<li><a href="#"> Dowerglen  </a></li>
						<li><input id="Submit2" runat="server" type="submit" value="Confirm"/></li>
					</ul>
				</div>
				<div class="clearfix"></div>
			</div>
		</div>
		<div class="region-block">
			<div class="container">
				<div class="state col-md-3">
					<h3>Serurity and Fire</h3>
				</div>
				<div class="sun-regions col-md-9">
					<ul>
						<li><a href="#">alarm set off</a></li>
						<li><a href="#"> alarm too sensitive  </a></li>
						<li><a href="#"> Dowerglen  </a></li>
						<li><input id="Submit3" runat="server" type="submit" value="Confirm"/></li>
					</ul>
				</div>
				<div class="clearfix"></div>
			</div>
		</div>
		
	</div>
</asp:Content>
