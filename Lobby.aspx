<%@ Page Language="C#" Inherits="Krypton.Lobby" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Lobby</title>
	<p>Once Everyone is Here, Start the Game!</p>
	<style>
		body{
			background-color: yellow;
			text-align: center;
			color: black;
			font-size: 40px;
		}
		div.StartButton{
			position: absolute;
			margin: auto;
			height: 10%;
			width: 60%;
			left: 20%;
			top: 80%;
			background-color: gold;
			border: 3px solid olive;
			text-align: center;
			font-size: 20px;
			text-decoration: none;
		}
		div.Queue{
			position: absolute;
			margin: auto;
			height: 60%;
			width: 80%;
			left: 10%;
			top: 15%;
			background-color: gold;
			border: 3px solid olive;
			text-align: left;
			font-size: 20px;
		}
	</style>
</head>
<body>
	<form id="form1" runat="server">
		<div class="StartButton">
			<a href="Game.aspx">Start The Game Already!</a>
		</div>
		<div class="Queue">
			<p>Smitty Werbenjagermanjensen</p>
			<p></p>
		</div>
	</form>
</body>
</html>
