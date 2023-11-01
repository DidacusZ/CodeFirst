using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeFist_1.Models
{
    public class Generos
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_genero { get; set; }
        public string nombre_genero { get; set; }
        public string descripcion_genero { get; set; }

        public ICollection<Libros> Libros_genero { get; set; }//un genero puede tener muchos libros
    }
}
