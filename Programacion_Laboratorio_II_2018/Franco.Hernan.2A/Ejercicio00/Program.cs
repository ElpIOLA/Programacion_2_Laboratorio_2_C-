using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio00
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.Title = "Ejercicio00";
      string name;
      int edad;
      float sueldo;

      Console.ForegroundColor = ConsoleColor.Green; //Cambia de color las letras de la consola.

      Console.Write("Ingrese Nombre: ");
      name = Console.ReadLine(); //Sirve para agregar datos y para pausar el programa.

      Console.Write("Ingrese Edad: ");
      edad = int.Parse(Console.ReadLine()); //int.Parse sirve para convertir un string en un entero.

      Console.Write("Ingrese Sueldo: ");
      sueldo = float.Parse(Console.ReadLine()); 

      Console.WriteLine("\nHola {0}. Su edad es {1}. Su sueldo es {2:#.00}", name,edad,sueldo);
      Console.WriteLine("\nHoy es: {0:dddd, dd \\de MMMM \\de yyyy}", DateTime.Now);
      Console.ReadLine();

      //Tarea Instalar Visual Studio 2017.
    }
  }
}
