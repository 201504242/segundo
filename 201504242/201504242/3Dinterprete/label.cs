using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201504242._3Dinterprete
{
    class label : AstNode
    {
        private  int numero { get; set; }

        public override object ejecutar(Entorno3D env, object obj = null)
        {
             base.ejecutar(env, obj);
             return null;
        }

        
    }
}
