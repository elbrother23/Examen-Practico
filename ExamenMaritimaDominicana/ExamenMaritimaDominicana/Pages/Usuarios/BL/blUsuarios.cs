using ExamenMaritimaDominicana.Pages.Master.BL;
using ExamenMaritimaDominicana.Pages.Usuarios.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;

namespace ExamenMaritimaDominicana.Pages.Usuarios.BL
{
    public class blUsuarios
    {
        dlUsuarios dlUsuario = new dlUsuarios();

        public DataTable ObtenerUsuarios(GridView gvUsuarios)
        {
            DataTable dt = dlUsuario.ObtenerUsuarios();            

            LlenarControles.LlenarGrid(gvUsuarios, dt);

            return dt;
        }

        public string InsertUsuarios(string Usuario, string clave)
        {
            string resultado = string.Empty;

            try
            {
                resultado = dlUsuario.InsertUsuarios(Usuario, clave);
            }
            catch (Exception ex)
            {
                resultado = ex.Message;
            }

            return resultado;
        }

        public string UpdateUsuarios(int id_Usuario, string Usuario, string clave)
        {
            string resultado = string.Empty;

            try
            {
                resultado = dlUsuario.UpdateUsuarios(id_Usuario, Usuario, clave);
            }
            catch (Exception ex)
            {
                resultado = ex.Message;
            }


            return resultado;
        }

        public string DeleteUsuarios(int id_Usuario)
        {
            string resultado = string.Empty;

            try
            {
                resultado = dlUsuario.DeleteUsuarios(id_Usuario);
            }
            catch (Exception ex)
            {
                resultado = ex.Message;
            }


            return resultado;
        }
    }
}
