using System;
namespace Ganaderia.App.Dominio
{
    public class Vacunas
    {
        public int Id { get; set; }
        public string NombreVacuna { get; set; }
        public string Laboratorio { get; set; }
        public DateTime Periosidad { get; set; }
        public string Descripcion { get; set; }
        
        
    }
}