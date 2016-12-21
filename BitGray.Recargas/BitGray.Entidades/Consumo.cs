using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitGray.Entidades
{
    public class Consumo
    {
        public long idConsumo { get; set; }
        public string celular { get; set; }
        public int consumo1 { get; set; }
        public System.DateTime fechaConsumo { get; set; }
        public long idParametro { get; set; }

    }
}
