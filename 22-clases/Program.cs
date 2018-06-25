using System;

namespace _22_clases {
    
    class Puerta {
        int ancho; // Ancho en centimetros
        int alto; // Alto en centimetros
        int color; // Color en formato RGB
        bool abierta; // Abierta o cerrada
        public void Abrir () {
            abierta = true;
        }
        public void Cerrar () {
            abierta = false;
        }
        public void MostrarEstado () {
            Console.WriteLine ("Ancho: {0}", ancho);
            Console.WriteLine ("Alto: {0}", alto);
            Console.WriteLine ("Color: {0}", color);
            Console.WriteLine ("Abierta: {0}", abierta);
        }
    } // Final de la clase Puerta

    public class Principal {
        public static void Main () {
            Puerta p = new Puerta ();
            Console.WriteLine ("Valores iniciales...");
            p.MostrarEstado ();
            Console.WriteLine ("\nVamos a abrir...");
            p.Abrir ();
            p.MostrarEstado ();
        }
    }
}