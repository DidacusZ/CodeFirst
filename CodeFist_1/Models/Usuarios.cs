using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeFist_1.Models
{
    public class Usuarios
    {
        //lo que hay entre [] son restricciones para los campos que se pueden añadir
        [Key]//PK
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//se invrementa automaticamente
        public int id_usuario { get; set; }
        public string dni_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public string apellidos_usuario { get; set; }
        public string tlf_usuario { get; set; }
        public string email_usuario { get; set; }
        public string clave_usuario { get; set; }

        public int id_acceso { get; set; }//FK-Accesos
        public Accesos Acceso { get; set; }

        public bool estaBloqueado_usuario { get; set; }
        public DateTime fch_fin_bloqueo_usuario { get; set; }
        public DateTime fch_alta_usuario { get; set; }
        public DateTime fch_baja_usuario { get; set; }

        public ICollection<Prestamos> Prestamos_usuario { get; set;}//un usuario puede tener muchos prestamos
    }

}
