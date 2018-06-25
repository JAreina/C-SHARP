using System;

namespace _14_funciones {
    class Program {
        public static void Saludar () {
            Console.WriteLine ("funcion Saludar()");
            Console.WriteLine ("HOLA");
            Console.WriteLine ("----FIN SALUDO");
        }

        public static void escribeNumeroReal (float n) {
            Console.WriteLine ("FUNCION NUMERO REAL");
            Console.WriteLine (n.ToString ("#.###"));
            Console.WriteLine ("FIN FUNCION NUMERO REAL");
        }

        public static int cuadrado (int n) {
            return n * n;
        }

        public static float mayor (float n1, float n2) {
            if (n1 > n2)
                return n1;
            else
                return n2;
        }
        public static void Main () {
            Saludar ();
            escribeNumeroReal (3.46666434F);
            Console.WriteLine (cuadrado (100));
           Console.WriteLine("mayor : "+ mayor(100000,300000));
            Console.WriteLine ("fin del main");
        }
    }
}