namespace Ganaderia.App.Dominio
{
    public class Solicitudes
    {
        public int Id { get; set; }
        public string FechaSolicitud { get; set; }
        public string Descripcion { get; set; }
        public string Estado{ get; set; }
        public Administrador Administrador{ get; set; }
        public Veterinario Veterinario { get; set; }


       
    }
}