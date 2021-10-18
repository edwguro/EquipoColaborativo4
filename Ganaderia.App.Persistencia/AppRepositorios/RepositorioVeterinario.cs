using System;
using Ganaderia.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Ganaderia.App.Persistencia
{
    public class RepositorioVeterinario : IRepositorioVeterinario
    {
        private readonly AppContext _appContext;

        public RepositorioVeterinario(AppContext appContext)
        {
            _appContext = appContext;
        }
void IRepositorioVeterinario.AddVeterinario(Veterinario veterinario)
        {
            _appContext.Veterinarios.Add(veterinario);
            _appContext.SaveChanges();
        }
         IEnumerable<Veterinario> IRepositorioVeterinario.GetAllVeterinarios()
        {
            return _appContext.Veterinarios;
        }

        Veterinario IRepositorioVeterinario.GetLogin2(string correo, string contrasena)
        {
            return _appContext.Veterinarios.FirstOrDefault(v => v.Correo == correo && v.Contrasena == contrasena);
        }
         void IRepositorioVeterinario.DeleteVeterinarios(int idVeterinario)
        {
            var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(v => v.Id == idVeterinario);

            if (veterinarioEncontrado != null) 
            {
                _appContext.Veterinarios.Remove(veterinarioEncontrado);
                _appContext.SaveChanges();
            }
        }
        Veterinario IRepositorioVeterinario.GetVeterinario(int idVeterinario)
        {
            return _appContext.Veterinarios.FirstOrDefault(v => v.Id == idVeterinario);
        }



    } 
}