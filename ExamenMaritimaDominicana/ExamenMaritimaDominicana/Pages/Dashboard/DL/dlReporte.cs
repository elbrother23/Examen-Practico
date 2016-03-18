using ExamenMaritimaDominicana.Pages.Master.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ExamenMaritimaDominicana.Pages.Dashboard.DL
{
    class dlReporte
    {
        public DataTable ObtenerSolicitudes(string fechaDesde, string fechaHasta)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(dlConexionBd.ObtenerConexionBd());
                SqlCommand command = new SqlCommand("sp_HistoricoSolicitudes", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                command.Parameters.AddWithValue("@FechaHasta", fechaHasta);

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
