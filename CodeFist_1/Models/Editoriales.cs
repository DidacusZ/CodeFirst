using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeFist_1.Models
{
    public class Editoriales
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_editorial { get; set; }
        public string nombre_editorial { get; set; }

        public ICollection<Libros> Libros_editorial { get; set; }//una editorial puede tener muchos libros
    }
}
