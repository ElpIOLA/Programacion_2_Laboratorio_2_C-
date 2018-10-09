using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Lavadero
  {
    #region Atributos
    private List<Vehiculo> _vehiculos;
    private static float _precioAuto;
    private static float _precioCamion;
    private static float _precioMoto;
    private string _razonSocial;
    #endregion

    #region Constructor
    static Lavadero()
    {
      Random aleatorio = new Random();

      _precioAuto = (float)aleatorio.Next(150, 565);
      _precioCamion = (float)aleatorio.Next(150, 565);
      _precioMoto = (float)aleatorio.Next(150, 565);
    }

    private Lavadero()
    {
      this._vehiculos = new List<Vehiculo>();
    }

    public Lavadero(string razonSocial) : this()
    {
      this._razonSocial = razonSocial;
    }
    #endregion

    #region Propiedad
    public string LavaderoToString
    {
      get
      {
        string retorno = "";
        retorno += "\n\tRAZON SOCIAL: " + this._razonSocial + "\n";
        retorno += "\n\tPRECIOS DE LAVADO POR VEHICULOS: ";
        retorno += "\n\tMoto: $" + Lavadero._precioMoto;
        retorno += "\n\tAuto: $" + Lavadero._precioAuto;
        retorno += "\n\tCamion: $" + Lavadero._precioCamion;
        retorno += "\n\n\tLISTA DE VEHICULOS SIENDO LAVADOS: \n";
        foreach (Vehiculo item in this._vehiculos)
        {

          retorno += "\n\t" + item.ToString() + "\n";
        }
        return retorno;
      }
    }

    public List<Vehiculo> Vehiculos
    {
      get { return this._vehiculos; }
    }
    #endregion

    #region Metodos
    public double MostrarTotalFacturado()
    {
      double gananciaTotal = 0;

      gananciaTotal += this.MostrarTotalFacturado(EVehiculos.Auto);
      gananciaTotal += this.MostrarTotalFacturado(EVehiculos.Moto);
      gananciaTotal += this.MostrarTotalFacturado(EVehiculos.Camión);

      return gananciaTotal;
    }

    public double MostrarTotalFacturado(EVehiculos vehiculo)
    {
      double gananciaTotal = 0;

      foreach(Vehiculo item in this._vehiculos)
      {
        switch (vehiculo)
        {
          case EVehiculos.Auto:
            if (item is Auto)
              gananciaTotal += Lavadero._precioAuto;
            break;

          case EVehiculos.Moto:
            if (item is Moto)
              gananciaTotal += Lavadero._precioMoto;
            break;

          case EVehiculos.Camión:
            if (item is Camion)
              gananciaTotal += Lavadero._precioCamion;
            break;
        }
      }

      return gananciaTotal;
    }

    public static int OrdenarVehiculoPorPatente(Vehiculo v1, Vehiculo v2)
    {
      if(v1.Patente == v2.Patente)
        return 0;
      else if (v1.Patente.Length > v2.Patente.Length)
        return 1;
      else
        return -1;
    }

    public int OrdenarVehiculosPorMarca(Vehiculo v1, Vehiculo v2)
    {
      if (v1.Marca == v2.Marca)
        return 0;
      else if (v1.Marca > v2.Marca)
        return 1;
      else
        return -1;
    }
    #endregion

    #region SobreCargas
    public static bool operator ==(Lavadero L, Vehiculo V)
    {
      bool retorno = false;
      foreach (Vehiculo item in L._vehiculos)
      {
        if (item == V)
        {
          retorno = true;
          break;
        }
      }

      return retorno;
    }

    public static bool operator !=(Lavadero L, Vehiculo V)
    {
      return !(L == V);
    }

    public static int operator ==(Vehiculo V, Lavadero L)
    {
      int retorno = -1,
        cont = L._vehiculos.Count;

      for (int i = 0; i < cont; i++)
      {
        if (L._vehiculos[i] == V)
        {
          retorno = i;
          break;
        }
      }
      return retorno;
    }

    public static int operator !=(Vehiculo V, Lavadero L)
    {
      return -1;
    }

    public static Lavadero operator +(Lavadero L, Vehiculo V)
    {
      if (L != V)
        L._vehiculos.Add(V);
      
      return L;
    }

    public static Lavadero operator -(Lavadero L, Vehiculo V)
    {
      int index = (V == L);
      L._vehiculos.RemoveAt(index);

      return L;
    }
    #endregion
  }
}
