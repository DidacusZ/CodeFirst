using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace CodeFist_1.Models
{
    public class Accesos
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_acceso { get; set; }
        public string codigo_acceso { get; set; }
        public string descripcion_acceso { get; set; }

        public ICollection<Usuarios> Usuarios_acceso { get; set; } // un Acceso puede tener muchos usuarios
    }
}
