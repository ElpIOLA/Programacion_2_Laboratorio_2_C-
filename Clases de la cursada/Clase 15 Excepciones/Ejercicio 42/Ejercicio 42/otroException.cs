using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    class otroException : Exception
    {
        public otroException()
            : base()
        {
        }

        public otroException(string mensaje, Exception innerterinnerException)
            : base(mensaje, innerterinnerException)
        {
        }
    }
}
