using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeFist_1.Models
{
    public class LibrosPrestamos
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_rel_libros_prestamos { get; set; }

        public int id_libro { get; set; }//FK-Libros
        public Libros Libro { get; set; }
        public int id_prestamo { get; set; }//FK-Prestamos
        public Prestamos Prestamo { get; set; }
    }
}
