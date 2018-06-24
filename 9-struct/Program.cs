using System;

namespace _9_struct {
    class Program {
        
            struct tipoPersona {
                public string nombre;
                public char inicial;
                public int edad;
                public float nota;
            }

            public static void Main () {
                tipoPersona persona;
                persona.nombre = "Juan";
                persona.inicial = 'J';
                persona.edad = 200;
                persona.nota = 789877.5f;
                Console.WriteLine ("La edad de {0} es {1}",
                    persona.nombre, persona.edad);
            }
        }
    }
