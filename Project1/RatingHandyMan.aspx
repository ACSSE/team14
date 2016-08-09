<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="RatingHandyMan.aspx.vb" Inherits="Project1.RatingHandyMan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyBody" runat="server">

<div id="page-wrapper" class="sign-in-wrapper">
         <form id="form1" runat="server">
         <h1>Rating Your Handyman</h1>
         <h4>Please help the Handyman by gving him/her feedback on his serviceas and how he can improve himself</h4>
             <p>&nbsp;</p>
            <div>
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
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                     <table>
    
                    <tr><td class="auto-style2" style="width: 367px">How would you rate the HandyMan on other stuff</td></tr>
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

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <input id="btnRatingSubmit" runat="server" type="submit" value="Submit"/>
            </div>
                <p>


                     </p>
            </form>
    </div>
</asp:Content>
