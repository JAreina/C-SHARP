using System;
  using System.IO; // Para StreamWriter
namespace _29_ficheros
{
  
public class Ejemplo70
{
public static void Main()
{
StreamWriter fichero;
fichero = File.CreateText("prueba.txt");
fichero.WriteLine("Esto es una línea");
fichero.Write("Esto es otra");
fichero.WriteLine(" y esto es continuación de la anterior");
fichero.Close();
}
}
}
