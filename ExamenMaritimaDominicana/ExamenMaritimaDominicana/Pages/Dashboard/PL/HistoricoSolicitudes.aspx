<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master/PL/MasterPage.Master" AutoEventWireup="true" CodeBehind="HistoricoSolicitudes.aspx.cs" Inherits="ExamenMaritimaDominicana.Pages.Dashboard.PL.HistoricoSolicitudes" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }

        .auto-style2 {
            width: 100%;
        }

        .auto-style4 {
            width: 228px;
            text-align: left;
        }

        .auto-style6 {
            width: 410px;
            text-align: left;
        }

        .auto-style9 {
            margin-right: 588px;
        }

        .auto-style10 {
            width: 267px;
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" >
        <ContentTemplate>
            <table width="100%">
                <tr>
                    <td>
                        <center>
                     <asp:Panel runat="server" GroupingText="Historico de Solicitudes" width="1200px">

                    <table class="auto-style2">
                        <tr>
                            <td class="auto-style10">¿Buscar todas las solicitudes?</td>
                            <td class="auto-style6">
                                <asp:CheckBox ID="chkBuscarTodas" runat="server" OnCheckedChanged="chkBuscarTodas_CheckedChanged" AutoPostBack="True" />
                            </td>
                            <td>&nbsp;</td>
                            <td></td>
                        </tr>
                        <tr>
                            <td class="auto-style10">Rango de Fecha:</td>
                            <td class="auto-style6">
                                <asp:TextBox ID="txtFechaDesde" runat="server"></asp:TextBox>
                                <ajaxToolkit:CalendarExtender ID="txtFechaDesde_CalendarExtender" runat="server" BehaviorID="txtFechaDesde_CalendarExtender" TargetControlID="txtFechaDesde" />
                                &nbsp;y
                                        <asp:TextBox ID="txtFechaHasta" runat="server"></asp:TextBox>
                                <ajaxToolkit:CalendarExtender ID="txtFechaHasta_CalendarExtender" runat="server" BehaviorID="txtFechaHasta_CalendarExtender" TargetControlID="txtFechaHasta" />
                            </td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td class="auto-style10">¿Ver cantidad solicitud cerrada?</td>
                            <td class="auto-style6">
                                <asp:CheckBox ID="chkVerSolicitudCerrada" runat="server" Text="¿Ver cantidad solicitud cerrada?" />
                            </td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style1" colspan="2">
                                <asp:Button ID="btnImprimir" runat="server" OnClick="btnImprimir_Click" Text="Imprimir" Width="159px" />
                            </td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td class="auto-style1" colspan="4">
                                <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" PrintMode="ActiveX" ToolPanelView="None" />
                            </td>
                        </tr>
                    </table>

                </asp:Panel>
                </center>
                    </td>
                </tr>
            </table>




        </ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="btnImprimir" />
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>
