using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Empresa
    {
        #region Atributos
        private List<Empleado> _nominaEmpleados;
        private string _razonSocial;
        private string _direccion;
        private float _ganancias;
        #endregion

        #region Propiedades
        public string RazonSocial
        {
            get { return _razonSocial; }
            set { _razonSocial = value; }
        }

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public float Ganancias
        {
            get { return _ganancias; }
            set { _ganancias = value; }
        }
        #endregion

        #region Constructor
        private Empresa()
        {
            _nominaEmpleados = new List<Empleado>();
        }

        public Empresa(string razon, string direccion, float ganancias) : this()
        {
            _razonSocial = razon;
            _direccion = direccion;
            _ganancias = ganancias;
        }
        #endregion

        #region Metodos
        public static Empresa operator +(Empresa empresa, Empleado empleado)
        {
            foreach (Empleado e in empresa._nominaEmpleados)
            {
                // Si encuentro al empleado en la nómina, salgo del método.
                if (empleado == e)
                    return empresa;
            }
            // Agrego al empleado a la nómina
            empresa._nominaEmpleados.Add(empleado);
            return empresa;
        }

        public string MostrarEmpresa()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("La empresa {0} sita en la cale {1} cuenta con ganancias por {3} y con {4} empleados.",
                _razonSocial, _direccion, _ganancias, _nominaEmpleados.Count);
            foreach (Empleado e in this._nominaEmpleados)
            {
                s.AppendLine(e.Mostrar());
            }
            return s.ToString();
        }
        #endregion
    }
}
