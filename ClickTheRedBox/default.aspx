<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ClickTheRedBox._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Click the Red Box</title>
    <link href="css/style.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div id="main-wrapper">
            <div class="header">
                <div class="logo">Click the Red Box</div>
            </div>
            <div class="clear"></div>
            <div id="content-wrapper">
                <div class="col_100">
                    <asp:ScriptManager ID="scriptManager1" runat="server"></asp:ScriptManager>
                    <asp:UpdatePanel is="up1" runat="server" UpdateMode="Always">
                        <ContentTemplate>
                            <p class="right">
                                Score:
                                <asp:Label ID="lblScore" runat="server"></asp:Label>
                            </p>
                            
                            <div id="level0" runat="server" visible="false">
                                <h2>High Scores</h2>

                                <p>
                                    <asp:Label ID="lblHighScores" runat="server"></asp:Label>
                                </p>


                                <asp:Button ID="button0" runat="server" CssClass="button" Text="Start" OnClick="button_Click" CommandArgument="0" />
                            </div>
                            <div id="level1" runat="server" visible="false">
                                <div class="box">
                                    <asp:Button ID="button101" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="1" Width="600px" Height="600px" />
                                </div>
                            </div>
                            <div id="level2" runat="server" visible="false">
                                <div class="box">
                                    <asp:Button ID="button201" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="2" Width="300px" Height="600px" />
                                    <asp:Button ID="button202" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="2" Width="300px" Height="600px" />
                                </div>
                            </div>
                            <div id="level3" runat="server" visible="false">
                                <div class="box">
                                    <asp:Button ID="button301" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="3" Width="300px" Height="300px" />
                                    <asp:Button ID="button302" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="3" Width="300px" Height="300px" />
                                    <asp:Button ID="button303" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="3" Width="300px" Height="300px" />
                                    <asp:Button ID="button304" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="3" Width="300px" Height="300px" />
                                </div>
                            </div>
                            <div id="level4" runat="server" visible="false">
                                <div class="box">
                                    <asp:Button ID="button401" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="4" Width="300px" Height="200px" />
                                    <asp:Button ID="button402" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="4" Width="300px" Height="200px" />
                                    <asp:Button ID="button403" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="4" Width="300px" Height="200px" />
                                    <asp:Button ID="button404" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="4" Width="300px" Height="200px" />
                                    <asp:Button ID="button405" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="4" Width="300px" Height="200px" />
                                    <asp:Button ID="button406" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="4" Width="300px" Height="200px" />
                                </div>
                            </div>
                            <div id="level5" runat="server" visible="false">
                                <div class="box">
                                    <asp:Button ID="button501" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="5" Width="200px" Height="200px" />
                                    <asp:Button ID="button502" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="5" Width="200px" Height="200px" />
                                    <asp:Button ID="button503" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="5" Width="200px" Height="200px" />
                                    <asp:Button ID="button504" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="5" Width="200px" Height="200px" />
                                    <asp:Button ID="button505" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="5" Width="200px" Height="200px" />
                                    <asp:Button ID="button506" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="5" Width="200px" Height="200px" />
                                    <asp:Button ID="button507" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="5" Width="200px" Height="200px" />
                                    <asp:Button ID="button508" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="5" Width="200px" Height="200px" />
                                    <asp:Button ID="button509" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="5" Width="200px" Height="200px" />
                                </div>
                            </div>
                            <div id="level6" runat="server" visible="false">
                                <div class="box">
                                    <asp:Button ID="button601" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="6" Width="200px" Height="100px" />
                                    <asp:Button ID="button602" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="6" Width="200px" Height="100px" />
                                    <asp:Button ID="button603" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="6" Width="200px" Height="100px" />
                                    <asp:Button ID="button604" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="6" Width="200px" Height="100px" />
                                    <asp:Button ID="button605" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="6" Width="200px" Height="100px" />
                                    <asp:Button ID="button606" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="6" Width="200px" Height="100px" />
                                    <asp:Button ID="button607" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="6" Width="200px" Height="100px" />
                                    <asp:Button ID="button608" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="6" Width="200px" Height="100px" />
                                    <asp:Button ID="button609" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="6" Width="200px" Height="100px" />
                                    <asp:Button ID="button610" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="6" Width="200px" Height="100px" />
                                    <asp:Button ID="button611" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="6" Width="200px" Height="100px" />
                                    <asp:Button ID="button612" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="6" Width="200px" Height="100px" />
                                    <asp:Button ID="button613" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="6" Width="200px" Height="100px" />
                                    <asp:Button ID="button614" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="6" Width="200px" Height="100px" />
                                    <asp:Button ID="button615" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="6" Width="200px" Height="100px" />
                                    <asp:Button ID="button616" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="6" Width="200px" Height="100px" />
                                    <asp:Button ID="button617" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="6" Width="200px" Height="100px" />
                                    <asp:Button ID="button618" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="6" Width="200px" Height="100px" />
                                </div>
                            </div>
                            <div id="level7" runat="server" visible="false">
                                <div class="box">
                                    <asp:Button ID="button701" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button702" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button703" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button704" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button705" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button706" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button707" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button708" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button709" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button710" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button711" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button712" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button713" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button714" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button715" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button716" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button717" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button718" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button719" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button720" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button721" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button722" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button723" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button724" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button725" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button726" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button727" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button728" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button729" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button730" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button731" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button732" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button733" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button734" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button735" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />
                                    <asp:Button ID="button736" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="7" Width="100px" Height="100px" />

                                </div>
                            </div>

                            <div id="level8" runat="server" visible="false">
                                <div class="box">
                                    <asp:Button ID="button801" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button802" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button803" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button804" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button805" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button806" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button807" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button808" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button809" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button810" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button811" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button812" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button813" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button814" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button815" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button816" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button817" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button818" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button819" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button820" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button821" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button822" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button823" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button824" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button825" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button826" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button827" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button828" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button829" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button830" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button831" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button832" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button833" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button834" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button835" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button836" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button837" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button838" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button839" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button840" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button841" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button842" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button843" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button844" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button845" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button846" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button847" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button848" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button849" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button850" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button851" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button852" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button853" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button854" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button855" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button856" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button857" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button858" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button859" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button860" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button861" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button862" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button863" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button864" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button865" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button866" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button867" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button868" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button869" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button870" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button871" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />
                                    <asp:Button ID="button872" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="8" Width="50px" Height="100px" />

                                </div>
                            </div>

                            <div id="level9" runat="server" visible="false">
                                <div class="box">
                                    <asp:Button ID="button901" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button902" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button903" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button904" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button905" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button906" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button907" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button908" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button909" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button910" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button911" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button912" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button913" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button914" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button915" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button916" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button917" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button918" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button919" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button920" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button921" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button922" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button923" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button924" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button925" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button926" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button927" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button928" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button929" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button930" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button931" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button932" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button933" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button934" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button935" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button936" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button937" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button938" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button939" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button940" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button941" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button942" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button943" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button944" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button945" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button946" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button947" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button948" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button949" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button950" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button951" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button952" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button953" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button954" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button955" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button956" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button957" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button958" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button959" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button960" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button961" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button962" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button963" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button964" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button965" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button966" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button967" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button968" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button969" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button970" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button971" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button972" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button973" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button974" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button975" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button976" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button977" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button978" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button979" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button980" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button981" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button982" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button983" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button984" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button985" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button986" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button987" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button988" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button989" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button990" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button991" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button992" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button993" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button994" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button995" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button996" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button997" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button998" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button999" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9100" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9101" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9102" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9103" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9104" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9105" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9106" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9107" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9108" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9109" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9110" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9111" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9112" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9113" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9114" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9115" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9116" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9117" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9118" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9119" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9120" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9121" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9122" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9123" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9124" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9125" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9126" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9127" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9128" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9129" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9130" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9131" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9132" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9133" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9134" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9135" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9136" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9137" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9138" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9139" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9140" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9141" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9142" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9143" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />
                                    <asp:Button ID="button9144" runat="server" CssClass="gameButton" Text="" OnClick="button_Click" CommandArgument="9" Width="50px" Height="50px" />

                                </div>
                            </div>

                            <div id="level99" runat="server" visible="false">
                                <h3>Your Score:
                                    <asp:Label ID="lblYourScore" runat="server"></asp:Label></h3>

                                <p>
                                    Initial:
                                    <asp:TextBox ID="tbInitial" runat="server" ValidationGroup="saveGame"></asp:TextBox>
                                    <asp:Button ID="btnSaveScore" runat="server" Text="Save Your Score" CssClass="button" OnClick="btnSaveScore_Click" ValidationGroup="saveGame" />
                                    
                                </p>

                                <asp:Button ID="button99" runat="server" CssClass="button" Text="Restart" OnClick="button_Click" CommandArgument="99" />
                            </div>
                        </ContentTemplate>

                    </asp:UpdatePanel>

                </div>
                <div class="clear"></div>
            </div>
        </div>
        <div id="footer-wrapper">
            <div class="footer center"></div>
        </div>
    </form>
</body>
</html>
