using System.Collections.Generic;
using UParking.App.Dominio;
using System.Linq;

namespace UParking.App.Persistencia
{
    public class RepositorioProfesor : IRepositorioProfesor
    {
        private readonly AppContext _appContext;

        public RepositorioProfesor(AppContext appContext)
        {
            _appContext = appContext;
        }

        public Profesor AddProfesor(Profesor profesor)
        {
            var profesorAdicionado = _appContext.Profesores.Add(profesor);
            _appContext.SaveChanges();
            return profesorAdicionado.Entity;
        }

        public void DeleteProfesor(int idProfesor)
        {
            var profesorEncontrado = _appContext.Profesores.FirstOrDefault(p => p.id == idProfesor);
            if (profesorEncontrado == null)
                return;
            _appContext.Profesores.Remove(profesorEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Profesor> GetAllProfesor()
        {
            return _appContext.Profesores;
        }

        public Profesor GetProfesor(int idProfesor)
        {
            return _appContext.Profesores.FirstOrDefault(p => p.id == idProfesor);
        }

        public Profesor UpdateProfesor(Profesor profesor)
        {
            var profesorEncontrado = _appContext.Profesores.FirstOrDefault(p => p.id == profesor.id);
            if (profesorEncontrado != null)
            {
                profesorEncontrado.nombre = profesor.nombre;
                profesorEncontrado.apellido = profesor.apellido;
                profesorEncontrado.identificacion = profesor.identificacion;
                profesorEncontrado.telefono = profesor.telefono;
                profesorEncontrado.correo = profesor.correo;
                profesorEncontrado.facultad = profesor.facultad;
                profesorEncontrado.departamento = profesor.departamento;
                profesorEncontrado.cubiculo = profesor.cubiculo;
                _appContext.SaveChanges();
            }
            return profesorEncontrado;
        }
    }
}