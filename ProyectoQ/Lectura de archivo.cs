using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProyectoQ
{
    internal class LeerArchivo
    {
        private string _path;
        private List<string> nombres = new List<string>();          

       //constructor de la clase ojo
        public LeerArchivo(string path)
        {
            _path = path;
        }
        //metodo para leer el archivo
        public void LeerNombres()
        {
            using (StreamReader sr = new StreamReader (_path))
            {
              while (sr.EndOfStream != true)
                {
                 nombres.Add(sr.ReadLine());

                }
            }
        }

    }
}
