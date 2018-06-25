using System;

namespace _24_constructor {
    public class Puerta {
        int ancho; // Ancho en centimetros
        int alto; // Alto en centimetros
        int color; // Color en formato RGB
        bool abierta; // Abierta o cerrada
        public Puerta () {
            ancho = 100;
            alto = 200;
            color = 0xFFFFFF;
            abierta = false;
        }
        public Puerta (int an, int al) {
            ancho = an;
            alto = al;
            color = 0xFFFFFF;
            abierta = false;
        }
 
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
    public class Ejemplo61 {
        public static void Main () {
            Puerta p = new Puerta ();
            Puerta p2 = new Puerta (90, 220);
            Console.WriteLine ("Valores iniciales...");
            p.MostrarEstado ();
            Console.WriteLine ("\nVamos a abrir...");
            p.Abrir ();
            p.MostrarEstado ();
            Console.WriteLine ("Para la segunda puerta...");
            p2.MostrarEstado ();
        }
    }
}