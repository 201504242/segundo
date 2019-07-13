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
                si = ToTerm("si"),
                 end = ToTerm("end"),
                 begin = ToTerm("begin"),
                 llamar = ToTerm("call"),
                proc = ToTerm("proc");
            
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
            NonTerminal LISTA_INSTRUCCION = new NonTerminal("LISTA_INSTRUCCION", typeof(listaIntrucciones));
            NonTerminal INS = new NonTerminal("INS", typeof(intruccion));
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
            NonTerminal CALL = new NonTerminal("CALL",typeof(call));
             NonTerminal FUNCION = new NonTerminal("CALL",typeof(funcion));
            #endregion

            S.Rule = LISTA_INSTRUCCION;

            LISTA_INSTRUCCION.Rule = MakeStarRule(LISTA_INSTRUCCION, INS);

            INS.Rule = DECLARACION_VAR + puntoycoma
                      |LABEL + dospuntos
                      | SI + puntoycoma
                      |SALTO + puntoycoma
                      |PRINT + puntoycoma
                      |ASIGNACION  + puntoycoma
                      | FUNCION 
                      |CALL + puntoycoma;

            DECLARACION_VAR.Rule = var + id  + igual + EXP;

            FUNCION.Rule = proc + id +  begin + LISTA_INSTRUCCION + end ;

            SI.Rule = si + pa_A + EXP + OP + EXP + pa_C + SALTO ;

            EXP.Rule = numero
                      | TEMPORAL
                      | IDENTIFICADOR ;

            SALTO.Rule = got + label;

            ASIGNACION.Rule =  ASIGNACIONES + igual + EXP
                             | ASIGNACIONES + igual + EXP + OP + EXP;

            ASIGNACIONES.Rule = temporal
                               | id;

            OP.Rule = mas | menos  |  identico |diferente |menorQue|mayorQue | menorIgual | mayorIgual ;

            LABEL.Rule = label;

            PRINT.Rule = print + pa_A + OP2 + coma + EXP + pa_C;

            CALL.Rule = llamar + id ;

            OP2.Rule = caracter | entero | flotante;

            TEMPORAL.Rule = temporal;
            IDENTIFICADOR.Rule = id;
            this.Root = S;
        }
    }
}
