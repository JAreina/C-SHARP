using System;

namespace _21_Main_argumentos_return {
    class Program {

        // dotnet run hola adios
        public static int Main (string[] args) {
            Console.WriteLine ("Parámetros: {0}", args.Length);
            for (int i = 0; i < args.Length; i++) {
                Console.WriteLine ("El parámetro {0} es: {1}",
                    i, args[i]);
            }
            if (args.Length == 0) {
                Console.WriteLine ("Escriba algún parámetro!");
                Environment.Exit (1);
            }
            return 0;

            /*Parámetros: 2
El parámetro 0 es: hola
El parámetro 1 es: adios */
        }
    }
}