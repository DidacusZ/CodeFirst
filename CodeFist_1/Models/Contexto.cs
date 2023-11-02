using Microsoft.EntityFrameworkCore;

namespace CodeFist_1.Models
{
    public class Contexto : DbContext
    {
        // <nombre entidad>     nombre en BD
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Accesos> Accesos { get; set; }
        public DbSet<Autores> Autores { get; set; }
        public DbSet<Colecciones> Colecciones { get; set; }
        public DbSet<Editoriales> Editoriales { get; set; }
        public DbSet<Estados_Prestamos> Estados_Prestamos { get; set; }
        public DbSet<Generos> Generos { get; set; }
        public DbSet<Libros> Libros { get; set; }
        public DbSet<Prestamos> Prestamos { get; set; }
        public DbSet<LibrosPrestamos> Rel_Libros_Prestamos { get; set; }
        public DbSet<AutoresLibros> Rel_Autores_Libros { get; set; }

        public Contexto(DbContextOptions<Contexto> opciones):base(opciones) { 
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)//ids autoincrementables
        {
            modelBuilder.UseSerialColumns();//ids autoincrementables


            //crea una sola columna en vez de dos para la FK   Usuarios-Acces...

            //relacion Acceso-Usuarios
            modelBuilder.Entity<Usuarios>()
            .HasOne(uno => uno.Acceso)
            .WithMany(muchos => muchos.Usuarios_acceso)//campos de acceso
            .HasForeignKey(uno => uno.id_acceso);//campos de usuario

            //Prestamo-Usuarios
            modelBuilder.Entity<Prestamos>()
            .HasOne(uno => uno.Usuario)
            .WithMany(muchos => muchos.Prestamos_usuario)
            .HasForeignKey(uno => uno.id_usuario);

            //Estado-Prestamos
            modelBuilder.Entity<Prestamos>()
            .HasOne(uno => uno.Estado_Prestamo)
            .WithMany(muchos => muchos.Prestamos_estado)
            .HasForeignKey(uno => uno.id_prestamo);



            //Libro-Rel_Libros_Prestamos
            modelBuilder.Entity<LibrosPrestamos>()
            .HasOne(uno => uno.Libro)
            .WithMany(muchos => muchos.Rel_Libros_Prestamos)
            .HasForeignKey(uno => uno.id_libro);

            //Prestamos-Rel_Libros_Prestamos
            modelBuilder.Entity<LibrosPrestamos>()
            .HasOne(uno => uno.Prestamo)
            .WithMany(muchos => muchos.Rel_Prestamos_Libros)
            .HasForeignKey(uno => uno.id_prestamo);



            //Coleccion-Libros
            modelBuilder.Entity<Libros>()
            .HasOne(uno => uno.Coleccion)
            .WithMany(muchos => muchos.Libros_coleccion)
            .HasForeignKey(uno => uno.id_coleccion);

            //Editorial-Libros
            modelBuilder.Entity<Libros>()
            .HasOne(uno => uno.Editorial)
            .WithMany(muchos => muchos.Libros_editorial)
            .HasForeignKey(uno => uno.id_editorial);

            //Genero-Libros
            modelBuilder.Entity<Libros>()
            .HasOne(uno => uno.Genero)
            .WithMany(muchos => muchos.Libros_genero)
            .HasForeignKey(uno => uno.id_genero);



            //Libro-Rel_libros_autores
            modelBuilder.Entity<AutoresLibros>()
            .HasOne(uno => uno.Libro)
            .WithMany(muchos => muchos.Rel_Libros_Autores)
            .HasForeignKey(uno => uno.id_libro);

            //Autor-Rel_libros_autores
            modelBuilder.Entity<AutoresLibros>()
            .HasOne(uno => uno.Autor)
            .WithMany(muchos => muchos.Rel_Autores_Libros)
            .HasForeignKey(uno => uno.id_autor);





            /* RELACION UNO A MUCHOS
             modelBuilder.Entity<muchos>()
            .HasOne(c2 => c2.uno)
            .WithMany(c1 => c1.muchosItems)//relacion esta en uno(item)
            .HasForeignKey(c2 => c2.unoId);//campo esta en muchos
             */

            /* RELACION UNO A UNO
            modelBuilder.Entity<uno2>()
            .HasOne(c2 => c2.uno1)
            .WithOne(c1 => c1.uno2)
            .HasForeignKey<uno2>(c2 => c2.uno1Id);
            */

            /* RELACION MUCHOS A MUCHOS (TABLA INTERMEDIA) */
        }

    }
}
