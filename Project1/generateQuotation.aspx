c<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site3.Master" CodeBehind="generateQuotation.aspx.vb" Inherits="Project1.generateQuotation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="submit-ad main-grid-border">
		<div class="container">
            <form runat="server">
			<h2 class="head">Generate Quotation</h2>
			<div class="post-ad-form">
				<table class="table" style="margin:initial; color:black;">
                <tr>
                    <td>
                        <asp:Label ID="lblQuoteDescription" ForeColor="Black"  runat="server" Text="Enter Your Description:"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtQuoteDescription" runat="server" MaxLengtd="200" Rows="3" TextMode="MultiLine"></asp:TextBox></td>
                </tr>

                <tr>
                   <td>
                        <asp:Label ID="lblQuoteHours" ForeColor="Black" runat="server" Text="Enter Estimated Amount of Hours:"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtQuoteHours" runat="server" TextMode="Number"></asp:TextBox></td>
                </tr>
                <tr>
                     <td>
                        <asp:Label ID="lblQuoteAmount" ForeColor="Black"     runat="server" Text="Enter Estimated Amount R:"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtQuoteAmount" runat="server" TextMode="Number"></asp:TextBox></td>
                </tr>

                     
               

            </table>
                <input type="submit" runat="server" id="btnSubQuote" value="Submit"/>
						</div>
                </form>
				</div>
					
		</div>	

    

</asp:Content>
