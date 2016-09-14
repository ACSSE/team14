
﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="RatingHandyMan.aspx.vb" Inherits="Project1.RatingHandyMan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyBody" runat="server">

<div class="feedback text-center"  >
         <form id="form1" runat="server">
          <p>&nbsp;</p>
            <div id="handymanRating" runat="server">
            <h1>Rating Your Handyman</h1>
         <h4>Please help the Handyman by gving him/her feedback on his serviceas and how he can improve himself</h4>
            
            <table>
    
                    <tr><td class="auto-style4" title="Submit" style="width: 362px">How would you rate the Handyman on time managenment?</td></tr>
                <tr>
        
                <td class="auto-style4" title="Submit" style="width: 362px">poor
                    <asp:RadioButtonList ID="lstTimeMan" RepeatLayout="Flow" 
                        RepeatDirection="Horizontal" runat="server">
                        <asp:ListItem Value="1">1</asp:ListItem>
                        <asp:ListItem Value="2">2</asp:ListItem>
                        <asp:ListItem Value="3">3</asp:ListItem>
                        <asp:ListItem Value="4">4</asp:ListItem>
                        <asp:ListItem Value="5">5</asp:ListItem>
                    </asp:RadioButtonList>
                &nbsp;
                great
                </td>
        
                </tr>
            </table>

                <br />

            <table>
    
                    <tr><td class="auto-style4" style="width: 358px">How would you rate the Handyman on proffesionalism?</td></tr>
                <tr>
        
                <td class="auto-style4" style="width: 358px">poor
                    <asp:RadioButtonList ID="lstProffesion" RepeatLayout="Flow" 
                        RepeatDirection="Horizontal" runat="server">
                        <asp:ListItem Value="1">1</asp:ListItem>
                        <asp:ListItem Value="2">2</asp:ListItem>
                        <asp:ListItem Value="3">3</asp:ListItem>
                        <asp:ListItem Value="4">4</asp:ListItem>
                        <asp:ListItem Value="5">5</asp:ListItem>
                    </asp:RadioButtonList>
                &nbsp;
                great
                </td>
        
                </tr>
            </table>

                <br />

                <table>
    
                    <tr><td class="auto-style3" style="width: 364px">How would you rate the Handyman on the quality of work done?</td></tr>
                <tr>
        
                <td class="auto-style3" style="width: 364px">poor
                    <asp:RadioButtonList ID="lstQuality" RepeatLayout="Flow" 
                        RepeatDirection="Horizontal" runat="server">
                        <asp:ListItem Value="1">1</asp:ListItem>
                        <asp:ListItem Value="2">2</asp:ListItem>
                        <asp:ListItem Value="3">3</asp:ListItem>
                        <asp:ListItem Value="4">4</asp:ListItem>
                        <asp:ListItem Value="5">5</asp:ListItem>
                    </asp:RadioButtonList>
                &nbsp;
                great
                </td>
        
                </tr>
            </table>

                <br />

                <table>
    
                    <tr><td class="auto-style2">How would you rate the Handyman on interpersonal skills?</td></tr>
                <tr>
        
                <td class="auto-style2">poor
                    <asp:RadioButtonList ID="lstInterpersonal" RepeatLayout="Flow" 
                        RepeatDirection="Horizontal" runat="server">
                        <asp:ListItem Value="1">1</asp:ListItem>
                        <asp:ListItem Value="2">2</asp:ListItem>
                        <asp:ListItem Value="3">3</asp:ListItem>
                        <asp:ListItem Value="4">4</asp:ListItem>
                        <asp:ListItem Value="5">5</asp:ListItem>
                    </asp:RadioButtonList>
                &nbsp;
                great
                </td>
        
                </tr>
            </table>
                <br />

                     <table>
    
                    <tr><td class="auto-style2" style="width: 367px">How would you rate the HandyMan on Consistency</td></tr>
                <tr>
        
                <td class="auto-style2" style="width: 367px">poor
                    <asp:RadioButtonList ID="lstAn" RepeatLayout="Flow" 
                        RepeatDirection="Horizontal" runat="server">
                        <asp:ListItem Value="1">1</asp:ListItem>
                        <asp:ListItem Value="2">2</asp:ListItem>
                        <asp:ListItem Value="3">3</asp:ListItem>
                        <asp:ListItem Value="4">4</asp:ListItem>
                        <asp:ListItem Value="5">5</asp:ListItem>
                    </asp:RadioButtonList>
                &nbsp;
                great
                </td>
        
                </tr>
            </table>

            
            </div>

            <div id="clientRating" class="container text-center" runat="server">
            <h1>Rating Your Client</h1>
         <h4>Please rate the client on how </h4>
            
            <table>
                                    <tr><td class="auto-style2" style="width: 367px">How would you rate the Client?</td></tr>
                <tr>
        
                <td class="auto-style2" style="width: 367px">poor
                    <asp:RadioButtonList ID="clientRate" RepeatLayout="Flow" 
                        RepeatDirection="Horizontal" runat="server">
                        <asp:ListItem Value="1">1</asp:ListItem>
                        <asp:ListItem Value="2">2</asp:ListItem>
                        <asp:ListItem Value="3">3</asp:ListItem>
                        <asp:ListItem Value="4">4</asp:ListItem>
                        <asp:ListItem Value="5">5</asp:ListItem>
                    </asp:RadioButtonList>
                &nbsp;
                great
                </td>
        
                </tr>
            </table>
            </div>
                <p>


                     </p>
                    <!--  <div class="post-ad-form">--->
                     <textarea id="txtComments" runat="server"></textarea>
                     <br />
                <input id="btnRatingSubmit" runat="server" type="submit" value="Submit"/>
               <!-- </div>-->
            </form>
    </div>
</asp:Content>
