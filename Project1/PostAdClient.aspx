<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site2.Master" CodeBehind="PostAdClient.aspx.vb" Inherits="Project1.PostAdClient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="submit-ad main-grid-border">
		<div class="container">
            <form runat="server">
			<h2 class="head">Post an Ad</h2>
			<div class="post-ad-form">
				<table class="table" style="margin:initial; color:black;">
                <tr>
                    <td>
                
                        <asp:Label ID="lblCategory" ForeColor="Black"   runat="server" Text="Select Category"></asp:Label></td>
                    <td>
                      <asp:DropDownList ID="categoriesList" runat="server" Width="180px">
         
                      <asp:ListItem Text ="Selected Category" Value="0"></asp:ListItem>
					  <asp:ListItem Text="Electrician"></asp:ListItem>
					  <asp:ListItem Text="Paint and Decoration"></asp:ListItem>
					  <asp:ListItem Text="Pool Specialist"></asp:ListItem>
					  <asp:ListItem Text="Garden and Landscaping"></asp:ListItem>
					  <asp:ListItem Text="Security, Fire and Safety"></asp:ListItem>
					  <asp:ListItem Text="Kitchen Specialist"></asp:ListItem>
					  <asp:ListItem Text="Geyser Specialist"></asp:ListItem>
					  <asp:ListItem Text="Pest Control"></asp:ListItem>
					  <asp:ListItem Text="Tilling Specialist"></asp:ListItem>
					  <asp:ListItem Text="Roof Specialist"></asp:ListItem>
                      </asp:DropDownList></td>
                </tr>

                <tr>
                    <td style="width: 300px; height: 50px;">
                        <asp:Label ID="lblTitle" ForeColor="Black"  runat="server" Text="Ad Title"></asp:Label></td>
                    <td style="height: 50px">
                        <asp:TextBox ID="txtTitle" ForeColor="Black" TextMode="MultiLine"  runat="server" Height="60px" Width="300px"></asp:TextBox>

                    </td>
                </tr>
                    <tr>
                    <td style="width: 300px; margin:initial;">
                        <asp:Label ID="lblDescription" ForeColor="Black"  runat="server" Text="Add Description"  ></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtDescription" ForeColor="Black"  TextMode="MultiLine" Rows="3"  runat="server" Height="60px" Width="300px"></asp:TextBox></td>
                </tr>

                     <tr>
                    <td style="width: 300px; margin:initial;">
                        <asp:Label ID="lblLogo" runat="server" ForeColor="Black" Text="Photo for your ad"></asp:Label></td>
                    <td>
                        <div class="photos-upload-view">

						<input type="hidden" id="MAX_FILE_SIZE" name="MAX_FILE_SIZE" value="300000" />

						<div>
							<input type="file" runat="server" id="fileSelect" name="fileselect[]" multiple="multiple" /><br/>
							
						</div>

						

						</div></td>
                </tr>
               

            </table>
                <input type="submit" runat="server" id="btnSubmit" value="Post"/>
						</div>
					<div class="clearfix"></div>
						<script src="js/filedrag.js"></script>
                </form>
				</div>
					
		</div>	

</asp:Content>