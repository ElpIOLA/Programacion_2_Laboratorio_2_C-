using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Ejercicio 08 Fabrica con empleados";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\t\tPrograma: Calcular sueldo de un empleado\n");
            Console.ForegroundColor = ConsoleColor.Green;
            float valorPorHora;
            int antiguedadEnAños;
            int cantidadDeHoras;
            int totalAños;
            float importe;
            float descuento;
            float importeFinal;
            string nombre;

            Console.Write("\n\tIngrese nombre: ");
            nombre = Console.ReadLine();

            Console.Write("\n\tIngrese el valor por hora: ");
            valorPorHora = float.Parse(Console.ReadLine());

            Console.Write("\n\tIngrese su antiguerdad: ");
            antiguedadEnAños = int.Parse(Console.ReadLine());

            Console.Write("\n\tIngrese la cantidad de horas trabajadas este mes: ");
            cantidadDeHoras = int.Parse(Console.ReadLine());

            totalAños = (antiguedadEnAños * 150);

            importe = (valorPorHora * cantidadDeHoras) + totalAños;

            descuento = (13 * importe) / 100;

            importeFinal = importe - descuento;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n\t------------------------------------------------------------");
            Console.WriteLine("\n\n\t\t-Nombre del empleado: {0}", nombre);
            Console.WriteLine("\n\t\t-Antiguedad: {0} año/s", antiguedadEnAños);
            Console.WriteLine("\n\t\t-Valor por hora: ${0:0.00}", valorPorHora);
            Console.WriteLine("\n\t\t-Importe bruto: ${0:00.00}",importe);
            Console.WriteLine("\n\t\t-Descuentos: -${0:00.00}", descuento);
            Console.WriteLine("\n\t\t-Importe neto: ${0:00.00}", importeFinal);


            Console.ReadLine();
        }
    }
}
