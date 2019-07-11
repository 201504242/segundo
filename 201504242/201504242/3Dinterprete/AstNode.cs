using Irony.Ast;
using Irony.Parsing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _201504242._3Dinterprete
{
    class AstNode : IAstNodeInit, IBrowsableAstNode
    {
  
        public class AstNodeList : List<AstNode> { }
      
        public class locacion
        {
            public int fila;
            public int columna;
        }
        public AstNode Parent { get; set; }
        public locacion Span = new locacion();
        public bool isBreakPoint = false;

        protected object LockObject = new object();
        public readonly AstNodeList ChildNodes = new AstNodeList();
        public virtual string AsString { get; protected set; }

        public override string ToString()
        {
            return this.GetType().Name;
        }
        public virtual void Init(AstContext context, ParseTreeNode treeNode)
        {
            Span.columna = treeNode.Span.Location.Column;
            Span.fila = treeNode.Span.Location.Line;
        }
        public virtual object ejecutar(Entorno3D env, object obj = null)
        {
            if (this.isBreakPoint)
                Thread.Sleep(100);

            foreach (AstNode hijos in this.ChildNodes)
            {
                hijos.ejecutar(env, obj);
            }
            return null;
        }

        public int Position
        {
            get { return Span.fila; }
        }
        public virtual System.Collections.IEnumerable GetChildNodes()
        {
            return ChildNodes;
        }

        public ParseTreeNode findNodo(String nombre, ParseTreeNode nodo)
        {
            foreach (ParseTreeNode nodoTemporal in nodo.ChildNodes)
            {
                if (nodoTemporal.Term.Name.Equals(nombre, StringComparison.InvariantCultureIgnoreCase))
                {
                    return nodoTemporal;
                }
            }
            return null;
        }
    }

}
