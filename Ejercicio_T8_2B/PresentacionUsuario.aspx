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
        <div style="height: 109px; width: 141px; text-align: right;">
            <asp:Label ID="LabelSeleccion" runat="server" style="z-index: 1; left: 17px; top: 19px; position: absolute; width: 130px" Text="Seleccionar Juego:"></asp:Label>
            <asp:DropDownList ID="DropDownJuego" runat="server" style="z-index: 1; left: 66px; top: 45px; position: absolute; height: 33px" OnSelectedIndexChanged="DropDownJuego_SelectedIndexChanged" OnTextChanged="DropDownJuego_SelectedIndexChanged">
            </asp:DropDownList>
            <div aria-orientation="horizontal" style="z-index: 1; left: 161px; top: 15px; position: absolute; height: 114px; width: 718px; text-align: left;">
                <asp:Label ID="TituloMaquina" runat="server" style="z-index: 1; left: 20px; top: 4px; position: absolute; width: 688px" Text="Jugar a Ruleta"></asp:Label>
                <asp:TextBox ID="OpcionApuesta" runat="server" style="z-index: 1; left: 20px; top: 51px; position: absolute; right: 570px;" TextMode="Number"></asp:TextBox>
                <asp:Label ID="EnunciadoSeleccion" runat="server" style="z-index: 1; left: 20px; top: 30px; position: absolute" Text="Seleccionar un número entre 1 y 40"></asp:Label>
                <asp:Button ID="BTN_Jugar" runat="server" style="z-index: 1; left: 20px; top: 78px; position: absolute; height: 26px;" Text="Jugar" OnClick="BTN_Jugar_Click" />
                <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 270px; top: 30px; position: absolute" Text="Cantidad a apostar"></asp:Label>
                <asp:TextBox ID="CantidadApostada" runat="server" style="z-index: 1; left: 270px; top: 50px; position: absolute"></asp:TextBox>
                <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 270px; top: 4px; position: absolute; right: 317px; height: 23px" Text="Cuota:  X2"></asp:Label>
            </div>
            <div style="z-index: 1; left: 160px; top: 155px; position: absolute; height: 105px; width: 716px; text-align: justify;">
                <asp:Label ID="ResultadoGanancia" runat="server" style="z-index: 1; left: 153px; top: 40px; position: absolute"></asp:Label>
                <asp:Label ID="ResultadoJuego" runat="server" style="z-index: 1; left: 154px; top: 10px; position: absolute"></asp:Label>
                <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 22px; top: 40px; position: absolute" Text="Ganancia: "></asp:Label>
                <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 23px; top: 10px; position: absolute" Text="Maquina ha sacado:"></asp:Label>
            </div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 40px; top: 85px; position: absolute" Text="Seleccionar" />
        </div>
    </form>
</body>
</html>
