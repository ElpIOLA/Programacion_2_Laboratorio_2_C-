using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestEjercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabras = "Las gallinas son asi\r\nSon las amargas de la argentina\r\nCuando no salen campeon\r\nEsas tribunas estan vacias",
                recibe = "";

            if (AdministrarArchivos.Escribir(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), palabras))
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Archivo guardado en Escritorio");
            }
            else
            {
                Console.WriteLine("No se pudo agregar el archivo!\n");
            }

            if (AdministrarArchivos.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), out recibe))
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Archivo leido de Escritorio\n");
            }
            else
            {
                Console.WriteLine("No se pudo leer!");
            }

            /******************************************************************************************************************************************************/

            if (AdministrarArchivos.Escribir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), palabras))
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Archivo guardado en Mis Documentos!");
            }
            else
            {
                Console.WriteLine("No se pudo agregar el archivo!");
            }

            if (AdministrarArchivos.Leer(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), out recibe))
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Archivo leido de Mis Documentos!\n");
            }
            else
            {
                Console.WriteLine("No se pudo leer!");
            }

            /******************************************************************************************************************************************************/

            if (AdministrarArchivos.Escribir(AppDomain.CurrentDomain.BaseDirectory, palabras))
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Archivo guardado en Mis Imagenes!");
            }
            else
            {
                Console.WriteLine("No se pudo agregar el archivo!");
            }

            if (AdministrarArchivos.Leer(AppDomain.CurrentDomain.BaseDirectory, out recibe))
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Archivo leido de Mis Imagenes!");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n{0}", recibe);
            }
            else
            {
                Console.WriteLine("No se pudo leer!");
            }
            Console.ReadKey();
        }
    }
}
