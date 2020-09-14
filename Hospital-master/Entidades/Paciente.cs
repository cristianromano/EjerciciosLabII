using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente
    {
        string nombre;
        string apellido;
        int dni;
        Enfermedad dolencia;
        string descripcionDolencia;

        public Enfermedad Dolencia
        {
            set { dolencia = value; }
            get { return dolencia ; }
        }


        public Paciente(string nombre, string apellido,int dni,string descripcionDolencia)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;            
            this.descripcionDolencia = descripcionDolencia;
            
        }

        //public void SetEnfermedad(Enfermedad dolencia)
        //{
        //    this.dolencia = dolencia;
        //}
    }
}
