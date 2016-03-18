using System.Configuration;

namespace ExamenMaritimaDominicana.Pages.Master.DL
{
    public class dlConexionBd
    {
        public static string ObtenerConexionBd()
        {
            string conn = "";

            conn = ConfigurationManager.ConnectionStrings["db_MaritimaDominicana"].ConnectionString;

            return conn;
        }
    }
}
