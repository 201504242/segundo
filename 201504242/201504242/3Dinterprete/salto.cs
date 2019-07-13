using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _201504242._3Dinterprete
{
    class salto : AstNode
    {

        public override void Init(Irony.Ast.AstContext context, Irony.Parsing.ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);
            //this.exp = (AstNode)ChildNodes[0];

        }
        public override object ejecutar(Entorno3D env, object obj = null)
        {
            return this;
        }


    }
}
