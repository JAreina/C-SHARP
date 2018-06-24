using System;

namespace _3_cadenas {
    class Program {
        static void Main (string[] args) {
            string saludo = "Hola";
            string segundoSaludo;
            string nombre, despedida;

            segundoSaludo = "Que tal?";
            Console.WriteLine ("Dime tu nombre... ");
            nombre = Console.ReadLine ();

        
            Console.WriteLine ("{0} {1}", saludo, nombre);
            Console.WriteLine (segundoSaludo);

            if (nombre == "Rajoy")
                Console.WriteLine ("Dices que eres Rajoy?");
            else
                Console.WriteLine ("Así que no eres Rajoy?");

            despedida = "Adios " + nombre + "!";
            Console.WriteLine (despedida);


             /* length string */

            Console.WriteLine (nombre.Length + " : longitud de la cadena introducida");

            /* substring */
            
            Console.WriteLine (nombre.Substring (0, 1));

            /* indexof */

            string quixote = "En un lugar de la Mancha de cuyo nombre ...";
            if (quixote.IndexOf ("Mancha") != -1) {
                Console.WriteLine ("existe la palabra Mancha");
            }
            if(quixote.Contains("cuyo")) Console.WriteLine("APARECE LA PALABRA \"cuyo\"");
        }
    }
}