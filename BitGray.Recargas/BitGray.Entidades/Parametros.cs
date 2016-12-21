using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitGray.Entidades
{
    public class Parametros
    {
        public long idParametro { get; set; }
        //Costo de la recarga por segundo.
        public int valor { get; set; }

        // Si el parametro es vigente o es obsoleto.
        public bool esActual { get; set; }
        
        // fecha en que se creo el parametro.
        public System.DateTime fechaParametro { get; set; }
    }
}