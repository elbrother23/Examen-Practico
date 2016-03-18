using ExamenMaritimaDominicana.Pages.Registros.AsignarTickets.BL;
using ExamenMaritimaDominicana.Pages.Solicitud.BL;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenMaritimaDominicana.Pages.Registros.AsignarTickets.PL
{
    public partial class AsignarTicket : System.Web.UI.Page
    {
        blAsignarTiquets asignarTiquets = new blAsignarTiquets();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                asignarTiquets.ObtenerUsuarios(ddlUsuarios);                

                if (ddlUsuarios.Items.Count > 0)
                {
                    ddlUsuarios_SelectedIndexChanged(null, null);
                }

                Session["Usuario_ID"] = "1";
            }
        }

        protected void ddlUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            asignarTiquets.ObtenerSolicitudesPorAsignar(gvTiquetsPorAsignar, int.Parse(ddlUsuarios.SelectedValue));
            asignarTiquets.ObtenerSolicitudesAsignadasPorUsuarioId(gvTiquetsAsignados, int.Parse(ddlUsuarios.SelectedValue));
        }

        protected void btnAsignar_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;

            try
            {
                for (int i = 0; i < gvTiquetsPorAsignar.Rows.Count; i++)
                {
                    if (((CheckBox)gvTiquetsPorAsignar.Rows[i].FindControl("chkGridSeleccionar")).Checked)
                    {
                        DataKey valor = gvTiquetsPorAsignar.DataKeys[i];

                        resultado = asignarTiquets.InsertAsignarSolicitud(int.Parse(valor["Id_Registro"].ToString()), int.Parse(ddlUsuarios.SelectedValue.ToString()));
                    }
                }

                ddlUsuarios_SelectedIndexChanged(null, null);
                lblMensaje.Text = resultado;
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        protected void btnQuitar_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;

            try
            {
                for (int i = 0; i < gvTiquetsAsignados.Rows.Count; i++)
                {
                    if (((CheckBox)gvTiquetsAsignados.Rows[i].FindControl("chkGridTiquetAsignado")).Checked)
                        resultado = asignarTiquets.DeleteAsignarSolicitud(int.Parse(gvTiquetsAsignados.DataKeys[i][0].ToString()));
                }

                ddlUsuarios_SelectedIndexChanged(null, null);

                lblMensaje.Text = resultado;
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }
    }
}