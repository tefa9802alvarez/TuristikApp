using System.ComponentModel.DataAnnotations;

namespace TURISTIKApp.Entities.Models
{
    public class Role
    {
        public Guid RoleId { get; set; }

        [Required(ErrorMessage = "El nombre es un campo obligatorio.")]
        public string Name { get; set; }

        public int Status { get; set; }

        public virtual ICollection<User>? User { get; set; }

        public virtual ICollection<AssociatedPermission>? AssociatedPermission { get; set; }
    }
}