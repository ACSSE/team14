

<%@ Page Title="" Language="vb" Debug="true" AutoEventWireup="false" MasterPageFile="~/Site3.Master" CodeBehind="ClientProfile.aspx.vb" Inherits="Project1.ClientProfile" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
<!--header1 start here-->
<div class="header1">
	<h1 class="main-head text-center">My Stat Profile</h1><br/>
	    <div class="head-strip">
	    	<div class="head-strip-left">
	    		<span class="joe"><img src="images/User-icon.png" alt=""> </span>
	    		<div class="joe-text">
	    			<h2>Welcome back Client</h2>
	    			<p></p>
	    		</div>
	    	</div>
	    	<div class="head-strip-right">
	    		<ul class="strip-date">
	    			<li><span class="cal"> </span><h4 style="color:black">Wednesday.October 05</h4></li>
	    			<li><span class="clock"> </span><h4 style="color:black">10.30a.m</h4></li>
	    			<li><span class="sun"> </span><h4 style="color:black">Johannesburg</h4></li>
	    		</ul>
	    		<%--<div class="settiing">
	    			<div class="menu2">
					<span class="menu-at-on"><img src="images/setter.png" alt=""> </span>	
					<ul>
						<li><a href="#">Profile</a></li>
						<li><a href="#" >Login</a></li>	
						<li><a href="#" >Log Out</a></li>							
					</ul>
					<script>
						$("span.menu-at-on").click(function(){
							$(".menu2 ul").slideToggle(500, function(){
							});
						});
					</script>
				</div>
						</div>--%>
	    		</div>
	    		  <div class="clearfix"> </div>
	    	</div>
	    
<!--header bottom start here-->
	    <div class="header1-bottom">
	    	<div class="col-md-4 header1-bot-left">
<!--user-profile start here-->
	    		<div class="user-profile">
	    			<div class="user-prof-top">
	    				<span class="cros"> </span>
	    				<div class="col-md-4 user-prof-img">
	    				    <img src="images/User-icon1.png" alt="">
	    				</div>
	    				<div class="col-md-8 user-prof-text">
	    					<h3 style="color:black">Mr. Client</h3>
	    				    <p style="color:#f3c500"><i class="glyphicon glyphicon-map-marker"></i>Gauteng, Edenvale</p>
	    				</div>
	    			  <div class="clearfix"> </div>
	    			</div>
	    			<%--<div class="user-polio-bot">
	    				<div class="col-md-4 user-prof-numb like-wt">
	    					<span class="like-heart"> </span>
	    					<h6>25,498</h6>
	    				</div>
	    				<div class="col-md-4 user-prof-numb fdback">
	    					<span class="feedback"> </span>
	    					<h6>145,369</h6>
	    				</div>
	    				<div class="col-md-4 user-prof-numb comment">
	    					<span class="comment-mess"> </span>
	    					<h6>2,487,521</h6>
	    				</div>
	    			  <div class="clearfix"> </div>
	    			</div>--%>
	    		</div>
