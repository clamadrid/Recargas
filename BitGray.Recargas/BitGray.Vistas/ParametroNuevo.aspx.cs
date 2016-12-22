using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BitGray.Vistas
{
    public partial class ParametroNuevo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApi"]);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Entidades.Parametros parametro = new Entidades.Parametros();
            parametro.valor = int.Parse(this.txtCosto.Text);
            parametro.fechaParametro = DateTime.Now;
            parametro.esActual = this.chkVigente.Checked;

            var response = client.PostAsJsonAsync("api/Parametros", parametro).Result;
            if (response.IsSuccessStatusCode)
            {
                System.Windows.Forms.MessageBox.Show("El parámetro ha sido creado exitosamente");
            }

            if (this.chkVigente.Checked)
            {
                //Se debe actualizar el parametro porque ya cambio.
            }
        }
    }
}