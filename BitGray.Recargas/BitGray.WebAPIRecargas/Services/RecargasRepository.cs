using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitGray.WebAPIRecargas.Services
{
    public class RecargasRepository
    {
        private BitGray.Log.Log log = new Log.Log();
        public List<Models.Recarga> GetRecargas(string celular)
        {
            List<Models.Recarga> lstRecargas = null;

            try
            {               
                using (var ctx = new BDRecargasEntities())
                {

                    lstRecargas = (from obj in ctx.Recargas where obj.celular.Equals(celular) select obj).ToList();
                }
               
            }
            catch (Exception ex)
            {
                log.InsertLog(ex);

            }
            return lstRecargas;
        }

        public bool CrearRecarga(Models.Recarga recarga)
        {
            try
            {
                //Ingresa costo en la base de datos
                using (var ctx = new BDRecargasEntities())
                {    
                    ctx.Recargas.Add(recarga);                  

                    var saldo = (from obj in ctx.Saldos where obj.celular.Equals(recarga.celular) select obj).FirstOrDefault();
                    var parametro = (from obj in ctx.Parametros where obj.idParametro==recarga.idParametros  select obj).FirstOrDefault();
                    
                    if (saldo != null)
                    {
                        saldo.saldoPesos = saldo.saldoPesos + recarga.valor;
                        if (parametro != null)
                        {
                            saldo.saldoSegundos = (saldo.saldoSegundos) + (int)(recarga.valor / parametro.valor);
                        }
                    }
                    else
                    {
                        Models.Saldo newSaldo = new Models.Saldo();
                        newSaldo.celular = recarga.celular;
                        newSaldo.saldoPesos = recarga.valor;
                        newSaldo.saldoSegundos = recarga.valor / parametro.valor;
                        ctx.Saldos.Add(newSaldo);
                    }

                    ctx.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                log.InsertLog(ex);
                return false;
            }
        }      

    }
}