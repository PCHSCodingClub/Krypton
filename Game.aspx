<%@ Page Language="C#" Inherits="Krypton.Game" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Krypton</title>
	<style>
			body{
				background-color: #CC0000;
				height: 100%;
				width: 100%;
				padding: 0px;
				margin: 0px;
			}
			div.content{
				position: absolute;
				background-color:#FFFFDD;
				left: 5%;
				top:5%;
				width: 90%;
				height: 90%;
				text-align: center;
				border-radius: 50px;
			}
			p.header{
				color: #000099;
				font-size: 72px;
			}
			div.problemCards{
				position: absolute;
				background-color: #BBBBFF;
				width: 40%;
				height: 35%;
				left: 8%;
			}
			div.finalCard{
				position: absolute;
				background-color: #BBBBFF;
				width: 40%;
				height: 35%;
				right: 8%;
			}
			div.card{
				color: #FFFFFF;
				background-color:#000044;
				margin-bottom: 5px;
				width: 60px;
				margin-left: auto;
				margin-right: auto;
			}
			.newCardsButton{
				position: absolute;
				bottom: 1%;
				left: 30%;
				width: 10%;
			}
			.answerBox{
				position: absolute;
				bottom: 1%;
				margin: auto;
				left: 45%;
				width: 10%;
			}
			.label{
				position: absolute;
				bottom: 15%;
				margin: auto;
				left: 45%;
				width: 10%;
			}
			.checkCardsButton{
				position: absolute;
				bottom: 1%;
				margin: auto;
				left: 60%;
				width: 10%;
			}
			div.RoundDiv{
				position: absolute;
				bottom: 90%;
				left: 90%;
				width: 10%;
				height: 10%;
				background-color: blue;
			}
			.Time{
			
			}
			.Score{

			}
			.RoundCurrent{

			}
			./{

			}
			.RoundMax{

			}
	</style>
</head>
<body>
	<form id="form1" runat="server">
		<div class = "content">
			<asp:Label id="Time" class="Time" cssClass="Time" runat="server" Text="Tick Tock"></asp:Label>
			<asp:Label id="Score" class="Score" cssClass="Score" runat="server" Text="SCOOOOORE!!!!"></asp:Label>
			<div class="RoundDiv">
				<asp:Label id="RoundCurrent" class="RoundCurrent" cssClass="RoundCurrent" runat="server" Text="Hi"></asp:Label>
				<asp:Label class="/" Text="/"></asp:Label>
				<asp:Label id="RoundMax" class="RoundMax" cssClass="Roundmax" runat="server" Text="hI"></asp:Label>
			</div>
			<p class = "header"><strong>Welcome to Krypton</strong></p>
			<div class = "problemCards">
				<p>Arrange these numbers</p>
				<div class = "card">
					<asp:Label id = "card1" runat="server" CssClass = "card"/>
				</div>
				<div class = "card">
					<asp:Label id = "card2" runat="server" CssClass = "card"/>
				</div>
				<div class = "card">
					<asp:Label id = "card3" runat="server" CssClass = "card"/>
				</div>
				<div class = "card">
					<asp:Label id = "card4" runat="server" CssClass = "card"/>
				</div>
				<div class = "card">
					<asp:Label id = "card5" runat="server" CssClass = "card"/>
				</div>
			</div>
			<div class = "finalCard">
				<p>To equal this number</p>
				<div class = "card">
					<asp:Label id = "card6" runat="server" CssClass = "card"/>
				</div>
			</div>
			<asp:Label id = "label" runat="server"  CssClass="label" Text=""/>
			<asp:Button id="newCardsButton" CssClass="newCardsButton" runat="server" Text="New Cards!" OnClick="generateCards" />
			<asp:TextBox id="answerBox" CssClass="answerBox" runat="server"/>
			<asp:Button id="checkCardsButton" CssClass="checkCardsButton" runat="server" Text = "Check Cards!" OnClick="checkCards"/>
		</div>
	</form>
</body>
</html>
