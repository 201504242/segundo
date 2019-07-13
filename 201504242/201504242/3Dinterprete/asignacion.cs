using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _201504242._3Dinterprete
{
    class asignacion: AstNode
    {

        public override void Init(Irony.Ast.AstContext context, Irony.Parsing.ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);
        }
        public override object ejecutar(Entorno3D env, object obj = null)
        {
            if (ChildNodes.Count == 2)
            {
                object asg = ChildNodes[0].ejecutar(env, null);
                object val = ChildNodes[1].ejecutar(env, null);
                if (asg is ISimbolo)
                {
                    ((ISimbolo)asg).valor = val;
                }
                else if (asg is temporal)
                {
                    env.insertTemporal(((temporal)asg).valor , val);
                }
            }
            else
            {
               object ret =  operar.operarG(ChildNodes[1].ejecutar(env, null), ChildNodes[3].ejecutar(env, null), ChildNodes[2].ejecutar(env, null).ToString());
               object asg = ChildNodes[0].ejecutar(env, null);
               if (asg is ISimbolo)
               {
                   ((ISimbolo)asg).valor = ret;
               }
               else if (asg is temporal)
               {
                   env.insertTemporal(((temporal)asg).valor, ret);
               }
            }
            
            return null;
        }

        private string Name;
        private string valor;
    
    }
}
