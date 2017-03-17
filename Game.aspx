<%@ Page Language="C#" Inherits="Krypton.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Krypton</title>
	<style>
			body{
				background-color: #DD0000;
				height: 100%;
				width: 100%;
				padding: 0px;
				margin: 0px;
			}
			div.content{
				position: absolute;
				background-color:#FFFF88;
				left: 5%;
				top:5%;
				width: 90%;
				height: 90%;
				text-align: center;
				border-radius: 50px;
			}
			p.header{
				color: #0000AF;
				font-size: 72px;
			}
			div.problemCards{
				font-weight: bold;
				position: absolute;
				background-color: #8989FF;
				font-size: 18px;
				width: 40%;
				height: 35%;
				left: 8%;
			}
			div.finalCard{
				font-weight: bold;
				position: absolute;
				background-color: #8989FF;
				font-size: 18px;
				width: 40%;
				height: 35%;
				right: 8%;
			}
			div.card{
				color: lavender;
				background-color:#000033;
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
			div.Clock{
				position: absolute;
				bottom: 8%;
				left: 6%;
				width: 10%;
			}
			div.Points{
				position: absolute;
				bottom: 8%;
				left: 45%;
				width: 10%;
			}
			div.Rounds{
				position: absolute;
				bottom: 8%;
				left: 85.7%;
				width:10%
			}
	</style>
</head>
<body>
	<form id="form1" runat="server">
		<div class = "content">
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
			<div class="Clock">
				<p>Elapsed Time</p>
			</div>
			<div class="Points">
				<p>Score</p>
			</div>
			<div class="Rounds">
				<p>10/15</p>
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
