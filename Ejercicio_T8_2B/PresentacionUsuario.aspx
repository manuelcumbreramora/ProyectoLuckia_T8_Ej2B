<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PresentacionUsuario.aspx.cs" Inherits="Ejercicio_T8_2B.PresentacionUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 510px;
        }
    </style>
</head>
<body style="height: 291px; width: 869px">
    <form id="form1" runat="server">
        <div style="height: 185px">
            <asp:Label ID="LabelSeleccion" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; width: 233px" Text="Seleccionar Juego:"></asp:Label>
            <asp:ListBox ID="ListBoxJuegos" runat="server" OnSelectedIndexChanged="ListBoxJuegos_SelectedIndexChanged" style="z-index: 1; left: 13px; top: 43px; position: absolute; width: 192px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
