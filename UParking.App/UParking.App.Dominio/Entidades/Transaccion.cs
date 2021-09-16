using System;

namespace UParking.App.Dominio
{
    public class Transaccion
    {
        public int Id {get;set;}
        public DateTime fechaHoraIngreso {get;set;}
        public DateTime fechaHoraSalida {get;set;}
        public Vehiculo vehiculo {get;set;}
        public float valorHora {get;set;}
        private void CalcularTarifa()
        {
            
        }
    }
}