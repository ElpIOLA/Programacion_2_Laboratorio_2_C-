using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{ 
    public class Empleado
    {
        public enum EPuestoJerarquico
        {
            Administracion,
            Gerencia,
            Sistemas,
            Accionista,
        }

        #region Atributos
        private string _nombre;
        private string _apellido;
        private string _legajo;
        private EPuestoJerarquico _puesto;
        private int _salario;
        #endregion

        #region Constructor
        public Empleado(string nombre, string apellido, string legajo, EPuestoJerarquico puesto, int salario)
        {
            _nombre = nombre;
            _apellido = apellido;
            _legajo = legajo;
            _puesto = puesto;
            _salario = salario;
        }
        #endregion

        #region Metodos
        public static bool operator ==(Empleado e1, Empleado e2)
        {
            bool retorno = false;

            if (e1._legajo == e2._legajo)
                retorno = true;

            return retorno;
        }

        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }

        public string Mostrar()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("\nNombre: {0},\nApellido: {1},\nLegajo: {2},\nPuesto: {3},\nSalario: {4}\n"
                , _nombre, _apellido,_legajo, _puesto, _salario);
            return s.ToString();
        }
        #endregion
    }
}
