using System;

namespace _26_array_de_objetos {
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
    // -- -- -- -- -- -- -- -- --
    public class GatoSiames : Gato {
        public GatoSiames () {
            Console.WriteLine ("Ha nacido un gato siamés");
        }
    }
    // ------------------
    public class Ejemplo63 {
        public static void Main () {
            Perro[] misPerros = new Perro[5];
            for (byte i = 0; i < 5; i++)
                misPerros[i] = new Perro ();


   Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@");
   
            Animal[] misAnimales = new Animal[8];
            misAnimales[0] = new Perro ();
            misAnimales[1] = new Gato ();
            misAnimales[2] = new GatoSiames ();
            for (byte i = 3; i < 7; i++)
                misAnimales[i] = new Perro ();
            misAnimales[7] = new Animal ();
        }
    }
}