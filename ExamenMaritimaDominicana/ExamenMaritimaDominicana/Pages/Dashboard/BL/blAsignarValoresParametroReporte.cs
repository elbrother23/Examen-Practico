using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace ExamenMaritimaDominicana.Pages.Dashboard.BL
{
    class blAsignarValoresParametroReporte
    {
        public static void asignarValoresParametrosReporte(ArrayList al, ParameterValues pv)
        {
            for (int i = 0; i < al.Count; i++)
            {
                ParameterDiscreteValue dv = new ParameterDiscreteValue();
                dv.Value = al[i];
                pv.Add(dv);
            }
        }

        public static void Parametros(ReportDocument reporte, List<KeyValuePair<string, object>> parametros)
        {
        }

        public static void CambiarConexionBd(ReportDocument reporte, string institucion)
        {
            string clave = ConfigurationManager.ConnectionStrings[institucion].ConnectionString.ToString().Split(';')[1].ToString().Split('=')[1];
            string usuario = ConfigurationManager.ConnectionStrings[institucion].ConnectionString.ToString().Split(';')[2].ToString().Split('=')[1];
            TableLogOnInfo oLogOn; foreach (Table tbCurrent in reporte.Database.Tables) { oLogOn = tbCurrent.LogOnInfo; oLogOn.ConnectionInfo.DatabaseName = ConfigurationManager.ConnectionStrings[institucion].ConnectionString.ToString().Split(';')[3].Split('=')[1]; oLogOn.ConnectionInfo.UserID = usuario; oLogOn.ConnectionInfo.Password = clave; oLogOn.ConnectionInfo.ServerName = ConfigurationManager.ConnectionStrings[institucion].ConnectionString.ToString().Split(';')[0].Split('=')[1]; oLogOn.ConnectionInfo.Type = ConnectionInfoType.SQL; tbCurrent.ApplyLogOnInfo(oLogOn); }
            for (int i = 0; i < reporte.Subreports.Count; i++) { foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in reporte.Subreports[i].Database.Tables) { oLogOn = tbCurrent.LogOnInfo; if (!reporte.Subreports[i].Name.Contains("Header")) oLogOn.ConnectionInfo.DatabaseName = ConfigurationManager.ConnectionStrings[institucion].ConnectionString.ToString().Split(';')[3].Split('=')[1]; else oLogOn.ConnectionInfo.DatabaseName = ConfigurationManager.ConnectionStrings["IQ_Acceso"].ConnectionString.ToString().Split(';')[3].Split('=')[1]; oLogOn.ConnectionInfo.UserID = usuario; oLogOn.ConnectionInfo.Password = clave; oLogOn.ConnectionInfo.ServerName = ConfigurationManager.ConnectionStrings[institucion].ConnectionString.ToString().Split(';')[0].Split('=')[1]; oLogOn.ConnectionInfo.Type = ConnectionInfoType.SQL; tbCurrent.ApplyLogOnInfo(oLogOn); } }
        }
    }
}
