using System;

namespace _11_struct_anidados {
    class Program {

        struct fechaNacimiento {
            public int dia;
            public int mes;
            public int anyo;
        }
        struct tipoPersona {
            public string nombre;
            public char inicial;
            public fechaNacimiento diaDeNacimiento;
            public float nota;
        }

        public static void Main () {

            tipoPersona persona;
            
            persona.nombre = "Juan";
            persona.inicial = 'J';
            persona.diaDeNacimiento.dia = 15;
            persona.diaDeNacimiento.mes = 9;
            persona.nota = 7.5f;

            Console.WriteLine ("{0} nació en el mes {1}",
                persona.nombre, persona.diaDeNacimiento.mes);
        }

    }
}