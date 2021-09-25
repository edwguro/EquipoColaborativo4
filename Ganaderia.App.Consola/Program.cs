using System;
using Ganaderia.App.Dominio;
using Ganaderia.App.Persistencia;

namespace Ganaderia.App.Consola
{
    class Program
    {
        private static IRepositorioGanadero _repositorioGanadero = new RepositorioGanadero(new Persistencia.AppContext()); 
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddGanadero();
            
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
        
    }
}
