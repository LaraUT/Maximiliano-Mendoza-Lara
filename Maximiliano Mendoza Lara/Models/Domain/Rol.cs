using System.ComponentModel.DataAnnotations;

namespace Maximiliano_Mendoza_Lara.Models.Domain
{
    public class Rol
    {
        [Key]
        public int PkRol { get; set; }
        public string Nombre { get; set; }
    }
}
