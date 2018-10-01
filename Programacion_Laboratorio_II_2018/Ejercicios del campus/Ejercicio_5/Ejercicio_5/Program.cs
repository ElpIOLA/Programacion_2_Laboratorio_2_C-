using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_5;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Estante estante = new Estante(3, 1);

            Producto p1 = new Producto("Manzana","P2P3P4P5",(float)20.30);
            Producto p2 = new Producto("Coca-Cola", "COSDS55752", (float)11.5);
            Producto p3 = new Producto("Manaos", "MASDS51292", (float)20.5);
            Producto p4 = new Producto("Crush", "CRSDS54861", (float)10.75);
            if (estante + p1)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nAgregó: Marca: {0} Codigo: {1} Precio: {2}", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nNo agregó: Marca: {0} Codigo: {1} Precio: {2}", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }
            if (estante + p2)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nAgregó: Marca: {0} Codigo: {1} Precio: {2}", p2.GetMarca(), (string)p2, p2.GetPrecio());
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nNo agregó: Marca: {0} Codigo: {1} Precio: {2}", p2.GetMarca(), (string)p2, p2.GetPrecio());
            }
            if (estante + p3)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nAgregó: Marca: {0} Codigo: {1} Precio: {2}", p3.GetMarca(), (string)p3, p3.GetPrecio());
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nNo agregó: Marca: {0} Codigo: {1} Precio: {2}", p3.GetMarca(), (string)p3, p3.GetPrecio());
            }
            if (estante + p4)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nAgregó: Marca: {0} Codigo: {1} Precio: {2}", p4.GetMarca(), (string)p4, p4.GetPrecio());
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nNo agregó: Marca: {0} Codigo: {1} Precio: {2}", p4.GetMarca(), (string)p4, p4.GetPrecio());
            }
            Console.WriteLine();
            Console.WriteLine("<------------------------------------------------->");
            Console.Write(Estante.MostrarEstante(estante));
            Console.ReadKey();
        }
    }
}
