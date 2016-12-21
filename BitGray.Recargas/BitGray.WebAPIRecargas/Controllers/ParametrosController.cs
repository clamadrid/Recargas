using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BitGray.WebAPIRecargas.Controllers
{
    public class ParametrosController : ApiController
    {
        private Services.ParametrosRepository parametrosRepository;

        public ParametrosController()
        {
            this.parametrosRepository = new Services.ParametrosRepository();
        }
        
        public Models.Parametro GetParametros()
        {            
            return this.parametrosRepository.GetParametroActual();
        }

        public HttpResponseMessage CrearParametros(Models.Parametro parametros)
        {           
            this.parametrosRepository.CrearCosto(parametros);
            return Request.CreateResponse<Models.Parametro>(System.Net.HttpStatusCode.Created, parametros);
        }
    }
}
