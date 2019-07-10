using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Parsing;

namespace _201504242.Interprete
{
    class Gramatica : Irony.Parsing.Grammar
    {
        public Gramatica() : base(true)
        {
            #region Declaracion de TERMINALES
            NumberLiteral numero = new NumberLiteral("numero");
            IdentifierTerminal identificador = new IdentifierTerminal("identificador");
            StringLiteral cadena = new StringLiteral("cadena", "\"", StringOptions.AllowsAllEscapes);
            StringLiteral caracter = new StringLiteral("caracter", "\'", StringOptions.IsChar);

            #region Palabras reservadas
            KeyTerm pr_int = ToTerm("int"),
           pr_double = ToTerm("double"),
           pr_char = ToTerm("char"),
           pr_bool = ToTerm("bool"),
           pr_String = ToTerm("String"),

           Treturn = ToTerm("return"),
           Tbreak = ToTerm("break"),
           Tcontinue = ToTerm("continue"),
           Tif = ToTerm("if"),
           Telse = ToTerm("else"),
           Twhile = ToTerm("while"),
           Tclass = ToTerm("class"),
           Tnone = ToTerm("None"),
           Tassert = ToTerm("assert"),
           Tasync = ToTerm("async"),
           Tawait = ToTerm("await"),
           Tdef = ToTerm("def"),
           Tdel = ToTerm("del"),
           Tfor = ToTerm("for"),
           Tfrom = ToTerm("from"),
           Tglobal = ToTerm("global"),
           Timport = ToTerm("import"),
           Tin = ToTerm("in"),
           Tis = ToTerm("is"),
           Tpass = ToTerm("pass"),
           Traise = ToTerm("raise"),
           Twith = ToTerm("with"),
           Tnonlocal = ToTerm("nonlocal"),
           Telif = ToTerm("elif"),
           Tprint = ToTerm("print");

            MarkReservedWords("int", "double", "char", "bool", "String", "void", "return",
                "break", "continue", "if", "else", "while", "class", "print",
                "None","assert","async", "await","def","del","elif","for","from","global",
                "import","in","is", "nonlocal","pass","raise","with");
            #endregion

            #region Operadores y simbolos
            Terminal ptcoma = ToTerm(";"),
                coma = ToTerm(","),
                punto = ToTerm("."),
                dospts = ToTerm(":"),
                parizq = ToTerm("("),
                parder = ToTerm(")"),
                llaizq = ToTerm("{"),
                llader = ToTerm("}"),
                signo_mas = ToTerm("+"),
                signo_menos = ToTerm("-"),
                signo_por = ToTerm("*"),
                signo_div = ToTerm("/"),
                signo_pot = ToTerm("^"),
                igual_que = ToTerm("=="),
                diferente_que = ToTerm("!="),
                menor_que = ToTerm("<"),
                mayor_que = ToTerm(">"),
                pr_or = ToTerm("||"),
                pr_and = ToTerm("&&"),
                pr_not = ToTerm("!"),
                pr_true = ToTerm("true", "true"),
                pr_false = ToTerm("false", "false"),
                igual = ToTerm("=");
            #endregion

            #region Comentarios
            CommentTerminal comentarioMultilinea = new CommentTerminal("comentarioMultiLinea", "/*", "*/");
            base.NonGrammarTerminals.Add(comentarioMultilinea);
            CommentTerminal comentarioUnilinea = new CommentTerminal("comentarioUniLinea", "//", "\n", "\r\n");
            base.NonGrammarTerminals.Add(comentarioUnilinea);
            #endregion

            #endregion

            #region Declaracion de NO TERMINALES
            NonTerminal I = new NonTerminal("I");
            NonTerminal CONJUNTOS = new NonTerminal("CONJUNTOS");
            NonTerminal CONJUNTO = new NonTerminal("CONJUNTO");
            NonTerminal literal = new NonTerminal("literal");
            NonTerminal LISTA_CLASES = new NonTerminal("LISTA_CLASES");

            #endregion

            #region Gramatica
            I.Rule = MakePlusRule(I,CONJUNTOS);

            CONJUNTOS.Rule = CONJUNTO + Eos 
                | LISTA_CLASES;

            LISTA_CLASES.Rule = Tclass +identificador + dospts ;

            CONJUNTO.Rule = Tfor;
            #endregion

            #region precedencia

            #endregion

            MarkPunctuation(parizq, parder, llaizq, llader, ptcoma, dospts, coma, igual, punto);
            this.Root = I;
        }
    }
}
