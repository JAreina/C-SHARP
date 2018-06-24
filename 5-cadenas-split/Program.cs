using System;

namespace _5_cadenas_split {
    class Program {
        static void Main (string[] args) {

            string cadena = "a,b.c,d";
            char[] delimitadores = { ',', '.' };
            int i;
            string[] arr = cadena.Split (delimitadores);
            
            for (i = 0; i < arr.Length; i++)
                Console.WriteLine ("PARTE --> {0}= {1}",
                    i, arr[i]);
        }
    }
}