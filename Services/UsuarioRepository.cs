using EntityFrameworkClase2.Models;
using EntityFrameworkClase2.Data;

namespace EntityFrameworkClase2.Services;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly UsuarioDBContext _context;

    public UsuarioRepository(UsuarioDBContext context)
    {
        _context = context;
    }

    #region MetodosGuardar

    public void Add(Usuario usuario)
    {
        _context.Usuarios.Add(usuario);
        Save();
    }

    public void Save() => _context.SaveChanges();

    #endregion

    public Usuario? GetById(int id) => _context.Usuarios.Find(id);
}