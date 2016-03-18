using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;

namespace ExamenMaritimaDominicana.Pages.Master.BL
{
    public class LlenarControles
    {
        public static void LlenarGrid(GridView gvGenerico, DataTable dt, int editIndex = -1)
        {
            gvGenerico.EditIndex = editIndex;
            gvGenerico.DataSource = dt;
            gvGenerico.DataBind();
        }

        public static void llenarDDLs(DropDownList ddl, DataTable dt, bool insertarTodos = false)
        {
            //ddl.DataSource = null;
            //ddl.DataBind();

            ddl.DataSource = dt;
            ddl.DataBind();

            if (ddl.Items.Count == 0 || insertarTodos)
            {
                ddl.Items.Insert(0, "");
                ddl.Items[0].Value = "0";
            }
        }
    }
}
