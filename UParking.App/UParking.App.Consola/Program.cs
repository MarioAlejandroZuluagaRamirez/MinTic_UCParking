using System;
using System.Collections.Generic;
using System.Linq;
using UParking.App.Dominio;
using UParking.App.Persistencia;

namespace UParking.App.Consola
{
    class Program
    {
        private static IRepositorioProfesor _repoProfesor = new RepositorioProfesor(new Persistencia.AppContext());
        private static IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddProfesor();
            //GetProfesor(1);
            //DeleteProfesor(2);
            //UpdateProfesor(1,1);
            //ListarProfesores();
            //AddVehiculo();
            Console.WriteLine("Terminado");
        }

        private static void AddProfesor()
        {
            var vehiculoEncontrado = _repoVehiculo.GetVehiculo(1);
            var vehiculo = new Vehiculo();
            vehiculo = vehiculoEncontrado;

            Profesor profesor = new Profesor
            {
                nombre = "Mario Alejandro",
                apellido = "Zuluaga Ramirez",
                identificacion = 16070445,
                telefono = "3172252178",
                correo = "mazuluagar@hotmail.com",
                vehiculo_1 = null,
                vehiculo_2 = vehiculo,
                facultad = "Ingenieria",
                departamento = "",
                cubiculo = ""
            };
            var profesorIngresado = _repoProfesor.AddProfesor(profesor);

            if (profesorIngresado != null)
            {
                Console.WriteLine("Id Registro " + profesorIngresado.id);
            }
        }

        private static void GetProfesor(int idProfesor)
        {
            var profesor = _repoProfesor.GetProfesor(idProfesor);
            Console.WriteLine(profesor.nombre + " " + profesor.apellido);
        }

        private static void UpdateProfesor(int idProfesor, int IdVehiculo)
        {
            var vechiculo = _repoVehiculo.GetVehiculo (IdVehiculo) ;
            var profesor = _repoProfesor.GetProfesor(idProfesor);
            profesor.departamento = "Ciencias";
            profesor.cubiculo = "20B";
            profesor.vehiculo_1 = vechiculo;
            _repoProfesor.UpdateProfesor(profesor);
        }

        private static void DeleteProfesor(int idProfesor)
        {
            _repoProfesor.DeleteProfesor(idProfesor);
            var profesor = _repoProfesor.GetProfesor(idProfesor);
            if (profesor == null)
            {
                Console.WriteLine("Registro eliminado");
            }
        }

        private static void ListarProfesores()
        {
            IEnumerable<Profesor> profesores = _repoProfesor.GetAllProfesor();
            Console.WriteLine(profesores.First().nombre + " " + profesores.First().apellido);
        }
        //Vehiculo
        private static void AddVehiculo()
        {
            var vehiculo = new Vehiculo
            {
                modelo = 2020,
                marca = "Bajaj",
                tipoVehiculo = TipoVehiculo.Motocicleta,
                placa = "OOS39E"
            };
            var vehiculoIngresado = _repoVehiculo.AddVehiculo(vehiculo);

            if (vehiculoIngresado != null)
            {
                Console.WriteLine("Id Registro " + vehiculoIngresado.id);
            }
        }
    }
}