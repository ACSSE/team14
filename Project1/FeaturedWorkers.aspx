
﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="FeaturedWorkers.aspx.vb" Inherits="Project1.FeaturedWorkers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyBody" runat="server">

<%--Paint and deco--%>

                <div>
                        
					<div class="wrapper">					
					<div class="bs-example bs-example-tabs" role="tabpanel" data-example-id="togglable-tabs">
					  
					  <div id="myTabContent" class="tab-content">
						<div role="tabpanel" class="tab-pane fade in active" id="home" aria-labelledby="home-tab">
						   <div>
												<div id="container">
								<div class="view-controls-list" id="viewcontrols">
									<label>view :</label>
									<a class="gridview"><i class="glyphicon glyphicon-th"></i></a>
									<a class="listview active"><i class="glyphicon glyphicon-th-list"></i></a>
								</div>
								<div class="sort">
								   <div class="sort-by">
										<label>Sort By : </label>
										<select>
														<option value="">Most Rated</option>
														<option value="">Rate:  Low to High</option>
														<option value="">Rate:  High to Low</option>
										</select>
									   </div>
									 </div>
								<div class="clearfix"></div>
							<div id="PaintnDecoration" runat="server">
								
								
<%--								<a href="WorkerProfile.aspx">
									<li>
									<img src="images/p1.png" title="" alt="" />
									<section class="list-left">
									<h5 class="title">Decorator</h5>
									<span class="adprice"><p> <i class="glyphicon glyphicon-map-marker"></i><a href="#">Gauteng</a>, <a href="#">Edenvale</a></p></span>
									<p class="catpath">Visit Profile</p>
									</section>
									<section class="list-right">
									</section>
									<div class="clearfix"></div>
									</li> 
								</a>
								<a href="WorkerProfile.aspx">
									<li>
									<img src="images/p2.png" title="" alt="" />
									<section class="list-left">
									<h5 class="title">Decorator</h5>
									<span class="adprice"><p> <i class="glyphicon glyphicon-map-marker"></i><a href="#">Gauteng</a>, <a href="#">Dunvegan</a></p></span>
									<p class="catpath">Visit Profile</p>
									</section>
									<section class="list-right">
									</section>
									<div class="clearfix"></div>
									</li> 
								</a>
								<a href="WorkerProfile.aspx">
									<li>
									<img src="images/p3.png" title="" alt="" />
									<section class="list-left">
									<h5 class="title">Painter</h5>
									<span class="adprice"><p> <i class="glyphicon glyphicon-map-marker"></i><a href="#">Gauteng</a>, <a href="#">Eastleigh</a></p></span>
									<p class="catpath">Visit Profile</p>
									</section>
									<section class="list-right">
									</section>
									<div class="clearfix"></div>
									</li> 
								</a>
								<a href="WorkerProfile.aspx">
									<li>
									<img src="images/p4.png" title="" alt="" />
									<section class="list-left">
									<h5 class="title">Decorator</h5>
									<span class="adprice"><p> <i class="glyphicon glyphicon-map-marker"></i><a href="#">Gauteng</a>, <a href="#">Randburg</a></p></span>
									<p class="catpath">Visit Profile</p>
									</section>
									<section class="list-right">
									</section>
									<div class="clearfix"></div>
									</li> 
								</a>
								<a href="WorkerProfile.aspx">
									<li>
									<img src="images/p1.png" title="" alt="" />
									<section class="list-left">
									<h5 class="title">Painter</h5>
									<span class="adprice"><p> <i class="glyphicon glyphicon-map-marker"></i><a href="#">Gauteng</a>, <a href="#">Dowerglen</a></p></span>
									<p class="catpath">Visit Profile</p>
									</section>
									<section class="list-right">
									</section>
									<div class="clearfix"></div>
									</li> 
								</a>--%>
							</div>
						</div>
							</div>
						</div>
						
						
						<ul class="pagination pagination-sm">
							<li><a href="#">Prev</a></li>
							<li><a href="#">1</a></li>
							<li><a href="#">2</a></li>
							<li><a href="#">Next</a></li>
						</ul>
					  </div>
					</div>
				</div>
				</div>
						
