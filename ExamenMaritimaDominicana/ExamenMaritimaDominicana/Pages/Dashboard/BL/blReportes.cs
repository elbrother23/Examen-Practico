using ExamenMaritimaDominicana.Pages.Dashboard.DL;
using System.Data;

namespace ExamenMaritimaDominicana.Pages.Dashboard.BL
{
    class blReportes
    {
        dlReporte reporte = new dlReporte();
        public DataTable ObtenerSolicitudes(string fechaDesde, string fechaHasta)
        {
            return reporte.ObtenerSolicitudes(fechaDesde, fechaHasta);
        }
    }
}
