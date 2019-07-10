using _201504242.entorno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201504242.com.AST.General
{
    public interface Expresion : NodoAST
    {
        object get3D(Entorno ent);
        object getASM(Entorno ent);
        Tipo getTipo(Entorno ent);
    }
}
