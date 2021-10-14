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
    public class RegisterModel : PageModel
    {
         private static IRepositorioGanadero _repositorioGanadero = new RepositorioGanadero(new Persistencia.AppContext()); 
        public IEnumerable<Ganadero> Ganaderos { get; set; }
        
        public void OnGet()
        {
         Ganaderos = _repositorioGanadero.GetAllGanaderos();
        }
        public void OnPostAdd(Ganadero ganadero)
        {
            _repositorioGanadero.AddGanadero(ganadero);
             Ganaderos = _repositorioGanadero.GetAllGanaderos();
        }
    }
}
