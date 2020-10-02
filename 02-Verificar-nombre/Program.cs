// Validar Nombres
// Tener en cuenta las siguientes definiciones
// a) El término ingresado pueden ser iniciales o palabras completas
// b) Una inicial es solo un carácter más un punto
// c) Una palabra se comprende de 2 o más caracteres, sin punto.

// Un nombre válido se puede escribir de alguna de las siguientes formas:

// E. Poe
// E.A. Poe
// Edgard Allan Poe
// Edgard A. Poe

// Los siguientes ejemplos son inválidos:

// Edgard (solo nombres o apellidos no son válidos)
// E Poe o E.A Poe (las iniciales deben contener un punto)
// e. Poe o E. poe o e.a. Poe (sin mayúsculas)
// E. Allan Poe (el segundo nombre completo, mientras que el primero es solo una inicial)
// E.A. P. (El apellido es una palabra completa)
// Edg. A. Poe (la inicial debe ser una letra)

// Reglas
// a) Tanto las iniciales como las palabras deben estar capitalizadas (la primera letra en 
// mayúsculas).
// b) Las iniciales deben terminar en punto (.)
// c) Solo habrán 2 o 3 términos en el ingreso. Es decir, o dos nombres y un apellido o solo
// un nombre y un apellido.
// d) Si se ingresan 2 nombres y un apellido, los 2 primeros pueden ser iniciales, o solo el
// segundo. Nunca puede ser una inicial el primer nombre y no el segundo.
// e) El apellido siempre debe ser una palabra completa

// La tarea consiste en escribir una función que, siguiendo las reglas anteriores, devuelva 
// si un nombre es válido (true) o no (false).

// Ejemplos:
// ValidName("E. Poe") // true
// ValidName("E.A. Poe") // true
// ValidName("Edgard A. Poe") // true
// ValidName("Edgard") // false

// deben ser 2 o 3 palabras
// ValidName("e. Poe") // false

// capitalización
// ValidName("E Poe") // false

// falta el punto detrás de la inicial
// ValidName("E. Allan Poe") // false

// no es válido: inicial como primer nombre y palabra como segundo
// ValidName("E. Allan P.") // false

// Apellido como inicial
// ValidName("Edg. Allan Poe") // false

using System;
using System.Linq;

namespace Validador
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool a = ValidName("E. Poe"); //➞ true
            bool b = ValidName("E.A. Poe");// ➞ true
            bool c = ValidName("Edgard A. Poe");// ➞ true
            bool d = ValidName("Edgard");// ➞ false
                                         //deben ser 2 o tres palabras
            bool e = ValidName("e. Poe");// ➞ false
                                         // capitalizacion
            bool f = ValidName("E Poe"); //➞ false
                                         // falta el punto detrás de la inicial
            bool g = ValidName("E. Allan Poe"); //➞ false
                                                // no es valido: inicial como primer nombre y palabra como segundo
            bool h = ValidName("E. Allan P."); //➞ false
                                               // Apellido como inicial
            bool i = ValidName("Edg. Allan Poe"); //➞ false

            Console.WriteLine(a);
            Console.ReadKey();
        } // end método Main

        public static bool ValidName(string name)
        {
            if (name.Split(null).Count() == 1)
            {
                return false;
            }
            else
            {
                if (name.Split(null).Count() == 2)
                {

                    //es nombre y apellido
                    return ValidarNombreYApellido(name.Split(null)[0], name.Split(null)[1]);
                }
                else
                {
                    if (name.Split(null).Count() == 3)
                    {
                        return ValidarNombreYApellido(name.Split(null)[0], name.Split(null)[1], name.Split(null)[2]);
                    }
                }
            }
            return true;
        } // end método ValidName

        private static bool ValidarNombreYApellido(string nombre, string apellido)
        {
            if (apellido.Contains('.') || StartsWithUpper(nombre) == false || StartsWithUpper(apellido) == false || nombre.Count() == 1)
            {
                return false;
            }
            else
            {
                if (apellido.Count() >= 2)
                {
                    //me fijo si el apellido comienza con mayuscula
                    if (StartsWithUpper(apellido) == false)
                    {
                        return false;
                    }
                }
            }
            if (nombre.Count() == 2 && nombre.Contains("."))
            {
                //es inicial
                if (StartsWithUpper(apellido) == false)
                {
                    return false;
                }
            }
            return true;
        } // end metodo ValidarNombreYApellido

        private static bool ValidarNombreYApellido(string PrimerNombre, string SegundoNombre, string apellido)
        {
            if (apellido.Contains('.') || StartsWithUpper(PrimerNombre) == false || StartsWithUpper(SegundoNombre) == false || StartsWithUpper(apellido) == false || apellido.Count() == 1)
            {
                return false;
            }
            else
            {
                if ((PrimerNombre.Count() > 3 && PrimerNombre.Contains('.')) || (SegundoNombre.Count() > 3 && SegundoNombre.Contains('.')))
                {
                    return false;
                }

                //si el primer nombre es inicial, el segundo tambien debe ser inicial
                if (PrimerNombre.Count() == 1 || SegundoNombre.Count() == 1)
                {
                    return false;
                }

                if (PrimerNombre.Count() == 2)
                {
                    if (PrimerNombre.Contains('.'))
                    {
                        if (SegundoNombre.Count() > 2 && !SegundoNombre.Contains('.'))
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }

                }
            }

            return true;
        } // end metodo StartsWithUpper

        private static bool StartsWithUpper(string nombres)
        {
            if (char.IsUpper(nombres[0]))
            {
                return true;
            }
            return false; ;
        } // end metodo StartsWithUpper
    } // end class Program
} // end namespace Validador
