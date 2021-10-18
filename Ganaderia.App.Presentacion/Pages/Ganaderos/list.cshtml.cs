using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ganaderia.App.Dominio;

namespace Ganaderia.App.Presentacion.Pages
{
  public class listModel : PageModel
    {
      public List <Ganadero> Ganaderos {get; set; }
      public string usuarios;
       
        public IActionResult OnGet()
          {
           var ganadero = new Ganadero
          {
              Nombres= "Juan",
              Apellidos = "Rojas",
              NumeroTelefono = "3148596562",
              Correo = "juan.rojas@cun.edu.co",
              Contrasena = "12345",
              Latitud = 4554,
              Longitud = 5455,
           };

           Ganaderos = new List<Ganadero>();
           Ganaderos.Add(ganadero);
           usuarios = Request.Cookies["key"];
            // if (usuarios == null) {
            //     return Redirect("/Ganaderos/list");
            // }

           return Page();

           Console.WriteLine("Nombre login :" + usuarios);

        }
    }
}
