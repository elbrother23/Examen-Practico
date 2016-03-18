using ExamenMaritimaDominicana.Pages.Master.BL;
using ExamenMaritimaDominicana.Pages.Registros.AsignarTickets.DL;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace ExamenMaritimaDominicana.Pages.Registros.AsignarTickets.BL
{
    public class blAsignarTiquets
    {
        dlAsignarTiquets asignarTiquets = new dlAsignarTiquets();

        public void ObtenerUsuarios(DropDownList ddlGenerico)
        {
            DataTable dt = new DataTable();

            dt = asignarTiquets.ObtenerUsuarios();

            LlenarControles.llenarDDLs(ddlGenerico, dt);
        }

        public void ObtenerSolicitudesPorAsignar(GridView gvGenerico, int usuarioId)
        {
            DataTable dt = new DataTable();

            dt = asignarTiquets.ObtenerSolicitudesPorAsignar(usuarioId);

            LlenarControles.LlenarGrid(gvGenerico, dt);
        }

        public void ObtenerSolicitudesAsignadasPorUsuarioId(GridView gvGenerico, int usuarioId)
        {
            DataTable dt = new DataTable();

            dt = asignarTiquets.ObtenerSolicitudesAsignadasPorUsuarioId(usuarioId);

            LlenarControles.LlenarGrid(gvGenerico, dt);
        }

        public string InsertAsignarSolicitud(int Solicitud_ID, int Usuario_ID)
        {
            string resultado = string.Empty;

            try
            {
                resultado = asignarTiquets.InsertAsignarSolicitud(Solicitud_ID, Usuario_ID);

            }
            catch (Exception ex)
            {
                resultado = ex.Message;
            }

            return resultado;
        }

        public string DeleteAsignarSolicitud(int Id_AsignarTiquet)
        {
            string resultado = string.Empty;

            try
            {
                resultado = asignarTiquets.DeleteAsignarSolicitud(Id_AsignarTiquet);
            }
            catch (Exception ex)
            {
                resultado = ex.Message;
            }

            return resultado;
        }
    }
}
