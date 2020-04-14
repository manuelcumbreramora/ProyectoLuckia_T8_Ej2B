<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CasinoUsuario.aspx.cs" Inherits="Ejercicio_T8_2B.CasinoUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Listado de juegos"></asp:Label>
        </div>
        <asp:ListBox ID="lstJuego" runat="server"></asp:ListBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Cantidad de la apuesta"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtApuesta" runat="server" CausesValidation="True" TextMode="Number"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnApostar" runat="server" Text="Apostar" />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Label ID="lblResultado" runat="server"></asp:Label>
    </form>
</body>
</html>
