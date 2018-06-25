using System;

namespace _13_arrays_ordenacion {
    class Program {
        public static void Main () {
            int[] datos = { 5, 3, 14, 20, 8, 9, 1 };
            int i, j, datoTemporal;
            int n = 7; // Numero de datos
            // BURBUJA
            // (Intercambiar cada pareja consecutiva que no esté ordenada)
            // Para i=1 hasta n-1
            // Para j=i+1 hasta n
            // Si A[i] > A[j]
            // Intercambiar ( A[i], A[j])
            Console.WriteLine ("Ordenando mediante burbuja... ");
            for (i = 0; i < n - 1; i++) {
                foreach (int dato in datos) // Muestro datos
                    Console.Write ("{0} ", dato);
                Console.WriteLine ();
                for (j = i + 1; j < datos.Length ; j++) {
                    if (datos[i] > datos[j]) {
                        datoTemporal = datos[i];
                        datos[i] = datos[j];
                        datos[j] = datoTemporal;
                    }
                }
            }
            Console.Write ("Ordenado:");
          
            foreach (int dato in datos) // Muestro datos finales
                Console.Write ("{0} ", dato);
            Console.WriteLine ();
            // SELECCIÓN DIRECTA:
            // (En cada pasada busca el menor, y lo intercambia al final de la pasada)
            // Para i=1 hasta n-1
            // menor = i
            // Para j=i+1 hasta n
            // Si A[j] < A[menor]
            // menor = j
            // Si menor <> i
            // Intercambiar ( A[i], A[menor])
            Console.WriteLine ("\nOrdenando mediante selección directa... ");
            int[] datos2 = { 5, 3, 14, 20, 8, 9, 1 };
            for (i = 0; i < n - 1; i++) {
                foreach (int dato in datos2) // Muestro datos
                    Console.Write ("{0} ", dato);
                Console.WriteLine ();
                int menor = i;
                for (j = i + 1; j < n; j++)
                    if (datos2[j] < datos2[menor])
                        menor = j;
                if (i != menor) {
                    datoTemporal = datos2[i];
                    datos2[i] = datos2[menor];
                    datos2[menor] = datoTemporal;
                }
            }
            Console.Write ("Ordenado:");
            foreach (int dato in datos2) // Muestro datos finales
                Console.Write ("{0} ", dato);
            Console.WriteLine ();
            // INSERCION DIRECTA:
            // (Comparar cada elemento con los anteriores -que ya están ordenados-
            // y desplazarlo hasta su posición correcta).
            // Para i=2 hasta n
            // j=i-1
            // mientras (j>=1) y (A[j] > A[j+1])
            // Intercambiar ( A[j], A[j+1])
            // j = j - 1
            Console.WriteLine ("\nOrdenando mediante inserción directa... ");
            int[] datos3 = { 5, 3, 14, 20, 8, 9, 1 };
            for (i = 1; i < n; i++) {
                foreach (int dato in datos3) // Muestro datos
                    Console.Write ("{0} ", dato);
                Console.WriteLine ();
                j = i - 1;
                while ((j >= 0) && (datos3[j] > datos3[j + 1])) {
                    datoTemporal = datos3[j];
                    datos3[j] = datos3[j + 1];
                    datos3[j + 1] = datoTemporal;
                    j--;
                }
            }
            Console.Write ("Ordenado:");
            foreach (int dato in datos3) // Muestro datos finales
                Console.Write ("{0} ", dato);
            Console.WriteLine ();
        }
    }
}