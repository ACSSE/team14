<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="RegisterClient.aspx.vb" Inherits="Project1.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyBody" runat="server">
    
    <div class="submit-ad main-grid-border">
		<div class="container">
        <form  runat="server">
			<h2 class="head">Register With Us</h2>

            <div class="personal-details">

                <h3>Personal Details</h3><br/>

                <table style="margin:initial">
                <tr>
                    <th style="width: 300px; height: 30px;">
                        <asp:Label ID="lblName" runat="server" Text="Your Name"></asp:Label></th>
                    <th style="height: 30px">
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox></th>
                </tr>
                    <br/>
                <tr>
                    <th style="width: 300px; height: 30px;">
                        <asp:Label ID="lblSurname" runat="server" Text="Your Surname"></asp:Label></th>
                    <th style="height: 30px">
                        <asp:TextBox ID="txtSurname"  runat="server"></asp:TextBox></th>
                </tr>
                <tr>
                    <th style="width: 300px; height: 30px;">
                        <asp:Label ID="lblUserName" runat="server" Text="Your Username"></asp:Label></th>
                    <th style="height: 30px">
                        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox></th>
                </tr>
                <tr>
                    <th style="width: 300px; height: 30px;">
                        <asp:Label ID="lblPassword" runat="server" Text="Your Password"></asp:Label></th>
                    <th style="height: 30px">
                        <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox></th>
                </tr>
               
            
            </table>
                <label id="lblCheck" runat="server"  style="margin-left:0px;"></label>

                <%--<h3>Personal Details</h3><br/>
					<form runat="server">
						<label>
                        <div class="text-left">
                           <asp:Label ID="lblName" runat="server" Text="Your Name"></asp:Label></div>
                        </label>
                        
						&nbsp;<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
						<div class="clearfix"></div>
                        
                        <label>
                        <div class="text-left">
                            <asp:Label ID="lblSurname" runat="server" Text="Your Surname"></asp:Label>

                        </div>
                        </label>
						&nbsp;<asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
						<div class="clearfix"></div>
                        <label>
                        <div class="text-left">
                            <asp:Label ID="lblUserName" runat="server" Text="Your Username"></asp:Label></div>
                        </label>
						&nbsp;<asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
						<div class="clearfix"></div>
                        <label>
                        <div class="text-left">
                            <asp:Label ID="lblPassword" runat="server" Text="Your Password"></asp:Label></div>
                        </label>
						&nbsp;<asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
						<div class="clearfix"></div>
						
								
					<div class="clearfix"></div>--%>
					
					</div><br/><br/>


			<div class="post-ad-form">

                 <h3>Confidential & Address Related details</h3><br/>

                <table style="margin:initial">
                <tr>
                    <th>
                        <asp:Label ID="lblRegion" runat="server" Text="Select Town"></asp:Label></th>

                    <th>
                        <asp:DropDownList ID="regionList" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Town" DataValueField="Town" >
                            <asp:ListItem>Select</asp:ListItem>
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT DISTINCT [Town] FROM [Location]"></asp:SqlDataSource>
                    </th>
                </tr>

                <tr>
                    <th>
                        <asp:Label ID="lblSuburb" runat="server" Text="Select Surburb"></asp:Label></th>

                    <th>
                        <asp:DropDownList ID="suburbList" runat="server" DataSourceID="SqlDataSource2" Width="150px" AutoPostBack="True" DataTextField="Surburb" DataValueField="Surburb">
                            <asp:ListItem>Select</asp:ListItem>
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT Surburb FROM Location WHERE (Town = @Town)">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="regionList" Name="Town" PropertyName="SelectedValue" Type="String" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                    </th>
                </tr>
                <tr>
                    <td></td>
                    <td>If your town isn't listed above,<br/> click <a href="findme.aspx">here</a> to help us find you </td>
                    
                </tr>
                <tr>
                    <th style="width: 300px; height: 13px;">
     <asp:Label ID="lblMobile" runat="server" Text="Your Mobile Number"></asp:Label></th>
                    <th style="height: 13px">
                        <asp:TextBox ID="txtMobile" TextMode="Phone" runat="server" Height="25px" Width="130px"></asp:TextBox></th>
                </tr>
                <tr>
                    <th style="width: 300px; height: 50px;">
                        <asp:Label ID="lblEmail" runat="server" Text="Your Email"></asp:Label></th>
                    <th style="height: 50px">
                        <asp:TextBox ID="txtEmail" runat="server" Height="25px" Width="130px"></asp:TextBox>

                    </th>
                </tr>
                    <tr>
                    <th style="width: 300px; margin:initial;">
                        <asp:Label ID="lblAddress" runat="server" Text="Your Address"  ></asp:Label></th>
                    <th>
                        <asp:TextBox ID="txtAddress" TextMode="MultiLine"  runat="server" Height="52px" Width="130px"></asp:TextBox></th>
                </tr>
               

            </table>

 


                 <input type="submit" runat="server" id="btnReg" value="Register"/>
                 

                

				 <%--<form id="form1" runat="server">

                    <label>
                    <div class="text-left">
                    Select Region <span>*</span></div>
                    </label>&nbsp;<select class="">
                        <option>Select Region</option>
					    <option>Edenvale</option>
					    <option>Dunvegan </option>
					    <option>Dowerglen</option>
					    <option>Marais Steyn Park</option>
					    <option>Croydon</option>
					    <option>Isando</option>
					</select>

					<div class="clearfix"></div>


                     <label>
                    <div class="text-left">
                    <asp:Label ID="lblRegion" runat="server" Text="Select Region"></asp:Label></div>
                    </label>
                     &nbsp;<asp:DropDownList ID="regionList" runat="server">

                        <asp:ListItem Text="Select Region" Value="0"></asp:ListItem>
                        <asp:ListItem Text="Edenvale" ></asp:ListItem>
                        <asp:ListItem Text="Dunvegan" ></asp:ListItem>
                        <asp:ListItem Text="Dowerglen" ></asp:ListItem>
                        <asp:ListItem Text="Marais Steyn Park" ></asp:ListItem>
                        <asp:ListItem Text="Croydon" ></asp:ListItem>
                        <asp:ListItem Text="Isando" ></asp:ListItem>

                           </asp:DropDownList>
                        
					

					<div class="clearfix"></div>



                    <label>
                        <div class="text-left">
                            Your Address <span>*</span></div>
                        </label>
						&nbsp;<input type="text" class="phone" placeholder="">
						<div class="clearfix"></div>

                    <label>
                        <div class="text-left">
                            Your Mobile No <span>*</span></div>
                        </label>
						&nbsp;<input type="text" class="phone" placeholder="">
						<div class="clearfix"></div>
						<div class="text-left">
						<label>
                        <div style="text-align: left">
                            Your Email Address<span>*</span></div>
                        </label>
						&nbsp;<input type="text" class="email" placeholder=""><div class="text-left">
                            </div>
                            

                            <a href="WorkerProfile.aspx"><input type="button" value="Register"/></a>	
					

						&nbsp;</div>
						<div class="clearfix"></div>
					

						</form>--%>
</div></form>
						
				</div>
					
			</div>
			
	


</asp:Content>