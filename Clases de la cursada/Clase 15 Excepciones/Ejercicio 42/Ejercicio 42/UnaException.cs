using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
  class UnaException : Exception
  {
        public UnaException()
            : base()
        {
        }

        public UnaException(string mensaje)
            : base(mensaje)
        {
        }

        public UnaException(string mensaje, Exception innerException)
            : base(mensaje,innerException)
        {
        }
    }
}
