<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site2.Master" CodeBehind="RoofSpecialist.aspx.vb" Inherits="Project1.RoofSpecialist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyBody" runat="server">
     <div class="trending-ads">
				<div class="container">
				<!-- slider -->

                     
				<div class="trend-ads">
					<h3>Roof Specialist</h3><br/>
							<ul id="flexiselDemo3">
								<li>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imageA/o1.jpg"/>
										</a> 
										<div class="ad-info">
											<h5>Specialist</h5>
											<span>cresta, Gauteng</span>
										</div>
									</div>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imageA/o2.jpg"/>
										</a> 
										<div class="ad-info">
											<h5></h5>
											<span>Marais Steyn Park, Edenvale</span>
										</div>
									</div>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imageA/o3.jpg"/>
											
										</a> 
										<div class="ad-info">
											<h5>Specialist</h5>
											<span>Dunvegan, Edenvale</span>
										</div>
									</div>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imageA/o4.jpg"/>
											
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
											<img src="images/imageA/o5.jpg"/>
											
										</a> 
										<div class="ad-info">
											<h5>Specialist</h5>
											<span>cresta, Gauteng</span>
										</div>
									</div>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imageA/o6.jpg"/>
											
										</a> 
										<div class="ad-info">
											<h5></h5>
											<span>Marais Steyn Park, Edenvale</span>
										</div>
									</div>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imageA/o7.jpg"/>
											
										</a> 
										<div class="ad-info">
											<h5>Specialist</h5>
											<span>Dunvegan, Edenvale</span>
										</div>
									</div>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imageA/o8.jpg"/>
											
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
                        <p>Roofing inspectors are generally called upon to examine roofs throughout the building process.
                             These professionals inspect rooftops and materials to ensure safety, structural integrity, and code compliance.
                             Roofing inspectors may be employed by themselves, the government, or businesses such as construction developers or even insurance companies.
                             Roofing inspectors, like other types of construction and building inspectors, usually work full-time during business hours.
                             Although roofing inspections must be done during the day, some weekends may be required; inspectors may write reports during evening hours. 
                             Roofing inspectors must be comfortable with heights.
                             There are some risks associated with the job, but inspectors can take precautionary measures against them.</p>
					</div>
                     <div class="modal-header" >
                         <a href="index.aspx">Go back</a>
                        <a style="text-align:end;margin-left:20px" href="ClientOrWorker.aspx">Return-to-login-page</a>&nbsp;&nbsp;&nbsp;
                         <a href="FeaturedWorkers.aspx#parentVerticalTab10">Featured Workers</a>
                    </div>
                       
			</div>
			<!-- //slider -->	
     </div>
</asp:Content>
