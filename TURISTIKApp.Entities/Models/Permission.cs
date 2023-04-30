using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TURISTIKApp.Entities.Models
{
    public class Permission
    {
        public Guid PermissionId { get; set; }

        [Required(ErrorMessage = "El modulo es un campo obligatorio.")]
        public string Module { get; set; }

        public int Status { get; set; }

        public virtual ICollection<AssociatedPermission>? AssociatedPermission { get; set; }
    }
}
