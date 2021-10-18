using System;
using Ganaderia.App.Dominio;
using System.Collections.Generic;
using System.Linq;
using Ganaderia.App.Persistencia;


namespace Ganaderia.App.Persistencia
{
    public class RepositorioGanadero : IRepositorioGanadero
    {
        private readonly AppContext _appContext;

        public RepositorioGanadero(AppContext appContext)
        {
            _appContext = appContext;
        }
void IRepositorioGanadero.AddGanadero(Ganadero ganadero)
        {
            _appContext.Ganaderos.Add(ganadero);
            _appContext.SaveChanges();
        }
        IEnumerable<Ganadero> IRepositorioGanadero.GetAllGanaderos()
        {
            return _appContext.Ganaderos;
        }
        Ganadero IRepositorioGanadero.GetLogin(string correo, string contrasena)
        {
            return _appContext.Ganaderos.FirstOrDefault(g => g.Correo == correo && g.Contrasena == contrasena);
        }
        void IRepositorioGanadero.DeleteGanaderos(int idGanadero)
        {
            var ganaderoEncontrado = _appContext.Ganaderos.FirstOrDefault(g => g.Id == idGanadero);

            if (ganaderoEncontrado != null) 
            {
                _appContext.Ganaderos.Remove(ganaderoEncontrado);
                _appContext.SaveChanges();
            }
        }
         Ganadero IRepositorioGanadero.GetGanadero(int idGanadero)
        {
            return _appContext.Ganaderos.FirstOrDefault(g => g.Id == idGanadero);
        }

    } 
}