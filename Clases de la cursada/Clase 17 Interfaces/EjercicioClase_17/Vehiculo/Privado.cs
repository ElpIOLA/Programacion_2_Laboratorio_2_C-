using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Privado : Avion
    {
        protected int _valoracionServicioDeAbordo;

        public Privado(double precio, double velocidad, int valoracion)
            : base(precio, velocidad)
        {
            _valoracionServicioDeAbordo = valoracion;
        }

        public void MostrarValoracion()
        {
            Console.WriteLine("^\nValoracion: {0}", _valoracionServicioDeAbordo);
        }

        //public override double PropiedadDouble
        //{
        //    get { return _precio; }
        //    set { _precio = value; }
        //}
    }
}
