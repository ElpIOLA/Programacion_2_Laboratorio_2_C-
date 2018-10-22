using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace LavaderoTest
{
  class Program
  {
    static void Main(string[] args)
    {
      Lavadero lavadero = new Lavadero("Quiero lavar el auto");

      Vehiculo a1 = new Vehiculo("LPM", 4, EMarcas.Honda);
      Vehiculo a2 = new Vehiculo("ABC", 4, EMarcas.Scania);
      Vehiculo a3 = new Vehiculo("ZBG", 4, EMarcas.Iveco);

      Moto m1 = new Moto(a1.Patente, a1.CantidadRuedas, a1.Marca, 70);
      Auto v1 = new Auto(a2.Patente, a2.Marca, 4);
      Camion c1 = new Camion(a3, 2000);

      lavadero += m1;
      lavadero += v1;
      lavadero += c1;

      
        lavadero.Vehiculos.Sort(Lavadero.OrdenarVehiculoPorPatente);
        Console.Write("\n\tTOTAL FACTURA: {0}\n", lavadero.MostrarTotalFacturado());
        Console.Write(lavadero.LavaderoToString);
        Console.ReadKey();

        Console.Clear();
        Console.Write("\n\tTOTAL FACTURA: {0}\n", lavadero.MostrarTotalFacturado());
        lavadero -= m1;
        Console.Write(lavadero.LavaderoToString);
        Console.ReadKey();
      

      Console.ReadKey();
    }
  }
}
