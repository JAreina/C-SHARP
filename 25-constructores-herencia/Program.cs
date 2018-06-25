using System;

namespace _25_constructores_herencia {
    public class Animal {
        public Animal () {
            Console.WriteLine ("Ha nacido un animal");
        }
    }
    // ------------------
    public class Perro : Animal {
        public Perro () {
            Console.WriteLine ("Ha nacido un perro");
        }
    }
    // ------------------
    public class Gato : Animal {
        public Gato () {
            Console.WriteLine ("Ha nacido un gato");
        }
    }
    // ------------------
    public class GatoSiames : Gato {
        public GatoSiames () {
            Console.WriteLine ("Ha nacido un gato siamés");
        }
    }
    // ------------------
    public class Ejemplo62 {
        public static void Main () {
            Animal a1 = new Animal ();
            GatoSiames a2 = new GatoSiames ();
            Perro a3 = new Perro ();
            Gato a4 = new Gato ();
        }
    }
}