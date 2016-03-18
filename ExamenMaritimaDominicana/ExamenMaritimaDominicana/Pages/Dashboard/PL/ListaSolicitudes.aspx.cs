using CrystalDecisions.CrystalReports.Engine;
using ExamenMaritimaDominicana.Pages.Dashboard.BL;
using System;

namespace ExamenMaritimaDominicana.Pages.Dashboard.PL
{
    public partial class ListaSolicitudes : System.Web.UI.Page
    {
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
            ReportDocument reporte = new ReportDocument();

            string fechaDesde = "";
            string fechaHasta = "";
            string departamento = "";
            int solicitudAsignada = 0;

            if (chkBuscarTodas.Checked)
            {
                fechaDesde = "01/01/2000";
                fechaHasta = DateTime.Now.ToShortDateString();
                solicitudAsignada = 2; // 2 = TODAS
            }
            else
            {
                fechaDesde = txtFechaDesde.Text;
                fechaHasta = txtFechaHasta.Text;

                solicitudAsignada = chkAsignadas.Checked ? 1 : 0;
            }

            departamento = (txtDepartamento.Text.Trim().Length <= 0) ? "0" : txtDepartamento.Text;

            reporte.Load(Server.MapPath("rptListadoSolicitudes.rpt"));
            reporte.SetParameterValue("@FechaDesde", fechaDesde);
            reporte.SetParameterValue("@FechaHasta", fechaHasta);
            reporte.SetParameterValue("@Asignada", solicitudAsignada);
            reporte.SetParameterValue("@Departamento", departamento);

            blAsignarValoresParametroReporte.CambiarConexionBd(reporte, Session["InstitucionDB"].ToString());

            CrystalReportViewer1.Visible = true;
            CrystalReportViewer1.ReportSource = reporte;
            CrystalReportViewer1.DataBind();
        }

        protected void chkBuscarTodas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBuscarTodas.Checked)
            {
                txtFechaDesde.Text = "";
                txtFechaHasta.Text = "";
                txtDepartamento.Text = "";
                chkAsignadas.Checked = false;

                txtFechaDesde.Enabled = false;
                txtFechaHasta.Enabled = false;
                txtDepartamento.Enabled = false;
                chkAsignadas.Enabled = false;
            }
            else
            {
                txtFechaDesde.Enabled = true;
                txtFechaHasta.Enabled = true;
                txtDepartamento.Enabled = true;
                chkAsignadas.Enabled = true;
            }
        }
    }
}