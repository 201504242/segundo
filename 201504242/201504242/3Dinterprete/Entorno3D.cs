using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201504242._3Dinterprete
{
    class Entorno3D
    {
        internal class tablaSimbolos : List<ISimbolo>
        {
            public tablaSimbolos() { }
        }

        internal class tablaTemporales : System.Collections.ArrayList
        {
            public tablaTemporales() {}
        }
        public Entorno3D ant { set; get; }

        internal tablaSimbolos ts { set; get; }

        internal tablaTemporales tst { set; get; }

        public bool FlagDonde = false;

        public Entorno3D(Entorno3D ant)
        {
            this.ant = ant;
            ts = new tablaSimbolos();
            tst = new tablaTemporales();
           
          
        }
        internal void put(ISimbolo sim)
        {
            if (!existe(sim.id))
            { ts.Add(sim); }
            else
            {
                // GENERAR ERROR 
            }
            
        }

       internal bool existe(String id)
        {
            foreach (ISimbolo simboloTemp in ts)
            {
                if (simboloTemp.id.Equals(id, StringComparison.InvariantCultureIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
       internal ISimbolo get(String id)
       {
           for (Entorno3D ent = this; ent != null; ent = ent.ant)
           {
               foreach (ISimbolo simbolo in ent.ts)
               {
                   if (simbolo.id.Equals(id, StringComparison.CurrentCultureIgnoreCase))
                   {
                       return simbolo;
                   }
               }
           }
           return null;
       }

       internal object getTemporal(int p)
       {
           return this.tst[p];
       }

       internal void insertTemporal(int p, object value)
       {
           this.tst.Insert(p, value);
       }
    }
}

