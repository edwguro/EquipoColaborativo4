using System;
using Ganaderia.App.Dominio;
using System.Collections.Generic;
using System.Linq;


namespace Ganaderia.App.Persistencia
{
    public interface IRepositorioEjemplares
    {
       void AddEjemplares(Ejemplares ejemplares);
       Ejemplares AsignarVeterinarioAEjemplares(int idEjemplares, int idVeterinario);
       IEnumerable<Ejemplares> GetAllEjemplares();
       


    }
     
    
}
