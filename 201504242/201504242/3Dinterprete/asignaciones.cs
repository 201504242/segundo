using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _201504242._3Dinterprete
{
    class asignaciones : AstNode
    {

        public override void Init(Irony.Ast.AstContext context, Irony.Parsing.ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);
            this.Name = treeNode.ChildNodes[0].Term.Name;
            this.valor = treeNode.ChildNodes[0].Token.ValueString;
        }
        public override object ejecutar(Entorno3D env, object obj = null)
        {
            if (this.Name == "id")
            {
                return env.get(this.valor);
            }
            else if (this.Name == "temporal")
            {
                return new temporal(this.valor);
            }
            
            return null;
        }

        private string Name;
        private string valor;
    }
}
