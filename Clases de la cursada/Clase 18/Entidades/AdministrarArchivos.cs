using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class AdministrarArchivos
    {
        public static bool Escribir(string path, string dato)
        {
            bool ret = false;
            path += "\\archivo.txt";
            try
            {
                using (StreamWriter archivo = new StreamWriter(path, false))
                {
                    archivo.WriteLine("\r{0}",dato);
                    ret = true;
                }
            }
            catch(Exception e)
            {
                ret = false;
            }

            return ret;
        }

        public static bool Leer(string path, out string dato)
        {
            dato = "";
            bool ret = false;
            path += "\\archivo.txt";
            try
            { 
                using (StreamReader archivo = new StreamReader(path, true))
                {
                    dato = archivo.ReadToEnd();
                    ret = true;
                }
            }
            catch (Exception e)
            {
                ret = false;
            }

            return ret;
        }
    }
}
