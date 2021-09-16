using System.Collections.Generic;
using UParking.App.Dominio;

namespace UParking.App.Persistencia
{
    public interface IRepositorioProfesor
    {
        //Metodos
        IEnumerable<Profesor> GetAllProfesor();
        //DataType Nombre_Metodo (DataType NameVariable)
        Profesor AddProfesor(Profesor profesor);
        Profesor UpdateProfesor(Profesor profesor);
        void DeleteProfesor(int idProfesor);
        Profesor GetProfesor(int idProfesor);
    }
}
