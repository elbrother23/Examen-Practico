using ExamenMaritimaDominicana.Pages.Master.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ExamenMaritimaDominicana.Pages.Usuarios.DL
{
    public class dlUsuarios
    {
        public DataTable ObtenerUsuarios()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(dlConexionBd.ObtenerConexionBd());
                SqlCommand command = new SqlCommand("Select * From tb_Usuarios",conn);
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

        public string InsertUsuarios(string Usuario, string clave)
        {
            string resultado = string.Empty;

            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(dlConexionBd.ObtenerConexionBd());
                SqlCommand command = new SqlCommand("sp_InsertUsuarios", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Descripcion", Usuario);
                command.Parameters.AddWithValue("@Clave", clave);

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

        public string UpdateUsuarios(int id_Usuario, string Usuario, string clave)
        {
            string resultado = string.Empty;

            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(dlConexionBd.ObtenerConexionBd());
                SqlCommand command = new SqlCommand("sp_UpdateUsuarios", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Id_Usuario", id_Usuario);
                command.Parameters.AddWithValue("@Descripcion", Usuario);
                command.Parameters.AddWithValue("@Clave", clave);

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

        public string DeleteUsuarios(int id_Usuario)
        {
            string resultado = string.Empty;

            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(dlConexionBd.ObtenerConexionBd());
                SqlCommand command = new SqlCommand("sp_DeleteUsuarios", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Id_Usuario", id_Usuario);

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
