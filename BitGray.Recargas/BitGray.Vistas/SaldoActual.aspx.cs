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
    public partial class SaldoActual : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        private void ObtenerSaldoDisponible()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApi"]);

            string celular = this.txtCelular.Text.Trim();

            HttpResponseMessage response = client.GetAsync("api/Saldo/"+celular).Result;
            
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            if (response.IsSuccessStatusCode)
            {
                var parameter = response.Content.ReadAsAsync<Entidades.Saldo>().Result;

                if (parameter != null)
                {
                    this.lblDisponibleDinero.Text = parameter.saldoPesos.ToString();
                    this.lblDisponibleSegundos.Text = parameter.saldoSegundos.ToString();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("El número celular no tiene saldo disponible");
                }
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            ObtenerSaldoDisponible();
        }
    }
}