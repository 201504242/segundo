
using _201504242.com.AST;
using Irony.Parsing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201504242.Interprete
{
    class ConstructorAST
    {
        public AST Analizar(ParseTreeNode raiz)
        {
            return (AST)auxiliar(raiz);
        }

        private object auxiliar(ParseTreeNode raiz)
        {
            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine("error en constructor "+e.Message);
            }
            return null;
        }
    }
}
