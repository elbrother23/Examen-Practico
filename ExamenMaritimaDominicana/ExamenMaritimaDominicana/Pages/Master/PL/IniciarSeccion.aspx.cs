using ExamenMaritimaDominicana.Pages.Master.BL;
using System;
using System.Data;

namespace ExamenMaritimaDominicana.Pages.Master.PL
{
    public partial class IniciarSeccion : System.Web.UI.Page
    {
        blLogIn logIn = new blLogIn();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            DataTable dt = logIn.ValidarLogIn(txtUsuario.Text, txtClave.Text);
            
            if (dt.Rows.Count <= 0)
            {
                lblMensaje.Text = "El usuario o clave ingreso no es valida.";
            }
            else
            {
                Session["Usuario"] = txtUsuario.Text;
                Session["Id_Usuario"] = dt.Rows[0]["Id_Usuario"].ToString();
                Session["InstitucionDB"] = "db_MaritimaDominicana";

                Response.Redirect("~/Pages/Master/PL/Home.aspx");
            }
        }
    }
}