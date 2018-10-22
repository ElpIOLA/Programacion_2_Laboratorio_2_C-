using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    class MiClase3
    {
        public void metodoDeInstancia()
        {
            try
            {
                new MiClase2(4, 'c');
            }
            catch(Exception e)
            {
                throw new MiException(e.Message + "\nError en MetodoDeInstancia en Clase 3", e);
            }
        }
    }
}
