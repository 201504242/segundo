using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201504242._3Dinterprete
{
    class variable : ISimbolo
    {
        public variable(String id)
        {
            this.id = id;
        }
        public variable(String id , object obj)
        {
            this.id = id;
            this.valor = obj;
        }

        public string id
        {
            get;
            set;
        }

        public object valor
        {
            get;
            set;
        }

        public string tipointerno
        {
            get;
            set;
        }
    }
}
