using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Vehiculo
  {
    #region Atributos
    protected string _patente;
    protected Byte _cantRuedas;
    protected EMarcas _marca;
    #endregion

    #region Propiedades
    public string Patente
    {
      get { return this._patente; }
    }

    public byte CantidadRuedas
    {
      get { return this._cantRuedas; }
      set { this._cantRuedas = value; }
    }

    public EMarcas Marca
    {
      get { return this._marca; }
    }
    #endregion

    #region Constructor
    public Vehiculo(string patente, Byte ruedas, EMarcas marca)
    {
      this._patente = patente;
      this._cantRuedas = ruedas;
      this._marca = marca;
    }
    #endregion

    #region Metodos
    protected virtual string Mostrar()
    {
      return string.Format("Patente: " + this._patente + " Cantidad de ruedas: " + this._cantRuedas + " Marca: " + this._marca);
    }

    public override string ToString()
    {
      return Mostrar();
    }
    #endregion

    #region SobreCargas
    public static bool operator == (Vehiculo v1, Vehiculo v2)
    {
      bool retorno = false;

      if(!object.Equals(v1,null) && !object.Equals(v2, null))
      {
        if(v1.Patente == v2.Patente && v1.Marca == v2.Marca)
        {
          retorno = true;
        }
      }

      return retorno;
    }

    public static bool operator !=(Vehiculo v1, Vehiculo v2)
    {
      return !(v1 == v2);
    }
    #endregion
  }
}
