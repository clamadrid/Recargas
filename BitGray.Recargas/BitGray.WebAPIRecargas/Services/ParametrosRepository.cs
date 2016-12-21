using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BitGray.WebAPIRecargas.Services
{
    public class ParametrosRepository
    {
        private BitGray.Log.Log log = new Log.Log();
        public bool CrearCosto(Models.Parametro costo)
        {
            try
            {
                //Ingresa costo en la base de datos
                using (var ctx = new BDRecargasEntities())
                {
                  
                        if (costo.esActual)
                        {
                            ctx.Database.ExecuteSqlCommand("usp_UpdateRecargas");
                        }
                 
                    ctx.Parametros.Add(costo);
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

        public Models.Parametro GetParametroActual()
        {
            Models.Parametro parameter = null; 
            try
            {
                using (var ctx = new BDRecargasEntities())
                {
                    parameter = (from obj in ctx.Parametros where obj.esActual.Equals(true) select obj ).ToList().FirstOrDefault();
                }            
              
            }
            catch (Exception ex)
            {
                log.InsertLog(ex);
                return null;
            }
            return parameter;
        }
    }
}