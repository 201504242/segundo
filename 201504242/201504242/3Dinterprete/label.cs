﻿using System;
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
        }
        public override object ejecutar(Entorno3D env, object obj = null)
        {
            if (this.ChildNodes.Count == 1)
            {

                return this.ChildNodes[0].ejecutar(env, obj); ;
            }
             return null;
        }
        public object valor
        {
            get;
            set;
        }
        
    }
}
