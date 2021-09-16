using System.Security.AccessControl;
using System;

namespace UParking.App.Dominio
{
    public class Parqueadero
    {
        public int id {get;set;}
        public string direccion {get;set;}
        public int numeroPuestos {get;set;}
        public string horario {get;set;}
        public string picoyPlaca {get;set;}
        public System.Collections.Generic.List<Puesto> puestos {get;set;}
        public System.Collections.Generic.List<Persona> personasAutorizadas {get;set;}
        public System.Collections.Generic.List<Transaccion> transaccion {get;set;}
    }
}