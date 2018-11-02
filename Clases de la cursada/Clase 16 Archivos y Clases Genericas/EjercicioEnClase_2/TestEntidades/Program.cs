using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestEntidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Cocina c1 = new Cocina(111, 12300, false);
            Cocina c2 = new Cocina(112, 15000, true);
            Cocina c3 = new Cocina(113, 5600, false);
            DepositoDeCocinas dc = new DepositoDeCocinas(5);
            dc.Agregar(c1);
            dc.Agregar(c2);
            if (!(dc + c3))
            {
                Console.WriteLine("No se pudo agregar el item!!!");
            }
            Console.WriteLine(dc);
            dc.Remover(c2);
            if (!(dc - c2))
            {
                Console.WriteLine("No se pudo remover el item!!!");
            }
            Console.WriteLine(dc);

            // con @ adelante de la cadena el compilador no toma el \ como caracter de escape.
            if(dc.Guardar(@"E:\EjercicioEnClase_2\archivo.txt"))
            {
                Console.WriteLine("Archivo guardado con exito!");
            }
            else
            {
                Console.WriteLine("No se pudo agregar el archivo!");
            }

            if (dc.Recuperar(@"E:\EjercicioEnClase_2\archivo.txt"))
            {
                Console.WriteLine("Archivo leido con exito!");
            }
            else
            {
                Console.WriteLine("El archivo no existe!");
            }
            Console.ReadLine();
        }
    }
}
