using System;

namespace _28_super_enJAVA_base_enCSHARP {
    public class Animal { }
    // ------------------
    public class Gato : Animal {
        public void Hablar () {
            Console.WriteLine ("Miauuu");
        }
    }
    // ------------------
   
    public class GatoSiames : Gato {
        public new void Hablar () {
            base.Hablar ();
            Console.WriteLine ("Pfff");
        }
    }
    // ------------------
    public class Ejemplo67 {
        public static void Main () {
            Gato miGato = new Gato ();
            GatoSiames miGato2 = new GatoSiames ();
            miGato.Hablar ();
            Console.WriteLine (); // Linea en blanco
            miGato2.Hablar ();
        }
    }
}