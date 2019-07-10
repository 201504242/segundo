using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _201504242.entorno.Tipo;

namespace _201504242.entorno
{
    public class Simbolo
    {
        public string identificador { get; set; }
        public object valor { get; set; }
        public Tipos tipo { get; set; }
        public bool funcion { get; set; }
        public LinkedList<Simbolo> listaParametros { get; set; }


    }
}
