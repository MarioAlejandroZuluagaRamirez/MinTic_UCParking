using System.Collections.Generic;
 
 using UParking.App.Dominio;
 
 using System.Linq;

 namespace UParking.App.Persistencia
 {
 	public class RepositorioVehiculo:IRepositorioVehiculo
 	{
 		private readonly AppContext _appContext;

 		public RepositorioVehiculo(AppContext appContext)
 		{
 		    _appContext = appContext;
 		}

 		//Implementar metodos de la clase Super
 		Vehiculo IRepositorioVehiculo.AddVehiculo(Vehiculo vehiculo)
 		{
 			var vehiculoAdicionado = _appContext.Vehiculos.Add(vehiculo);
 			_appContext.SaveChanges();
 			return vehiculoAdicionado.Entity;
 		}

 		void IRepositorioVehiculo.DeleteVehiculo(int idVehiculo)
 		{
 			var vehiculoEncontrado = _appContext.Vehiculos.FirstOrDefault(p => p.id == idVehiculo);
 			if (vehiculoEncontrado == null) 
 				return;
 			_appContext.Vehiculos.Remove (vehiculoEncontrado);
 			_appContext.SaveChanges();
 		}

 		IEnumerable<Vehiculo> IRepositorioVehiculo.GetAllVehiculo ()
 		{
 			return _appContext.Vehiculos;
 		}

 		Vehiculo IRepositorioVehiculo.GetVehiculo (int idVehiculo)
 		{
 			return _appContext.Vehiculos.FirstOrDefault(p => p.id == idVehiculo);
 		}

 		Vehiculo IRepositorioVehiculo.UpdateVehiculo (Vehiculo vehiculo)
 		{
 			var vehiculoEncontrado = _appContext.Vehiculos.FirstOrDefault(p => p.id == vehiculo.id);
 			if (vehiculoEncontrado !=null)
 			{
 				vehiculoEncontrado.modelo = vehiculo.modelo;
                vehiculoEncontrado.marca = vehiculo.marca;
                vehiculoEncontrado.tipoVehiculo = vehiculo.tipoVehiculo;
                vehiculoEncontrado.placa = vehiculo.placa;
 				_appContext.SaveChanges();
 			}
 			return vehiculoEncontrado;
 		}
 	}
 }