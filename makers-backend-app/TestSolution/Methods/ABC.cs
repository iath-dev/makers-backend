using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSolution.DTOs;
using TestSolution.Repos;

namespace TestSolution.Methods
{
    public class ABC
    {
        /**
         * Metodo para hacer una consulta de un repositorio y mapear los resultados en una unica lista
         */
        public Task<IEnumerable<ClaseResultado>> abc()
        {
            var repositorio = new ClaseRepositorio();

            IEnumerable<Libro> newLibro = repositorio.ObtenerLibros();
            IEnumerable<AutorLibro> newAutor = repositorio.ObtenerAutores();
            IEnumerable<Ciudades> newCiudad = repositorio.ObtenerCiudad();

            var result = from l in newLibro
                         join a in newAutor on l.AutorId equals a.AutorId
                         group a by a.Nombre into g
                         select new ClaseResultado()
                         {
                             Nombre = g.Key,
                             Total = g.Count(x => x.Total)
                         };

            return Task.FromResult(result);
        }
    }
}
