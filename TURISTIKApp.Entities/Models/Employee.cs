using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TURISTIKApp.Entities.Models
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre es un campo obligatorio.")]
        public string Name { get; set; }

        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "El apellido es un campo obligatorio.")]
        public string LastName { get; set; }

        [Display(Name = "Documento")]
        [Required(ErrorMessage = "El documento es un campo obligatorio.")]
        public string Document { get; set; }

        [Display(Name = "Teléfono")]
        [Required(ErrorMessage = "El teléfono es un campo obligatorio.")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Usuario")]
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }

        public virtual User? User { get; set; }
    }
}