using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201504242._3Dinterprete
{
    class operar
    {
        public static object operarG(object op1 , object op2 , string op)
        {
            switch (op)
            {
                case "+":
                    #region SUMA
                    if (op1 is int && op2 is double)
                    {
                        return (int)op1 + (double)op2;
                    }
                    if (op1 is double && op2 is int)
                    {
                        return (double)op1 + (int)op2;
                    }
                    if (op1 is bool && op2 is double)
                    {
                        int o1 = (bool)op1 ? 1 : 0;
                        return o1 + (double)op2;
                    }
                    if (op1 is double && op2 is bool)
                    {
                        int o2 = (bool)op1 ? 1 : 0;
                        return (double)op1 + o2;
                    }
                    if (op1 is double && op2 is double)
                    {
                        return (double)op1 + (double)op2;
                    }
                    if (op1 is string || op2 is string)
                    {
                        return op1.ToString() + op2.ToString();
                    }
                    if (op1 is bool && op2 is bool)
                    {
                        return (bool)op1 || (bool)op2;
                    }
                    if (op1 is int && op2 is char)
                    {
                        return (int)op1 + (int)((char)op2);
                    }
                    if (op1 is bool && op2 is int)
                    {
                        int o1 = (bool)op1 ? 1 : 0;
                        return o1 + (int)op2;
                    }
                    if (op1 is int && op2 is bool)
                    {
                        int o2 = (bool)op1 ? 1 : 0;
                        return (int)op1 + o2;
                    }
                    if (op1 is int && op2 is int)
                    {
                        return (int)op1 + (int)op2;
                    }
                    #endregion
                    break;
                case "-":
                    #region Resta
                    if (op1 is int && op2 is double)
                    {
                        return (int)op1 - (double)op2;
                    }
                    if (op1 is double && op2 is int)
                    {
                        return (double)op1 - (int)op2;
                    }


                    if (op1 is bool && op2 is double)
                    {
                        int o1 = (bool)op1 ? 1 : 0;
                        return o1 - (double)op2;
                    }
                    if (op1 is double && op2 is bool)
                    {
                        int o2 = (bool)op1 ? 1 : 0;
                        return (double)op1 - o2;
                    }
                    if (op1 is double && op2 is double)
                    {
                        return (double)op1 - (double)op2;
                    } //Tipo resultante de datos: Entero

                    if (op1 is bool && op2 is int)
                    {
                        int o1 = (bool)op1 ? 1 : 0;
                        return o1 - (int)op2;
                    }
                    if (op1 is int && op2 is bool)
                    {
                        int o2 = (bool)op1 ? 1 : 0;
                        return (int)op1 - o2;
                    }
                    if (op1 is int && op2 is int)
                    {
                        return (int)op1 - (int)op2;
                    }
                    #endregion
                    break;
                case "*":
                    #region Multiplicacion
                    if (op1 is int && op2 is double)
                    {
                        return (int)op1 * (double)op2;
                    }
                    if (op1 is double && op2 is int)
                    {
                        return (double)op1 * (int)op2;
                    }
                    if (op1 is bool && op2 is double)
                    {
                        int o1 = (bool)op1 ? 1 : 0;
                        return o1 * (double)op2;
                    }
                    if (op1 is double && op2 is bool)
                    {
                        int o2 = (bool)op1 ? 1 : 0;
                        return (double)op1 * o2;
                    }
                    if (op1 is double && op2 is double)
                    {
                        return (double)op1 * (double)op2;
                    }
                    if (op1 is bool && op2 is int)
                    {
                        int o1 = (bool)op1 ? 1 : 0;
                        return o1 * (int)op2;
                    }
                    if (op1 is int && op2 is bool)
                    {
                        int o2 = (bool)op1 ? 1 : 0;
                        return (int)op1 * o2;
                    }
                    if (op1 is int && op2 is int)
                    {
                        return (int)op1 * (int)op2;
                    }
                    if (op1 is bool && op2 is bool)
                    {
                        return (bool)op1 && (bool)op2;
                    }
                    #endregion
                    break;
                case "/":
                    #region DIVISION
                    if (op1 is int && op2 is double)
                    {
                        if ((double)op2 != 0.0)
                        {
                            return (int)op1 / (double)op2;
                        }
                        else
                        {
                            // GENERAR ERROR==========================================
                            return null;
                        }
                    }
                    if (op1 is double && op2 is int)
                    {
                        if ((int)op2 != 0)
                        {
                            return (double)op1 / (int)op2;
                        }
                        else
                        {
                            // GENERAR ERROR==========================================
                            return null;
                        }
                    }

                    if (op1 is bool && op2 is double)
                    {
                        int o1 = (bool)op1 ? 1 : 0;
                        if ((double)op2 != 0.0)
                        {
                            return o1 / (double)op2;
                        }
                        else
                        {
                            // GENERAR ERROR==========================================
                            return null;
                        }
                    }
                    if (op1 is double && op2 is bool)
                    {
                        int o2 = (bool)op1 ? 1 : 0;
                        if (o2 != 0)
                        {
                            return (double)op1 / o2;
                        }
                        else
                        {
                            // GENERAR ERROR==========================================
                            return null;
                        }
                    }
                    if (op1 is double && op2 is double)
                    {
                        if ((double)op2 != 0.0)
                        {
                            return (double)op1 / (double)op2;
                        }
                        else
                        {
                            // GENERAR ERROR==========================================
                            return null;
                        }
                    }
                    if (op1 is bool && op2 is int)
                    {
                        int o1 = (bool)op1 ? 1 : 0;
                        if ((int)op2 != 0)
                        {
                            return o1 / (int)op2;
                        }
                        else
                        {
                            // GENERAR ERROR==========================================
                            return null;
                        }
                    }
                    if (op1 is int && op2 is bool)
                    {
                        int o2 = (bool)op1 ? 1 : 0;
                        if (o2 != 0)
                        {
                            return (int)op1 / o2;
                        }
                        else
                        {
                            // GENERAR ERROR==========================================
                            return null;
                        }
                    }
                    if (op1 is int && op2 is int)
                    {
                        if ((int)op2 != 0)
                        {
                            double res = ((int)op1) * 1.0 / ((int)op2) * 1.0;
                            checked
                            {
                                if (!double.IsNaN(res))
                                {
                                    return res;
                                }
                                else
                                {
                                    return Int32.Parse((Math.Floor(res)).ToString());
                                }
                            }
                        }
                        else
                        {
                            // GENERAR ERROR==========================================
                            return null;
                        }
                    } //Tipo resultante de datos: Cadena
                    if (op1 is string || op2 is string)
                    {
                        // GENERAR ERROR==========================================
                        return null;
                    } //Tipo resultante de datos: Bool
                    if (op1 is bool && op2 is bool)
                    {
                        // GENERAR ERROR==========================================
                        return null;
                    }
                    #endregion
                    break;
                case "^":
                    #region POTENCIA
                    if (op1 is int && op2 is double)
                    {
                        return Math.Pow((int)op1, (double)op2);
                    }
                    if (op1 is double && op2 is int)
                    {
                        return Math.Pow((double)op1, (int)op2);
                    }

                    if (op1 is bool && op2 is double)
                    {
                        int o1 = (bool)op1 ? 1 : 0;
                        return Math.Pow(o1, (double)op2);
                    }
                    if (op1 is double && op2 is bool)
                    {
                        int o2 = (bool)op1 ? 1 : 0;
                        return Math.Pow((double)op1, o2);
                    }
                    if (op1 is double && op2 is double)
                    {
                        return Math.Pow((double)op1, (double)op2);
                    }

                    if (op1 is bool && op2 is int)
                    {
                        int o1 = (bool)op1 ? 1 : 0;
                        return Math.Pow(o1, (int)op2);
                    }
                    if (op1 is int && op2 is bool)
                    {
                        int o2 = (bool)op1 ? 1 : 0;
                        return Math.Pow((int)op1, o2);
                    }
                    if (op1 is int && op2 is int)
                    {
                        return Math.Pow((int)op1, (int)op2);
                    }
                    if (op1 is string || op2 is string)
                    {

                        return null;
                    }
                    if (op1 is bool && op2 is bool)
                    {

                        return null;
                    }
                    #endregion
                    break;
                case "%":
                    #region Modulo
                    if (op1 is int && op2 is double)
                    {
                        return (int)op1 % (double)op2;
                    }
                    if (op1 is double && op2 is int)
                    {
                        return (double)op1 % (int)op2;
                    }
                    if (op1 is bool && op2 is double)
                    {
                        int o1 = (bool)op1 ? 1 : 0;
                        return o1 * (double)op2;
                    }
                    if (op1 is double && op2 is bool)
                    {
                        int o2 = (bool)op1 ? 1 : 0;
                        return (double)op1 % o2;
                    }
                    if (op1 is double && op2 is double)
                    {
                        return (double)op1 % (double)op2;
                    }
                    if (op1 is bool && op2 is int)
                    {
                        int o1 = (bool)op1 ? 1 : 0;
                        return o1 % (int)op2;
                    }
                    if (op1 is int && op2 is bool)
                    {
                        int o2 = (bool)op1 ? 1 : 0;
                        return (int)op1 % o2;
                    }
                    if (op1 is int && op2 is int)
                    {
                        return (int)op1 % (int)op2;
                    }
                    #endregion
                    break;
                case ">":
                    #region  MAYORQUE
                    if (op1 is int && op2 is double)
                    {
                        return (int)op1 > (double)op2;
                    }
                    if (op1 is double && op2 is int)
                    {
                        return (double)op1 > (int)op2;
                    }
                    if (op1 is bool && op2 is double)
                    {
                        int o1 = (bool)op1 ? 1 : 0;
                        return o1 > (double)op2;
                    }
                    if (op1 is double && op2 is bool)
                    {
                        int o2 = (bool)op1 ? 1 : 0;
                        return (double)op1 > o2;
                    }
                    if (op1 is double && op2 is double)
                    {
                        return (double)op1 > (double)op2;
                    }
                    if (op1 is bool && op2 is int)
                    {
                        int o1 = (bool)op1 ? 1 : 0;
                        return o1 > (int)op2;
                    }
                    if (op1 is int && op2 is bool)
                    {
                        int o2 = (bool)op1 ? 1 : 0;
                        return (int)op1 > o2;
                    }
                    if (op1 is int && op2 is int)
                    {
                        return (int)op1 > (int)op2;
                    }

                    #endregion
                    break;
                case "<":
                    #region MENORQUE
                    if (op1 is int && op2 is double)
                    {
                        return (int)op1 < (double)op2;
                    }
                    if (op1 is double && op2 is int)
                    {
                        return (double)op1 < (int)op2;
                    }
                    if (op1 is bool && op2 is double)
                    {
                        int o1 = (bool)op1 ? 1 : 0;
                        return o1 < (double)op2;
                    }
                    if (op1 is double && op2 is bool)
                    {
                        int o2 = (bool)op1 ? 1 : 0;
                        return (double)op1 < o2;
                    }
                    if (op1 is double && op2 is double)
                    {
                        return (double)op1 < (double)op2;
                    }
                    if (op1 is bool && op2 is int)
                    {
                        int o1 = (bool)op1 ? 1 : 0;
                        return o1 < (int)op2;
                    }
                    if (op1 is int && op2 is bool)
                    {
                        int o2 = (bool)op1 ? 1 : 0;
                        return (int)op1 < o2;
                    }
                    if (op1 is int && op2 is int)
                    {
                        return (int)op1 < (int)op2;
                    }
                    if (op1 is bool && op2 is bool)
                    {
                        /// ERROR
                        return null;
                    }
                    #endregion
                    break;
                case "==":
                    #region IDENTICO
                    if (op1 is int && op2 is double)
                    {
                        return (int)op1 == (double)op2;
                    }
                    if (op1 is double && op2 is int)
                    {
                        return (double)op1 == (int)op2;
                    }
                    if (op1 is bool && op2 is double)
                    {
                        int o1 = (bool)op1 ? 1 : 0;
                        return o1 == (double)op2;
                    }
                    if (op1 is double && op2 is bool)
                    {
                        int o2 = (bool)op1 ? 1 : 0;
                        return (double)op1 == o2;
                    }
                    if (op1 is double && op2 is double)
                    {
                        return (double)op1 == (double)op2;
                    }
                    if (op1 is bool && op2 is int)
                    {
                        int o1 = (bool)op1 ? 1 : 0;
                        return o1 == (int)op2;
                    }
                    if (op1 is int && op2 is bool)
                    {
                        int o2 = (bool)op1 ? 1 : 0;
                        return (int)op1 == o2;
                    }
                    if (op1 is int && op2 is int)
                    {
                        return (int)op1 == (int)op2;
                    }
                    if (op1 is bool && op2 is bool)
                    {
                        return (bool)op1 == (bool)op2;
                    }
                    if (op1 == null && op2 == null)
                    {
                        return true;
                    }

                    if (op1 == null && op2 != null)
                    {
                        return false;
                    }
                    if (op1 != null && op2 == null)
                    {
                        return false;
                    }

                    #endregion
                    break;
                case "!=":
                    #region DISTINTO
                    if (op1 is int && op2 is double)
                    {
                        return (int)op1 != (double)op2;
                    }
                    else if (op1 is double && op2 is int)
                    {
                        return (double)op1 != (int)op2;
                    }
                    else if (op1 is bool && op2 is double)
                    {
                        int o1 = (bool)op1 ? 1 : 0;
                        return o1 == (double)op2;
                    }
                    else if (op1 is double && op2 is bool)
                    {
                        int o2 = (bool)op1 ? 1 : 0;
                        return (double)op1 != o2;
                    }
                    else if (op1 is double && op2 is double)
                    {
                        return (double)op1 != (double)op2;
                    }
                    else if (op1 is bool && op2 is int)
                    {
                        int o1 = (bool)op1 ? 1 : 0;
                        return o1 != (int)op2;
                    }
                    else if (op1 is int && op2 is bool)
                    {
                        int o2 = (bool)op1 ? 1 : 0;
                        return (int)op1 != o2;
                    }
                    else if (op1 is int && op2 is int)
                    {
                        return (int)op1 != (int)op2;
                    }
                    else if (op1 == null && op2 == null)
                    {
                        return false;
                    }
                    else if (op1 == null && op2 != null)
                    {
                        return true;
                    }
                    else if (op1 != null && op2 == null)
                    {
                        return true;
                    }



                    #endregion
                    break;
                case ">=":
                    #region  IGUALMAYORQUE
                    if (op1 is int && op2 is double)
                    {
                        return (int)op1 >= (double)op2;
                    }
                    if (op1 is double && op2 is int)
                    {
                        return (double)op1 >= (int)op2;
                    }
                    if (op1 is bool && op2 is double)
                    {
                        int o1 = (bool)op1 ? 1 : 0;
                        return o1 >= (double)op2;
                    }
                    if (op1 is double && op2 is bool)
                    {
                        int o2 = (bool)op1 ? 1 : 0;
                        return (double)op1 >= o2;
                    }
                    if (op1 is double && op2 is double)
                    {
                        return (double)op1 >= (double)op2;
                    }
                    if (op1 is bool && op2 is int)
                    {
                        int o1 = (bool)op1 ? 1 : 0;
                        return o1 >= (int)op2;
                    }
                    if (op1 is int && op2 is bool)
                    {
                        int o2 = (bool)op1 ? 1 : 0;
                        return (int)op1 >= o2;
                    }
                    if (op1 is int && op2 is int)
                    {
                        return (int)op1 >= (int)op2;
                    }

  
                    #endregion
                    break;
                case "<=":
                    #region IGUALMENORQUE
                    if (op1 is int && op2 is double)
                    {
                        return (int)op1 <= (double)op2;
                    }
                    if (op1 is double && op2 is int)
                    {
                        return (double)op1 <= (int)op2;
                    }
                    if (op1 is bool && op2 is double)
                    {
                        int o1 = (bool)op1 ? 1 : 0;
                        return o1 <= (double)op2;
                    }
                    if (op1 is double && op2 is bool)
                    {
                        int o2 = (bool)op1 ? 1 : 0;
                        return (double)op1 <= o2;
                    }
                    if (op1 is double && op2 is double)
                    {
                        return (double)op1 <= (double)op2;
                    }
                    if (op1 is bool && op2 is int)
                    {
                        int o1 = (bool)op1 ? 1 : 0;
                        return o1 <= (int)op2;
                    }
                    if (op1 is int && op2 is bool)
                    {
                        int o2 = (bool)op1 ? 1 : 0;
                        return (int)op1 <= o2;
                    }
                    if (op1 is int && op2 is int)
                    {
                        return (int)op1 <= (int)op2;
                    }


                    if (op1 is bool && op2 is bool)
                    {
                        /// ERROR
                        return null;
                    }
               
                    #endregion
                    break;
            }
            return null;
        }
    }
}
