using System;

namespace _22_clases
{
    public class Principal
    {
        
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
