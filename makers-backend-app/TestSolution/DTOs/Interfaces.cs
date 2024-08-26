using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolution.DTOs
{
    public abstract class RepoObject {
        public int Id { get; set; }
    }

    public class Libro: RepoObject
    {
        public int LibroId {get;set;}
        public string Nombre {get;set;}
        public int AnioPublicacion { get; set; }
        public int AutorId {get; set;}
    }

    public class AutorLibro : RepoObject
    {
        public int AutorId {get;set;}
        public string Nombre {get; set;}
        public int CiudadId { get; set; }
        public bool Total { get; set; }
    }

    public class Ciudades : RepoObject
    {
        public int CiudadId {get;set;}

        public string Nombre {get; set;}
    }

    public class ClaseResultado : RepoObject
    {
        public int Total { get; set; }
        public string Nombre { get; set; }
    }
}
