using System;

namespace UParking.App.Dominio
{
    public class Administrativo : Persona
    {
        public int idAdministrativo {get;set;}
        public string oficina { get; set; }
        public string dependencia { get; set; }
    }
}