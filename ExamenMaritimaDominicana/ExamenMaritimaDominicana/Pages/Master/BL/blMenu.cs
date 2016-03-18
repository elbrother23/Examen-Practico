using ExamenMaritimaDominicana.Pages.Master.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;

namespace ExamenMaritimaDominicana.Pages.Master.BL
{
    public class blMenu
    {
        public static void ObtenerMenu(Menu miMenu)
        {
            DataTable dt = dlMenu.ObtenerMenu();

            DataView dtView = dt.DefaultView;
            dtView.RowFilter = "Padre = 0";

            foreach (DataRowView item in dtView)
            {
                MenuItem menuItem = new MenuItem(item["Descripcion"].ToString(), item["ID"].ToString());
                miMenu.Items.Add(menuItem);

                ObtenerMenuDetalle(dt, miMenu, menuItem);
            }
        }

        public static void ObtenerMenuDetalle(DataTable dt, Menu miMenu, MenuItem menuItem)
        {
            DataView dtView = dt.DefaultView;
            dtView.RowFilter = "Padre = " + menuItem.Value;
            
            foreach (DataRowView item in dtView)
            {
                MenuItem menuItemDetalle = new MenuItem(item["Descripcion"].ToString(), item["ID"].ToString());
                menuItem.ChildItems.Add(menuItemDetalle);
                
               // miMenu.Items.Add(menuItemDetalle);

                ObtenerMenuDetalle(dt, miMenu, menuItemDetalle);
            }
        }
    }
}
