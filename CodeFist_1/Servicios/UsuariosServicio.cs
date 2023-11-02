using CodeFist_1.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFist_1.Servicios
{
    public class UsuariosServicio
    {
        private readonly Contexto _context;

        public UsuariosServicio(Contexto context)
        {
            _context = context;
        }

        public void CrearUsuario(Usuarios usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public Usuarios ObtenerUsuarioPorId(int usuarioId)
        {
            return _context.Usuarios.FirstOrDefault(u => u.id_usuario == usuarioId);
        }

        public void ActualizarUsuario(Usuarios usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
        }

        public void EliminarUsuario(int usuarioId)
        {
            var usuario = _context.Usuarios.FirstOrDefault(u => u.id_usuario == usuarioId);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            }
        }
    }
}
