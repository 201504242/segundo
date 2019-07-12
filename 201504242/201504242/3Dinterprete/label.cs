using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201504242._3Dinterprete
{
    class label : AstNode
    {
               
        public override void Init(Irony.Ast.AstContext context, Irony.Parsing.ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);
            string label = treeNode.ChildNodes[0].Token.ValueString.Substring(1);
            this.valor = int.Parse(label); 

        }
        public override object ejecutar(Entorno3D env, object obj = null)
        {
             return null;
        }
        private int valor
        {
            get;
            set;
        }
        
    }
}
