<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site2.Master" CodeBehind="WorkerProfile.aspx.vb" Inherits="Project1.WorkerProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="single-page main-grid-border">
		<div class="container">
			<ol class="breadcrumb" style="margin-bottom: 5px;">
				<li><a href="index.html">Home</a></li>
				<li class="active">Worker's Profile</li>
			</ol>
			<div class="product-desc">
				<div class="col-md-7 product-view">
                    <h1 id="JobTitle" runat="server" ></h1>
                    
					<h4>Previous work done</h4>
					<p> <i class="glyphicon glyphicon-map-marker"></i><a href="#">Gauteng</a>, <a href="#"><label id="lblRegion" runat="server" text=""/></a></p>
					<div class="flexslider">
                        <img src="images/ImagesG/g1.png" />
						<!--<ul class="slides">
							<li data-thumb="images/t1.jpg">
								<img src="images/t1.jpg" />
							</li>
							<li data-thumb="images/t2.jpg">
								<img src="images/t2.jpg" />
							</li>
							<li data-thumb="images/t3.jpg">
								<img src="images/t3.jpg" />
							</li>
						</ul>-->
					</div>
					<!-- FlexSlider -->
					  <script defer="" src="js/jquery.flexslider.js"></script>
					<link rel="stylesheet" href="css/flexslider.css" type="text/css" media="screen" />

						<script>
						    // Can also be used with $(document).ready()
						    $(window).load(function () {
						        $('.flexslider').flexslider({
						            animation: "slide",
						            controlNav: "thumbnails"
						        });
						    });
					</script>
					<!-- //FlexSlider -->
					<div class="product-details">
						<h4>Name : <a href="#"><label id="lblName" runat="server" text=""/> <label id="lblSurname" runat="server" text=""/></a></h4>
                        <h4>Worker Contact Number : <strong><label id="lblNumber" runat="server" text=""/></strong></h4>
						<h4>Worker email : <strong><label id="lblEmail" runat="server" text=""/></strong></h4>
                        <h4 id="update" runat="server"><a href="UpdateProfile.aspx?user=handyman">Update your profile</a></h4>
                        <h4 id="check" runat="server"><a href="clientStat.aspx?user=client">Check Your Stats</a></h4>
					</div>

                    <div class="product-price">
							<h3 class="rate">History</h3>

						</div>
                    <div class="happy-clients-grids" id="divHistory" runat="server">

                       

                    </div>

				</div>
				<div class="col-md-5 product-details-grid">
					
					<%--<div class="interested text-center">
                    <br/>
						<h4 style="text-align:center;">Interested?<br/></h4>
						<a href="Post.aspx"><p><i class="fa fa-check-square"></i>Check Post</p></a><div class="clearfix"></div>
                         
					</div>--%>

                    <div  class="interested text-center">
                    <div  id="divrating" runat="server">
                        </div>
                        <p id="personalAd" runat="server"></p>
                        </div>
                    <br/>
                    <br/>
                 
                 <div class="interested text-center" id="personalJobs" runat="server">
                                 
                           
						</div>
                        <br />

						<div class="interested text-center" id="myJobs" runat="server">
                                 
                           
						</div>
                        <br />
                          <div class="interested text-center" id="JobNots" runat="server">
			           </div>
                       <br />
                        
                       <div class="interested text-center" id="penJobs" runat="server">
						<!--<div class="condition">
							<h5 class="p-price">clientK, Gauteng Edenvale</h5>
							
							<h5><a href="ClientProfile1.aspx">Confirm</a>&nbsp;&nbsp;&nbsp; <a href="LeaveComment.aspx"><small>Leave a comment</small></a></h5>
							
						</div>
                        <div class="condition">
							<h5 class="p-price">annaK, Gauteng Dunvegan</h5>
							<h5><a href="ClientProfile2.aspx">Confirm</a>&nbsp;&nbsp;&nbsp;<a href="LeaveComment.aspx"><small>Leave a comment</small></a></h5>
							
						</div>-->
                            
						
					

						<!--<div class="tips">
						<h3>Job offer</h3>
							<ul>
								<li><a href="#">A. Kapinga, Gauteng Edenvale</a></li>
								<li><a href="#">J. Makou, Gauteng Dunvegan</a></li>
								
							</ul>
						</div>-->
				</div>



			<div class="clearfix"></div>
			</div>
		</div>
	</div>


    </label>
    </label>
    </label>
    </label>
    </label>
    </label>


    </div>
</asp:Content>