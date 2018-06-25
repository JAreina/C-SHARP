using System;

namespace _23_herencia {
    public class Puerta {
        protected int ancho; // Ancho en centimetros
        protected int alto; // Alto en centimetros
        protected int color; // Color en formato RGB
        protected bool abierta; // Abierta o cerrada
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
    // -------------------------------
    public class Porton : Puerta {// hereda : de Puerta
        bool bloqueada;
        public void Bloquear () {
            bloqueada = true;
        }
        public void Desbloquear () {
            bloqueada = false;
        }
        public new void MostrarEstado () {
            Console.WriteLine ("Ancho: {0}", ancho);
            Console.WriteLine ("Alto: {0}", alto);
            Console.WriteLine ("Color: {0}", color);
            Console.WriteLine ("Abierta: {0}", abierta);
            Console.WriteLine ("Bloqueada: {0}", bloqueada);
        }
    } // Final de la clase Porton
    // -------------------------------
    public class Principal {

        public static void Main () {
            Porton p = new Porton ();
            Console.WriteLine ("Valores iniciales...");
            p.MostrarEstado ();
            Console.WriteLine ("\nVamos a bloquear...");
            p.Bloquear ();
            p.MostrarEstado ();
            Console.WriteLine ("\nVamos a desbloquear y a abrir...");
            p.Desbloquear ();
            p.Abrir ();
            p.MostrarEstado ();
        }
    }
}