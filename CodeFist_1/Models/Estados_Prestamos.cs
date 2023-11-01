using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeFist_1.Models
{
    public class Estados_Prestamos
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_estado_prestamo { get; set; }
        public string codigo_estado_prestamo { get; set; }
        public string descripcion_estado_prestamo { get; set; }

        public ICollection<Prestamos> Prestamos_estado { get; set; }//un estado puede tener muchos prestamos
    }
}
