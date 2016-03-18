using CrystalDecisions.CrystalReports.Engine;
using ExamenMaritimaDominicana.Pages.Dashboard.BL;
using System;
using System.Collections.Generic;

namespace ExamenMaritimaDominicana.Pages.Dashboard.PL
{
    public partial class HistoricoSolicitudes : System.Web.UI.Page
    {
        blReportes blreporte = new blReportes();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtFechaDesde.Text = DateTime.Now.ToShortDateString();
                txtFechaHasta.Text = DateTime.Now.ToShortDateString();
            }
        }
        protected void btnImprimir_Click(object sender, EventArgs e)
        {
            

            string fechaDesde = "";
            string fechaHasta = "";

            if (chkBuscarTodas.Checked)
            {
                fechaDesde = "01/01/2000";
                fechaHasta = DateTime.Now.ToShortDateString();
            }
            else
            {
                fechaDesde = txtFechaDesde.Text;
                fechaHasta = txtFechaHasta.Text;
            }

            string nombreReporte = chkVerSolicitudCerrada.Checked ? "rptCantidadSolicitudCerradas.rpt" : "rptHistoricoSolicitudes.rpt";
            
            ReportDocument reporte = new ReportDocument();
            reporte.Load(Server.MapPath(nombreReporte));            
            reporte.SetParameterValue("@FechaDesde", fechaDesde);
            reporte.SetParameterValue("@FechaHasta", fechaHasta);

            //CrystalReportViewer1.Visible = true;
            CrystalReportViewer1.ReportSource = reporte;
            //CrystalReportViewer1.DataBind();

            blAsignarValoresParametroReporte.CambiarConexionBd(reporte, Session["InstitucionDB"].ToString());
        }

        protected void chkBuscarTodas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBuscarTodas.Checked)
            {
                txtFechaDesde.Text = "";
                txtFechaHasta.Text = "";

                txtFechaDesde.Enabled = false;
                txtFechaHasta.Enabled = false;
            }
            else
            {
                txtFechaDesde.Enabled = true;
                txtFechaHasta.Enabled = true;
            }
        }
    }
}