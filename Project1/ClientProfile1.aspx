<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="ClientProfile1.aspx.vb" Inherits="Project1.ClientProfile1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyBody" runat="server">

    <div class="single-page main-grid-border">
		<div class="container">
			<ol class="breadcrumb" style="margin-bottom: 5px;">
				<li><a href="index.aspx">Home</a></li>
				<li class="active">Client's Profile</li>
			</ol>
			<div class="product-desc">
				<div class="col-md-7 product-view">
                    <h1>Client's Profile</h1>
                    <small><p>connection established<p/></small>  
					<p> <i class="glyphicon glyphicon-map-marker"></i><a href="#">Gauteng</a>, <a href="#">Edenvale</a></p>
					
					<!-- FlexSlider -->
					  <script src="js/jquery.flexslider.js"></script>
					<link rel="stylesheet" href="css/flexslider.css" type="text/css" media="screen" />

						<script>
					// Can also be used with $(document).ready()
					$(window).load(function() {
					  $('.flexslider').flexslider({
						animation: "slide",
						controlNav: "thumbnails"
					  });
					});
					</script>
					<!-- //FlexSlider -->
					<div class="product-details">
						<h4>Name : <a href="#">Client K</a></h4>
                        <h4>Contact Number : <strong>0760101010</strong></h4>
						<h4>Email : <strong>client@gmail.com</strong></h4>
						<p><strong>Address</strong> : 23 reign avenue edenvale </p>
                        <small><a href="RegisterClient.aspx">Update your profile</a></small>
					</div>
				</div>

                

				<div class="col-md-5 product-details-grid">
					<div class="item-price">

						<div class="condition">
							<p class="p-price">Rating</p>
							<h4><i><img src="images/rate1.png" alt=" " /></i></h4>
							<div class="clearfix"></div>
						</div>
					</div>
					<div class="interested text-center">
						<h4 style="text-align:center;">Interested?</h4>

						<p style="align-content:center"><a href="PostAdClient.aspx">Post an ad</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a href="FeaturedWorkers.aspx">Check out Featured Workers</a></p>
                      

					</div>

                    <div class="product-price">
							<h3 class="rate">History</h3>

						</div>
                    <div class="happy-clients-grids">

                        <div class="col-md-6 happy-clients-grid wow bounceIn" data-wow-delay="0.4s">
							<div class="client">
								<img src="images/client_1.jpg" alt="" />
							</div>
							<div class="client-info">
								<p><label id="lblComment" runat="server" text=""/></p>
								<h4><a href="#">Mrs Michle, </a><p> <i class="glyphicon glyphicon-map-marker"></i><a href="#">Gauteng</a>, <a href="#">Edenvale</a></p></h4>
							</div>
							<div class="clearfix"></div>
						</div>
                        <div class="col-md-6 happy-clients-grid span_66 wow bounceIn" data-wow-delay="0.4s">
							<div class="client">
								<img src="images/client_2.jpg" alt="" />
							</div>
							<div class="client-info">
								<p>Great worker, would use him again anytime</p>
								<h4><a href="#">Miss Elisabath, </a><p> <i class="glyphicon glyphicon-map-marker"></i><a href="#">Gauteng</a>, <a href="#">Dunvegan</a></p></h4>
							</div>
							<div class="clearfix"></div>
						</div>

                    </div>


				</div>
			<div class="clearfix"></div>
			</div>
		</div>
	</div>


</asp:Content>