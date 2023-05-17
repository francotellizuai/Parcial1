using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Parcial1
{
    internal class Jubilado:Pasajero
    {
        private int numero_afiliado_pami;

        public Jubilado() 
        {
            base.porcentaje_descuento = 0;
        }

        public Jubilado( string nombre, string apellido, string dni, int numero_afiliado_pami):base(nombre, apellido, dni) {
            this.numero_afiliado_pami = numero_afiliado_pami;
            base.porcentaje_descuento = 0;
            
        }

        public int NumeroAfiliadoPami
        {
            get { return numero_afiliado_pami; }
            set { numero_afiliado_pami = value; }
        }

        public override string ToString()
        {
            return $"***********************\r\nJubilado:\r\nNombre y Apellido: {base.Nombre} {base.Apellido}\r\nDni: {base.Dni}\r\nNro afiliado pami:{this.numero_afiliado_pami}\r\n";
        }
    }
}
