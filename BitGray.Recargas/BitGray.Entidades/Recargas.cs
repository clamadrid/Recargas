using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitGray.Entidades
{
   public class Recargas
    {
        public long idRecargas { get; set; }
        public long idParametros { get; set; }
        public string celular { get; set; }
        public int valor { get; set; }
        public System.DateTime fechaVigencia { get; set; }
        public System.DateTime fechaRecarga { get; set; }
    }
}
