using ExamenMaritimaDominicana.Pages.Master.DL;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ExamenMaritimaDominicana.Pages.Solicitud.DL
{
    public class dlCrearSolicitud
    {
        public DataTable ObtenerObjetos()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(dlConexionBd.ObtenerConexionBd());
                SqlCommand command = new SqlCommand("Select * From tb_Objetos", conn);
                command.CommandType = CommandType.Text;

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlDataAdapter adp = new SqlDataAdapter(command);
                adp.Fill(dt);
            }
            catch (Exception)
            {
            }

            return dt;
        }

        public DataTable ObtenerProblemas()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(dlConexionBd.ObtenerConexionBd());
                SqlCommand command = new SqlCommand("Select * From tb_Problemas", conn);
                command.CommandType = CommandType.Text;

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlDataAdapter adp = new SqlDataAdapter(command);
                adp.Fill(dt);
            }
            catch (Exception)
            {
            }

            return dt;
        }

        public DataTable ObtenerLugares()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(dlConexionBd.ObtenerConexionBd());
                SqlCommand command = new SqlCommand("Select * From tb_LugarSolicitud", conn);
                command.CommandType = CommandType.Text;

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlDataAdapter adp = new SqlDataAdapter(command);
                adp.Fill(dt);
            }
            catch (Exception)
            {
            }

            return dt;
        }

        public DataTable ObtenerTituloSolicitudes()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(dlConexionBd.ObtenerConexionBd());
                SqlCommand command = new SqlCommand("Select Id_Registro, TituloSolicitud From tb_Solicitudes", conn);
                command.CommandType = CommandType.Text;

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlDataAdapter adp = new SqlDataAdapter(command);
                adp.Fill(dt);
            }
            catch (Exception ex)
            {
            }

            return dt;
        }

        public DataTable ObtenerSolicitudes()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(dlConexionBd.ObtenerConexionBd());
                SqlCommand command = new SqlCommand("Select * From vw_Solicitudes", conn);
                command.CommandType = CommandType.Text;

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlDataAdapter adp = new SqlDataAdapter(command);
                adp.Fill(dt);
            }
            catch (Exception)
            {
            }

            return dt;
        }

        public DataTable ObtenerSolicitudesPorId(int solicitudId)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(dlConexionBd.ObtenerConexionBd());
                SqlCommand command = new SqlCommand("Select * From vw_Solicitudes Where Id_Registro = " + solicitudId, conn);
                command.CommandType = CommandType.Text;

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlDataAdapter adp = new SqlDataAdapter(command);
                adp.Fill(dt);
            }
            catch (Exception)
            {
            }

            return dt;
        }

        public DataTable ObtenerEstados()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(dlConexionBd.ObtenerConexionBd());
                SqlCommand command = new SqlCommand("Select * From tb_Estados", conn);
                command.CommandType = CommandType.Text;

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlDataAdapter adp = new SqlDataAdapter(command);
                adp.Fill(dt);
            }
            catch (Exception)
            {
            }

            return dt;
        }

        public DataTable ObtenerEstadosDetalle(int estadoId)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(dlConexionBd.ObtenerConexionBd());
                SqlCommand command = new SqlCommand("Select * From tb_EstadosDetalle Where Estado_ID = " + estadoId, conn);
                command.CommandType = CommandType.Text;

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlDataAdapter adp = new SqlDataAdapter(command);
                adp.Fill(dt);
            }
            catch (Exception)
            {
            }

            return dt;
        }

        public DataTable ObtenerPrioridades()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(dlConexionBd.ObtenerConexionBd());
                SqlCommand command = new SqlCommand("Select * From tb_Prioridad", conn);
                command.CommandType = CommandType.Text;

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlDataAdapter adp = new SqlDataAdapter(command);
                adp.Fill(dt);
            }
            catch (Exception)
            {
            }

            return dt;
        }

        public DataTable ObtenerIdiomas()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(dlConexionBd.ObtenerConexionBd());
                SqlCommand command = new SqlCommand("Select * From tb_Idioma", conn);
                command.CommandType = CommandType.Text;

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlDataAdapter adp = new SqlDataAdapter(command);
                adp.Fill(dt);
            }
            catch (Exception)
            {
            }

            return dt;
        }

        public DataTable ObtenerDocumentosSolicitudes(int Id_CerrarSolicitud)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(dlConexionBd.ObtenerConexionBd());
                SqlCommand command = new SqlCommand("Select * From tb_DocumentosSolicitudes Where CerrarSolicitud_Id=" + Id_CerrarSolicitud+"", conn);
                command.CommandType = CommandType.Text;
                
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlDataReader reader = command.ExecuteReader();

                dt.Load(reader);
            }
            catch (Exception)
            {
            }

            return dt;
        }

        public DataTable ObtenerDocumentosSolicitudesPorID(int Id_Documento)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(dlConexionBd.ObtenerConexionBd());
                SqlCommand command = new SqlCommand("Select * From tb_DocumentosSolicitudes Where Id_Documento=" + Id_Documento + "", conn);
                command.CommandType = CommandType.Text;

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlDataReader reader = command.ExecuteReader();

                dt.Load(reader);
            }
            catch (Exception)
            {
            }

            return dt;
        }

        public string InsertSolicitud(string Fecha, string UsuarioSolicita, string Organizacion, int Objeto_Id, string TituloSolicitud, string DescripcionProblema, string Departamento, int Problema_ID, int LugarSolicitud_ID, int Usuario_ID)
        {
            string resultado = string.Empty;

            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(dlConexionBd.ObtenerConexionBd());
                SqlCommand command = new SqlCommand("sp_InsertSolicitud", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Fecha", Fecha);
                command.Parameters.AddWithValue("@UsuarioSolicita", UsuarioSolicita);
                command.Parameters.AddWithValue("@Organizacion", Organizacion);
                command.Parameters.AddWithValue("@Objeto_Id", Objeto_Id);
                command.Parameters.AddWithValue("@TituloSolicitud", TituloSolicitud);
                command.Parameters.AddWithValue("@DescripcionProblema", DescripcionProblema);
                command.Parameters.AddWithValue("@Departamento", Departamento);
                command.Parameters.AddWithValue("@Problema_ID", Problema_ID);
                command.Parameters.AddWithValue("@LugarSolicitud_ID", LugarSolicitud_ID);
                command.Parameters.AddWithValue("@Id_Usuario", Usuario_ID);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                resultado = command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                resultado = ex.Message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return resultado;
        }

        public string UpdateSolicitud(int Id_Registro, string Fecha, string UsuarioSolicita, string Organizacion, int Objeto_Id, string TituloSolicitud, string DescripcionProblema, string Departamento, int Problema_ID, int LugarSolicitud_ID)
        {
            string resultado = string.Empty;

            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(dlConexionBd.ObtenerConexionBd());
                SqlCommand command = new SqlCommand("sp_UpdateSolicitud", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Id_Registro", Id_Registro);
                command.Parameters.AddWithValue("@Fecha", Fecha);
                command.Parameters.AddWithValue("@UsuarioSolicita", UsuarioSolicita);
                command.Parameters.AddWithValue("@Organizacion", Organizacion);
                command.Parameters.AddWithValue("@Objeto_Id", Objeto_Id);
                command.Parameters.AddWithValue("@TituloSolicitud", TituloSolicitud);
                command.Parameters.AddWithValue("@DescripcionProblema", DescripcionProblema);
                command.Parameters.AddWithValue("@Departamento", Departamento);
                command.Parameters.AddWithValue("@Problema_ID", Problema_ID);
                command.Parameters.AddWithValue("@LugarSolicitud_ID", LugarSolicitud_ID);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                resultado = command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                resultado = ex.Message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return resultado;
        }

        public string InsertUpdateDetalleSolicitud(int Solicitud_ID, int Id_CerrarSolicitud, int Estado_ID, int EstadoDetalle_ID, int Prioridad_ID, int Idioma_ID, bool FechaFinalPrevista, bool ClienteRecibioInformacion, bool MaterialReemplazado, bool DebeCrearseBoletin)
        {
            string resultado = string.Empty;

            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(dlConexionBd.ObtenerConexionBd());
                SqlCommand command = new SqlCommand("sp_InsertUpdateDetalleSolicitud", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Solicitud_ID", Solicitud_ID);
                command.Parameters.AddWithValue("@Id_CerrarSolicitud", Id_CerrarSolicitud);
                command.Parameters.AddWithValue("@Estado_ID", Estado_ID);
                command.Parameters.AddWithValue("@EstadoDetalle_ID", EstadoDetalle_ID);
                command.Parameters.AddWithValue("@Prioridad_ID", Prioridad_ID);
                command.Parameters.AddWithValue("@Idioma_ID", Idioma_ID);
                command.Parameters.AddWithValue("@FechaFinalPrevista", FechaFinalPrevista);
                command.Parameters.AddWithValue("@ClienteRecibioInformacion", ClienteRecibioInformacion);
                command.Parameters.AddWithValue("@MaterialReemplazado", MaterialReemplazado);
                command.Parameters.AddWithValue("@DebeCrearseBoletin", DebeCrearseBoletin);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                resultado = command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                resultado = ex.Message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return resultado;
        }

        public string InsertDocumentoSolicitud(int CerrarSolicitud_ID, string nombreDoc, string tipoContenido, byte[] doc)
        {
            string resultado = string.Empty;

            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(dlConexionBd.ObtenerConexionBd());
                SqlCommand command = new SqlCommand("sp_InsertDocumentoSolicitudes", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@CerrarSolicitud_ID", CerrarSolicitud_ID);
                command.Parameters.AddWithValue("@NombreDoc", nombreDoc);
                command.Parameters.AddWithValue("@TipoContenido", tipoContenido);
                command.Parameters.AddWithValue("@Documento", doc);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                resultado = command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                resultado = ex.Message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return resultado;
        }
    }
}
