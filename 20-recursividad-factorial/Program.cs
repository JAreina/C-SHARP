using System;

namespace _20_recursividad_factorial {
    class Program {
        public static long fact (int n) {
            if (n == 1) // Aseguramos que termine
                return 1;
            return n * fact (n - 1); // Si no es 1, sigue la recursión
        }
        
        public static void Main () {
            int num;
            Console.WriteLine ("Introduzca un número entero: ");
            num = Convert.ToInt32 (System.Console.ReadLine ());
            Console.WriteLine ("Su factorial es: {0}", fact (num));
        }
    }
}