<!--user-profile end here-->
<!--ring states start here-->
                <div class="ring-states">
                	<div class="today-status">
                		<div class="today-text">
                		    <h6>TODAY STATS</h6>
                	    </div>
                	    <span class="todat-start"><img src="images/start.png" alt=""></span>
                	    <div class="clearfix"> </div>
                	</div>
                	<div class="skill-grid">
							<div class="every" id="circles-1"> </div>									
											
							</div>                	
							<!---->
				            <script type="text/javascript" src="js/circles.js"></script>
					           <script>
								var colors = [
										['#DFDFDF', '#41c0c2']
									];
								for (var i = 1; i <= 5; i++) {
									var child = document.getElementById('circles-' + i),
										percentage = 50 + (i * 10);
										
									Circles.create({
										id:         child.id,
										percentage: percentage,
										radius:     115,
										width:      10,
										number:   	percentage / 10,
										text:       '%',
										colors:     colors[i - 1]
									});
								}
						
				         </script>
				        <!--/-->
				        <div class="tabs">
				        	<div class="sap_tabs">	
				     <div id="horizontalTab" style="display: block; width: 100%; margin: 0px;">
						  <ul class="resp-tabs-list">
						  	  <li class="resp-tab-item" aria-controls="tab_item-0" role="tab"><span>Notifications</span></li>
							  <li class="resp-tab-item" aria-controls="tab_item-1" role="tab"><span>ProfileViews</span></li>
							  <li class="resp-tab-item" aria-controls="tab_item-2" role="tab"><span>LOGS <small class="num3"> </small> </span></li>
						  </ul>				  	 
							<%--<div class="resp-tabs-container">
							    <div class="tab-1 resp-tab-content" aria-labelledby="tab_item-0">
									<div class="facts">
									  <ul class="tab_list">
									  	<li><a href="#">Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.</a></li>
									  </ul>           
							        </div>
							     </div>	
							      <div class="tab-1 resp-tab-content" aria-labelledby="tab_item-1">
									<div class="facts">
									  <ul class="tab_list">
									    <li><a href="#">augue duis dolore te feugait nulla facilisi. Nam liber tempor cum soluta nobis eleifend option congue nihil imperdiet doming id quod mazim placerat.</a></li>								  	
									  </ul>           
							        </div>
							     </div>	
							      <div class="tab-1 resp-tab-content" aria-labelledby="tab_item-2">
									<ul class="tab_list">
									  	<li><a href="#">Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.</a></li>
									  </ul>      
							     </div>	
							  <div class="clearfix"> </div> 
							 </div>--%>
					      </div>
					 </div>

				        </div>
                 </div>
<!--alaram start here-->
                <br/>
                <br/>
                 <div class="alarm">
                 	<div class="alarm-top">
                 		<h6>Next Appointment</h6>
                 		<span class="bell animated shake"> </span>
                 		<div class="clearfix"> </div>
                 	</div>
 				    <%--<div id="countdown"> </div>
 				    <div class="dottes">
 				    <span class="dot1">:</span>
 				    <span class="dot2">:</span> 
 				    </div>
 				     <h4>Hour</h4>
 				    <h5>Min</h5>
 				    <h3>Sec</h3>--%>
 				    <a href="#">Mr.Client X</a>
 				    <div class="clearfix"> </div> 
 				 </div>
<!--alaram end here-->
<!--weather start here-->
                 <%--<div class="weather">
                 	<div class="col-md-5 cloud-img">
                 		<img src="images/clud.png" alt="">
                 		<p>Partly Cloudy</p>
                 	</div>
                 	<div class="col-md-7 tempara">
				          <ul id="flexiselDemo1">			
						<li>
							   <div class="weather-text">
									<h3>89F</h3>
									<p>COPAN RUNINAS</p>
								</div>
							</li>
							<li>
								<div class="weather-text">
									<h3>65F</h3>
									<p>COPAN RUNINAS</p>
								</div>
							</li>
							<li>
								<div class="weather-text">
									<h3>45F</h3>
									<p>COPAN RUNINAS</p>
								</div>								
							</li>
							<li>
								<div class="weather-text">
								<h3>50F</h3>
								<p>COPAN RUNINAS</p>		
							   </div>						
							</li>
						</ul>
						<script type="text/javascript">
						$(window).load(function() {
							$("#flexiselDemo1").flexisel({
								visibleItems: 1,
								animationSpeed: 1000,
								autoPlay: false,
								autoPlaySpeed: 3000,    		
								pauseOnHover: true,
								enableResponsiveBreakpoints: true,
						    	responsiveBreakpoints: { 
						    		portrait: { 
						    			changePoint:480,
						    			visibleItems: 1
						    		}, 
						    		landscape: { 
						    			changePoint:640,
						    			visibleItems: 1
						    		},
						    		tablet: { 
						    			changePoint:768,
						    			visibleItems: 1
						    		}
						    	}
						    });
						    
						});
			</script>
			<script type="text/javascript" src="js/jquery.flexisel.js"></script>
                 	</div>
                   <div class="clearfix"> </div>
                 </div>--%>
<!--weather end here-->
<!--login start here-->
				 <%--<div class="login">
					<h4>SIMPLE  LOGIN FORM</h4>
					<form>
					  <div class="login-name">
					  	<span class="login-user"> </span>
						<input type="text" value="Username" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Username';}"/>
					  </div>
					  <div class="login-password">
					  	<span class="login-key"> </span>
						<input type="password" value="Password" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Password';}"/>
					  </div>
						<div class="remember">
							<span class="checkbox1">
								 <label class="checkbox"><input type="checkbox" checked=""><i> </i>Remember me</label>
							</span>
							<div class="send">
								<input type="submit" value="LOGIN">
							</div>
						  <div class="clearfix"> </div>
						</div>
					</form>
				 </div>--%>
