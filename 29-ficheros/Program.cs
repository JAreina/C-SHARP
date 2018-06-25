using System;
  using System.IO; // Para StreamWriter
namespace _29_ficheros
{
  
public class Ejemplo70
{
public static void Main()
{

    // ESCRIBIR 
StreamWriter fichero;
fichero = File.CreateText("prueba.txt");
fichero.WriteLine("Esto es una línea");
fichero.Write("Esto es otra");
fichero.WriteLine(" y esto es continuación de la anterior");
fichero.Close();


// LEER 

StreamReader fichero2;
string linea;
fichero2 = File.OpenText("prueba.txt");
linea = fichero2.ReadLine();
Console.WriteLine( linea );
Console.WriteLine( fichero2.ReadLine() );
fichero2.Close();


// LEER ENTERO EL FICHERO

StreamReader fichero3;
string linea2;
fichero3 = File.OpenText("prueba.txt");
do
{
linea2 = fichero3.ReadLine();
if (linea2 != null)
Console.WriteLine( linea2 );
}
while (linea2 != null);
fichero3.Close();


// AÑÑADIR AL FINAL 
StreamWriter fichero4;
fichero4 = File.CreateText("prueba2.txt");
fichero4.WriteLine("Primera línea");
fichero4.Close();
fichero4 = File.AppendText("prueba2.txt");
fichero4.WriteLine("Segunda línea");
fichero4.Close();


// @ para no poner las barras de escape
string nombreFichero = @"d:\ejemplos\ejemplo1.txt";
// EXIsTS el fichero

StreamReader fichero5;
string nombre;
while (true) {
Console.Write( "Dime el nombre del fichero (\"fin\" para terminar): ");
nombre = Console.ReadLine();
if (nombre == "fin")
break;
if ( File.Exists(nombre) )
{
fichero5 = File.OpenText( nombre );
Console.WriteLine("Su primera linea es: {0}",
fichero5.ReadLine() );
fichero5.Close();
}
else
Console.WriteLine( "No existe!" );
}
}
}
}
