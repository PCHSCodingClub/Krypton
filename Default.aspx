<%@ Page Language="C#" Inherits="Krypton.Default" %>
<!DOCTYPE html>
<html>
	<head runat="server">
		<p>Welcome To Krypton!</p>
		<Style>
			body{
				background-color: midnightblue;
				color: skyblue;
				font-size: 75px;
				text-align: center;
			}
			a.createbutton{
				position: relative;
				padding: 100px 180px;
				border: 3px solid darkgreen;
				border-style: outset;
				border-radius: 2px;
				background-color: forestgreen;
				color: lavender;
				font-size: 40px;
				text-decoration: none;
			}
			a.createbutton:Hover{
				background-color: green;
				color: white;
			}
			a.joinbutton{
				position: relative;
				padding: 100px 200px;
				border: 3px solid teal;
				border-style: outset;
				background-color: lightseagreen;
				border-radius: 2px;
				color: lavender;
				font-size: 40px;
				text-decoration: none;
			}
			a.joinbutton:Hover{
				background-color: #009b9b;
				color: white;
			}
			.colorchangebutton{
				position: absolute;
				left: 5px;
				top: 5px;
				horizontal-align: left;
				border: 2px solid steelblue;
				border-radius: 4px;
				background-color: black;
				color: white;
			}
		</Style>

		<title>Krypton</title>
	</head>
	<body id="mainpagebody">
		<form runat="server">
			<a href="CreateGame.aspx" class="createbutton">Create Game</a>
			<a href="null" class="joinbutton">Join Game</a>
			<asp:Button id="colorchangebutton" runat="server" Text="Change Theme?" CssClass="colorchangebutton"/>
		</form>
	</body>
</html>
