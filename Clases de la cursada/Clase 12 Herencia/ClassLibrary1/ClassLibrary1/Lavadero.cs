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
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("\n\tRAZON SOCIAL: " + this._razonSocial + "\n");
        sb.AppendLine("\n\tPRECIOS DE LAVADO POR VEHICULOS: ");
        sb.AppendFormat("\n\tMoto: $" + Lavadero._precioMoto);
        sb.AppendFormat("\n\tAuto: $" + Lavadero._precioAuto);
        sb.AppendFormat("\n\tCamion: $" + Lavadero._precioCamion);
        sb.AppendLine("\n\n\tLISTA DE VEHICULOS SIENDO LAVADOS: \n");
        foreach (Vehiculo item in this._vehiculos)
        {
            sb.AppendLine("\n\t" + item.ToString() + "\n");
        }
        return sb.ToString();
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
            return string.Compare(v1.Patente, v2.Patente);
    }

    public int OrdenarVehiculosPorMarca(Vehiculo v1, Vehiculo v2)
    {
            return string.Compare(Enum.GetName(typeof(EMarcas), v1.Marca), Enum.GetName(typeof(EMarcas), v2.Marca));
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
