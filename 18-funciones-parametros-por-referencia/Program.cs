using System;

namespace _18_funciones_parametros_por_referencia {
    class Program {

        public static void duplica (ref int x) {
            Console.WriteLine (" El valor recibido por referencia vale {0}", x);
            x = x * 2;
            Console.WriteLine (" y ahora vale funcion duplica {0}", x);
        }
        public static void Main () {
            int n = 5;
            Console.WriteLine ("main: n vale {0}", n);
            duplica (ref n);
            Console.WriteLine ("main: Ahora n HA CAMBIADO {0}", n);
        }
    }
}