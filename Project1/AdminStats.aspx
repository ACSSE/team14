<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site3.Master" CodeBehind="AdminStats.aspx.vb" Inherits="Project1.AdminStats" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form1" runat="server">

    <h2>Website Statistics</h2>
    <br /><br /><br />
    <h3>New Users</h3>
    <div id="VisiterStats" runat="server">
       <%-- <div class="content">
        <div class="container">
            <div class="span_1_by_4">
        <div class="col-md-3 spansecound">
        <div class="span1">  
                        <h3 class="tlt">STATISTICS</h3>
                        <canvas id="bar" height="300" width="400" style="width: 400px; height: 300px;"></canvas>
                        <script>
                            var barChartData = {
                            labels : ["Jan","Feb","Mar","Apr","May","Jun","jul"],
                            datasets : [
                                {
                                    fillColor : "#cbb25c",
                                    data : [65,59,90,81,56,55,40]
                                },
                                {
                                    fillColor : "#5f8b9e",
                                    data : [28,48,40,19,96,27,100]
                                }
                            ]

                        };
                            new Chart(document.getElementById("bar").getContext("2d")).Bar(barChartData);

                        </script>
                    </div> </div> </div> </div>

</div>--%>
        <asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource1" Palette="Fire" Width="600px">
            <Series>
                <asp:Series Name="Series1" XValueMember="Category" YValueMembers="JoinDate">
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Category] FROM [AdminStats]"></asp:SqlDataSource>
    </div>
    <br /><br />
    <div id="TotalUsers" runat="server"></div>
    <br /><br />
    <div id="WeekStats" runat="server"></div>

    </form>

</asp:Content>
