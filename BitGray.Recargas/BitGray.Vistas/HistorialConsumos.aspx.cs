using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BitGray.Vistas
{
    public partial class HistorialConsumos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ObtenerHistorialRecargas();
        }

        private void ObtenerHistorialRecargas()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:36839/");

            HttpResponseMessage response = client.GetAsync("api/Consumo").Result;
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            if (response.IsSuccessStatusCode)
            {
                var consumo = response.Content.ReadAsAsync<IEnumerable<Entidades.Consumo>>().Result;
                this.grdConsumos.DataSource = consumo;
                this.grdConsumos.DataBind();
            }
        }
    }
}