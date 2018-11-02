using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EntidadesCocina
{
    public class DepositoDeCocinas
    {
        #region Atributos
        private int _capacidadMaxima;
        private List<Cocina> _lista;
        #endregion

        #region Constructor
        public DepositoDeCocinas(int capacidad)
        {
            this._lista = new List<Cocina>();
            this._capacidadMaxima = capacidad;
        }
        #endregion

        #region SobreCargas
        public static bool operator +(DepositoDeCocinas d, Cocina c)
        {
            int capacidad = d._lista.Count;
            bool hayEspacio = false;

            
            if(capacidad < d._capacidadMaxima)
            {
                hayEspacio = true;
            }

            if (hayEspacio)
                d._lista.Add(c);

            return hayEspacio;
        }

        public static bool operator -(DepositoDeCocinas d, Cocina c)
        {
            bool borrado = false;
            int indice = d.GetIndice(c);

            if (indice != -1)
            {
                d._lista.RemoveAt(indice);
                borrado = true;
                Console.WriteLine("\nAuto borrado");
            }

            return borrado;
        }
        #endregion

        #region Metodos
        private int GetIndice(Cocina c)
        {
            int index = -1;
            bool existe = false;

            foreach (Cocina item in this._lista)
            {
                index++;
                if (item == c)
                {
                    existe = true;
                    break;
                }
            }

            if (!existe)
                index = -1;

            return index;
        }

        public bool Agregar(Cocina a)
        {
            bool retorno = false;

            if (this + a)
            {
                retorno = true;
            }

            return retorno;

        }

        public bool Remover(Cocina a)
        {
            bool retorno = false;

            if (this - a)
            {
                retorno = true;
            }

            return retorno;
        }

        public bool Guardar(string path)
        {
            bool ret = false;

            //treu ya existe el archivo.
            //false Sobre escrimimos el archivo.
            try
            {
                //Si usamos using no es necesario usar Close.
                using(StreamWriter archivo = new StreamWriter(path, false))
                {
                    archivo.WriteLine(this.ToString());
                }
                
                //archivo.Close();
                ret = true;
            }
            catch(Exception e)
            {
                Console.Write(e);
            }

            return ret;
        }

        public bool Recuperar(string path)
        {
            bool ret = false;
            
            try
            {
                // StringReader sirve para leer un archivo. 
                using(StreamReader archivo = new StreamReader(path))
                {
                    //ReadToEnd lee el archivo
                    Console.Write(archivo.ReadToEnd());
                    ret = true;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            return ret;
        }
        #endregion

        #region Polimorfismo
        public override string ToString()
        {
            string retorno = "";
            retorno += "\nCantidad maxima del Deposito: " + this._capacidadMaxima;
            retorno += "\nCantidad de cocinas en el Deposito: " + this._lista.Count;
            retorno += "\nLista de cocinas:";
            foreach (Cocina item in this._lista)
            {
                retorno += "\n" + item.ToString();

            }
            return retorno;
        }
        #endregion
    }
}
