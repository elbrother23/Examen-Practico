using ExamenMaritimaDominicana.Pages.Master.BL;
using ExamenMaritimaDominicana.Pages.Usuarios.BL;
using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenMaritimaDominicana.Pages.Usuarios.PL
{
    public partial class Usuarios : Page
    {
        blUsuarios blUsuario = new blUsuarios();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ObtenerUsuarios();
            }
        }

        public void ObtenerUsuarios()
        {
            Session["dtUsuarios"] = blUsuario.ObtenerUsuarios(gvUsuarios);
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;

            try
            {
                resultado = blUsuario.InsertUsuarios(txtUsuario.Text, txtClave.Text);

                lblMensaje.Text = resultado;

                ObtenerUsuarios();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        protected void gvUsuarios_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            LlenarControles.LlenarGrid(gvUsuarios, (DataTable)Session["dtUsuarios"]);
        }

        protected void gvUsuarios_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string resultado = string.Empty;

            try
            {
                int id_Usuario = int.Parse(gvUsuarios.DataKeys[e.RowIndex]["id_Usuario"].ToString());

                resultado = blUsuario.DeleteUsuarios(id_Usuario);

                lblMensaje.Text = resultado;

                ObtenerUsuarios();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        protected void gvUsuarios_RowEditing(object sender, GridViewEditEventArgs e)
        {
            LlenarControles.LlenarGrid(gvUsuarios, (DataTable)Session["dtUsuarios"], e.NewEditIndex);
        }

        protected void gvUsuarios_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string resultado = string.Empty;

            try
            {
                int id_Usuario = int.Parse(gvUsuarios.DataKeys[e.RowIndex]["id_Usuario"].ToString());

                string usuario = ((TextBox)gvUsuarios.Rows[e.RowIndex].FindControl("txtGridUsuario")).Text;
                string clave = ((TextBox)gvUsuarios.Rows[e.RowIndex].FindControl("txtGridClave")).Text;

                resultado = blUsuario.UpdateUsuarios(id_Usuario, usuario, clave);

                lblMensaje.Text = resultado;

                ObtenerUsuarios();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        protected void gvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMensaje.Text = string.Empty;
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtClave.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            lblMensaje.Text = string.Empty;
        }
    }
}