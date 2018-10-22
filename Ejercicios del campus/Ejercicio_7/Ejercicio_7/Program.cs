using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_7;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            bool seguir = true;

            Cajon cajon = new Cajon(20);

            Fruta manzana = new Fruta();
            Fruta naranja = new Fruta();

            while(seguir)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\t1. Agregar Fruta.\n");
                Console.Write("\n\t2. Borrar Fruta.\n");
                Console.Write("\n\t3. Mostrar lista de Frutas.\n");
                Console.Write("\n\t4. Salir\n");
                
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch(opcion)
                    {
                        case 1:
                            Console.Clear();
                            cajon.AgregarFruta(manzana);
                            cajon.AgregarFruta(naranja);
                            Console.Write("\n\tSe han agregado frutas al cajon!\n");
                            break;
                        case 2:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Gray;
                            cajon.QuitarFruta();
                            Console.Write("\n\tSe a borrado un producto al azar!\n");
                            break;
                        case 3:
                            Console.Clear();
                            Console.Write(cajon.MostrarContenido());
                            break;
                        case 4:
                            seguir = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\n\tLa opcion elegida no es correcta!");
                            break;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
