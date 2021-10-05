using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ganaderia.App.Dominio;

namespace Ganaderia.App.Presentacion.Pages
{
    public class listVeterinariosModel : PageModel
    {
       public List <Veterinario> Veterinarios {get; set; }
       
        public void OnGet()
          {
            var veterinario = new Veterinario
          {
              Nombres= "Manuel Francisco",
              Apellidos = "Tellez Rojas",
              NumeroTelefono = "3148596562",
              Correo = "mfran.trojas@cun.edu.co",
              Contrasena = "12345",
              Latitud = 4554,
              Longitud = 5455,
              TarjetaProfesional = "TP9877",
              Especialidad = "Zootecnico",
           };

           Veterinarios = new List<Veterinario>();
           Veterinarios.Add(veterinario);

        }
    }
}
