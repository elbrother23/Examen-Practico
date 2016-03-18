using ExamenMaritimaDominicana.Pages.Master.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ExamenMaritimaDominicana.Pages.Master.BL
{
    class blLogIn
    {
        dlLogIn logIn = new dlLogIn();
        public DataTable ValidarLogIn(string usuario, string clave)
        {
            DataTable dt = logIn.ValidarLogIn(usuario, clave);

            return dt;
        }
    }
}
