using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _201504242._3Dinterprete
{
    class si : AstNode
    {

        public override void Init(Irony.Ast.AstContext context, Irony.Parsing.ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);
            //this.exp = (AstNode)ChildNodes[0];

        }
        public override object ejecutar(Entorno3D env, object obj = null)
        {
            bool b = (bool)operar.operarG(ChildNodes[0].ejecutar(env, null), ChildNodes[2].ejecutar(env, null), ChildNodes[1].ejecutar(env, null).ToString());
            if (b)
            {
                return ChildNodes[3].ejecutar(env, null);
            }
            return null;
        }
    }
}
