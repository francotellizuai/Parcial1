using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    internal class Colectivo
    {
        private List<Pasajero> pasajeros;


        private string marca;
        private DateTime anio_fabricacion;
        private const int CAPACIDAD_MAXIMA = 40;
        private double costo_boleto;

        private double total_recaudado;

        public Colectivo() 
        {
            pasajeros = new List<Pasajero>();
            var pasajero = new Pasajero();

        }

        public Colectivo(DateTime anio_fabricacion, double costo_boleto)
        {
            pasajeros = new List<Pasajero>();

            this.anio_fabricacion = anio_fabricacion;
            this.costo_boleto = costo_boleto;

        }

        public DateTime AnioFabricacion
        {
            get { return anio_fabricacion; }
            set { anio_fabricacion = value; }
        }
        public double CostoBoleto
        {
            get { return costo_boleto; }
            set { costo_boleto = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public double TotalRecaudado
        {
            get { return total_recaudado; }
        }

        public string VenderBoleto(Pasajero pasajero)
        {
            double totalPagado = 0;

            if (pasajero is Estudiante)
            {

                totalPagado = this.costo_boleto * pasajero.PorcentajeDescuento;
                pasajeros.Add(pasajero);
                this.total_recaudado += totalPagado;
            }
            else if (pasajero is Jubilado)
            {
                totalPagado = this.costo_boleto * pasajero.PorcentajeDescuento;
                this.total_recaudado += 0;
                pasajeros.Add(pasajero);
            }
            else
            {
                totalPagado = this.costo_boleto * pasajero.PorcentajeDescuento;

                this.total_recaudado += totalPagado;
                pasajeros.Add(pasajero);
            }

            return "Boleto vendido correctamente.";
        }

        public bool ExistePasajero(string dni)
        {
            int existePasajero = this.pasajeros.FindIndex(objeto => objeto.Dni == dni);
            if(existePasajero != -1){
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetTotalBoletosVendidos()
        {
            return pasajeros.Count();
        }

        public ReadOnlyCollection<string> ListarPasajeros()
        {
            var listaPasajeros = new List<string>();
            foreach (var item in pasajeros)
            {
                listaPasajeros.Add(item.ToString());
            }
            return listaPasajeros.AsReadOnly();
        }

        public bool EstaCupoLleno() 
        {
            if (pasajeros.Count >= CAPACIDAD_MAXIMA)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