<!--login end here-->
<!--mountain-img start here-->
                <%--<div class="mountain-img">
                	<div class="mountain-strip">
	                	<div class="col-md-6 moutain-follow">
	                		<span class="red-heart"> </span>
	                		<p>1,182</p>
	                	</div>
	                	<div class="col-md-6 moutain-follow">
	                		<span class="gree-download"> </span>
	                		<p>14,327</p>
	                	</div>
	                	<div class="clearfix"> </div>
                  </div>
               </div>--%>
	    	</div>
<!--header1-bot-right start here-->
	    	<div class="col-md-8 header1-bot-right">
<!--analytic start here-->
	    		<div class="analytic">
	    			<div class="analytic-top">
	    				<div class="infograpy"><h4>Earning information</h4></div>
	    				<span class="share"> </span>
	    			  <div class="clearfix"> </div>
	    			</div>
	    				<div class="analttic-right">
	    					 <div class="graph-grid">
	    			<!--graph-->
								<link rel="stylesheet" href="css/graph.css"/>
								<script src="js/jquery.flot.min.js"></script>
					<!--//graph-->
					<script>
										$(document).ready(function () {
										
											// Graph Data ##############################################
											var graphData = [{
													// Returning Visits
													data: [ [6, 4500], [7,3500], [8, 6550], [9, 7600], ],
													color: '#000000',
													points: { radius: 4, fillColor: '#000000' }
												}
											];
										
											// Lines Graph #############################################
											$.plot($('#graph-lines'), graphData, {
												series: {
													points: {
														show: true,
														radius: 1
													},
													lines: {
														show: true
													},
													shadowSize: 0
												},
												grid: {
												    color: '#000000',
												    borderColor: '#b2b2b2',
													borderWidth: 10,
													hoverable: true
												},
												xaxis: {
												    tickColor: '#b2b2b2',
													tickDecimals: false
												},
												yaxis: {
													tickSize: 1200
												}
											});
										
											// Bars Graph ##############################################
											$.plot($('#graph-bars'), graphData, {
												series: {
													bars: {
														show: true,
														barWidth: .9,
														align: 'center'
													},
													shadowSize: 0
												},
												grid: {
													color: '#fff',
													borderColor: '#b2b2b2',
													borderWidth: 20,
													hoverable: true
												},
												xaxis: {
												    tickColor: '#b2b2b2',
													tickDecimals: 2
												},
												yaxis: {
													tickSize: 1000
												}
											});
										
											// Graph Toggle ############################################
											$('#graph-bars').hide();
										
											$('#lines').on('click', function (e) {
												$('#bars').removeClass('active');
												$('#graph-bars').fadeOut();
												$(this).addClass('active');
												$('#graph-lines').fadeIn();
												e.preventDefault();
											});
										
											$('#bars').on('click', function (e) {
												$('#lines').removeClass('active');
												$('#graph-lines').fadeOut();
												$(this).addClass('active');
												$('#graph-bars').fadeIn().removeClass('hidden');
												e.preventDefault();
											});
										
											// Tooltip #################################################
											function showTooltip(x, y, contents) {
												$('<div id="tooltip">' + contents + '</div>').css({
													top: y - 16,
													left: x + 20
												}).appendTo('body').fadeIn();
											}
										
											var previousPoint = null;
										
											$('#graph-lines, #graph-bars').bind('plothover', function (event, pos, item) {
												if (item) {
													if (previousPoint != item.dataIndex) {
														previousPoint = item.dataIndex;
														$('#tooltip').remove();
														var x = item.datapoint[0],
															y = item.datapoint[1];
															showTooltip(item.pageX, item.pageY, y+ x );
													}
												} else {
													$('#tooltip').remove();
													previousPoint = null;
												}
											});
										
										});
										</script>
					<!-- Graph HTML -->
								<div id="graph-wrapper">
									<div class="graph-container">
										<%--<div id="graph-lines"> </div>
										<div id="graph-bars"> </div>--%>
									    <%--<asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource3" Height="285px" Palette="Fire" PaletteCustomColors="243, 197, 0; 0, 0, 192" Width="750px">
                                            <series>
                                                <asp:Series Name="Series1" XValueMember="Username" YValueMembers="JoinDate">
                                                </asp:Series>
                                            </series>
                                            <chartareas>
                                                <asp:ChartArea Name="ChartArea1">
                                                </asp:ChartArea>
                                            </chartareas>
                                        </asp:Chart>
                                        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Clients]"></asp:SqlDataSource>
                                        <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>
                                        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>--%>
                                        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" Height="277px" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt">
                                            <LocalReport ReportPath="Report2.rdlc">
                                                <DataSources>
                                                    <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet1" />
                                                </DataSources>
                                            </LocalReport>
                                        </rsweb:ReportViewer>
									    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData" TypeName="Project1.HandymanDatabaseDataSet1TableAdapters.MessengesTableAdapter"></asp:ObjectDataSource>
									</div>
								</div>
							<!-- end Graph HTML -->
                     </div>
                    </div>
					<div class="analytic-bottom">
						<ul>
							<li><h3><a href="#">R</a></h3><p>Total</p></li>
							<li><h3><a href="#">R</a></h3><p>Total</p></li>
							<li><h3><a href="#">1</a></h3><p>New</p></li>
						</ul>
					</div>
			 </div>
