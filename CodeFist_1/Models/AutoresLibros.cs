using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeFist_1.Models
{
    public class AutoresLibros
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_rel_autores_libros { get; set; }

        public int id_libro { get; set; }//FK-Libros
        public Libros Libro { get; set; }

        public int id_autor { get; set; }//FK-Autores
        public Autores Autor { get; set; }

    }
}
