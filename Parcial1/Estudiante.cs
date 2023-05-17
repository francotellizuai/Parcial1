using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Parcial1
{
    internal class Estudiante : Pasajero
    {
        private string institucion;
        private int legajo;

        public Estudiante() 
        {
            base.porcentaje_descuento = 0.5;

        }

        public Estudiante(string nombre, string apellido, string dni, string insitutcion, int legajo):base(nombre, apellido, dni)
        {
            this.institucion = insitutcion;
            this.legajo = legajo;
            base.porcentaje_descuento = 0.5;

        }

        public string Institucion
        {
            get { return institucion; }
            set { institucion = value; }
        }

        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }

        public override string ToString()
        {
            return $"***********************\r\nEstudiante:\r\nNombre y Apellido: {base.Nombre} {base.Apellido}\r\nDni: {base.Dni}\r\nInsitucion:{this.institucion}\r\n";
        }
    }
}
