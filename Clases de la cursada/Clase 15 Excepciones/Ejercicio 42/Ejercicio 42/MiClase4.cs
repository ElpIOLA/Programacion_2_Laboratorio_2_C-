using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    class MiClase4
    {
        public void MetodoDeInstancia4()
        {
            try
            {
                Program.lanzarOtroException();
            }
            catch(Exception e)
            {
                throw new otroException(e.Message + "\nError de clase 4",e);
            }
        }
    }
}
