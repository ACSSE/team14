<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="PostAdClient.aspx.vb" Inherits="Project1.PostAdClient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyBody" runat="server">


    <div class="submit-ad main-grid-border">
		<div class="container">
            <form runat="server">
			<h2 class="head">Post an Ad</h2>
			<div class="post-ad-form">
				<table style="margin:initial">
                <tr>
                    <td>
                
                        <asp:Label ID="lblCategory" runat="server" Text="Select Category"></asp:Label></td>
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
                        <asp:Label ID="lblTitle" runat="server" Text="Ad Title"></asp:Label></td>
                    <td style="height: 50px">
                        <asp:TextBox ID="txtTitle" runat="server" Height="25px" Width="180px"></asp:TextBox>

                    </td>
                </tr>
                    <tr>
                    <td style="width: 300px; margin:initial;">
                        <asp:Label ID="lblDescription" runat="server" Text="Add Description"  ></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtDescription" TextMode="MultiLine"  runat="server" Height="52px" Width="180px"></asp:TextBox></td>
                </tr>

                     <tr>
                    <td style="width: 300px; margin:initial;">
                        <asp:Label ID="lblLogo" runat="server" Text="Photo for your ad"></asp:Label></td>
                    <td>
                        <div class="photos-upload-view">

						<input type="hidden" id="MAX_FILE_SIZE" name="MAX_FILE_SIZE" value="300000" />

						<div>
							<input type="file" runat="server" id="fileSelect" name="fileselect[]" multiple="multiple" /><br/>
							<div id="filedrag">or drop file here</div>
						</div>

						<div id="submitbutton">
							<button type="submit" id="btnUpload" runat="server">Upload Files</button>
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