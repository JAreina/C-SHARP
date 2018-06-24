using System;

namespace _10_array_de_structs {
    class Program {

        struct tipoPersona {
            public string nombre;
            public char inicial;
            public int edad;
            public float nota;

        }

        public static void Main () {
            
            tipoPersona[] persona = new tipoPersona[100];
            persona[0].nombre = "Juan";
            persona[0].inicial = 'J';
            persona[0].edad = 20;
            persona[0].nota = 7.5f;
            Console.WriteLine ("La edad de {0} es {1}",
                persona[0].nombre, persona[0].edad);
            persona[1].nombre = "Pedro";
            Console.WriteLine ("La edad de {0} es {1}",
                persona[1].nombre, persona[1].edad);
        }
    }
}