<%--Pool specialist--%>

                        <div>
                        
					<div class="wrapper">					
					<div class="bs-example bs-example-tabs" role="tabpanel" data-example-id="togglable-tabs">
					  
					  <div id="myTabContent" class="tab-content">
						<div role="tabpanel" class="tab-pane fade in active" id="home" aria-labelledby="home-tab">
						   <div>
												<div id="container">
								<div class="view-controls-list" id="viewcontrols">
									<label>view :</label>
									<a class="gridview"><i class="glyphicon glyphicon-th"></i></a>
									<a class="listview active"><i class="glyphicon glyphicon-th-list"></i></a>
								</div>
								<div class="sort">
								   <div class="sort-by">
										<label>Sort By : </label>
										<select>
														<option value="">Most Rated</option>
														<option value="">Rate:  Low to High</option>
														<option value="">Rate:  High to Low</option>
										</select>
									   </div>
									 </div>
								<div class="clearfix"></div>
							<div id="PoolSpel" runat="server">
								
								
<%--								<a href="WorkerProfile.aspx">
									<li>
									<img src="images/p1.png" title="" alt="" />
									<section class="list-left">
									<h5 class="title">Pool Specialist</h5>
									<span class="adprice"><p> <i class="glyphicon glyphicon-map-marker"></i><a href="#">Gauteng</a>, <a href="#">Edenvale</a></p></span>
									<p class="catpath">Visit Profile</p>
									</section>
									<section class="list-right">
									</section>
									<div class="clearfix"></div>
									</li> 
								</a>
								<a href="WorkerProfile.aspx">
									<li>
									<img src="images/p2.png" title="" alt="" />
									<section class="list-left">
									<h5 class="title">Pool Specialist</h5>
									<span class="adprice"><p> <i class="glyphicon glyphicon-map-marker"></i><a href="#">Gauteng</a>, <a href="#">Dunvegan</a></p></span>
									<p class="catpath">Visit Profile</p>
									</section>
									<section class="list-right">
									</section>
									<div class="clearfix"></div>
									</li> 
								</a>
								<a href="WorkerProfile.aspx">
									<li>
									<img src="images/p3.png" title="" alt="" />
									<section class="list-left">
									<h5 class="title">Pool Specialist</h5>
									<span class="adprice"><p> <i class="glyphicon glyphicon-map-marker"></i><a href="#">Gauteng</a>, <a href="#">Eastleigh</a></p></span>
									<p class="catpath">Visit Profile</p>
									</section>
									<section class="list-right">
									</section>
									<div class="clearfix"></div>
									</li> 
								</a>
								<a href="WorkerProfile.aspx">
									<li>
									<img src="images/p4.png" title="" alt="" />
									<section class="list-left">
									<h5 class="title">Pool Specialist</h5>
									<span class="adprice"><p> <i class="glyphicon glyphicon-map-marker"></i><a href="#">Gauteng</a>, <a href="#">Randburg</a></p></span>
									<p class="catpath">Visit Profile</p>
									</section>
									<section class="list-right">
									</section>
									<div class="clearfix"></div>
									</li> 
								</a>
								<a href="WorkerProfile.aspx">
									<li>
									<img src="images/p1.png" title="" alt="" />
									<section class="list-left">
									<h5 class="title">Pool Specialist</h5>
									<span class="adprice"><p> <i class="glyphicon glyphicon-map-marker"></i><a href="#">Gauteng</a>, <a href="#">Dowerglen</a></p></span>
									<p class="catpath">Visit Profile</p>
									</section>
									<section class="list-right">
									</section>
									<div class="clearfix"></div>
									</li> 
								</a>--%>
							</div>
						</div>
							</div>
						</div>
						
						
						<ul class="pagination pagination-sm">
							<li><a href="#">Prev</a></li>
							<li><a href="#">1</a></li>
							<li><a href="#">2</a></li>
							<li><a href="#">Next</a></li>
						</ul>
					  </div>
					</div>
				</div>
				</div>

