using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201504242.entorno
{
    public class Tipo
    {
        public Tipo(Tipos primitivo)
        {
            this.primitivo = primitivo;
        }

        public Tipo( string objeto)
        {
            this.objeto = objeto;
        }

        public enum Tipos
        {
            STRING,
            INT,
            DOUBLE,
            CHAR,
            BOOL,
            NOTIPE,
            OBJETO
        }

        public String objeto
        {
            get;
            set;
        }

        public Tipos primitivo
        {
            get;
            set;
        }
        
    }
}
