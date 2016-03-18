
using System;
using System.Data;
using System.Data.SqlClient;

namespace ExamenMaritimaDominicana.Pages.Master.DL
{
    public class dlMenu
    {
        public static DataTable ObtenerMenu()
        {
            SqlConnection conn = new SqlConnection(dlConexionBd.ObtenerConexionBd());
            DataTable dt = new DataTable();

            try
            {               
                SqlCommand command = new SqlCommand("Select * From tb_Menu", conn);
                SqlDataAdapter adp = new SqlDataAdapter(command);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                adp.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally 
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return dt;
        }
    }
}
