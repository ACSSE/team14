<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site2.Master" CodeBehind="Electrician.aspx.vb" Inherits="Project1.Electrician" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyBody" runat="server">




    <div class="trending-ads">
				<div class="container">
				<!-- slider -->

                     
				<div class="trend-ads">
					<h3>Electrical Work</h3><br/>
                    <br/><br/>
							<ul id="flexiselDemo3">
								<li>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imagesE/elec1.png"/>
										</a> 
										<div class="ad-info">
											<h5>Specialist</h5>
											<span>cresta, Gauteng</span>
										</div>
									</div>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imagesE/elec4.png"/>
										</a> 
										<div class="ad-info">
											<h5>Electrician</h5>
											<span>Marais Steyn Park, Edenvale</span>
										</div>
									</div>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imagesE/elec2.png"/>
											
										</a> 
										<div class="ad-info">
											<h5>Specialist</h5>
											<span>Dunvegan, Edenvale</span>
										</div>
									</div>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imagesE/elec3.png"/>
											
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
											<img src="images/imagesE/elec5.png"/>
											
										</a> 
										<div class="ad-info">
											<h5>Specialist</h5>
											<span>cresta, Gauteng</span>
										</div>
									</div>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imagesE/elec3.png"/>
											
										</a> 
										<div class="ad-info">
											<h5>Electrician</h5>
											<span>Marais Steyn Park, Edenvale</span>
										</div>
									</div>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imagesE/elec2.png"/>
											
										</a> 
										<div class="ad-info">
											<h5>Specialist</h5>
											<span>Dunvegan, Edenvale</span>
										</div>
									</div>
									<div class="col-md-3 biseller-column">
										<a href="#">
											<img src="images/imagesE/elec4.png"/>
											
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
                        <p>Electrical work can be a bit intimidating, especially for someone new to construction or DIY
                            . Understanding more about electricity can help you determine what types of electrical projects you'd be comfortable tackling on your own.
                            There was quite a bit of discussion on this post about changing out a wall outlet that questioned whether or not it's safe to tackle your own electrical or wiring projects. 
                            Some projects do require permits and the use of a licensed electrician by law, 
                            but most projects including changing wall outlets, light fixtures, and switches can be done safely by any homeowner. 
                            Every project (and house) is a bit different so it is always best to understand your own system, the basics of how the system should work, 
                            and gauge your comfort level with tackling different projects from there.</p>
					</div>
                   <div class="modal-header" >
                         <a href="index.aspx">Go back</a>
                        <a style="text-align:end;margin-left:20px" href="ClientOrWorker.aspx">Return-to-login-page</a>&nbsp;&nbsp;&nbsp;
                       <a href="FeaturedWorkers.aspx">Featured Workers</a>
                    </div>  
                       
			</div>
			<!-- //slider -->				
			</div><br><br>
    


</asp:Content>
