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
    public partial class HistorialRecargas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApi"]);

            HttpResponseMessage response = client.GetAsync("api/Recargas/" + this.txtCelular.Text.Trim()).Result;
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            if (response.IsSuccessStatusCode)
            {
                var consumo = response.Content.ReadAsAsync<IEnumerable<Entidades.Recargas>>().Result;
                this.grdRecargas.DataSource = consumo;
                this.grdRecargas.DataBind();
            }
        }
    }
}