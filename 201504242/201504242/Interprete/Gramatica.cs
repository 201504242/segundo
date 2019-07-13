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
            #region INSTRUCCION de TERMINALES
            NumberLiteral numero = TerminalFactory.CreatePythonNumber("numero");
            //NumberLiteral numero = new NumberLiteral("numero");
            IdentifierTerminal identificador = TerminalFactory.CreatePythonIdentifier("identificador");
            StringLiteral cadena = new StringLiteral("cadena", "\"", StringOptions.AllowsAllEscapes);
            StringLiteral caracter = new StringLiteral("caracter", "\'", StringOptions.IsChar);
            
            #region Palabras reservadas
            KeyTerm pr_int = ToTerm("int"),
           pr_double = ToTerm("double"),
           pr_char = ToTerm("char"),
           pr_bool = ToTerm("boolean"),
           pr_void = ToTerm("void"),
           pr_String = ToTerm("String"),

           Treturn = ToTerm("return"),
           __init__ = ToTerm("__init__"),
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
                corizq = ToTerm("["),
                corder = ToTerm("]"),
                llaizq = ToTerm("{"),
                llader = ToTerm("}"),
                signo_mas = ToTerm("+"),
                signo_menos = ToTerm("-"),
                signo_por = ToTerm("*"),
                signo_mod = ToTerm("%"),
                signo_div = ToTerm("/"),
                signo_piso = ToTerm("//"),
                signo_pot = ToTerm("^"),
                igual_que = ToTerm("=="),
                diferente_que = ToTerm("!="),
                menor_que = ToTerm("<"),
                menor_igual = ToTerm("<="),
                mayor_que = ToTerm(">"),
                mayor_igual = ToTerm(">="),
                pr_or = ToTerm("or"),
                pr_and = ToTerm("and"),
                pr_not = ToTerm("not"),
                pr_true = ToTerm("true", "True"),
                pr_false = ToTerm("false", "False"),
                igual = ToTerm("=");
            #endregion

            #region Comentarios
            CommentTerminal comentarioMultilinea = new CommentTerminal("comentarioMultiLinea","/*", "*/");
            base.NonGrammarTerminals.Add(comentarioMultilinea);
            CommentTerminal comentarioUnilinea = new CommentTerminal("comentarioUniLinea", "#", "\n", "\r\n");
            base.NonGrammarTerminals.Add(comentarioUnilinea);
            #endregion

            #endregion

            #region INSTRUCCION de NO TERMINALES
            NonTerminal S = new NonTerminal("S");
            NonTerminal EXPRESION = new NonTerminal("EXPRESION");
            NonTerminal DECLARACION = new NonTerminal("DECLARACION");
            NonTerminal FunctionDef = new NonTerminal("FunctionDef");
            NonTerminal ParamList = new NonTerminal("ParamList");
            NonTerminal Block = new NonTerminal("Block");
            NonTerminal LLAMADA = new NonTerminal("LLAMADA");
            NonTerminal ASIGNACION = new NonTerminal("ASIGNACION");
            NonTerminal INSTRUCCION = new NonTerminal("INSTRUCCION");
            NonTerminal DeclaracionLista = new NonTerminal("DeclaracionLista");
            NonTerminal ReturnDeclaracion = new NonTerminal("ReturnDeclaracion");
            NonTerminal ExtDeclaracion = new NonTerminal("ExtDeclaracion");
            NonTerminal ArgList = new NonTerminal("ArgList");
            NonTerminal CLASES = new NonTerminal("CLASES");
            NonTerminal CLASE = new NonTerminal("CLASE");
            NonTerminal ClaseDef = new NonTerminal("ClaseDef");
            NonTerminal LISTAASIGNACION = new NonTerminal("LISTAASIGNACION");
            NonTerminal SENT_PRINT = new NonTerminal("SENT_PRINT");
            NonTerminal LISTAEXPRE = new NonTerminal("LISTAEXPRE");
            NonTerminal INI_ARRAY = new NonTerminal("INI_ARRAY");
            NonTerminal B = new NonTerminal("B");
            NonTerminal LISTACORCHE = new NonTerminal("LISTACORCHE");
            NonTerminal CORCHETES = new NonTerminal("CORCHETES");
            NonTerminal TIPO = new NonTerminal("TIPO");
            NonTerminal SENT_IF = new NonTerminal("SENT_IF");


            #endregion

            #region Gramatica

            S.Rule = CLASES;

            CLASES.Rule = MakePlusRule(CLASES,CLASE);

            CLASE.Rule = INSTRUCCION
                | ClaseDef;

            ClaseDef.Rule = Tclass + identificador + dospts + Eos + Block;

            DeclaracionLista.Rule = MakePlusRule(DeclaracionLista, ExtDeclaracion);

            ExtDeclaracion.Rule = INSTRUCCION 
                | FunctionDef;

            FunctionDef.Rule = Tdef + TIPO + identificador + parizq + ParamList + parder + dospts + Eos + Block
                | Tdef + __init__ + parizq + ParamList + parder + dospts + Eos + Block;

            ParamList.Rule = MakeStarRule(ParamList, coma, identificador);

            Block.Rule = Indent + DeclaracionLista + Dedent;

            INSTRUCCION.Rule = ASIGNACION + Eos
                | DECLARACION + Eos
                | SENT_PRINT + Eos
                | SENT_IF
                | LLAMADA + Eos
                | ReturnDeclaracion + Eos;

            SENT_PRINT.Rule = Tprint + parizq + ArgList + parder ;

            SENT_IF.Rule = Tif + EXPRESION + dospts + Eos + Block
                | Tif + EXPRESION + dospts + Eos + Block + Telse + dospts + Eos + Block;

            DECLARACION.Rule = TIPO + identificador + igual + EXPRESION
                | TIPO + identificador
                | identificador + identificador 
                | Tnonlocal + identificador
                | Tglobal + identificador;

            ASIGNACION.Rule = LISTAASIGNACION + igual + EXPRESION;

            LISTAASIGNACION.Rule = LISTAASIGNACION + punto + LISTAASIGNACION
                | identificador
                | identificador + parizq + ArgList + parder;

            INI_ARRAY.Rule = llaizq + B + llader;

            B.Rule = MakePlusRule(B,EXPRESION);

            LISTACORCHE.Rule = MakePlusRule(LISTACORCHE, CORCHETES);
            CORCHETES.Rule = corizq + corder;
            
            EXPRESION.Rule =
                 INI_ARRAY
                | LISTACORCHE
                | cadena
                | caracter
                | identificador
                | identificador + parizq + ArgList + parder
                | numero
                | EXPRESION + punto + EXPRESION
                | EXPRESION + Tis + EXPRESION
                | EXPRESION + Tin + EXPRESION
                | EXPRESION + signo_mas + EXPRESION
                | EXPRESION + signo_menos + EXPRESION
                | EXPRESION + signo_por + EXPRESION
                | EXPRESION + signo_div + EXPRESION
                | EXPRESION + signo_mod + EXPRESION
                | EXPRESION + signo_piso + EXPRESION
                | EXPRESION + mayor_que + EXPRESION
                | EXPRESION + mayor_igual + EXPRESION
                | EXPRESION + menor_que + EXPRESION
                | EXPRESION + menor_igual + EXPRESION
                | EXPRESION + igual_que + EXPRESION
                | EXPRESION + diferente_que + EXPRESION
                | EXPRESION + pr_or + EXPRESION
                | EXPRESION + pr_and + EXPRESION
                | signo_menos + EXPRESION
                | pr_not + EXPRESION;

            ReturnDeclaracion.Rule = Treturn + EXPRESION;

            LLAMADA.Rule = LISTAASIGNACION;
                        
            ArgList.Rule = MakeStarRule(ArgList, coma, EXPRESION);

            TIPO.Rule = pr_int
                |pr_bool
                |pr_char
                |pr_double
                |pr_int
                |pr_String
                |pr_void
                |Tnone; 
            #endregion

            #region precedencia
            RegisterOperators(1, Associativity.Right, igual);
            RegisterOperators(2, Associativity.Left, pr_or);
            RegisterOperators(4, Associativity.Left, pr_and);
            RegisterOperators(5, Associativity.Left, igual_que, diferente_que);
            RegisterOperators(6, Associativity.Left, Tis,Tin,mayor_que, menor_que,mayor_igual,menor_igual);
            RegisterOperators(7, Associativity.Left, signo_mas, signo_menos);
            RegisterOperators(8, Associativity.Left, signo_por, signo_div,signo_mod,signo_piso);
            RegisterOperators(9, Associativity.Right, signo_pot);
            RegisterOperators(10, Associativity.Right, pr_not);
            RegisterOperators(11, Associativity.Left, punto);
            RegisterOperators(12, Associativity.Neutral, parizq, parder);
            #endregion

            ExtDeclaracion.ErrorRule = SyntaxError + Eos;
            FunctionDef.ErrorRule = SyntaxError + Dedent;
            AddToNoReportGroup(parizq);
            AddToNoReportGroup(Eos);

            NonGrammarTerminals.Add(ToTerm(@"\"));
            MarkPunctuation(parizq, parder, llaizq, llader, ptcoma, dospts, coma, igual, punto);
            this.Root = S;
        }

        public override void CreateTokenFilters(LanguageData language, TokenFilterList filters)
        {
            var outlineFilter = new CodeOutlineFilter(language.GrammarData,
              OutlineOptions.ProduceIndents | OutlineOptions.CheckBraces, ToTerm(@"\")); // "\" is continuation symbol
            filters.Add(outlineFilter);

        }
    }
}
