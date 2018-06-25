using System;

namespace _27_funciones_virtuales_overrride {
    class Program {
        public class Animal {
           // public  void Hablar () {
            public virtual void Hablar () {
                Console.WriteLine ("Estoy comunicándome...");
            }
        }
        // ------------------
        public class Perro : Animal {
            // public new void Hablar () {
            public override void Hablar () {
                Console.WriteLine ("Guau!");
            }
        }
        // ------------------
        public class Gato : Animal {
            // public new void Hablar () {
            public override void Hablar () {
                Console.WriteLine ("Miauuu");
            }
        }
        // ------------------
        public class Ejemplo65 {
            public static void Main () {
                // Primero creamos un animal de cada tipo
                Perro miPerro = new Perro ();
                Gato miGato = new Gato ();
                Animal miAnimal = new Animal ();
                miPerro.Hablar ();
                miGato.Hablar ();
                miAnimal.Hablar ();
              
                // Linea en blanco, por legibilidad
                Console.WriteLine ("@@@@@@@@@@@@");
                // Ahora los creamos desde un array
                Animal[] misAnimales = new Animal[3];
                misAnimales[0] = new Perro ();
                misAnimales[1] = new Gato ();
                misAnimales[2] = new Animal ();
                misAnimales[0].Hablar ();
                misAnimales[1].Hablar ();
                misAnimales[2].Hablar ();
            }
        }
    }
}