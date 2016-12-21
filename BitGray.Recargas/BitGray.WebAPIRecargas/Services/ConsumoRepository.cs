using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitGray.WebAPIRecargas.Services
{
    public class ConsumoRepository
    {
        private BitGray.Log.Log log = new Log.Log();
        public bool CrearConsumo(Models.Consumo consumo)
        {
            try
            {
                //Ingresa costo en la base de datos
                using (var ctx = new BDRecargasEntities())
                {
                    ctx.Consumoes.Add(consumo);
                    var saldo = (from obj in ctx.Saldos where obj.celular.Equals(consumo.celular) select obj).FirstOrDefault();
                    var parametro = (from obj in ctx.Parametros where obj.idParametro == consumo.idParametro select obj).FirstOrDefault();

                    if (saldo != null)
                    {
                        saldo.saldoPesos = saldo.saldoPesos - (consumo.consumo1 * parametro.valor);
                        if (parametro != null)
                        {
                            saldo.saldoSegundos = (saldo.saldoSegundos) - consumo.consumo1;
                        }
                    }
                    else
                    {
                        Models.Saldo newSaldo = new Models.Saldo();
                        newSaldo.celular = consumo.celular;
                        newSaldo.saldoPesos = consumo.consumo1 * parametro.valor;
                        newSaldo.saldoSegundos = consumo.consumo1;
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

        public bool ValidarConsumo(int consumo, string celular)
        {
            bool tieneSaldo = false;
            try
            {
                using (var ctx = new BDRecargasEntities())
                {
                    var saldo = (from obj in ctx.Saldos where obj.celular.Equals(celular) select obj).FirstOrDefault();
                    if (saldo != null)
                    {
                        if (saldo.saldoSegundos > consumo)
                        {
                            //Tiene saldo disponible.
                            tieneSaldo = true;
                        }
                        else
                        {
                            tieneSaldo = false;
                        }
                    }
                    return tieneSaldo;
                }
            } catch (Exception ex)
            {
                log.InsertLog(ex);
                return false;
            }
        }
      
        public IEnumerable<Models.Consumo> ObtenerConsumos()
        {
            List<Models.Consumo> lstRecargas = null;

            try
            {
                using (var ctx = new BDRecargasEntities())
                {

                    lstRecargas = (from obj in ctx.Consumoes select obj).ToList();
                }

            }
            catch (Exception ex)
            {
                log.InsertLog(ex);
            }
            return lstRecargas;
        }
    }
}