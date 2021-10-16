using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Ganaderia.App.Dominio;
using Ganaderia.App.Persistencia;

namespace Ganaderia.App.Presentacion.Pages
{
    public class IndexModel : PageModel
    {
        private static IRepositorioGanadero _repositorioGanadero = new RepositorioGanadero(new Persistencia.AppContext()); 
        private static IRepositorioVeterinario _repositorioVeterinario = new RepositorioVeterinario(new Persistencia.AppContext()); 
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public IActionResult OnPostLogin (string Correo, string Contrasena)
        {
            
         Console.WriteLine("Correo : " + Correo);
         Console.WriteLine("Contrasena : " + Contrasena);

         var ganadero = _repositorioGanadero.GetLogin(Correo, Contrasena);
         if (ganadero != null)
         {
             Console.WriteLine("Bienvenido a SICSA S.A");
             Console.WriteLine("Nombre :" + ganadero.Nombres);
             Response.Cookies.Append("nombres", ganadero.Nombres);
             Response.Cookies.Append("apellidos", ganadero.Apellidos);
             Response.Cookies.Append("correo", ganadero.Correo);

             return Redirect("/Ganaderos/list");
         }else
         {
             var veterinario = _repositorioVeterinario.GetLogin2(Correo, Contrasena);
         if (veterinario != null)
         {
             Console.WriteLine("Bienvenido a SICSA S.A");
             Console.WriteLine("Nombre :" + veterinario.Nombres);
             Response.Cookies.Append("nombres", veterinario.Nombres);
             Response.Cookies.Append("apellidos",veterinario.Apellidos);
             Response.Cookies.Append("correo", veterinario.Correo);

             return Redirect("/Veterinarios/listVeterinarios");
         }else
         {
             Console.WriteLine("Datos Erroneos");
             return Page();
         }
             
         }

         
        }
        public IActionResult OnPostLogin2(string Correo, string Contrasena)
        {
            var veterinario = _repositorioVeterinario.GetLogin2(Correo, Contrasena);
         if (veterinario != null)
         {
             Console.WriteLine("Bienvenido a SICSA S.A");
             Console.WriteLine("Nombre :" + veterinario.Nombres);
             Response.Cookies.Append("nombres", veterinario.Nombres);
             Response.Cookies.Append("apellidos",veterinario.Apellidos);
             Response.Cookies.Append("correo", veterinario.Correo);

             return Redirect("/Veterinarios/listVeterinarios");
         }else
         {
             Console.WriteLine("Datos Erroneos");
             return Page();
         }


        }

    }
}