<!--banner start here-->
	    		<%--<div class="banner">
	    			<div class="bann-left">
	    				<span class="bann-part"> </span>
	    				<div class="bann-text">
	    					<h1>Want to search Analitycs History?</h1>
	    					<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit</p>
	    				</div>
	    			</div>
	    			<div class="bann-rit">
	    				<a href="#">EXPLORE</a>
	    			</div>
	    		  <div class="clearfix"> </div>
	    		</div>--%>
<!--part1 start here-->
                <br/>
                <div class="bar-kit">
	    		<div class="col-md-5 header1-bot-right-part-1">
<!--latest activity strta here-->
                    <br/>
	    			<div class="latest-activity">
	    				<div class="latest-act-top">
	    					<h4>LATEST Comments</h4>
	    					<span class="rocket"> </span>
	    				  <div class="clearfix"> </div>
	    				</div>
	    				<div class="latest-act-bot">
	    					<ul>
	    						<li><span class="box"> </span></li>
	    						<li><span class="line"> </span></li>
	    						<li><span class="box"> </span></li>
                                <li><span class="line"> </span></li>
	    						<li><span class="box"> </span></li>
	    						
	    					</ul>
	    					<div class="latest-today">
	    						<h4>Today,3.20AM</h4>
	    						<h3>Client x</h3>
	    						<p> Greatest electrician ever <span class="todt-joe">   Client x</span></p>
	    					</div>
	    					<div class="latest-today">
	    						<h4>Today,2.45AM</h4>
	    						<h3>anna k</h3>
	    						<p>Greatest electrician <span class="todt-joe">   anna k</span></p>
	    					</div>
	    					<div class="latest-today">
	    						<h4>Today,5.15AM</h4>
	    						<h3>joe j</h3>
	    						<p>Greatest electrician<span class="todt-joe"> Joe j </span></p>
	    					</div>
	    					<%--<div class="latest-today">
	    						<h4>Today,12.06AM</h4>
	    						<h3>SITE UPDATE</h3>
	    						<p>Viris phaedrum ad cum, in usu ipsum percipit. Ut ponderum percipitur este -by <span class="todt-joe"> Joe Black </span></p>
	    					</div>
	    					<div class="latest-today">
	    						<h4>NEW PRODUCTS</h4>
	    						<h3>NEW INVOICE SUBMITED</h3>
	    						<p>Viris phaedrum ad cum, in usu ipsum percipit. Ut ponderum percipitur este -by <span class="todt-joe"> Joe Black </span></p>
	    					</div>--%>
	    				</div>
	    				<div class="late-btn">
	    					<a href="#">LOAD MORE</a>
	    				</div>
	    			</div>
