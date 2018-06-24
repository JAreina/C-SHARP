using System;

namespace _8_forEACH {
    class Program {
        static void Main (string[] args) {

            int[] diasMes = { 31, 28, 21 };

            foreach (int dia in diasMes) {
                Console.WriteLine ("Dias del mes: {0}", dia);
            }

            string[] nombres = { "JUAN", "VANESSA", "EVA" };

            foreach (string nombre in nombres) {
                Console.Write ("---> {0}", nombre);
            }
            Console.WriteLine ();

            string saludo = "Hola";

            foreach (char letra in saludo) {
                Console.Write ("{0}---------------", letra);
            }
            Console.WriteLine ();
        }
    }
}
