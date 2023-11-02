using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeFist_1.Models
{
    public class Autores
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_autor { get; set; }
        public string nombre_autor { get; set; }
        public string apellidos_autor { get; set; }

        public ICollection<AutoresLibros> Rel_Autores_Libros { get; set; }//un autoer puede tener muchos Rel_Autores_Libros
    }
}
