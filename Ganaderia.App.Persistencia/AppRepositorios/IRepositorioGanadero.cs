using Ganaderia.App.Dominio;
using System.Collections.Generic;

namespace Ganaderia.App.Persistencia
{
    public interface IRepositorioGanadero
    {
       void AddGanadero(Ganadero ganadero);
        IEnumerable<Ganadero> GetAllGanaderos();
    }
}
