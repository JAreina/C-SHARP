using System;

namespace _16_funciones_variables_globales {
    class Program {
        static int n = 7;
        public static void cambiaN () {
            n++;
        }
        public static void Main () {
            Console.WriteLine ("n vale {0}", n);
            cambiaN ();
            Console.WriteLine ("Ahora n vale {0}", n);
        }
    }
}