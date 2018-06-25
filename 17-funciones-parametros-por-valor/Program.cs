using System;

namespace _17_funciones_parametros_por_valor {
    class Program {
        public static void duplica (int x) {
            Console.WriteLine (" El valor recibido por valor  vale {0}", x);
            x = x * 2;
            Console.WriteLine (" y ahora vale {0}", x);
        }
        public static void Main () {
            int n = 5;
            Console.WriteLine ("n vale {0}", n);
            duplica (n);
            Console.WriteLine ("Ahora n sigue valiendo  {0} ", n);
        }
    }
}