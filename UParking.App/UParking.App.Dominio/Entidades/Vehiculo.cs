using System;

namespace UParking.App.Dominio
{
    public class Vehiculo
    {
        public int id {get;set;}
        public int modelo {get;set;}
        public string marca {get;set;}
        public TipoVehiculo tipoVehiculo {get;set;}
        public string placa {get;set;}
    }
}