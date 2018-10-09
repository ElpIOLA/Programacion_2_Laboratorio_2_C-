using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Auto : Vehiculo
  {
    #region Atributos
    protected int _cantidadAsientos;
    #endregion

    #region Constructor
    public Auto(string patente, EMarcas marca, Byte cantRuedas ,int cantAsiento) : base(patente,cantRuedas,marca)
    {
      this._cantidadAsientos = cantAsiento;
    }

    public Auto(string patente, EMarcas marca, int cantAsientos) : this (patente, marca, 4, cantAsientos)
    {

    }
    #endregion

    #region Metodos
    protected override string Mostrar()
    {
      return string.Format(base.Mostrar() +  " Cantidad de asientos: " + this._cantidadAsientos);
    }

    public override string ToString()
    {
      return base.Mostrar();
    }
    #endregion
  }
}
