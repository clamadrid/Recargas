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
    public partial class Recargas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApi"]);

            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            Entidades.Recargas recargas = new Entidades.Recargas();
            recargas.celular = this.txtCelular.Text.Trim();
            recargas.valor = int.Parse(this.txtValor.Text.Trim());
            recargas.fechaVigencia = DateTime.Now.AddDays(-30);
            recargas.fechaRecarga = DateTime.Now;
            recargas.idParametros = Entidades.ConfiguracionGlobal.idParametro;
            var response = client.PostAsJsonAsync("api/Recargas", recargas).Result;
            if (response.IsSuccessStatusCode)
            {
                System.Windows.Forms.MessageBox.Show("La Recarga ha sido creado exitosamente");
            }
        }
    }
}