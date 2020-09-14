using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medico
    {
        string nombre;
        string apellido;
        int dni;
        string especialidad;

        public Medico(string nombre, string apellido, int dni, string especialidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.especialidad = especialidad;

        }
    }
}
