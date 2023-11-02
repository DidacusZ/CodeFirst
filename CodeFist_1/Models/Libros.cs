using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeFist_1.Models
{
    public class Libros
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_libro { get; set; }
        public string isbn_libro { get; set; }
        public string titulo_libro { get; set; }
        public string edicion_libro { get; set; }

        public int id_editorial { get; set; }//FK-Editoriales
        public Editoriales Editorial { get; set; }

        public int id_genero { get; set; }//FK-Generos
        public Generos Genero { get; set; }

        public int id_coleccion { get; set; }//FK-Colecciones
        public Colecciones Coleccion { get; set; }

        public ICollection<Prestamos> Prestamos_libro { get; set; }//un libro puede tener muchos prestamos

        public ICollection<AutoresLibros> Rel_Libros_Autores { get; set; }//un libro puede tener muchos Rel_Autores_Libros
        public ICollection<LibrosPrestamos> Rel_Libros_Prestamos { get; set; }//un libro puede tener muchos Rel_Autores_Libros
    }
}
