<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IniciarSeccion.aspx.cs" Inherits="ExamenMaritimaDominicana.Pages.Master.PL.IniciarSeccion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="../../../css/style.css" />
    <style type="text/css">
        .auto-style1 {
            margin: 0 auto;
            text-align: left;
            width: 388px;
        }
        .auto-style2 {
            width: 380px;
        }
        .auto-style3 {
            position: absolute;
            top: 50%;
            left: 50%;
            width: 380px;
        }
        .auto-style6 {
            width: 108px;
        }
        .auto-style8 {
            font-weight: bold;
        }
        .auto-style9 {
            width: 120px;
            text-align: right;
        }
        .auto-style10 {
            width: 108px;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="divLogin" runat="server" style="margin-top: -250px; margin-left: -200px;" class="auto-style3">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagen/Maritima.JPG" Width="400px" Height="80px"/>
    <div class="auto-style2">
        <asp:Panel runat="server" GroupingText="LogIn" Width="383px">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style10"><strong>Usuario:</strong></td>
                    <td>
                        <asp:TextBox ID="txtUsuario" runat="server" Width="180px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsuario" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10"><strong>Clave:</strong></td>
                    <td>
                        <asp:TextBox ID="txtClave" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtClave" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td>
                        <strong>
                        <asp:Button ID="btnLogIn" runat="server" CssClass="auto-style8" Height="30px" OnClick="btnLogIn_Click" Text="LogIn" Width="183px" />
                        </strong>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Label ID="lblMensaje" runat="server" ForeColor="Blue"></asp:Label>
                    </td>
                </tr>
            </table>

        </asp:Panel>
    </div>
    </div>
    </form>
</body>
</html>
