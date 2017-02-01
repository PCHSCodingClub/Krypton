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
				width: 1400px;
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
				margin-left: 175px;
			}
			div.finalCard{
				background-color: #DDDDEE;
				width: 520px;
				height: 170px;
				margin-left: 705px;
				margin-top: -186px;
				margin-bottom: 186px;
			}
			div.card{
				color: #FFFFFF;
				background-color:#000044
			}
	</style>
</head>
<body>
	<div class = "content">
		<br/>
		<p class = "header"><strong>Welcome to Krypton</strong></p>
		<br/>
		<br/>
		<br/>
		<div class = "problemCards">
			<p>Arrange these numbers</p>
			<div class = "card">
				<asp:Label id = "card1" runat="server"/>
			</div>
			<div class = "card">
				<asp:Label id = "card2" runat="server"/>
			</div>
			<div class = "card">
				<asp:Label id = "card3" runat="server"/>
			</div>
			<div class = "card">
				<asp:Label id = "card4" runat="server"/>
			</div>
			<div class = "card">
				<asp:Label id = "card5" runat="server"/>
			</div>
		</div>
		<div class = "finalCard">
			<p>To equal this number</p>
			<div class = "card">
				<asp:Label id = "card6" runat="server"/>
			</div>
		</div>
		<form id="form1" runat="server">
			<asp:Button id="button1" runat="server" Text="New Cards!" OnClick="generateCards" />
		</form>
	</div>
</body>
</html>
