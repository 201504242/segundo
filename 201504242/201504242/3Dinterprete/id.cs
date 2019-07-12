﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _201504242._3Dinterprete
{
    class id : AstNode
    {
        public override void Init(Irony.Ast.AstContext context, Irony.Parsing.ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);
            this.valor = treeNode.ChildNodes[0].Token.ValueString;

        }
        public override object ejecutar(Entorno3D env, object obj = null)
        {
            return env.get(this.valor).valor;
        }
        private string valor
        {
            get;
            set;
        }
    }
}
