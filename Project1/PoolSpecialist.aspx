<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="PoolSpecialist.aspx.vb" Inherits="Project1.PoolSpecialist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyBody" runat="server">

 <div class="trending-ads">
				<div class="container">
				<!-- slider -->

                     
				<div class="trend-ads">
					<h3>Pool Specialist</h3><br/>
							<ul id="flexiselDemo3">
								<li>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imagesPL/pl4.png"/>
										</a> 
										<div class="ad-info">
											<h5>Specialist</h5>
											<span>cresta, Gauteng</span>
										</div>
									</div>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imagesPL/pl5.jpg"/>
										</a> 
										<div class="ad-info">
											<h5></h5>
											<span>Marais Steyn Park, Edenvale</span>
										</div>
									</div>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imagesPL/pl6.jpg"/>
											
										</a> 
										<div class="ad-info">
											<h5>Specialist</h5>
											<span>Dunvegan, Edenvale</span>
										</div>
									</div>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imagesPL/pl7.jpg"/>
											
										</a> 
										<div class="ad-info">
											<h5>Specialist</h5>
											<span>Eastleigh, Gauteng</span>
										</div>
									</div>
								</li>

                                <li>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imagesPL/Pl2.png"/>
											
										</a> 
										<div class="ad-info">
											<h5>Specialist</h5>
											<span>cresta, Gauteng</span>
										</div>
									</div>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imagesPL/p1.png"/>
											
										</a> 
										<div class="ad-info">
											<h5></h5>
											<span>Marais Steyn Park, Edenvale</span>
										</div>
									</div>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imagesPL/p2.png"/>
											
										</a> 
										<div class="ad-info">
											<h5>Specialist</h5>
											<span>Dunvegan, Edenvale</span>
										</div>
									</div>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imagesPL/pl4.png"/>
											
										</a> 
										<div class="ad-info">
											<h5>Specialist</h5>
											<span>Eastleigh, Gauteng</span>
										</div>
									</div>
								</li>

								
						</ul>
					<script type="text/javascript">
					    $(window).load(function () {
					        $("#flexiselDemo3").flexisel({
					            visibleItems: 1,
					            animationSpeed: 1000,
					            autoPlay: true,
					            autoPlaySpeed: 5000,
					            pauseOnHover: true,
					            enableResponsiveBreakpoints: true,
					            responsiveBreakpoints: {
					                portrait: {
					                    changePoint: 480,
					                    visibleItems: 1
					                },
					                landscape: {
					                    changePoint: 640,
					                    visibleItems: 1
					                },
					                tablet: {
					                    changePoint: 768,
					                    visibleItems: 1
					                }
					            }
					        });

					    });
					   </script>
					   <script type="text/javascript" src="js/jquery.flexisel.js"></script>

                     <br><h3>Description</h3><br>
                        <p>Pool cost estimators, or pool contractors, use their skills to project the amount of money necessary to construct a pool. 
                            These professionals may estimate pool costs for personal homes, hotels or community centers.
                             Estimators may be required to complete a training program and earn state licensure. 
                            Some licenses may require a certain amount of work experience.</p>
					</div>
                   <div class="modal-header" >
                         <a href="index.aspx">Go back</a>
                        <a style="text-align:end;margin-left:20px" href="ClientOrWorker.aspx">Return-to-login-page</a>&nbsp;&nbsp;&nbsp;
                       <a href="FeaturedWorkers.aspx#parentVerticalTab3">Featured Workers</a>
                    </div>  
                       
			</div>
			<!-- //slider -->	
     </div>
</asp:Content>
