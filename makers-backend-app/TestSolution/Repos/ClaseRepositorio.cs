using TestSolution.DTOs;

namespace TestSolution.Repos
{
    public class ClaseRepositorio
    {
        public IEnumerable<Libro> ObtenerLibros() {  return new List<Libro>(); }
        public IEnumerable<AutorLibro> ObtenerAutores() { return new List<AutorLibro>(); }
        public IEnumerable<Ciudades> ObtenerCiudad() { return new List<Ciudades>(); }
    }
}
