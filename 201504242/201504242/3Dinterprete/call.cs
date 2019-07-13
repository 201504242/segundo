using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _201504242._3Dinterprete
{
    class call : AstNode
    {

        public override void Init(Irony.Ast.AstContext context, Irony.Parsing.ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);
            //this.exp = (AstNode)ChildNodes[0];
            this.nombre = treeNode.ChildNodes[1].Token.ValueString;
        }
        public override object ejecutar(Entorno3D env, object obj = null)
        {
            AstNode funcion = (AstNode)env.funciones[nombre];
            Entorno3D entornoFuncion = new Entorno3D(env);
            entornoFuncion.ts = env.ts;
            entornoFuncion.funciones = env.funciones;
            //FALTA LA DEL HEAP Y LA DEL  STACK
            funcion.ejecutar(entornoFuncion, null);
            return null;
        }

        public string nombre { get; set; }
    }
}
