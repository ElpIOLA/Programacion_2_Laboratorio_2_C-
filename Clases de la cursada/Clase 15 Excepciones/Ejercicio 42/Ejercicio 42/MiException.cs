using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
  class MiException : Exception
  {
        public MiException()
            : base()
        {
        }

        public MiException(string mensaje)
            : base(mensaje)
        {
        }

        public MiException(string mensaje, Exception innerException)
            : base(mensaje, innerException)
        {
        }
    }
}
