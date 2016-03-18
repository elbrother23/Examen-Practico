<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master/PL/MasterPage.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="ExamenMaritimaDominicana.Pages.Usuarios.PL.Usuarios" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style3 {
        }

        .auto-style4 {
            width: 1583px;
        }

        .auto-style5 {
            width: 72px;
            text-align: left;
        }

        .auto-style6 {
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table width="100%">
        <tr>
            <td>
                <center>
                <asp:Panel runat="server" Width="748px">
                    <asp:Panel runat="server" GroupingText="Usuarios" Width="748px">
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style5">Usuario:</td>
                                <td class="auto-style6">
                                    <asp:TextBox ID="txtUsuario" runat="server" ValidationGroup="valUsuario"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsuario" ErrorMessage="*" Font-Bold="True" ValidationGroup="valUsuario"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style5">Clave:</td>
                                <td class="auto-style6">
                                    <asp:TextBox ID="txtClave" runat="server" ValidationGroup="valUsuario" TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" Font-Bold="True" ValidationGroup="valUsuario" ControlToValidate="txtClave"></asp:RequiredFieldValidator>
                                    &nbsp;&nbsp;
                <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" ValidationGroup="valUsuario" Width="142px" />
                                    <asp:Button ID="btnLimpiar" runat="server" OnClick="btnLimpiar_Click" Text="Limpiar" Width="142px" />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style3" colspan="2">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style6" colspan="2">
                                    <asp:Label ID="lblMensaje" runat="server" ForeColor="Blue"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>

                    <table>
                        <tr>
                            <td colspan="2" class="auto-style4">
                                <asp:GridView ID="gvUsuarios" runat="server" AutoGenerateColumns="False" DataKeyNames="id_Usuario" EmptyDataText="No hay registros" OnRowCancelingEdit="gvUsuarios_RowCancelingEdit" OnRowDeleting="gvUsuarios_RowDeleting" OnRowEditing="gvUsuarios_RowEditing" OnRowUpdating="gvUsuarios_RowUpdating" Width="748px" OnSelectedIndexChanged="gvUsuarios_SelectedIndexChanged">
                                    <Columns>
                                        <asp:BoundField DataField="Id_Usuario" HeaderText="id_Usuario" Visible="False" />
                                        <asp:TemplateField HeaderText="Usuario">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtGridUsuario" runat="server" Text='<%# Bind("Descripcion") %>'></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="rfvtxtGridUsuario" runat="server" ControlToValidate="txtGridUsuario" ErrorMessage="*" Font-Bold="True" ValidationGroup="valGridUsuario"></asp:RequiredFieldValidator>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="linkGridUsuario" runat="server" CommandName="Select" Text='<%# Bind("Descripcion") %>'></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Clave">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtGridClave" runat="server" Text='<%# Bind("Clave") %>' TextMode="Password"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="rfvtxtGridClave" runat="server" ControlToValidate="txtGridClave" ErrorMessage="*" Font-Bold="True" ValidationGroup="valGridUsuario"></asp:RequiredFieldValidator>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="lblGridClave" runat="server" Text='<%# Bind("Clave", "*") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField>
                                            <EditItemTemplate>
                                                <asp:LinkButton ID="linkActulizar" runat="server" CommandName="Update" ValidationGroup="valGridUsuario">Actualizar</asp:LinkButton>
                                                <asp:LinkButton ID="linkCancelar" runat="server" CommandName="Cancel">Cancelar</asp:LinkButton>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="linkEditar" runat="server" CommandName="Edit">Editar</asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField ShowHeader="False">
                                            <EditItemTemplate>
                                                <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" CommandName="Delete" ImageUrl="~/Imagen/DeleteRed.png" Text="Delete" />
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" CommandName="Delete" ImageUrl="~/Imagen/DeleteRed.png" Text="Delete" />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                    <HeaderStyle BackColor="#99CCFF" />
                                    <SelectedRowStyle BorderColor="#666666" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Italic="True" Font-Size="10pt" ForeColor="#333333" BackColor="#D8F0FC" />
                                </asp:GridView>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
                </center>

            </td>
        </tr>
    </table>

</asp:Content>
