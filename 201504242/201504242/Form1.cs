using _201504242.com.AST;
using _201504242.Interprete;
using Irony.Parsing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _201504242
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void analizar_Click(object sender, EventArgs e)
        {
            try
            {
                string text = System.IO.File.ReadAllText(@"c:\entrada.txt");

                Gramatica grammar = new Gramatica();
                LanguageData lenguaje = new LanguageData(grammar);
                Parser parser = new Parser(lenguaje);
                ParseTree arbol = parser.Parse(text);
                ParseTreeNode raiz = arbol.Root;
                ConstructorAST builder = new ConstructorAST();

                if (arbol.ParserMessages.Count == 0)
                {
                    Graficador j = new Graficador();
                    j.graficar(arbol.Root);
                    ConstructorAST an = new ConstructorAST();
                    AST auxArbol = an.Analizar(arbol.Root);
                    if (auxArbol != null)
                    {
                        auxArbol.ejecutar();
                    }
                    else
                    {
                        MessageBox.Show("No gener bien mi arbol aux en form1");
                    }
                }
                else
                {
                    for (int i = 0; i < arbol.ParserMessages.Count; i++)
                    {
                        int fila = arbol.ParserMessages.ElementAt(i).Location.Line + 1;
                        MessageBox.Show("USL-Mensaje: " + arbol.ParserMessages.ElementAt(i).Message +
                            " Linea: " + fila +
                            " Columna: " + arbol.ParserMessages.ElementAt(i).Location.Column);
                    }
                    MessageBox.Show("Hay errores lexicos o sintacticos\n El arbol de Irony no se construyo. Cadena invalida!\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Source + "  " + ex.ToString());
            }
        }
    }
}
