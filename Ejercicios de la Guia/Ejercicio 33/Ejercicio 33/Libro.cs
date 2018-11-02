using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    class Libro
    {
        private List<string> _paginas;

        public string this[int i]
        {
            get
            {
                string retorno = "";
                for(int j = 0; j < this._paginas.Count; j++)
                {
                    if(j == i)
                    {
                        retorno += this._paginas[i];
                        break;
                    }
                }

                return retorno;
            }
            set
            {
                for (int j = 0; j < this._paginas.Count; j++)
                {
                    if (j == i)
                    {
                        this._paginas.Add(value);
                        break;
                    }
                }
                if(i > this._paginas.Count)
                {
                    this._paginas.Capacity += 1;
                }
            }
        }
    }
}
