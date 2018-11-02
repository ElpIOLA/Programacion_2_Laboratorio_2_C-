using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            IAFIP afip;
            IARBA arba;

            Carreta ca1 = new Carreta(6300);
            Console.WriteLine("\n*********CARRETA*********");
            ca1.MostrarPrecio();

            Familiar f1 = new Familiar(124000.33, "HGF - 123", 4);
            Console.WriteLine("\n\n*********AUTO FAMILIAR*********");
            f1.MostrarPrecio();
            f1.MostrarPatente();
            Console.Write("\nCantidad de asientos: {0}", f1.CantidadAsientos);
            
            Deportivo d1 = new Deportivo(355000.55, "AAA - 666", 500);
            afip = d1;
            arba = d1;
            Console.WriteLine("\n\n*********AUTO DEPORTIVO*********");
            d1.MostrarPrecio();
            d1.MostrarPatente();
            Console.Write("\nImpuesto de Afip: {0:0.00}%", Gestion.MostrarImpuestoNacional(afip));
            Console.Write("\nImpuesto de Arba: {0:0.00}%", Gestion.MostrarImpuestoNacional(arba));

            Avion a1 = new Avion(5200, 2300);
            Console.WriteLine("\n\n*********AVION*********");
            a1.MostrarPrecio();
            afip = a1;
            arba = a1;
            Console.Write("\nVelocidad maxima: {0} Kilometros", a1.PropiedadDouble);
            Console.Write("\nImpuesto de Afip: {0:0.00}%", Gestion.MostrarImpuestoNacional(afip));
            Console.Write("\nImpuesto de Arba: {0:0.00}%", Gestion.MostrarImpuestoNacional(arba));

            Privado p1 = new Privado(7000, 2500, 65);
            Console.WriteLine("\n\n*********AVION PRIVADO*********");
            p1.MostrarPrecio();
            Console.Write("\nVelocidad maxima: {0} Kilometros", p1.PropiedadDouble);
            p1.MostrarValoracion();

            Comercial c1 = new Comercial(4000, 2000, 200);
            Console.WriteLine("\n\n*********AVION COMERCIAL*********");
            c1.MostrarPrecio();
            Console.Write("\nCantidad de pasajeros: {0}", c1.PropiedadInt);
            Console.Write("\nVelocidad maxima: {0} Kilometros", c1.PropiedadDouble);
            arba = c1;
            Console.Write("\nImpuesto de Arba: {0:0.00}%", Gestion.MostrarImpuestoNacional(arba));

            Console.ReadKey();
            
        }
    }
}
