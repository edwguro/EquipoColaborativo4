using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ganaderia.App.Dominio;

namespace Ganaderia.App.Presentacion.Pages
{
    public class EjemplaresModel : PageModel
    {
         public List <Ejemplares> Ejemplares {get; set; }
       
        public void OnGet()
          {
            var ejemplare = new Ejemplares
          {
              FechaIngresoAnimal= "25/12/23",
              Peso = "340 k",
              Edad = 36,
              NombreFinca = "Hacienda la Linda",
              Genero= "Macho",
              TipoGanado = "Bovino",
              Raza = "Cebu",
              
           };
           var ejemplare1 = new Ejemplares
          {
              FechaIngresoAnimal= "2/10/2021",
              Peso = "310 k",
              Edad = 16,
              NombreFinca = "Hacienda Carolina",
              Genero= "Hembra",
              TipoGanado = "Equino",
              Raza = "Arabe criollo",
              
           };

           Ejemplares = new List<Ejemplares>();
           Ejemplares.Add(ejemplare);
           Ejemplares.Add(ejemplare1);


        }
    }
}
