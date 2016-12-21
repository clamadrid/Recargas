using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BitGray.WebAPIRecargas.Controllers
{
    public class ConsumoController : ApiController
    {
        private Services.ConsumoRepository consumoRepository;

        public ConsumoController()
        {
            this.consumoRepository = new Services.ConsumoRepository();
        }

        [HttpGet()]
        public IEnumerable<Models.Consumo> ObtenerConsumo()
        {           
            return this.consumoRepository.ObtenerConsumos();
        }

        [System.Web.Http.AcceptVerbs("GET", "POST")]
        [System.Web.Http.HttpGet]
        [Route("api/Saldo/{consumo}/{saldoSegundos}/{celular}")]
        public bool ValidarConsumo(int consumo, int saldoSegundos, string celular)
        {
            return this.consumoRepository.ValidarConsumo(consumo, celular);
        }

        public HttpResponseMessage CrearConsumo(Models.Consumo consumo)
        {            
            this.consumoRepository.CrearConsumo(consumo);
            return Request.CreateResponse<Models.Consumo>(System.Net.HttpStatusCode.Created, consumo);
        }
    }
}
