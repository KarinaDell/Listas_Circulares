using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Listas_Circulares
{
    class Base
    {
        public string nombre;
        public int duracion;
        public Base sig;

        public string Nombre => nombre;

        public Base(string nombre, int duracion)
        {
            this.nombre = nombre;
            this.duracion = duracion;
        }

        public override string ToString() => "Nombre de la base: " + nombre + "\tDuración: " + duracion + " min" + Environment.NewLine;
    }
}
