using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Moto : Vehiculo
  {
    #region Atributos
    protected float cilindradas;
    #endregion

    #region Constructor
    public Moto(string patente, Byte cantRuedas, EMarcas marca, float cilindradas) : base (patente, cantRuedas, marca)
    {
      this.cilindradas = cilindradas;
    }

    public Moto(EMarcas marca, float cilindrada, string patente, Byte cantRuedas) : this(patente,cantRuedas,marca,cilindrada)
    {

    }
    #endregion

    #region Metodos
    protected override string Mostrar()
    {
        return string.Format(base.Mostrar() + " Cilindradas: " + this.cilindradas);
    }

    public override string ToString()
    {
      return base.Mostrar();
    }
    #endregion
  }
}
