using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BitGray.WebAPIRecargas.Controllers
{
    public class SaldoController : ApiController
    {
        private Services.SaldoRepository saldoRepository;

        public SaldoController()
        {
            this.saldoRepository = new Services.SaldoRepository();
        }

        [System.Web.Http.AcceptVerbs("GET", "POST")]
        [System.Web.Http.HttpGet]
        [Route("api/Saldo/{celular}")]
        public Models.Saldo ObtenerSaldo(string celular)
        {
             return this.saldoRepository.ObtenerSaldoDisponible(celular);
        }
    }
}