<%--garden and landscaping--%>

                        <div>
                        
					<div class="wrapper">					
					<div class="bs-example bs-example-tabs" role="tabpanel" data-example-id="togglable-tabs">
					  
					  <div id="myTabContent" class="tab-content">
						<div role="tabpanel" class="tab-pane fade in active" id="home" aria-labelledby="home-tab">
						   <div>
												<div id="container">
								<div class="view-controls-list" id="viewcontrols">
									<label>view :</label>
									<a class="gridview"><i class="glyphicon glyphicon-th"></i></a>
									<a class="listview active"><i class="glyphicon glyphicon-th-list"></i></a>
								</div>
								<div class="sort">
								   <div class="sort-by">
										<label>Sort By : </label>
										<select>
														<option value="">Most Rated</option>
														<option value="">Rate:  Low to High</option>
														<option value="">Rate:  High to Low</option>
										</select>
									   </div>
									 </div>
								<div class="clearfix"></div>
							<div id="GardennLandscaping" runat="server">
								
								
								<%--<a href="WorkerProfile.aspx">
									<li>
									<img src="images/p1.png" title="" alt="" />
									<section class="list-left">
									<h5 class="title">Gardener</h5>
									<span class="adprice"><p> <i class="glyphicon glyphicon-map-marker"></i><a href="#">Gauteng</a>, <a href="#">Edenvale</a></p></span>
									<p class="catpath">Visit Profile</p>
									</section>
									<section class="list-right">
									</section>
									<div class="clearfix"></div>
									</li> 
								</a>
								<a href="WorkerProfile.aspx">
									<li>
									<img src="images/p2.png" title="" alt="" />
									<section class="list-left">
									<h5 class="title">Gardener</h5>
									<span class="adprice"><p> <i class="glyphicon glyphicon-map-marker"></i><a href="#">Gauteng</a>, <a href="#">Dunvegan</a></p></span>
									<p class="catpath">Visit Profile</p>
									</section>
									<section class="list-right">
									</section>
									<div class="clearfix"></div>
									</li> 
								</a>
								<a href="WorkerProfile.aspx">
									<li>
									<img src="images/p3.png" title="" alt="" />
									<section class="list-left">
									<h5 class="title">Gardener</h5>
									<span class="adprice"><p> <i class="glyphicon glyphicon-map-marker"></i><a href="#">Gauteng</a>, <a href="#">Eastleigh</a></p></span>
									<p class="catpath">Visit Profile</p>
									</section>
									<section class="list-right">
									</section>
									<div class="clearfix"></div>
									</li> 
								</a>
								<a href="WorkerProfile.aspx">
									<li>
									<img src="images/p4.png" title="" alt="" />
									<section class="list-left">
									<h5 class="title">Gardener</h5>
									<span class="adprice"><p> <i class="glyphicon glyphicon-map-marker"></i><a href="#">Gauteng</a>, <a href="#">Randburg</a></p></span>
									<p class="catpath">Visit Profile</p>
									</section>
									<section class="list-right">
									</section>
									<div class="clearfix"></div>
									</li> 
								</a>
								<a href="WorkerProfile.aspx">
									<li>
									<img src="images/p1.png" title="" alt="" />
									<section class="list-left">
									<h5 class="title">Gardener</h5>
									<span class="adprice"><p> <i class="glyphicon glyphicon-map-marker"></i><a href="#">Gauteng</a>, <a href="#">Dowerglen</a></p></span>
									<p class="catpath">Visit Profile</p>
									</section>
									<section class="list-right">
									</section>
									<div class="clearfix"></div>
									</li> 
								</a>--%>
							</div>
						</div>
							</div>
						</div>
						
						
						<ul class="pagination pagination-sm">
							<li><a href="#">Prev</a></li>
							<li><a href="#">1</a></li>
							<li><a href="#">2</a></li>
							<li><a href="#">Next</a></li>
						</ul>
					  </div>
					</div>
				</div>
				</div>

<%--Security, fire and Safety--%>

                        
                        <div>
                        
					<div class="wrapper">					
					<div class="bs-example bs-example-tabs" role="tabpanel" data-example-id="togglable-tabs">
					  
					  <div id="myTabContent" class="tab-content">
						<div role="tabpanel" class="tab-pane fade in active" id="home" aria-labelledby="home-tab">
						   <div>
												<div id="container">
								<div class="view-controls-list" id="viewcontrols">
									<label>view :</label>
									<a class="gridview"><i class="glyphicon glyphicon-th"></i></a>
									<a class="listview active"><i class="glyphicon glyphicon-th-list"></i></a>
								</div>
								<div class="sort">
								   <div class="sort-by">
										<label>Sort By : </label>
										<select>
														<option value="">Most Rated</option>
														<option value="">Rate:  Low to High</option>
														<option value="">Rate:  High to Low</option>
										</select>
									   </div>
									 </div>
								<div class="clearfix"></div>
							<div id="Security" runat="server">
								
								
