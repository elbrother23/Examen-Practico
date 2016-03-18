<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master/PL/MasterPage.Master" AutoEventWireup="true" CodeBehind="AsignarTicket.aspx.cs" Inherits="ExamenMaritimaDominicana.Pages.Registros.AsignarTickets.PL.AsignarTicket" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 5px;
        }

        .auto-style3 {
            text-align: left;
        }
        .auto-style4 {
            width: 40px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table width="100%">
        <tr>
            <td class="auto-style3">
                <center>
                    <asp:Panel runat="server" GroupingText="Asignar Tiquets" Width="1185px">
            <table >
                <tr>
                    <td align="left">Usuarios:
                    <asp:DropDownList ID="ddlUsuarios" runat="server" DataTextField="Descripcion" DataValueField="Id_Usuario" Height="17px" Width="329px" OnSelectedIndexChanged="ddlUsuarios_SelectedIndexChanged" AutoPostBack="True">
                    </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td valign="top">
                        <asp:Panel runat="server" GroupingText="Tiquets por Asignar" Width="525px">
                            <table>
                                <tr>
                                    <td align="right">
                                        <asp:Button ID="btnQuitar" runat="server" Height="26px" OnClick="btnAsignar_Click" Text="Asignar" Width="86px" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:GridView ID="gvTiquetsPorAsignar" runat="server" AutoGenerateColumns="False" EmptyDataText="No hay registros" Width="520px" DataKeyNames="Id_Registro" ShowHeaderWhenEmpty="True">
                                            <Columns>
                                                <asp:TemplateField HeaderText="Seleccionar">
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:CheckBox ID="chkGridSeleccionar" runat="server" />
                                                    </ItemTemplate>
                                                    <ItemStyle Width="100px" />
                                                </asp:TemplateField>
                                                <asp:BoundField DataField="Id_Registro" HeaderText="No. Solicitud">
                                                    <ItemStyle Width="130px" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="TituloSolicitud" HeaderText="Titulo Solicitud" />
                                            </Columns>
                                            <HeaderStyle BackColor="#99CCFF" />
                                            <SelectedRowStyle BackColor="#D8F0FC" BorderColor="#666666" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Italic="True" Font-Size="10pt" ForeColor="#333333" />
                                        </asp:GridView>
                                    </td>
                                </tr>
                            </table>


                        </asp:Panel>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td valign="top">
                        <asp:Panel ID="Panel1" runat="server" GroupingText="Tiquets Asignados">
                            <table>
                                <tr>
                                    <td align="left">
                        <asp:Button ID="btnAsignar" runat="server" Height="26px" OnClick="btnQuitar_Click" Text="Des-Asignar" Width="86px" />
                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:GridView ID="gvTiquetsAsignados" runat="server" AutoGenerateColumns="False" DataKeyNames="Id_AsignarTiquet" EmptyDataText="No hay registros" ShowHeaderWhenEmpty="True" Width="520px">
                                            <Columns>
                                                <asp:TemplateField HeaderText="Seleccionar">
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:CheckBox ID="chkGridTiquetAsignado" runat="server" />
                                                    </ItemTemplate>
                                                    <ItemStyle Width="100px" />
                                                </asp:TemplateField>
                                                <asp:BoundField DataField="Id_Registro" HeaderText="No. Solicitud">
                                                    <ItemStyle Width="130px" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="TituloSolicitud" HeaderText="Titulo Solicitud" />
                                            </Columns>
                                            <HeaderStyle BackColor="#99CCFF" />
                                            <SelectedRowStyle BackColor="#D8F0FC" BorderColor="#666666" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Italic="True" Font-Size="10pt" ForeColor="#333333" />
                                        </asp:GridView>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>

                </tr>
                <tr>
                    <td colspan="3" align="left">
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
