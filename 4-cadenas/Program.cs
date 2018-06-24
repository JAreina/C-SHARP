using System;

namespace _4_cadenas {
    class Program {
        static void Main (string[] args) {
            string ejemplo = "better than you, better than you";
            Console.WriteLine ("El texto es: {0}",
                ejemplo);
            Console.WriteLine ("La primera letra es: {0}",
                ejemplo[0]);
            Console.WriteLine ("Las tres primeras letras son: {0}",
                ejemplo.Substring (0, 3));
            Console.WriteLine ("La longitud del texto es: {0}",
                ejemplo.Length);
            Console.WriteLine ("La posicion de \"a\" es: {0}",
                ejemplo.IndexOf ("a"));
            Console.WriteLine ("La ultima u esta en la posicion: {0}", ejemplo.LastIndexOf ("u"));
            Console.WriteLine ("En mayúsculas: {0}",
                ejemplo.ToUpper ());
            Console.WriteLine ("En minúsculas: {0}",
                ejemplo.ToLower ());
            Console.WriteLine ("Si insertamos \", YOU\": {0}",
                ejemplo.Insert (ejemplo.Length, " YOU"));
            Console.WriteLine ("Si borramos las 6 primeras letras: {0}",
                ejemplo.Remove (0, 6));
            Console.WriteLine ("Si cambiamos YOU por ALL: {0}",
                ejemplo.Replace ("you", "ALL"));
        }
    }
}