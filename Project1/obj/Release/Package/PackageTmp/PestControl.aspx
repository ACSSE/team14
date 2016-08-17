<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site2.Master" CodeBehind="PestControl.aspx.vb" Inherits="Project1.PestControl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyBody" runat="server">
     <div class="trending-ads">
				<div class="container">
				<!-- slider -->

                     
				<div class="trend-ads">
					<h3>Pest Control</h3><br/>
							<ul id="flexiselDemo3">
								<li>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imagesP/P1.png"/>
										</a> 
										<div class="ad-info">
											<h5>Specialist</h5>
											<span>cresta, Gauteng</span>
										</div>
									</div>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imagesP/P2.png"/>
										</a> 
										<div class="ad-info">
											<h5></h5>
											<span>Marais Steyn Park, Edenvale</span>
										</div>
									</div>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imagesP/P3.png"/>
											
										</a> 
										<div class="ad-info">
											<h5>Specialist</h5>
											<span>Dunvegan, Edenvale</span>
										</div>
									</div>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imagesP/P4.png"/>
											
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
											<img src="images/imagesP/P1.png"/>
											
										</a> 
										<div class="ad-info">
											<h5>Specialist</h5>
											<span>cresta, Gauteng</span>
										</div>
									</div>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imagesP/P2.png"/>
											
										</a> 
										<div class="ad-info">
											<h5></h5>
											<span>Marais Steyn Park, Edenvale</span>
										</div>
									</div>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imagesP/P3.png"/>
											
										</a> 
										<div class="ad-info">
											<h5>Specialist</h5>
											<span>Dunvegan, Edenvale</span>
										</div>
									</div>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imagesP/P4.png"/>
											
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
                        <p>Responsible for identifying, selecting, mixing, and applying chemical or manual solutions to get rid of pests. 
                            Identifies pest problem and appropriate solution, applies chemical or trap, and removes dead rodents..
                            Spray chemical solutions, powders, and gases on or near surfaces of a building or house to eliminate pests.
                            *Identify invading pests, including rats, termites, snakes, wasps, ants, spiders, mosquitos, or bed bugs.
                            *Set mechanical traps and place bait.
                            *Remove dead rodents after extermination.</p>
					</div>
                    
                    <div class="modal-header" >
                         <a href="index.aspx">Go back</a>
                        <a style="text-align:end;margin-left:20px" href="ClientOrWorker.aspx">Return-to-login-page</a>&nbsp;&nbsp;&nbsp;
                         <a href="FeaturedWorkers.aspx#parentVerticalTab8">Featured Workers</a>
                    </div>    
			</div>
			<!-- //slider -->	
     </div>
</asp:Content>