<!--video start here-->
	    			<%--<div class="video">
	    				<div class="content-middle-top2">
		<div class=" video-grid">
					<div id="jp_container_1" class="jp-video jp-video-360p" role="application" aria-label="media player">
						<div class="jp-type-single">
							<div id="jquery_jplayer_1" class="jp-jplayer"></div>
							<div class="jp-gui">
								<div class="jp-video-play">
									<button class="jp-video-play-icon" role="button" tabindex="0">play</button>
								</div>
								<div class="jp-interface">
									<div class="jp-progress">
										<div class="jp-seek-bar">
											<div class="jp-play-bar"></div>
										</div>
									</div>
									<div class="jp-current-time" role="timer" aria-label="time">&nbsp;</div>
									<div class="jp-duration" role="timer" aria-label="duration">&nbsp;</div>
									<div class="jp-controls-holder">
										<div class="jp-controls">
											<button class="jp-play" role="button" tabindex="0">play</button>
											<button class="jp-stop" role="button" tabindex="0">stop</button>
										</div>
										<div class="jp-volume-controls">
											<button class="jp-mute" role="button" tabindex="0">mute</button>
											<button class="jp-volume-max" role="button" tabindex="0">max volume</button>
											<div class="jp-volume-bar">
												<div class="jp-volume-bar-value"></div>
											</div>
										</div>
										<div class="jp-toggles">
											<button class="jp-repeat" role="button" tabindex="0">repeat</button>
											<button class="jp-full-screen" role="button" tabindex="0">full screen</button>
										</div>
									</div>
									
								</div>
							</div>
							<div class="jp-no-solution">
								<span>Update Required</span>
								To play the media you will need to either update your browser to a recent version or update your <a href="http://get.adobe.com/flashplayer/" target="_blank">Flash plugin</a>.
							</div>
						</div>
					</div>
				</div>
	</div>
	    			</div>--%>
	    		</div>
<!--part2 start here-->
	    		<div class="col-md-7 header1-bot-right-part-2">
<!--meeting strta here-->
                    <br/>
                    <div class="meeting">
                    	<div class="meeting-top">
                    		<h3>Pending Notifications</h3>
                    		<%--<div class="menu3">
								<span class="menu-at-on1"><img src="images/menu1.png" alt=""> </span>	
								<ul>
									<li><a href="#">Profile</a></li>
									<li><a href="#" >Login</a></li>	
									<li><a href="#" >Logout</a></li>							
								</ul>
								<script>
									$("span.menu-at-on1").click(function(){
										$(".menu3 ul").slideToggle(500, function(){
										});
									});
								</script>
							</div>--%>
						   <div class="clearfix"> </div>
                    	</div>
                    	<%--<div class="meet-search">
							<form>
								<input type="text" value="Search" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Search';}"/>
								<input type="submit" value="">
							</form>
                    	</div>--%>
                    	<div class="menu_vertical">
					         	 	<section class="accordation_menu">
									  <div>
									    <input id="label-1" name="lida" type="radio" checked/>
									   <label for="label-1" id="item1"><i class="ferme"> </i> <span class="tickimg"><img src="images/check.png" alt=""/><i> </i>I need an electrician<strong  class="tad-timer"> <i class="tab-text-time">Today,3.20AM</i></strong></span><small class="pen"> </small> <i class="icon-plus-sign i-right1"> </i> <i class="icon-minus-sign i-right2"></i> </label>
									    <div class="content1" id="a1">
									       <ul class="news_list">
									       	<li><img src="images/User-icon.png" alt=""/> </li>
											 <li class="date_desc-auther"><p>Joe j</p></li>
							  			   	 <li class="date_desc-timer"><p>2h to Complete the task</p></li>
							  			  </ul> 
							  			  <p class="auther-para">power cable tripped and i don't know what to do</p>
									        
									    </div>
									  </div>
									  <div>
									    <input id="label-2" name="lida" type="radio"/>
									    <label for="label-2" id="item2"><i class="ferme"> </i> <span class="tickimg"><img src="images/check.png" alt=""><i> </i>Electrical Failure<strong  class="tad-timer"> <i class="tab-text-time">Today,3.20AM</i></strong></span><small class="pen"> </small> <i class="icon-plus-sign i-right1"> </i> <i class="icon-minus-sign i-right2"></i> </label>
									    <div class="content1" id="a2">
									       <ul class="news_list">
									       	<li><img src="images/User-icon.png" alt=""> </li>
											 <li class="date_desc-auther"><p>Joe Black</p></li>
							  			   	 <li class="date_desc-timer"><p>2h to Complete the task</p></li>
							  			  </ul> 
							  			  <p class="auther-para">there is no electricity at my place</p>   
									    </div>
									  </div>
									  <div>
									    <input id="label-3" name="lida" type="radio"/>
									     <label for="label-3" id="item3"><i class="ferme"> </i> <span class="tickimg"><img src="images/check.png" alt=""><i> </i>Website Update<strong  class="tad-timer"> <i class="tab-text-time">Today,3.20AM</i></strong></span><small class="pen"> </small> <i class="icon-plus-sign i-right1"> </i> <i class="icon-minus-sign i-right2"></i> </label>
									    <div class="content1" id="a3">									        
							  			  <p class="auther-para"> there is no power </p>									
									    </div>
									  </div>
								<%--	  <div>
									    <input id="label-4" name="lida" type="radio"/>
									     <label for="label-4" id="item4"><i class="ferme"> </i> <span class="tickimg"><img src="images/check.png" alt=""><i> </i>Financial Report<strong  class="tad-timer"> <i class="tab-text-time">02/15,2.20AM</i></strong></span><small class="pen"> </small> <i class="icon-plus-sign i-right1"> </i> <i class="icon-minus-sign i-right2"></i> </label>
									    <div class="content1" id="a4">
									      <ul class="news_list">
									       	<li><img src="images/icon.png" alt=""> </li>
											 <li class="date_desc-auther"><p>Joe Black</p></li>
							  			   	 <li class="date_desc-timer"><p>2h to Complete the task</p></li>
							  			  </ul> 
							  			  <p class="auther-para">Etiam feugiat lectus nisl, in euismod lectus viverra et.Sed et scelerisque felis. Integer vel volutpat massa Donec id justo nisl Vivamus</p>
									        <div class="involed-people">
									        	 <h4>PEOPLE INVOLVED:</h4>
									        	 <img src="images/invitation.png" alt="">
									        </div>
									    </div>
									  </div>--%>
									<div class="clearfix"> </div>
									</section>
                              </div>
                         </div>