<%--								<a href="WorkerProfile.aspx">
									<li>
									<img src="images/p1.png" title="" alt="" />
									<section class="list-left">
									<h5 class="title">ChildProofing Specialist</h5>
									<span class="adprice"><p> <i class="glyphicon glyphicon-map-marker"></i><a href="#">Gauteng</a>, <a href="#">Edenvale</a></p></span>
									<p class="catpath">Visit Profile</p>
									</section>
									<section class="list-right">
									</section>
									<div class="clearfix"></div>
									</li> 
								</a>
								<a href="WorkerProfile.aspx">
									<li>
									<img src="images/p2.png" title="" alt="" />
									<section class="list-left">
									<h5 class="title">Security System Specialist</h5>
									<span class="adprice"><p> <i class="glyphicon glyphicon-map-marker"></i><a href="#">Gauteng</a>, <a href="#">Dunvegan</a></p></span>
									<p class="catpath">Visit Profile</p>
									</section>
									<section class="list-right">
									</section>
									<div class="clearfix"></div>
									</li> 
								</a>
								<a href="WorkerProfile.aspx">
									<li>
									<img src="images/p3.png" title="" alt="" />
									<section class="list-left">
									<h5 class="title">Alarm Specialist</h5>
									<span class="adprice"><p> <i class="glyphicon glyphicon-map-marker"></i><a href="#">Gauteng</a>, <a href="#">Eastleigh</a></p></span>
									<p class="catpath">Visit Profile</p>
									</section>
									<section class="list-right">
									</section>
									<div class="clearfix"></div>
									</li> 
								</a>
								<a href="WorkerProfile.aspx">
									<li>
									<img src="images/p4.png" title="" alt="" />
									<section class="list-left">
									<h5 class="title">ChildProofing Specialist</h5>
									<span class="adprice"><p> <i class="glyphicon glyphicon-map-marker"></i><a href="#">Gauteng</a>, <a href="#">Randburg</a></p></span>
									<p class="catpath">Visit Profile</p>
									</section>
									<section class="list-right">
									</section>
									<div class="clearfix"></div>
									</li> 
								</a>
								<a href="WorkerProfile.aspx">
									<li>
									<img src="images/p1.png" title="" alt="" />
									<section class="list-left">
									<h5 class="title">Alarm Specialist</h5>
									<span class="adprice"><p> <i class="glyphicon glyphicon-map-marker"></i><a href="#">Gauteng</a>, <a href="#">Dowerglen</a></p></span>
									<p class="catpath">Visit Profile</p>
									</section>
									<section class="list-right">
									</section>
									<div class="clearfix"></div>
									</li> 
								</a>--%>
							</div>
						</div>
							</div>
						</div>
						
						
						<ul class="pagination pagination-sm">
							<li><a href="#">Prev</a></li>
							<li><a href="#">1</a></li>
							<li><a href="#">2</a></li>
							<li><a href="#">Next</a></li>
						</ul>
					  </div>
					</div>
				</div>
				</div>

