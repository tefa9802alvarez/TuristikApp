using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace TURISTIKApp.Entities.Models
{
    public class AssociatedPermission
    {
        public Guid AssociatedPermissionId { get; set; }

        [Display(Name = "Permiso")]
        [ForeignKey("PermissionId")]
        public Guid PermissionId { get; set; }

        public virtual Permission? Permission { get; set; }

        [Display(Name = "Rol")]
        [ForeignKey("RoleId")]
        public Guid RoleId { get; set; }

        public virtual Role? Role { get; set; }
    }
}