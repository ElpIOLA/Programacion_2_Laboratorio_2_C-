using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 07 calcular dias vividos";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\t\tPROGRAMA CALCULAR DIAS VIVIDOS\n");

            int dia = 0,
                mes = 0,
                año = 0;

            DateTime fechaPersona; //En esta variable se guardara la fecha del usuario.
            DateTime fechaActual = DateTime.Today; //Fecha Actual.
            TimeSpan dias;

            Console.Write("\nIngrese dia de nacimiento: ");
            dia = int.Parse(Console.ReadLine());

            Console.Write("\nIngrese mes de nacimiento: ");
            mes = int.Parse(Console.ReadLine());

            Console.Write("\nIngrese año de nacimiento: ");
            año = int.Parse(Console.ReadLine());

            fechaPersona = new DateTime(año, mes, dia);

            dias = fechaActual - fechaPersona; //Ha la fecha actual le restamos la fecha del usuario.
            
            
            Console.WriteLine("\n\tUsted nacio en la fecha: {0:dddd, dd \\de MMMM \\de yyyy}", fechaPersona);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\t\t USTED VIVIO HASTA AHORA {0:dddd} DIAS.", dias);

            Console.ReadLine();
        }
    }
}
