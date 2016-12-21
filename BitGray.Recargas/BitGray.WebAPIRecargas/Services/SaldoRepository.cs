using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitGray.WebAPIRecargas.Services
{
    public class SaldoRepository
    {
        private BitGray.Log.Log log = new Log.Log();
        public Models.Saldo ObtenerSaldoDisponible(string celular)
        {

            Models.Saldo saldo = null;
            try
            {
                using (var ctx = new BDRecargasEntities())
                {                  
                    saldo = (from obj in ctx.Saldos where obj.celular.Equals(celular) select obj).FirstOrDefault();                   
                }

            }
            catch (Exception ex)
            {
                log.InsertLog(ex);           

            }
            return saldo;
        }
    }
}