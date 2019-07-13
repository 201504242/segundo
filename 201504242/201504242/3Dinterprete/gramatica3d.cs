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
            Terminal var = ToTerm("var"),
                print = ToTerm("print"),
                got = ToTerm("goto"),
                caracter = ToTerm("'%c'"),
                entero = ToTerm("'%i'"),
                flotante = ToTerm("'%f'"),
                si = ToTerm("si");

            
            #endregion

            #region  Tipos de datos

            IdentifierTerminal id = new IdentifierTerminal("IDENTIFER");
            id.Name = "id";
            NumberLiteral numero = new NumberLiteral("numero");
            numero.Name = "numero";
            StringLiteral cadena = new StringLiteral("cadena", "\"", StringOptions.AllowsAllEscapes);
            cadena.Name = "cadena";
            RegexBasedTerminal label = new RegexBasedTerminal("(L|l)[0-9]+");
            label.Name = "label";
            RegexBasedTerminal temporal = new RegexBasedTerminal("(t|T)[0-9]+");
            temporal.Name = "temporal";
            RegexBasedTerminal bolean = new RegexBasedTerminal("(verdadero|falso)");
            bolean.Name = "bool";
            #endregion

            #region NonTerminals
            NonTerminal S = new NonTerminal("S", typeof(AstNode));
            NonTerminal LISTA_INSTRUCCION = new NonTerminal("LISTA_INSTRUCCION", typeof(AstNode));
            NonTerminal INS = new NonTerminal("INS", typeof(AstNode));
            NonTerminal EXP = new NonTerminal("EXP", typeof(natural));
            NonTerminal LABEL = new NonTerminal("LABEL", typeof(label));
            NonTerminal TEMPORAL = new NonTerminal("LABEL", typeof(temporal));
            NonTerminal IDENTIFICADOR = new NonTerminal("IDENTIFICADOR", typeof(id));
            NonTerminal DECLARACION_VAR = new NonTerminal("IDENTIFICADOR", typeof(decvar));
            NonTerminal SI = new NonTerminal("SI", typeof(si));
            NonTerminal SALTO = new NonTerminal("SI", typeof(salto));
            NonTerminal OP = new NonTerminal("SI", typeof(op));
             NonTerminal OP2 = new NonTerminal("SI", typeof(op));
             NonTerminal PRINT = new NonTerminal("PRINT", typeof(print));
             NonTerminal ASIGNACION = new NonTerminal("ASIGNACION", typeof(asignacion));
             NonTerminal ASIGNACIONES = new NonTerminal("ASIGNACION", typeof(asignaciones));
            #endregion

            S.Rule = LISTA_INSTRUCCION;

            LISTA_INSTRUCCION.Rule = MakeStarRule(LISTA_INSTRUCCION, INS);

            INS.Rule = //EXP + puntoycoma
                       DECLARACION_VAR + puntoycoma
                      |LABEL + dospuntos
                      |SI
                      |SALTO + puntoycoma
                      |PRINT + puntoycoma
                      |ASIGNACION  + puntoycoma;

            DECLARACION_VAR.Rule = var + id  + igual + EXP;

            SI.Rule = si + pa_A + EXP + OP + EXP + pa_C + SALTO ;

            EXP.Rule = numero
                      | TEMPORAL
                      | IDENTIFICADOR ;

            SALTO.Rule = got + LABEL;

            ASIGNACION.Rule =  ASIGNACIONES + igual + EXP
                             | ASIGNACIONES + igual + EXP + OP + EXP;

            ASIGNACIONES.Rule = temporal
                               | id;

            OP.Rule = mas | menos ;

            LABEL.Rule = label;

            PRINT.Rule = print + pa_A + OP2 + coma + EXP + pa_C;


            OP2.Rule = caracter | entero | flotante;

            TEMPORAL.Rule = temporal;
            IDENTIFICADOR.Rule = id;
            this.Root = S;
        }
    }
}
