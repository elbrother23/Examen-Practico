using ExamenMaritimaDominicana.Pages.Master.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ExamenMaritimaDominicana.Pages.Registros.AsignarTickets.DL
{
    public class dlAsignarTiquets
    {
        public DataTable ObtenerUsuarios()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(dlConexionBd.ObtenerConexionBd());
                SqlCommand command = new SqlCommand("Select * From tb_Usuarios", conn);
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

        public DataTable ObtenerSolicitudesPorAsignar(int usuarioId)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(dlConexionBd.ObtenerConexionBd());
                SqlCommand command = new SqlCommand(@"Select * 
                                                      From vw_Solicitudes s
                                                      Where s.Id_Registro NOT IN (Select at.Solicitud_ID From tb_AsignarTiquets at)", conn);
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

        public DataTable ObtenerSolicitudesAsignadasPorUsuarioId(int usuarioId)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(dlConexionBd.ObtenerConexionBd());
                SqlCommand command = new SqlCommand(@"Select s.*, at.* 
                                                      From vw_Solicitudes s
                                                         Left Join tb_AsignarTiquets at On at.Solicitud_ID = s.Id_Registro 
                                                      Where at.Usuario_ID = " + usuarioId, conn);
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

        public string InsertAsignarSolicitud(int Solicitud_ID, int Usuario_ID)
        {
            string resultado = string.Empty;

            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(dlConexionBd.ObtenerConexionBd());
                SqlCommand command = new SqlCommand("sp_InsertAsignarTiquets", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Solicitud_ID", Solicitud_ID);
                command.Parameters.AddWithValue("@Usuario_ID", Usuario_ID);

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

        public string DeleteAsignarSolicitud(int Id_AsignarTiquet)
        {
            string resultado = string.Empty;

            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(dlConexionBd.ObtenerConexionBd());
                SqlCommand command = new SqlCommand("sp_DeleteAsignarTiquets", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Id_AsignarTiquet", Id_AsignarTiquet);

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