<%--Kitchen Specialist --%>               
						
						
                        <div>
                        
					<div class="wrapper">					
					<div class="bs-example bs-example-tabs" role="tabpanel" data-example-id="togglable-tabs">
					  
					  <div id="myTabContent" class="tab-content">
						<div role="tabpanel" class="tab-pane fade in active" id="home" aria-labelledby="home-tab">
						   <div>
												<div id="container">
								<div class="view-controls-list" id="viewcontrols">
									<label>view :</label>
									<a class="gridview"><i class="glyphicon glyphicon-th"></i></a>
									<a class="listview active"><i class="glyphicon glyphicon-th-list"></i></a>
								</div>
								<div class="sort">
								   <div class="sort-by">
										<label>Sort By : </label>
										<select>
														<option value="">Most Rated</option>
														<option value="">Rate:  Low to High</option>
														<option value="">Rate:  High to Low</option>
										</select>
									   </div>
									 </div>
								<div class="clearfix"></div>
							<div id="KitchenSpec" runat="server">
								
								<%--<a href="WorkerProfile.aspx">
									<li>
									<img src="images/p1.png" title="" alt="" />
									<section class="list-left">
									<h5 class="title">Kitchen Specialist</h5>
									<span class="adprice"><p> <i class="glyphicon glyphicon-map-marker"></i><a href="#">Gauteng</a>, <a href="#">Edenvale</a></p></span>
									<p class="catpath">Visit Profile</p>
									</section>
									<section class="list-right">
									</section>
									<div class="clearfix"></div>
									</li> 
								</a>
								<a href="WorkerProfile.aspx">
									<li>
									<img src="images/p2.png" title="" alt="" />
									<section class="list-left">
									<h5 class="title">Kitchen Specialist</h5>
									<span class="adprice"><p> <i class="glyphicon glyphicon-map-marker"></i><a href="#">Gauteng</a>, <a href="#">Dunvegan</a></p></span>
									<p class="catpath">Visit Profile</p>
									</section>
									<section class="list-right">
									</section>
									<div class="clearfix"></div>
									</li> 
								</a>
								<a href="WorkerProfile.aspx">
									<li>
									<img src="images/p3.png" title="" alt="" />
									<section class="list-left">
									<h5 class="title">Kitchen Specialist</h5>
									<span class="adprice"><p> <i class="glyphicon glyphicon-map-marker"></i><a href="#">Gauteng</a>, <a href="#">Eastleigh</a></p></span>
									<p class="catpath">Visit Profile</p>
									</section>
									<section class="list-right">
									</section>
									<div class="clearfix"></div>
									</li> 
								</a>
								<a href="WorkerProfile.aspx">
									<li>
									<img src="images/p4.png" title="" alt="" />
									<section class="list-left">
									<h5 class="title">Kitchen Specialist</h5>
									<span class="adprice"><p> <i class="glyphicon glyphicon-map-marker"></i><a href="#">Gauteng</a>, <a href="#">Randburg</a></p></span>
									<p class="catpath">Visit Profile</p>
									</section>
									<section class="list-right">
									</section>
									<div class="clearfix"></div>
									</li> 
								</a>
								<a href="WorkerProfile.aspx">
									<li>
									<img src="images/p1.png" title="" alt="" />
									<section class="list-left">
									<h5 class="title">Kitchen Specialist</h5>
									<span class="adprice"><p> <i class="glyphicon glyphicon-map-marker"></i><a href="#">Gauteng</a>, <a href="#">Dowerglen</a></p></span>
									<p class="catpath">Visit Profile</p>
									</section>
									<section class="list-right">
									</section>
									<div class="clearfix"></div>
									</li> 
								</a>--%>
							</div>
						</div>
							</div>
						</div>
						
						
						<ul class="pagination pagination-sm">
							<li><a href="#">Prev</a></li>
							<li><a href="#">1</a></li>
							<li><a href="#">2</a></li>
							<li><a href="#">Next</a></li>
						</ul>
					  </div>
					</div>
				</div>
				</div>
						
						
						
						
						
						
						
							
						
					</div>
					<div class="clearfix"></div>
				</div>
			</div>
		</div>
	</div>
	<!--Plug-in Initialisation-->
	<script type="text/javascript">
	    $(document).ready(function () {

	        //Vertical Tab
	        $('#parentVerticalTab').easyResponsiveTabs({
	            type: 'vertical', //Types: default, vertical, accordion
	            width: 'auto', //auto or any width like 600px
	            fit: true, // 100% fit in a container
	            closed: 'accordion', // Start closed if in accordion view
	            tabidentify: 'hor_1', // The tab groups identifier
	            activate: function (event) { // Callback function if tab is switched
	                var $tab = $(this);
	                var $info = $('#nested-tabInfo2');
	                var $name = $('span', $info);
	                $name.text($tab.text());
	                $info.show();
	            }
	        });
	    });
</script>
	<!-- //Categories -->

    </div>
    </div>
</asp:Content>
