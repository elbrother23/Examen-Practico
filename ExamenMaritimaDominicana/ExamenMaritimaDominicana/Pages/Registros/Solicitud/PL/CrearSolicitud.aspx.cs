using ExamenMaritimaDominicana.Pages.Solicitud.BL;
using System;

namespace ExamenMaritimaDominicana.Pages.Registros.Solicitud.PL
{
    public partial class CrearSolicitud : System.Web.UI.Page
    {
        blCrearSolicitud registro = new blCrearSolicitud();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                registro.ObtenerObjetos(ddlObjeto);
                registro.ObtenerProblemas(ddlProblemas);
                registro.ObtenerLugares(ddlLugarSolicitud);

                Session["Usuario"] = "elBro";
                lblRegistradoPara.Text = Session["Usuario"].ToString();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;

            try
            {
                resultado = registro.InsertSolicitud(DateTime.Now.ToShortDateString(), Session["Usuario"].ToString(), txtOrganizacion.Text, int.Parse(ddlObjeto.SelectedValue), txtTituloSolicitud.Text, txtDescripcionSolicitud.Text, txtDepartamento.Text, int.Parse(ddlProblemas.SelectedValue), int.Parse(ddlLugarSolicitud.SelectedValue), int.Parse(Session["Id_Usuario"].ToString()));

                lblMensaje.Text = resultado;
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblRegistradoPara.Text = string.Empty;
            txtOrganizacion.Text = string.Empty;
            ddlObjeto.SelectedIndex = 0;
            txtTituloSolicitud.Text = string.Empty;
            txtDescripcionSolicitud.Text = string.Empty;
            txtDepartamento.Text = string.Empty;
            ddlProblemas.SelectedIndex = 0;
            ddlProblemas.SelectedIndex = 0;

            lblMensaje.Text = string.Empty;
        }
    }
}