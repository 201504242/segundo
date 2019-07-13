using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _201504242._3Dinterprete
{
    class listaIntrucciones : AstNode
    {

        public override void Init(Irony.Ast.AstContext context, Irony.Parsing.ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);
        }
        public override object ejecutar(Entorno3D env, object obj = null)
        {
            int i = 0;
            for (; i < ChildNodes.Count; i++)
            {
                AstNode nodo = ChildNodes[i];
                if (nodo.ChildNodes[0] is funcion)
                {
                    continue;
                }
                object ret = nodo.ejecutar(env, obj);
                if (ret is salto)
                {
                    salto jump = (salto)ret;
                    for (int j = 0; j < ChildNodes.Count; j++ )
                    {
                        try
                        {
                            AstNode a = ChildNodes[j].ChildNodes[0];
                            if (a is label)
                            {
                                if (((label)a).valor == jump.valor)
                                {
                                    i = j;
                                }
                            }
                        }
                        catch (Exception e)
                        { Console.WriteLine(e.StackTrace); }
                    }
                }
            }
                return null;
        }
    }
}
