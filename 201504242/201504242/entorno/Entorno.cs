using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201504242.entorno
{
    public class Entorno
    {
        public Hashtable tabla { get; set; }
        public Entorno anterior { get; set; }

        public Entorno(Entorno anterior)
        {
            tabla = new Hashtable();
            this.anterior = anterior;
        }
        public void agregar(string id, Simbolo simbolo)
        {
            tabla.Add(id, simbolo);
        }

        public Simbolo get(string id)
        {
            for (Entorno e = this; e != null; e = e.anterior)
            {
                Simbolo encontrado = (Simbolo)(e.tabla[id]);
                if (encontrado != null)
                {
                    return encontrado;
                }
            }
            Console.WriteLine("El simbolo \"" + id + "\" no ha sido declarado en el entorno actual ni en alguno externo");
            return null;
        }

        public bool existe(string id)
        {
            for (Entorno e = this; e != null; e = e.anterior)
            {
                if (e.tabla.Contains(id))
                {
                    return true;
                }
            }
            return false;
        }
    }


}
