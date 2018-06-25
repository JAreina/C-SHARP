using System;
using System.IO;
namespace _30_ficheros_excepciones {
    public class Ejemplo75 {

        public static void Main () {
            StreamReader fichero;
            string nombre;
            string linea;
            Console.WriteLine ("Introduzca el nombre del fichero");
            nombre = Console.ReadLine ();
            try {
                fichero = File.OpenText (nombre);
                do {
                    linea = fichero.ReadLine ();
                    if (linea != null)
                        Console.WriteLine (linea);
                }
                while (linea != null);
                fichero.Close ();
            } catch (Exception exp) {
                Console.WriteLine ("Ha habido un error: {0}", exp.Message);
                return;
            }
        }
    }
}