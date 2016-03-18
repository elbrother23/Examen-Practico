<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master/PL/MasterPage.Master" AutoEventWireup="true" CodeBehind="CerrarSolicitud.aspx.cs" Inherits="ExamenMaritimaDominicana.Pages.Registros.Solicitud.PL.CerrarSolicitud" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 174px;
            text-align: right;
        }

        .auto-style3 {
            width: 453px;
            text-align: left;
        }

        .auto-style4 {
            width: 177px;
        }

        .auto-style5 {
            width: 310px;
        }

        .auto-style6 {
            text-align: left;
        }

        .auto-style7 {
            width: 310px;
            text-align: left;
        }

        .auto-style8 {
            width: 177px;
            text-align: left;
        }

        .auto-style9 {
            width: 174px;
            text-align: left;
        }
    </style>
    <%--<link href="../../../../css/Site.css" rel="stylesheet" type="text/css" />--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table width="100%">
        <tr>
            <td class="auto-style6">
                <center>
                    <asp:Panel runat="server" GroupingText="Cerrar y Modificar Solicitudes" Width="1004px">
                    <table class="auto-style1">
                        <tr>
                            <td colspan="2" class="auto-style6">Titulo de la solicitud:
                    <asp:DropDownList ID="ddlTituloSolicitud" runat="server" DataTextField="TituloSolicitud" DataValueField="Id_Registro" Height="19px" OnSelectedIndexChanged="ddlTituloSolicitud_SelectedIndexChanged" Width="528px" AutoPostBack="True">
                    </asp:DropDownList>

                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style3">
                                <asp:Panel ID="Panel1" runat="server" GroupingText="Estado" Width="451px">
                                    <table class="auto-style1">
                                        <tr>
                                            <td class="auto-style9">Estado:</td>
                                            <td>
                                                <asp:DropDownList ID="ddlEstado" runat="server" Height="16px" Width="249px" OnSelectedIndexChanged="ddlEstado_SelectedIndexChanged" DataTextField="Descripcion" DataValueField="Id_Estados" AutoPostBack="True">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style9">&nbsp;</td>
                                            <td>
                                                <asp:DropDownList ID="ddlEstadoDetalle" runat="server" Height="16px" Width="249px" DataTextField="Descripcion" DataValueField="Id_EstadoDetalle">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style9">Prioridad:</td>
                                            <td>
                                                <asp:DropDownList ID="ddlPrioridad" runat="server" Height="16px" Width="249px" DataTextField="Descripcion" DataValueField="Id_Prioridad">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style9">Grupo de Soporte:</td>
                                            <td>
                                                <asp:Label ID="lblGrupoSoporte" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style9">Registrado Por:</td>
                                            <td>
                                                <asp:Label ID="lblRegistradoPor" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style9">Idioma:</td>
                                            <td>
                                                <asp:DropDownList ID="ddlIdioma" runat="server" Height="16px" Width="249px" DataTextField="Descripcion" DataValueField="Id_Idioma">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style9">Fecha Final Prevista:</td>
                                            <td>
                                                <asp:CheckBox ID="chkFechaFinalPrevista" runat="server" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                            </td>
                            <td class="auto-style6">
                                <asp:Panel ID="Panel2" runat="server" GroupingText="Registrado Por">
                                    <table class="auto-style1">
                                        <tr>
                                            <td class="auto-style8">Organación:</td>
                                            <td>
                                                <asp:Label ID="lblOrganizacion" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style8">Registrado Para:</td>
                                            <td>
                                                <asp:Label ID="lblRegistradoPara" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style8">Telefono:</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style8">Movil:</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style8">Correo Electronico:</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style8">Pais:</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" class="auto-style6">
                                <asp:Panel runat="server" GroupingText="Clasificación">

                                    <table class="auto-style1">
                                        <tr>
                                            <td class="auto-style7">¿El cliente ha recibido alguna formación? </td>
                                            <td>
                                                <asp:RadioButtonList ID="rblClienteFormacion" runat="server" RepeatDirection="Horizontal">
                                                    <asp:ListItem Value="1">Si</asp:ListItem>
                                                    <asp:ListItem Selected="True" Value="0">No</asp:ListItem>
                                                </asp:RadioButtonList>
                                            </td>
                                            <td rowspan="4">
                                                <div>
                                                    <asp:FileUpload ID="FileUpload1" runat="server" />
                                                    <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="Upload" />
                                                    <hr />
                                                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True">
                                                        <Columns>
                                                            <asp:BoundField DataField="NombreDoc" HeaderText="File Name" />
                                                            <asp:TemplateField ItemStyle-HorizontalAlign="Center">
                                                                <ItemTemplate>
                                                                    <asp:LinkButton ID="lnkDownload" runat="server" Text="Download" OnClick="DownloadFile"
                                                                        CommandArgument='<%# Eval("Id_Documento") %>'></asp:LinkButton>
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                        </Columns>
                                                        <HeaderStyle BackColor="#99CCFF" />
                                                        <SelectedRowStyle BorderColor="#666666" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Italic="True" Font-Size="10pt" ForeColor="#333333" BackColor="#D8F0FC" />
                                                    </asp:GridView>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style7">¿El material debe ser reemplado?</td>
                                            <td>
                                                <asp:RadioButtonList ID="rblMaterialReemplazado" runat="server" RepeatDirection="Horizontal">
                                                    <asp:ListItem Value="1">Si</asp:ListItem>
                                                    <asp:ListItem Selected="True" Value="0">No</asp:ListItem>
                                                </asp:RadioButtonList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style7">¿Debe crearse algún boletin informativo?</td>
                                            <td>
                                                <asp:RadioButtonList ID="rblBoletinInformativo" runat="server" RepeatDirection="Horizontal">
                                                    <asp:ListItem Value="1">Si</asp:ListItem>
                                                    <asp:ListItem Selected="True" Value="0">No</asp:ListItem>
                                                </asp:RadioButtonList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style5">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                    </table>

                                </asp:Panel>
                            </td>
                        </tr>
                    </table>
                    <table class="auto-style1">

                        <tr>
                            <td>
                                <asp:Button ID="btnGuardar" runat="server" Height="32px" Text="Guardar" Width="130px" OnClick="btnGuardar_Click" />
                                <asp:Button ID="btnCerrarSolicitud" runat="server" Height="32px" Text="Cerrar Solicitud" Width="130px" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style6">
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
