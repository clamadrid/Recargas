using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace BitGray.WebAPIRecargas.Controllers
{
    public class RecargasController : ApiController
    {
        private Services.RecargasRepository recargasRepository;

        public RecargasController()
        {
            this.recargasRepository = new Services.RecargasRepository();
        }

        [System.Web.Http.AcceptVerbs("GET", "POST")]
        [System.Web.Http.HttpGet]
        [Route("api/Recargas/{celular}")]
        public List<Models.Recarga>GetRecargas(string celular)
        {           
            return this.recargasRepository.GetRecargas(celular);
        }

        public HttpResponseMessage CrearRecarga(Models.Recarga recarga)
        {         
            this.recargasRepository.CrearRecarga(recarga);
            return Request.CreateResponse<Models.Recarga>(System.Net.HttpStatusCode.Created, recarga);
        }



    }
}
