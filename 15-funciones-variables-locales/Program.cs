using System;

namespace _15_funciones_variables_locales {
    class Program {
        
        public static int potencia (int nBase, int nExponente) {
            int temporal = 1; /* Valor que voy hallando */
            int i; /* Para bucles */
            for (i = 1; i <= nExponente; i++) /* Multiplico "n" veces */
                temporal *= nBase; /* Y calculo el valor temporal */
            return temporal; /* Tras las multiplicaciones, */
        } /* obtengo el valor que buscaba */


        public static void Main () {

            int num1, num2;
            Console.WriteLine ("Introduzca la base: ");
            num1 = Convert.ToInt32 (Console.ReadLine ());
            Console.WriteLine ("Introduzca el exponente: ");
            num2 = Convert.ToInt32 (Console.ReadLine ());
            Console.WriteLine ("{0} elevado a {1} vale {2}",
                num1, num2, potencia (num1, num2));
        }
    }
}