<!--map start here-->
	    			<%--<div class="map"> 
	    				<iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d127640.75918330808!2d103.8466694772479!3d1.3111268075660079!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x31da11238a8b9375%3A0x887869cf52abf5c4!2sSingapore!5e0!3m2!1sen!2sin!4v1436965675589"> </iframe>
                     </div>
	    			<div class="location">
	    				<div class="col-md-6 rids">
	    					<span class="localpointer"> </span>
	    					<div class="rid-text">
		    					<h3>RIDS</h3>
		    					<p>2College st</p>
		    					<p>Providence,Ri 02903</p>
		    					<p>United States</p>
	    					</div>
	    				</div>
	    				<div class="col-md-6 rids-btns">
	    					<div class="print-btn">
	    						<a href="#">PRINT</a>
	    					</div>
	    					<div class="print-btn">
	    						<a href="#">SHARE</a>
	    					</div>
	    				</div>
	    			  <div class="clearfix"> </div>
	    			</div>--%>
	    		</div>
	    		 <div class="clearfix"> </div>
	      </div>
	  </div>
   <div class="clearfix"> </div>
</div>
 <div class="clearfix"> </div>
</div>
        <%--<div class="copy-right">
			   <p>© 2015 Storage Ui Kit . All rights reserved | Template by  <a href="http://w3layouts.com/" target="_blank">  W3layouts </a></p>
		        <script type="text/javascript">
										$(document).ready(function() {
											/*
											var defaults = {
									  			containerID: 'toTop', // fading element id
												containerHoverID: 'toTopHover', // fading element hover id
												scrollSpeed: 1200,
												easingType: 'linear' 
									 		};
											*/
											
											$().UItoTop({ easingType: 'easeOutQuart' });
											
										});
									</script>
						<a href="#" id="toTop" style="display: block;"> <span id="toTopHover" style="opacity: 1;"> </span></a>

		   </div>--%>
<!--header1 bottom end here-->
<!--header1 end here-->

    </form>

</asp:Content>