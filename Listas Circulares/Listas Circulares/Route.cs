using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Listas_Circulares
{
    class Route
    {
        private Base inicio;

        public void Agregar(Base nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
                inicio.sig = inicio;
            }
            else
                agregarRecursivo(nuevo, inicio.sig);
        }

        private void agregarRecursivo(Base nuevo, Base t)
        {
            if (t.sig == inicio)
            {
                t.sig = nuevo;
                nuevo.sig = inicio;
            }
            else
                agregarRecursivo(nuevo, t.sig);
        }

        public Base Buscar(string nombre)
        {
            if (nombre == inicio.Nombre)
                return inicio;
            else
                return buscarRecursivo(nombre, inicio.sig);
        }

        private Base buscarRecursivo(string nombre, Base t)
        {
            if (t.Nombre == inicio.Nombre)
                return null;
            else if (nombre == t.Nombre)
                return t;
            else
                return buscarRecursivo(nombre, t.sig);
        }

        public Base eliminarUltimo()
        {

            Base _return = null;
            if (inicio.sig == inicio)
            {
                _return = inicio;
                inicio = null;
                return _return;
            }
            else
                return eliminarUltimoRecursivo(inicio);
        }

        private Base eliminarUltimoRecursivo(Base t)
        {
            Base _return = t;
            if (t.sig == inicio)
                return _return;
            else if (t.sig.sig == inicio)
            {
                _return = t.sig;
                t.sig = inicio;
                return _return;
            }
            else
                return eliminarUltimoRecursivo(t.sig);
        }

        public Base eliminarPrimero()
        {
            Base _return = inicio;
            if (inicio.sig == inicio)
            {
                inicio = null;
                return _return;
            }
            else
                return eliminarPrimeroRecursivo(inicio.sig);
        }

        private Base eliminarPrimeroRecursivo(Base t)
        {
            Base _return = inicio;
            if (t.sig == inicio)
            {
                inicio = inicio.sig;
                t.sig = inicio;
                return _return;
            }
            else
                return eliminarPrimeroRecursivo(t.sig);
        }

        public string Listar()
        {
            string s = inicio.ToString();
            Base _base = inicio.sig;
            while (_base != inicio)
            {
                s += _base.ToString();
                _base = _base.sig;
            }
            return s;
        }

        public string ruta (string nombre, DateTime horaInicio, DateTime horaFin)
        {
            if (inicio == null)
                return "La ruta no tiene bases";
            else
            {
                string s = " ";
                Base bi = Buscar(nombre);
                while (horaInicio <= horaFin)
                {
                    s += bi.Nombre + ": " + horaInicio.TimeOfDay + Environment.NewLine;
                    horaInicio = horaInicio.AddMinutes(bi.duracion);
                    bi = bi.sig;
                }
                return s;
            }
        }
    
    }
}
