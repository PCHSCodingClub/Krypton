<%@ Page Language="C#" Inherits="Krypton.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Krypton</title>
	<style>
			body{
				background-color:#CC0000;
			}
			
			div.content{
				background-color:#EEEEDD;
				margin: auto;
				width: 1200px;
				hiegt: auto;
				text-align: center;
			}
			p.header{
				color: #000099;
				font-size: 72px;
			}
			div.problemCards{
				background-color: #DDDDEE;
				width: 520px;
				height: 170px;
				margin-left: 75px;
			}
			div.finalCard{
				background-color: #DDDDEE;
				width: 520px;
				height: 170px;
				margin-left: 605px;
				margin-top: -186px;
				margin-bottom: 86px;
			}
			div.card{
				color: #FFFFFF;
				background-color:#000044;
				margin-bottom: 5px;
				width: 60px;
				margin-left: auto;
				margin-right: auto;
			}
	</style>
</head>
<body>
	<div class = "content">
		<form id="form1" runat="server">
			<br/>
			<p class = "header"><strong>Welcome to Krypton</strong></p>
			<br/>
			<br/>
			<br/>
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
			<asp:Button id="newCardsButton" runat="server" Text="New Cards!" OnClick="generateCards" />
			<asp:TextBox id = "answerBox" runat="server"/>
			<asp:Button id="checkCardsButton" runat="server" Text = "Check Cards!" OnClick="checkCards"/>
		</form>
	</div>
</body>
</html>
