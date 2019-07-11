using Irony.Parsing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201504242._3Dinterprete
{
    class ConstructorAst
    {
        public AstNode raiz { get; protected set; }
        public ConstructorAst(ParseTreeNode raiz)
        {
            this.raiz = getAst(raiz);
        }
        public AstNode getAst(ParseTreeNode nodo)
        {
            if (nodo.Term.AstConfig.NodeType != null)
            {
                nodo.AstNode = Activator.CreateInstance(nodo.Term.AstConfig.NodeType);
            }
            foreach (ParseTreeNode hijo in nodo.ChildNodes)
            {
                AstNode nuevohijo = getAst(hijo);
                if (nodo.AstNode != null && nuevohijo != null)
                {
                    AstNode NodoActualTemporal = (AstNode)nodo.AstNode;
                    NodoActualTemporal.ChildNodes.Add(nuevohijo);
                }
            }
            if (nodo.AstNode != null)
            {
                ((AstNode)nodo.AstNode).Init(null, nodo);
                return (AstNode)nodo.AstNode;
            }
            return null;
        }
    }
}
