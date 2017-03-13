<%@ Page Language="C#" Inherits="Krypton.CreateGame" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<style>
		body{
			background-color: darkgreen;
			color: lavender;
		}
		div.ID{
			position: absolute;
			border: 3px solid teal;
			height: 97%;
			width: 30%;
			color: lavender;
			left: 5%;
			font-size: 20px;
			text-decoration: none;
			background-color: forestgreen;
		}
		div.Options{
			position: absolute;
			border: 3px solid teal;
			height: 97%;
			width: 30%;
			left: 35%;
			font-size: 20px;
			text-decoration: none;
			background-color: seagreen;
		}
		div.Start{
			position: absolute;
			border: 3px solid teal;
			height: 97%;
			width: 30%;
			left: 65%;
			font-size: 20px;
			text-decoration: none;
			background-color: springgreen;
		}
		a.StartButton{
			position: absolute;
			margin: auto;
			padding: 60px 100px;
			border 3px solid yellow;
			font-size 30px;
			background-color: #FFFF30;
			text-decoration: none;
			color: black;
		}
	</style>
	<title>Krypton</title>
</head>
<body>
	<form id="form1" runat="server">
		<div class="ID">
			<asp:Label runat="server" id="IDLabel" CssClass="IDLabel" Text="Identification"></asp:Label>
		</div>
		<div class="Options">
			<p>Set Game Options</p>
			<asp:Label id = "MaxLabel" CssClass="MaxLabel" Text="Max card size:" runat="server"/>
			<asp:TextBox id="MaxBox" CssClass="MaxBox" runat="server" OnInit="InitSetMax" OnTextChanged="SetMax"/>
		</div>
		<div class="Start">
			<a href="Lobby.aspx" class="StartButton">Start Lobby</a>
		</div>
	</form>
</body>
</html>
