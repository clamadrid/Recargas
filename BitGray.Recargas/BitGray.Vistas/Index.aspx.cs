using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BitGray.Vistas
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ObtenerParametroActual();
        }

        private void ObtenerParametroActual()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:36839/");

            HttpResponseMessage response = client.GetAsync("api/Parametros").Result;
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            if (response.IsSuccessStatusCode)
            {
                var parameter = response.Content.ReadAsAsync<Entidades.Parametros>().Result;
                Entidades.ConfiguracionGlobal.costoXSegundo = parameter.valor;
                Entidades.ConfiguracionGlobal.idParametro = parameter.idParametro;
            }
        }
    }
}