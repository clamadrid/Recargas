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
    public partial class Consumo : System.Web.UI.Page
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
             Entidades.Consumo consumo = new Entidades.Consumo();
            consumo.celular = this.txtCelular.Text.Trim();
            consumo.fechaConsumo = DateTime.Now;
            consumo.consumo1 = int.Parse(this.txtValor.Text.Trim());
            consumo.idParametro= Entidades.ConfiguracionGlobal.idParametro;
            var response = client.PostAsJsonAsync("api/Consumo", consumo).Result;
            if (response.IsSuccessStatusCode)
            {
                System.Windows.Forms.MessageBox.Show("El consumo ha sido creado exitosamente");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Ocurrio un error al crear el consumo");
            }
        }

        private bool ValidarConsumos()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApi"]);

            string celular = this.txtCelular.Text.Trim();
            
            HttpResponseMessage response = client.GetAsync("api/Saldo/" +this.txtValor.Text.Trim() +"/"+ celular).Result;

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}