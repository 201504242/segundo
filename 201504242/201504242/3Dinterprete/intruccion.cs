using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _201504242._3Dinterprete
{
    class intruccion : AstNode
    {

        public override void Init(Irony.Ast.AstContext context, Irony.Parsing.ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);
        }
        public override object ejecutar(Entorno3D env, object obj = null)
        {
            return ChildNodes[0].ejecutar(env, obj);
        }
    }
}
