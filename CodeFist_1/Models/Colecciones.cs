using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeFist_1.Models
{
    public class Colecciones
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_coleccion { get; set; }
        public string nombre_coleccion { get; set; }

        public ICollection<Libros> Libros_coleccion { get; set; } // una coleccion puede tener muchos libros
    }
}
