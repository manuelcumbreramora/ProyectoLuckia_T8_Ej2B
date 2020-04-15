<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PresentacionAdmin.aspx.cs" Inherits="Ejercicio_T8_2B.PresentacionAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 349px">
    <form id="form1" runat="server">
        <div style="height: 112px">
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 20px; top: 34px; position: absolute" Text="Lista de Juegos"></asp:Label>
            <asp:DropDownList ID="ListaJuegos" runat="server" AutoPostBack ="true" OnSelectedIndexChanged="ListaJuegos_SelectedIndexChanged" style="z-index: 1; left: 21px; top: 64px; position: absolute; bottom: 472px; width: 110px; right: 762px;" Height="35px" Width="300px">
            </asp:DropDownList>
            <asp:CheckBox ID="CheckBoxActivo" runat="server" AutoPostBack ="true" style="z-index: 1; left: 158px; top: 64px; position: absolute" Text="Activo" OnCheckedChanged="CheckBoxActivo_CheckedChanged" />
        </div>
    </form>
</body>
</html>
