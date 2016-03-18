using ExamenMaritimaDominicana.Pages.Master.BL;
using System;

namespace ExamenMaritimaDominicana.Pages
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               // blMenu.ObtenerMenu(MenuBar);
            }
        }
    }
}