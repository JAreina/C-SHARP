using System;
using System.Text;

namespace _7_cadenas_STRING_BUFFER {
    class Program {
        static void Main (string[] args) {

            StringBuilder cadenaModificable = new StringBuilder ("Hola");
            cadenaModificable[0] = 'M';

            Console.WriteLine ("Cadena modificada: {0}", cadenaModificable);
            
            string cadenaNormal;
            cadenaNormal = cadenaModificable.ToString ();
            Console.WriteLine ("Cadena normal a partir de ella: {0}",
                cadenaNormal);
        }
    }
}