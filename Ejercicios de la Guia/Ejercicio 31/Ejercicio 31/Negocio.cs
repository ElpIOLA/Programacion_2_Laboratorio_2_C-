using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    class Negocio
    {
        #region Atributo
        private Puesto caja;
        private Queue<Cliente> _cliente;
        private string _nombre;
        #endregion
    
        #region Propiedad
        public Cliente Cliente
        {
            get { return this._cliente.Last(); }
            set
            {
                Negocio n = new Negocio();
                if(!(n == value))
                {
                    n._cliente.Enqueue(value);
                }
            }
        }
        #endregion

        #region Constructor
        private Negocio()
        {
            this._cliente = new Queue<Cliente>();
            this.caja = Puesto.Caja1;
        }

        public Negocio(string nombre) : this()
        {
            this._nombre = nombre;
        }
        #endregion

        #region Metodo
        public static bool operator ==(Negocio n, Cliente c)
        {
            bool existe = false;
            foreach(Cliente item in n._cliente)
            {
                if(item == c)
                {
                    existe = true;
                    break;
                }
            }
            return existe;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool existe = false;
            if(!(n == c))
            {
                n._cliente.Enqueue(c);
                existe = true;
            }
            return existe;
        }
        #endregion
    }
}
