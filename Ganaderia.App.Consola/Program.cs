using System;
using Ganaderia.App.Dominio;
using Ganaderia.App.Persistencia;
using System.Collections.Generic;
namespace Ganaderia.App.Consola
{
    class Program
    {
        private static IRepositorioGanadero _repositorioGanadero = new RepositorioGanadero(new Persistencia.AppContext()); 
        private static IRepositorioVeterinario _repositorioVeterinario = new RepositorioVeterinario(new Persistencia.AppContext()); 
        private static IRepositorioEjemplares _repositorioEjemplares = new RepositorioEjemplares(new Persistencia.AppContext()); 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddGanadero();
            // AddVeterinario();
            //AddEjemplares();
            //AddEjemplaresVacunasVeterinario();
            // AsignarVeterinarioAEjemplares();
              //DeleteGanadero(1);
              //GetAllVeterinarios();

            
            
        }
        private static void AddGanadero()
        {
            var ganadero = new Ganadero
            {
                Nombres = "Edwin",
                Apellidos = "Rodriguez",
                NumeroTelefono = "3148596562",
                Correo = "edwin.rodriguez@cun.edu.co",
                Contrasena = "12345",
                Latitud = 4554,
                Longitud = 5454,
            };

            _repositorioGanadero.AddGanadero(ganadero);
        }
         private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                Nombres = "Juan Carlos",
                Apellidos = "Zapata",
                NumeroTelefono = "3113596562",
                Correo = "juanzapata@cun.edu.co",
                Contrasena = "12345",
                TarjetaProfesional = "TP9821",
                Especialidad = "Inceminador",
            };

            _repositorioVeterinario.AddVeterinario(veterinario);
        }
        
        private static void AddEjemplares()
        {
            var ejemplares = new Ejemplares
            {
                FechaIngresoAnimal = DateTime.Now,
                Peso = "30 kilos",
                Edad = 26,
                NombreFinca = "Hacienda la Pola",
                Genero = "Macho",
                TipoGanado = "Vacuno",
                Raza = "Cebu",
                Veterinario = null,
                Vacunas = null,
               
            };

            _repositorioEjemplares.AddEjemplares(ejemplares);

        }
        private static void AddEjemplaresVacunasVeterinario()
        {

            var veterinario = new Veterinario
            {
                Nombres = "David",
                Apellidos = "Ospina",
                NumeroTelefono = "312432322",
                Correo = "david@mintic.edu.co",
                Contrasena = "987654",
                TarjetaProfesional = "TP123455",
                Especialidad = "Infectologo",
            };

            List<Vacunas> vacunas = new List<Vacunas>();

            Vacunas vac1 = new Vacunas
            {
                NombreVacuna = "Pisis",
                Laboratorio = "MK",
                Periosidad = DateTime.Now,
                Descripcion = "sirve para la fiebre"
            };

            Vacunas vac2 = new Vacunas
            {
                NombreVacuna = "Draguss",
                Laboratorio = "Fpizer",
                Periosidad = DateTime.Now,
                Descripcion = "sirve para la el dolor"
            };


            Vacunas vac3 = new Vacunas
            {
               NombreVacuna = "Pettes",
                Laboratorio = "Jhonson&Jhomson",
                Periosidad = DateTime.Now,
                Descripcion = "sirve para la el Garrapatas"
            };

            vacunas.Add(vac1);
            vacunas.Add(vac2);
            vacunas.Add(vac3);

            var ejemplares = new Ejemplares
            {
                FechaIngresoAnimal = DateTime.Now,
                Peso = "380 kilos",
                Edad = 16,
                NombreFinca = "Hacienda la Pola",
                Genero = "Macho",
                TipoGanado = "Vacuno",
                Raza = "Normandia",
                Veterinario = veterinario,
                Vacunas = vacunas
            };

            _repositorioEjemplares.AddEjemplares(ejemplares);
        }

         private static void AsignarVeterinarioAEjemplares()
        {
            _repositorioEjemplares.AsignarVeterinarioAEjemplares(1, 2);
        }
         private static void GetAllVeterinarios()
        {
            var veterinarios = _repositorioVeterinario.GetAllVeterinarios();

            foreach (var veterinario in veterinarios)
            {
                Console.WriteLine(veterinario.Nombres + " - " + veterinario.Apellidos);
            }

        }
         private static void GetAllEjemplares()
        {
            var ejemplares = _repositorioEjemplares.GetAllEjemplares();

        }
        private static void DeleteGanadero(int idGanadero)
        {
            _repositorioGanadero.DeleteGanadero(idGanadero);
        }
         private static void DeleteVerinario(int idVeterinario)
        {
            _repositorioVeterinario.DeleteVeterinario(idVeterinario);
        }



    }
}
