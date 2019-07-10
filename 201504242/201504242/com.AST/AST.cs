using _201504242.com.AST.General;
using _201504242.com.AST.instrucciones;
using _201504242.entorno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201504242.com.AST
{
    public class AST
    {
        public AST(LinkedList<Instruccion> instrucciones)
        {
            this.instrucciones = instrucciones;
        }

        public object ejecutar()
        {
            
            Entorno superGlobal = new Entorno(null);
            foreach (NodoAST item in instrucciones)
            {
                if (item is Clase)
                {
                    Clase c = (Clase)item;
                }   
            }
            return null;
        }
        public LinkedList<Instruccion> instrucciones { get; set; }
        

    }
}
