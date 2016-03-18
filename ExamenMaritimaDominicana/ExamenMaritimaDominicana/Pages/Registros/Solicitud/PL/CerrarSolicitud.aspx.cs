using ExamenMaritimaDominicana.Pages.Master.BL;
using ExamenMaritimaDominicana.Pages.Solicitud.BL;
using System;
using System.Data;
using System.IO;
using System.Text;
using System.Web;
using System.Web.UI.WebControls;

namespace ExamenMaritimaDominicana.Pages.Registros.Solicitud.PL
{
    public partial class CerrarSolicitud : System.Web.UI.Page
    {
        blCrearSolicitud registro = new blCrearSolicitud();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LlenarControles.LlenarGrid(GridView1, new DataTable());

                registro.ObtenerTituloSolicitudes(ddlTituloSolicitud);
                registro.ObtenerEstados(ddlEstado);
                registro.ObtenerPrioridades(ddlPrioridad);
                registro.ObtenerIdiomas(ddlIdioma);

                if (ddlTituloSolicitud.Items.Count > 0)
                {
                    ddlTituloSolicitud_SelectedIndexChanged(null, null);
                }

                if (ddlEstado.Items.Count > 0)
                {
                    ddlEstado_SelectedIndexChanged(null, null);
                }               
            }
        }

        protected void ddlEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            registro.ObtenerEstadosDetalle(ddlEstadoDetalle, int.Parse(ddlEstado.SelectedValue));
        }

        protected void ddlTituloSolicitud_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt = registro.ObtenerSolicitudesPorId(int.Parse(ddlTituloSolicitud.SelectedValue));

            Session["dtDocumentos"] = dt;

            foreach (DataRow item in dt.Rows)
            {
                Session["Id_CerrarSolicitud"] = item["Id_CerrarSolicitud"].ToString();

                lblGrupoSoporte.Text = item["Departamento"].ToString();
                lblRegistradoPor.Text = item["UsuarioSolicita"].ToString();
                lblOrganizacion.Text = item["Organizacion"].ToString();
                lblRegistradoPara.Text = item["UsuarioSolicita"].ToString();

                if (int.Parse(Session["Id_CerrarSolicitud"].ToString()) > 0)
                {
                    ddlEstado.SelectedValue = item["Estado_ID"].ToString();

                    if (ddlEstado.Items.Count > 0)
                    {
                        ddlEstado_SelectedIndexChanged(null, null);
                    }

                    ddlEstadoDetalle.SelectedValue = item["EstadoDetalle_ID"].ToString();
                    ddlPrioridad.SelectedValue = item["Prioridad_ID"].ToString();
                    ddlIdioma.SelectedValue = item["Idioma_ID"].ToString();
                    chkFechaFinalPrevista.Checked = Convert.ToBoolean(item["FechaFinalPrevista"]);
                    rblClienteFormacion.SelectedValue = Convert.ToInt32(item["ClienteRecibioInformacion"]).ToString();
                    rblMaterialReemplazado.SelectedValue = Convert.ToInt32(item["MaterialReemplazado"]).ToString();
                    rblBoletinInformativo.SelectedValue = Convert.ToInt32(item["DebeCrearseBoletin"]).ToString();

                    registro.ObtenerDocumentosSolicitudes(GridView1, int.Parse(Session["Id_CerrarSolicitud"].ToString()));
                }
                else
                {
                    Session["Id_CerrarSolicitud"] = "0";
                    ddlEstado.SelectedIndex = 0;

                    if (ddlEstado.Items.Count > 0)
                    {
                        ddlEstado_SelectedIndexChanged(null, null);
                    }

                    ddlEstadoDetalle.SelectedIndex = 0;
                    ddlPrioridad.SelectedIndex = 0;
                    ddlIdioma.SelectedIndex = 0;
                    chkFechaFinalPrevista.Checked = false;
                    rblClienteFormacion.SelectedValue = "0";
                    rblMaterialReemplazado.SelectedValue = "0";
                    rblBoletinInformativo.SelectedValue = "0";

                    LlenarControles.LlenarGrid(GridView1, new DataTable());
                }

                lblMensaje.Text = string.Empty;
            }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;

            try
            {
                int id_CerrarSolicitud = Session["Id_CerrarSolicitud"].ToString().Length == 0 ? 0 : int.Parse(Session["Id_CerrarSolicitud"].ToString());

                resultado = registro.InsertUpdateDetalleSolicitud(int.Parse(ddlTituloSolicitud.SelectedValue), id_CerrarSolicitud, int.Parse(ddlEstado.SelectedValue), int.Parse(ddlEstadoDetalle.SelectedValue), int.Parse(ddlPrioridad.SelectedValue), int.Parse(ddlIdioma.SelectedValue), chkFechaFinalPrevista.Checked, Convert.ToBoolean(int.Parse(rblClienteFormacion.SelectedValue.ToString())), Convert.ToBoolean(int.Parse(rblMaterialReemplazado.SelectedValue.ToString())), Convert.ToBoolean(int.Parse(rblBoletinInformativo.SelectedValue.ToString())));

                lblMensaje.Text = resultado;
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }            
        }

        protected void Upload(object sender, EventArgs e)
        {
            string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
            string contentType = FileUpload1.PostedFile.ContentType;

            using (Stream fs = FileUpload1.PostedFile.InputStream)
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    byte[] bytes = br.ReadBytes((Int32)fs.Length);

                    string resultado = string.Empty;

                    try
                    {
                        int id_CerrarSolicitud = Session["Id_CerrarSolicitud"].ToString().Length == 0 ? 0 : int.Parse(Session["Id_CerrarSolicitud"].ToString());

                        resultado = registro.InsertDocumentoSolicitud(id_CerrarSolicitud, filename, contentType, bytes);

                        lblMensaje.Text = resultado;
                    }
                    catch (Exception ex)
                    {
                        lblMensaje.Text = ex.Message;
                    }

                }
            }
            Response.Redirect(Request.Url.AbsoluteUri);

            registro.ObtenerSolicitudes(GridView1);
        }

        protected void DownloadFile(object sender, EventArgs e)
        {
            int id = int.Parse((sender as LinkButton).CommandArgument);
            byte[] bytes = null;
            string fileName = "";
            string contentType = "";

            DataTable dt = registro.ObtenerDocumentosSolicitudesPorID(id);

            if (dt.Rows.Count > 0)
            {
                DataRow fila = dt.Rows[0];

                bytes = (byte[])fila["Documento"];
                contentType = fila["TipoContenido"].ToString();
                fileName = fila["NombreDoc"].ToString();
            }
            Response.Clear();
            Response.Buffer = true;
            Response.Charset = "";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = contentType;
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);
            Response.BinaryWrite(bytes);
            Response.Flush();
            Response.End();
        }
    }
}