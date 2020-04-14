<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CasinoAdmin.aspx.cs" Inherits="Ejercicio_T8_2B.CasinoAdmin" %>

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
        <asp:ListBox ID="lstJuegos" runat="server"></asp:ListBox>
        <p>
            <asp:Button ID="btnCambioEstado" runat="server" Text="Activar/Desactivar" />
        </p>
    </form>
</body>
</html>
