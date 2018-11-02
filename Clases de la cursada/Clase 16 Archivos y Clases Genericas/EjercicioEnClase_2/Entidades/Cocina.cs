using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCocina
{
    public class Cocina
    {
        #region Atributos
        private int _codigo;
        private bool _esIndustrial;
        private double _precio;
        #endregion

        #region Propiedades
        public int Codigo
        {
            get { return this._codigo; }
        }

        public bool EsIndustrial
        {
            get { return this._esIndustrial; }
        }

        public double Precio
        {
            get { return this._precio; }
        }
        #endregion

        #region Constructor
        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this._codigo = codigo;
            this._esIndustrial = esIndustrial;
            this._precio = precio;
        }
        #endregion

        #region SobreCarga
        public static bool operator ==(Cocina a, Cocina b)
        {
            bool ret = false;
            if(a._codigo == b._codigo)
            {
                ret = true;
            }
            return ret;
        }

        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }
        #endregion

        #region Polimorfismo
        public override bool Equals(object obj)
        {
            bool ret = false;
            if (obj is Cocina)
            {
                ret = (this == (Cocina)obj);
            }
            return ret;
        }

        public override string ToString()
        {
            return string.Format("Codigo: " + this._codigo +" Precio: " + this._precio + " Industrail: " + this._esIndustrial);
        }
        #endregion

    }
}
