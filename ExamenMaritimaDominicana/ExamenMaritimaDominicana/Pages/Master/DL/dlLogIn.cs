using System;
using System.Data;
using System.Data.SqlClient;

namespace ExamenMaritimaDominicana.Pages.Master.DL
{
    public class dlLogIn
    {
        public DataTable ValidarLogIn(string usuario, string clave)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(dlConexionBd.ObtenerConexionBd());
                SqlCommand command = new SqlCommand(String.Format("Select * From tb_Usuarios Where Descripcion='{0}' And Clave='{1}'", usuario, clave), conn);
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
    }
}
