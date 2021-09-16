 using System.Collections.Generic;
 using UParking.App.Dominio;

 namespace UParking.App.Persistencia
 {
 	public interface IRepositorioVehiculo
 	{
 		//Metodos
 		IEnumerable<Vehiculo> GetAllVehiculo();
 		Vehiculo AddVehiculo(Vehiculo vehiculo);
 		Vehiculo UpdateVehiculo(Vehiculo vehiculo);
 		void DeleteVehiculo (int idVehiculo);
 		Vehiculo GetVehiculo (int idVehiculo);
 	}
 }