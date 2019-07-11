using Irony.Parsing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201504242._3Dinterprete
{
    class interprete3D
    {
        public string codigo;
        public interprete3D(String codigo)
        {
            this.codigo = codigo;
        }

        public void ejecutarCodigo()
        {
            try
            {
                gramatica3d gramatica = new gramatica3d();
                LanguageData lenguaje = new LanguageData(gramatica);
                Parser parser = new Parser(lenguaje);
                ParseTree arbol = parser.Parse(codigo);
                ParseTreeNode raiz = arbol.Root;
                if (raiz != null)
                {
                    ConstructorAst builder = new ConstructorAst(raiz);
                    AstNode nuevaRaiz = builder.raiz;
                    Entorno3D inicio = new Entorno3D(null);
                    nuevaRaiz.ejecutar(inicio);
                }
            }
            catch (Exception ex)
            {
                // Implementar Error
                Console.Write(ex.Message);
            }
        }
    }
}
