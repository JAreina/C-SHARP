using System;

namespace _19_Random {
    class Program {

        public static void Main () {
            Random r = new Random ();
            int aleatorio = r.Next (1, 11);
            Console.WriteLine ("Un número entre 1 y 10: {0}", aleatorio);
            int aleatorio2 = r.Next (1, 191);
            Console.WriteLine ("Otro: {0}", aleatorio2);
        }
    }
}