using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _201504242._3Dinterprete
{
    class decvar : AstNode 
    {

        public override void Init(Irony.Ast.AstContext context, Irony.Parsing.ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);
            this.valor = treeNode.ChildNodes[0].Token.ValueString;
            this.exp = (AstNode)ChildNodes[3];

        }
        public override object ejecutar(Entorno3D env, object obj = null)
        {
            env.put(new variable(this.valor , exp.ejecutar(env,obj)));
            return null;
        }
        private string valor
        {
            get;
            set;
        }
        private AstNode exp;

    }
}
