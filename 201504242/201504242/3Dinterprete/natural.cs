using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201504242._3Dinterprete
{
    class natural:AstNode
    {
        public override void Init(Irony.Ast.AstContext context, Irony.Parsing.ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);
            this.valor = treeNode.ChildNodes[0].Token.Value;
        }
        public override object ejecutar(Entorno3D env, object obj = null)
        {
            Console.WriteLine(this.valor);
            return null;
        }
        public object valor
        {
            get;
            set;
        }
    }
}
