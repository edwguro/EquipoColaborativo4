using System;
using Ganaderia.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Ganaderia.App.Persistencia
{
    public class RepositorioEjemplares : IRepositorioEjemplares
    {
        private readonly AppContext _appContext;

        public RepositorioEjemplares(AppContext appContext)
        {
            _appContext = appContext;
        }
void IRepositorioEjemplares.AddEjemplares(Ejemplares ejemplares)
        {
            _appContext.Ejemplares.Add(ejemplares);
            _appContext.SaveChanges();
        }
        Ejemplares IRepositorioEjemplares.AsignarVeterinarioAEjemplares(int idEjemplares, int idVeterinario)
        {
            var ejemplarEncontrado = _appContext.Ejemplares.FirstOrDefault(g => g.Id == idEjemplares);
            var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(g => g.Id == idVeterinario);

            if (ejemplarEncontrado != null && veterinarioEncontrado != null) {
                ejemplarEncontrado.Veterinario = veterinarioEncontrado;

                _appContext.SaveChanges();
            }
            return ejemplarEncontrado;
        }

    } 
}