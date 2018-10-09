using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Camion : Vehiculo
  {
    #region Atributos
    protected float tara;
    #endregion

    #region Constructor
    public Camion(string patente, Byte cantRuedas, EMarcas marca, float tara) : base(patente, cantRuedas, marca)
    {
      this.tara = tara;
    }

    public Camion(Vehiculo camion, float tara) : this(camion.Patente, camion.CantidadRuedas, camion.Marca, tara)
    {
     
    }
    #endregion

    #region Metodos
    protected override string Mostrar()
    {
      return string.Format(base.Mostrar() +  " Capacidad maxima: " + this.tara);
    }

    public override string ToString()
    {
      return base.Mostrar();
    }
    #endregion
  }
}
