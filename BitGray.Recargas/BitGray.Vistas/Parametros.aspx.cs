using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http.Formatting;
using Newtonsoft.Json;
using BitGray.Entidades;

namespace BitGray.Vistas
{
    public partial class Parametros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.ObtenerParametroActual();
            }
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

                if (parameter != null)
                {
                    this.txtParametroActual.Text = parameter.valor.ToString();
                }
            }
        }
    
    }
}