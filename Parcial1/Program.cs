using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido a la venta de boletos UAI");

            Colectivo colectivo = new Colectivo();
            Console.WriteLine("Ingrese la marca del colectivo");
            colectivo.Marca = Console.ReadLine();
            Console.WriteLine("Ingrese el año de fabricacion del colectivo");
            colectivo.AnioFabricacion = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el costo del boleto");
            colectivo.CostoBoleto = double.Parse(Console.ReadLine());

            Console.WriteLine("Seleccione una Opcion:");
            Console.WriteLine("1-Vender boleto a Pasajero comun:");
            Console.WriteLine("2-Vender boleto a Estudiante:");
            Console.WriteLine("3-Vender boleto a Jubilado:");
            Console.WriteLine("4-Ver total de boletos vendidos:");
            Console.WriteLine("5-Ver todos los pasajeros:");
            Console.WriteLine("6-Ver total recaudado:");
            Console.WriteLine("7-Salir");

            int opcion = Convert.ToInt32(Console.ReadLine());
            string message = "";
            string dni = "";
            do
            {
                switch (opcion)
                {
                    case 1:
                        if (!colectivo.EstaCupoLleno()) 
                        {
                            Pasajero pasajero = new Pasajero();
                            Console.WriteLine("Ingrese el nombre del Pasajero:");
                            pasajero.Nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese el apellido:");
                            pasajero.Apellido = Console.ReadLine();
                            Console.WriteLine("Ingrese DNI del pasajero:");
                            dni = Console.ReadLine();
                            if (!colectivo.ExistePasajero(dni))
                            {
                                pasajero.Dni = dni;
                            }
                            else
                            {
                                Console.WriteLine("No se puede crear el Pasajero porque ya existe.");
                                break;
                            }

                            Console.WriteLine(colectivo.VenderBoleto(pasajero));
                        }
                        else
                        {
                            Console.WriteLine("No se puede vender más boletos. Cupo Lleno.");
                        }
                        

                        break;
                    case 2:
                        if (!colectivo.EstaCupoLleno())
                        {
                            Estudiante estudiante = new Estudiante();
                            Console.WriteLine("Ingrese el nombre del Estudiante:");
                            estudiante.Nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese el apellido:");
                            estudiante.Apellido = Console.ReadLine();
                            Console.WriteLine("Ingrese DNI del pasajero:");
                            dni = Console.ReadLine();
                            if (!colectivo.ExistePasajero(dni))
                            {
                                estudiante.Dni = dni;
                            }
                            else
                            {
                                Console.WriteLine("No se puede crear el Estudiante porque ya existe.");
                                break;
                            }
                            Console.WriteLine("Ingrese nombre de su Insitución:");
                            estudiante.Institucion = Console.ReadLine();

                            Console.WriteLine("Ingrese el numero de legajo:");
                            estudiante.Legajo = int.Parse(Console.ReadLine());

                            Console.WriteLine(colectivo.VenderBoleto(estudiante));

                            
                        }
                        else
                        {
                            Console.WriteLine("No se puede vender más boletos. Cupo Lleno.");
                        }

                        break;
                    case 3:
                        if (!colectivo.EstaCupoLleno())
                        {
                            Jubilado jubilado = new Jubilado();
                            Console.WriteLine("Ingrese el nombre del Jubilado:");
                            jubilado.Nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese el apellido:");
                            jubilado.Apellido = Console.ReadLine();
                            Console.WriteLine("Ingrese DNI del pasajero:");
                            dni = Console.ReadLine();
                            if (!colectivo.ExistePasajero(dni))
                            {
                                jubilado.Dni = dni;
                            }
                            else
                            {
                                Console.WriteLine("No se puede crear el Jubilado porque ya existe.");
                                break;
                            }
                            Console.WriteLine("Ingrese el numero afiliado de pami:");
                            jubilado.NumeroAfiliadoPami = int.Parse(Console.ReadLine());

                            Console.WriteLine(colectivo.VenderBoleto(jubilado));
                        }
                        else
                        {
                            Console.WriteLine("No se puede vender más boletos. Cupo Lleno.");
                        }

                        break;

                    case 4:
                        Console.WriteLine("El total de boleteos vendidos es de: " + colectivo.GetTotalBoletosVendidos());
                        break;
                    case 5:
                        var pasajeros = colectivo.ListarPasajeros();
                        foreach (var pasajeroItem in pasajeros)
                        {
                            Console.WriteLine(pasajeroItem);
                        }
                        break;
                    case 6:
                        Console.WriteLine("El total recaudado es de: " + colectivo.TotalRecaudado);
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;

                }
                Console.WriteLine("Seleccione una Opcion:");
                Console.WriteLine("1-Vender boleto a Pasajero comun:");
                Console.WriteLine("2-Vender boleto a Estudiante:");
                Console.WriteLine("3-Vender boleto a Jubilado:");
                Console.WriteLine("4-Ver total de boletos vendidos:");
                Console.WriteLine("5-Ver todos los pasajeros:");
                Console.WriteLine("6-Ver total recaudado:");
                Console.WriteLine("7-Salir");

                opcion = Convert.ToInt32(Console.ReadLine());

            } while (opcion > 0 && opcion < 7);

            Console.ReadKey();// Esto evita que se cierre el programa


        }
    }
}