using System;
using System.Collections.Generic;
namespace Ganaderia.App.Dominio
{
    public class HistoriaClinica 
    {
     public int Id { get; set; }
     public string FechaHistoria { get; set; }
     public string Diagnostico { get; set; }
     public string Tratamiento { get; set; }
     public string VacunasAplicadas { get; set; }
     public string Observaciones { get; set; }
     public Ejemplares Ejemplar{ get; set; }
    
   
     
    }
}