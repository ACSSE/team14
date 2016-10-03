<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="AirConditioning.aspx.vb" Inherits="Project1.AirConditioning" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyBody" runat="server">
     <div class="trending-ads">
				<div class="container">
				<!-- slider -->

                     
				<div class="trend-ads">
					<h3>Air Conditioning</h3><br/>
							<ul id="flexiselDemo3">
								<li>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imageR/r1.jpg"/>
										</a> 
										<div class="ad-info">
											<h5>Specialist</h5>
											<span>cresta, Gauteng</span>
										</div>
									</div>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imageR/r2.jpg"/>
										</a> 
										<div class="ad-info">
											<h5></h5>
											<span>Marais Steyn Park, Edenvale</span>
										</div>
									</div>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imageR/r3.jpg"/>
											
										</a> 
										<div class="ad-info">
											<h5>Specialist</h5>
											<span>Dunvegan, Edenvale</span>
										</div>
									</div>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imageR/r4.jpg"/>
											
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
											<img src="images/imageR/r5.jpg"/>
											
										</a> 
										<div class="ad-info">
											<h5>Specialist</h5>
											<span>cresta, Gauteng</span>
										</div>
									</div>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imageR/r6.jpg"/>
											
										</a> 
										<div class="ad-info">
											<h5></h5>
											<span>Marais Steyn Park, Edenvale</span>
										</div>
									</div>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imageR/r7.jpg"/>
											
										</a> 
										<div class="ad-info">
											<h5>Specialist</h5>
											<span>Dunvegan, Edenvale</span>
										</div>
									</div>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imageR/r4.jpg"/>
											
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
                        <p>Air conditioning technicians may sometimes be referred to as HVACR technicians and are responsible for installing, maintaining and repairing heating, ventilation, air-conditioning and refrigeration systems. 
                            These professionals work in industrial, residential and commercial settings.
                            AC technicians, also called air conditioning mechanics and installers, specialize in the installation, maintenance or repair of air conditioning units in homes.
                             Although technicians tend to specialize in one of the two areas, they are trained to be able to both install and perform maintenance/repairs on AC units.
                             Installers place equipment, as well as connect water supply lines, air pumps, wiring and controls. Maintenance and repair technicians keep systems operating efficiently by checking equipment and looking for leaks; they make repairs using hand and power tools, a variety of measurement gauges and acetylene torches.

                        </p>
					</div>
                    
                   <div class="modal-header" >
                         <a href="index.aspx">Go back</a>
                        <a style="text-align:end;margin-left:20px" href="ClientOrWorker.aspx">Return-to-login-page</a>&nbsp;&nbsp;&nbsp;
                       <a href="FeaturedWorkers.aspx#parentVerticalTab12">Featured Workers</a>
                    </div>     
			</div>
			<!-- //slider -->	
     </div>
</asp:Content>
