using Ganaderia.App.Dominio;
using System.Collections.Generic;

namespace Ganaderia.App.Persistencia
{
    public interface IRepositorioVeterinario
    {
       void AddVeterinario(Veterinario veterinario);
        IEnumerable<Veterinario> GetAllVeterinarios();
        Veterinario GetLogin2(string correo, string contrasena);
        void DeleteVeterinarios(int idVeterinario);
        Veterinario GetVeterinario(int idVeterinario);
    }
}