using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProyectoQ
{
    internal class EscribirArchivo
    {
        private string _path;

        public EscribirArchivo(string path)
        {
            _path = path;
        }
         public void EscribirNombre(string nombre)
        {
            using (StreamWriter sw = new StreamWriter(_path, true))
            {
                sw.WriteLine(nombre);
                sw.Close();
            }

        }
        }
}
