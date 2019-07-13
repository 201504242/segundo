using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _201504242._3Dinterprete
{
    class print : AstNode
    {

        public override void Init(Irony.Ast.AstContext context, Irony.Parsing.ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);
        }
        public override object ejecutar(Entorno3D env, object obj = null)
        {
            object val = this.ChildNodes[1].ejecutar(env,obj);
            string tipoRender = (this.ChildNodes[0].ejecutar(env, obj)).ToString();
            if (tipoRender == "'%c'")
            {
                char c = Convert.ToChar(int.Parse(val.ToString()));
                Console.WriteLine(c);
            }
            else
            {
                Console.Write(val.ToString());
            }
            return null;
        }
    }
}
