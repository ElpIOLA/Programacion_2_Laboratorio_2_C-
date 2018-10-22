using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MiClase3 obj = new MiClase3();
                obj.metodoDeInstancia();
            }
            catch(Exception e)
            {
                Console.WriteLine("Mensaje de MiExcepcion: {0}", e.Message);
            }
            finally
            {
                Console.ReadKey();
            }

            try
            {
                MiClase4 obj = new MiClase4();
                obj.MetodoDeInstancia4();
            }
            catch (Exception e)
            {
                Console.WriteLine("Mensaje de MiExcepcion: {0}", e.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        public static void lanzarException()
        {
            throw new DivideByZeroException();
        }

        public static void lanzarOtroException()
        {
            throw new FormatException();
        }


  }
}
