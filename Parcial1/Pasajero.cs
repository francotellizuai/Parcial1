using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    internal class Pasajero
    {
        private string nombre;
        private string apellido;
        private string dni;
        protected double porcentaje_descuento;

        public Pasajero() 
        {
            this.porcentaje_descuento = 1;
        }


        public Pasajero(string nombre, string apellido, string dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.porcentaje_descuento = 1;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public double PorcentajeDescuento
        {
            get { return porcentaje_descuento; }
        }


        public override string ToString()
        {
            return $"***********************\r\nPasajeroComun:\r\nNombre y Apellido: {this.Nombre} {this.Apellido}\r\nDni: {this.Dni}\r\n";
        }
    }
}
