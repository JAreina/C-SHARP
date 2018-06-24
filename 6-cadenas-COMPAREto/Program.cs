using System;

namespace _6_cadenas_COMPAREto {
    class Program {
        static void Main (string[] args) {
            string frase;
            Console.WriteLine ("Escriba una palabra");
            frase = Console.ReadLine ();
            // Compruebo si es exactamente hola
            if (frase == "hola")
                Console.WriteLine ("Ha escrito hola");
            // Compruebo si es mayor o menor
            if (frase.CompareTo ("hola") > 0)
                Console.WriteLine ("Es mayor que hola");
            else if (frase.CompareTo ("hola") < 0)
                Console.WriteLine ("Es menor que hola");
            // Comparo sin distinguir mayúsculas ni minúsculas
            bool ignorarMays = true;
            if (String.Compare (frase, "hola", ignorarMays) > 0)
                Console.WriteLine ("Es mayor que hola ");
            else if (String.Compare (frase, "hola", ignorarMays) < 0)
                Console.WriteLine ("Es menor que hola ");
            else
                Console.WriteLine ("Es hola o algo parecido");
        }
    }
}