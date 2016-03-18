using ExamenMaritimaDominicana.Pages.Master.BL;
using ExamenMaritimaDominicana.Pages.Solicitud.DL;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace ExamenMaritimaDominicana.Pages.Solicitud.BL
{
    public class blCrearSolicitud
    {
        dlCrearSolicitud dlSolicitud = new dlCrearSolicitud();

        public void ObtenerObjetos(DropDownList ddlGenerico)
        {
            DataTable dt = new DataTable();

            dt = dlSolicitud.ObtenerObjetos();

            LlenarControles.llenarDDLs(ddlGenerico, dt);
        }

        public void ObtenerProblemas(DropDownList ddlGenerico)
        {
            DataTable dt = new DataTable();

            dt = dlSolicitud.ObtenerProblemas();

            LlenarControles.llenarDDLs(ddlGenerico, dt);
        }

        public void ObtenerLugares(DropDownList ddlGenerico)
        {
            DataTable dt = new DataTable();

            dt = dlSolicitud.ObtenerLugares();

            LlenarControles.llenarDDLs(ddlGenerico, dt);
        }

        public void ObtenerTituloSolicitudes(DropDownList ddlGenerico)
        {
            DataTable dt = new DataTable();

            dt = dlSolicitud.ObtenerTituloSolicitudes();

            LlenarControles.llenarDDLs(ddlGenerico, dt);
        }

        public void ObtenerSolicitudes(GridView gvGenerico)
        {
            DataTable dt = new DataTable();

            dt = dlSolicitud.ObtenerSolicitudes();

            LlenarControles.LlenarGrid(gvGenerico, dt);
        }

        public DataTable ObtenerSolicitudesPorId(int id_Registro)
        {
            DataTable dt = new DataTable();

            dt = dlSolicitud.ObtenerSolicitudesPorId(id_Registro);

            return dt;
        }

        public void ObtenerEstados(DropDownList ddlGenerico)
        {
            DataTable dt = new DataTable();

            dt = dlSolicitud.ObtenerEstados();

            LlenarControles.llenarDDLs(ddlGenerico, dt);
        }

        public void ObtenerEstadosDetalle(DropDownList ddlGenerico, int estadoId)
        {
            DataTable dt = new DataTable();

            dt = dlSolicitud.ObtenerEstadosDetalle(estadoId);

            LlenarControles.llenarDDLs(ddlGenerico, dt);
        }

        public void ObtenerPrioridades(DropDownList ddlGenerico)
        {
            DataTable dt = new DataTable();

            dt = dlSolicitud.ObtenerPrioridades();

            LlenarControles.llenarDDLs(ddlGenerico, dt);
        }

        public void ObtenerIdiomas(DropDownList ddlGenerico)
        {
            DataTable dt = new DataTable();

            dt = dlSolicitud.ObtenerIdiomas();

            LlenarControles.llenarDDLs(ddlGenerico, dt);
        }

        public DataTable ObtenerDocumentosSolicitudes(GridView gvDoc, int Id_CerrarSolicitud)
        {
            DataTable dt = new DataTable();

            dt = dlSolicitud.ObtenerDocumentosSolicitudes(Id_CerrarSolicitud);

            LlenarControles.LlenarGrid(gvDoc, dt);

            return dt;
        }

        public DataTable ObtenerDocumentosSolicitudesPorID(int Id_Documento)
        {
            DataTable dt = new DataTable();

            dt = dlSolicitud.ObtenerDocumentosSolicitudesPorID(Id_Documento);

            return dt;
        }

        public string InsertSolicitud(string Fecha, string UsuarioSolicita, string Organizacion, int Objeto_Id, string TituloSolicitud, string DescripcionProblema, string Departamento, int Problema_ID, int LugarSolicitud_ID, int Usuario_ID)
        {
            string resultado = string.Empty;

            try
            {
                resultado = dlSolicitud.InsertSolicitud(Fecha, UsuarioSolicita, Organizacion, Objeto_Id, TituloSolicitud, DescripcionProblema, Departamento, Problema_ID, LugarSolicitud_ID, Usuario_ID);

            }
            catch (Exception ex)
            {
                resultado = ex.Message;
            }

            return resultado;
        }

        public string UpdateSolicitud(int id_Registro, string Fecha, string UsuarioSolicita, string Organizacion, int Objeto_Id, string TituloSolicitud, string DescripcionProblema, string Departamento, int Problema_ID, int LugarSolicitud_ID)
        {
            string resultado = string.Empty;

            try
            {
                resultado = dlSolicitud.UpdateSolicitud(id_Registro, Fecha, UsuarioSolicita, Organizacion, Objeto_Id, TituloSolicitud, DescripcionProblema, Departamento, Problema_ID, LugarSolicitud_ID);
            }
            catch (Exception ex)
            {
                resultado = ex.Message;
            }

            return resultado;
        }

        public string InsertUpdateDetalleSolicitud(int Solicitud_ID, int Id_CerrarSolicitud, int Estado_ID, int EstadoDetalle_ID, int Prioridad_ID, int Idioma_ID, bool FechaFinalPrevista, bool ClienteRecibioInformacion, bool MaterialReemplazado, bool DebeCrearseBoletin)
        {
            string resultado = string.Empty;

            try
            {
                resultado = dlSolicitud.InsertUpdateDetalleSolicitud(Solicitud_ID, Id_CerrarSolicitud, Estado_ID, EstadoDetalle_ID, Prioridad_ID, Idioma_ID, FechaFinalPrevista, ClienteRecibioInformacion, MaterialReemplazado, DebeCrearseBoletin);
            }
            catch (Exception ex)
            {
                resultado = ex.Message;
            }

            return resultado;
        }

        public string InsertDocumentoSolicitud(int CerrarSolicitud_ID, string nombreDoc, string tipoContenido, byte[] doc)
        {
            string resultado = string.Empty;

            try
            {
                resultado = dlSolicitud.InsertDocumentoSolicitud(CerrarSolicitud_ID, nombreDoc, tipoContenido, doc);
            }
            catch (Exception ex)
            {
                resultado = ex.Message;
            }

            return resultado;
        }
    }
}
