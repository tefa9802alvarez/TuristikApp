using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TURISTIKApp.Entities.Models
{
    public class User
    {
        [Display(Name = "Id")]
        public Guid UserId { get; set; }

        [Display(Name = "Correo")]
        [Required(ErrorMessage = "El email es un campo obligatorio.")]
        public string Email { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "La contraseña es un campo obligatorio.")]
        public string Password { get; set; }

        [Display(Name = "Estado")]
        public int Status { get; set; }

        [Display(Name = "Rol")]
        [ForeignKey("RoleId")]
        public Guid RoleId { get; set; }

        public virtual Role? Role { get; set; }

        public virtual Employee? Employee { get; set; }

        public virtual Costumer? Costumer { get; set; }

    }
}