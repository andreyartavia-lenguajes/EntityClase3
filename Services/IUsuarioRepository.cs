using EntityFrameworkClase2.Models;

namespace EntityFrameworkClase2.Services;

public interface IUsuarioRepository
{
    void Add(Usuario usuario);
    void Save();

    Usuario? GetById(int id);
}