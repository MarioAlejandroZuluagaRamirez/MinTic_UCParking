using System;

namespace UParking.App.Dominio
{
    public class Visitante:Persona
    {
        public string actividad {get;set;}
        public Persona autoriza {get;set;}
    }
}