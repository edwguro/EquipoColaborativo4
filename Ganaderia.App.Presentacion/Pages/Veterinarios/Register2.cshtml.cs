using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ganaderia.App.Dominio;
using Ganaderia.App.Persistencia;

namespace Ganaderia.App.Presentacion.Pages
{
    public class Register2Model : PageModel
    {
         private static IRepositorioVeterinario _repositorioVeterinario = new RepositorioVeterinario(new Persistencia.AppContext()); 
         public IEnumerable<Veterinario> Veterinarios { get; set; }
        
         public void OnGet()
        {
             Veterinarios = _repositorioVeterinario.GetAllVeterinarios();
        }
         public void OnPostAdd(Veterinario veterinarios)
        {
            _repositorioVeterinario.AddVeterinario(veterinarios);
             Veterinarios = _repositorioVeterinario.GetAllVeterinarios();
        }
    }
}
