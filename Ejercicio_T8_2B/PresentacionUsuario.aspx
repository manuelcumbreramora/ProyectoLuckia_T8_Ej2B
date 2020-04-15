<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PresentacionUsuario.aspx.cs" Inherits="Ejercicio_T8_2B.PresentacionUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 510px;
        }
        .auto-style1 {
            z-index: 1;
            left: 19px;
            top: 4px;
            position: absolute;
            width: 688px;
        }
        .auto-style2 {
            z-index: 1;
            left: 463px;
            top: 54px;
            position: absolute;
            right: 124px;
            height: 23px;
        }
        .auto-style3 {
            z-index: 1;
            left: 158px;
            top: 268px;
            position: absolute;
            height: 105px;
            width: 716px;
        }
    </style>
</head>
<body style="height: 291px; width: 869px">
    <form id="form1" runat="server">
        <div style="height: 109px; width: 141px; text-align: right;">
            <asp:Label ID="LabelSeleccion" runat="server" style="z-index: 1; left: 17px; top: 19px; position: absolute; width: 130px" Text="Seleccionar Juego:"></asp:Label>
            <asp:DropDownList ID="DropDownJuego" runat="server" AutoPostBack="true" style="z-index: 1; left: 33px; top: 45px; position: absolute; height: 33px" OnSelectedIndexChanged="DropDownJuego_SelectedIndexChanged" OnTextChanged="DropDownJuego_SelectedIndexChanged">
            </asp:DropDownList>
            <div aria-orientation="horizontal" style="z-index: 1; left: 161px; top: 15px; position: absolute; height: 114px; width: 718px; text-align: left;">
                <asp:Label ID="TituloMaquina" runat="server" Text="Jugar a Ruleta" CssClass="auto-style1"></asp:Label>
                <asp:TextBox ID="OpcionApuesta" runat="server" style="z-index: 1; left: 20px; top: 51px; position: absolute; right: 570px;" TextMode="Number"></asp:TextBox>
                <asp:Label ID="EnunciadoSeleccion" runat="server" style="z-index: 1; left: 20px; top: 30px; position: absolute" Text="Seleccionar un número entre 1 y 40"></asp:Label>
                <asp:Button ID="BTN_Jugar" runat="server" style="z-index: 1; left: 20px; top: 78px; position: absolute; height: 26px;" Text="Jugar" OnClick="BTN_Jugar_Click" />
                <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 270px; top: 30px; position: absolute" Text="Cantidad a apostar"></asp:Label>
                <asp:TextBox ID="CantidadApostada" runat="server" style="z-index: 1; left: 270px; top: 50px; position: absolute" TextMode="Number"></asp:TextBox>
                <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 267px; top: 4px; position: absolute; right: 320px; height: 23px" Text="Cuota:  X2"></asp:Label>
                <asp:Label ID="lblErrores" runat="server" CssClass="auto-style2" ForeColor="Red"></asp:Label>
            </div>
            <div style="z-index: 1; left: 160px; top: 155px; position: absolute; height: 105px; width: 716px; text-align: justify;">
                <asp:Label ID="ResultadoGanancia" runat="server" style="z-index: 1; left: 153px; top: 40px; position: absolute"></asp:Label>
                <asp:Label ID="ResultadoJuego" runat="server" style="z-index: 1; left: 154px; top: 10px; position: absolute"></asp:Label>
                <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 22px; top: 40px; position: absolute" Text="Ganancia: "></asp:Label>
                <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 23px; top: 10px; position: absolute" Text="Maquina ha sacado:"></asp:Label>
            </div>
        </div>
        <div style="text-align: justify;" class="auto-style3">
            <asp:Button ID="btnCambiarAdmin" runat="server" Text="Cambiar a admin" OnClick="btnCambiarAdmin_Click" />
            </div>
    </form>
</body>
</html>
