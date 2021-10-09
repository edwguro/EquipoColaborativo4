using System;
using System.Collections.Generic;

namespace Ganaderia.App.Dominio
{
    public class Ejemplares 
    {
        public int Id { get; set; }
        public DateTime FechaIngresoAnimal { get; set;}
        public string Peso { get; set; }
        public float Edad { get; set; }
        public string NombreFinca { get; set; }
        public string Genero { get; set;}
        public string TipoGanado { get; set;}
        public string Raza { get; set;}
        public Veterinario Veterinario { get; set; }
        public List<Vacunas> Vacunas { get; set;}
        

    }
}