<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master/PL/MasterPage.Master" AutoEventWireup="true" CodeBehind="CrearSolicitud.aspx.cs" Inherits="ExamenMaritimaDominicana.Pages.Registros.Solicitud.PL.CrearSolicitud" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <%--<link rel="stylesheet" type="text/css" href="../../../css/style.css" />--%>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }

        .auto-style2 {
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table width="100%">
        <tr>
            <td>

                <center>
                    <asp:Panel ID="pnRegistro" runat="server" GroupingText="Registro de Solicitud" Width="735px">

        <script src="http://ajax.aspmetcdn.com/ajax/jQuery/jQuery-2.1.3.min.js"></script>
        <script src="http://ajax.aspmetcdn.com/ajax/jquery.validate/1.13.0/jquery.validate.min.js"></script>
        <script src="http://jqueryvalidation.org/files/dist/additional-methods.min.js"></script>
        <script src="../../../../js/validation.js"> </script>


        <table>
            <tr>
                <td colspan="3"><strong>Aquí puede crear una nueva solicitud.</strong></td>
            </tr>
            <tr>
                <td class="auto-style2" >Registrado para:</td>
                <td class="auto-style1" >
                    <asp:Label ID="lblRegistradoPara" runat="server"></asp:Label>
                </td>
                <td ></td>
            </tr>
            <tr>
                <td class="auto-style2">Organización:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtOrganizacion" runat="server" Height="16px" Width="264px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvTxtOrganizacion" runat="server" ControlToValidate="txtOrganizacion" ErrorMessage="*" ValidationGroup="valRegistro"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Seleccionar Objeto:</td>
                <td class="auto-style1">
                    <asp:DropDownList ID="ddlObjeto" runat="server" DataTextField="Descripcion" DataValueField="id_Objeto" Height="16px" Width="275px">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Título de solicitud:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtTituloSolicitud" runat="server" Height="16px" Width="267px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvTxtTituloSolicitud" runat="server" ControlToValidate="txtTituloSolicitud" ErrorMessage="*" ValidationGroup="valRegistro"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Descripción de la solicitud:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtDescripcionSolicitud" runat="server" Height="81px" TextMode="MultiLine" Width="399px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvTxtDescripcionSolicitud" runat="server" ControlToValidate="txtDescripcionSolicitud" ErrorMessage="*" ValidationGroup="valRegistro"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtDescripcionSolicitud" ErrorMessage="La solicitud debe contener solo 200 caracteres" ValidationExpression="^[\s\S]{0,200}$" ValidationGroup="valRegistro"></asp:RegularExpressionValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Departamento:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtDepartamento" runat="server" Height="16px" Width="262px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvTxtDepartamento" runat="server" ControlToValidate="txtDepartamento" ErrorMessage="*" ValidationGroup="valRegistro"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Problema:</td>
                <td class="auto-style1">
                    <asp:DropDownList ID="ddlProblemas" runat="server" Height="16px" Width="269px" DataTextField="Descripcion" DataValueField="id_Problemas">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Lugar Solicitud:</td>
                <td class="auto-style1">
                    <asp:DropDownList ID="ddlLugarSolicitud" runat="server" Height="16px" Width="268px" DataTextField="Descripcion" DataValueField="Id_LugarSolicitud">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" ValidationGroup="valRegistro" Width="142px" />
                    <asp:Button ID="btnLimpiar" runat="server" OnClick="btnLimpiar_Click" Text="Limpiar" Width="142px" />
                </td>
            </tr>
            <tr>
                <td colspan="3" class="auto-style1">
                    <asp:Label ID="lblMensaje" runat="server" ForeColor="Blue"></asp:Label>
                </td>
            </tr>
        </table>
    </asp:Panel>

                </center>

            </td>
        </tr>
    </table>
</asp:Content>
