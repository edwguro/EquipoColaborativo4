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
    public class RegistroEjemplarModel : PageModel
    {
        private static IRepositorioEjemplares _repositorioEjemplares = new RepositorioEjemplares(new Persistencia.AppContext()); 
        public IEnumerable<Ejemplares> Ejemplares { get; set; }

        public void OnGet()
        {
             Ejemplares = _repositorioEjemplares.GetAllEjemplares();
        }
        public void OnPostAdd(Ejemplares ejemplares)
        {
            _repositorioEjemplares.AddEjemplares(ejemplares);
             Ejemplares = _repositorioEjemplares.GetAllEjemplares();
        }
    }
}
