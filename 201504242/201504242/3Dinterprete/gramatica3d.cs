using Irony.Parsing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201504242._3Dinterprete
{
    class gramatica3d : Grammar
    {
        public gramatica3d()
            : base(false)
        {

            #region Aritmaticas
            Terminal pa_A = ToTerm("("),
                    pa_C = ToTerm(")"),
                    masmas = ToTerm("++"),
                    menosmenos = ToTerm("--"),
                    modulo = ToTerm("%"),
                    mas = ToTerm("+"),
                    menos = ToTerm("-"),
                    por = ToTerm("*"),
                    div = ToTerm("/"),
                    potencia = ToTerm("^")
                    ;
            #endregion
            #region   Relacionales
            Terminal identico = ToTerm("=="),
                     diferente = ToTerm("!="),
                     menorQue = ToTerm("<"),
                     mayorQue = ToTerm(">"),
                     menorIgual = ToTerm("<="),
                     mayorIgual = ToTerm(">=");
            #endregion

            #region Logicas
            Terminal and = ToTerm("&&"),
                     or = ToTerm("||"),
                     not = ToTerm("!");
            #endregion
            #region Signos
            Terminal igual = ToTerm("="),
                     puntoycoma = ToTerm(";"),
                     qmk = ToTerm("?"),
                     dospuntos = ToTerm(":"),
                     coma = ToTerm(",");

            #endregion
            #region Reservadas
            Terminal crear = ToTerm("crear"),
                tabla = ToTerm("tabla");
            #endregion

            #region  Tipos de datos

            IdentifierTerminal id = new IdentifierTerminal("IDENTIFER");
            id.Name = "identificador";
            NumberLiteral numero = new NumberLiteral("numero");
            numero.Name = "numero";
            StringLiteral cadena = new StringLiteral("cadena", "\"", StringOptions.AllowsAllEscapes);
            cadena.Name = "cadena";
            RegexBasedTerminal label = new RegexBasedTerminal("(L|l)[0-9]+");
            label.Name = "label";
            RegexBasedTerminal bolean = new RegexBasedTerminal("(verdadero|falso)");
            bolean.Name = "bool";
            #endregion

            #region NonTerminals
            NonTerminal S = new NonTerminal("S", typeof(AstNode));
            NonTerminal LISTA_INSTRUCCION = new NonTerminal("LISTA_INSTRUCCION", typeof(AstNode));
            NonTerminal INS = new NonTerminal("INS", typeof(AstNode));
            NonTerminal EXP = new NonTerminal("EXP", typeof(natural));
            NonTerminal LABEL = new NonTerminal("LABEL", typeof(label));
            #endregion

            S.Rule = LISTA_INSTRUCCION;

            LISTA_INSTRUCCION.Rule = MakeStarRule(LISTA_INSTRUCCION, INS);

            INS.Rule = EXP + puntoycoma;

            EXP.Rule = numero
                      | LABEL ;

            LABEL.Rule = label;

            this.Root = S;
        }
    }
}
