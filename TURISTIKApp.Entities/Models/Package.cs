using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TURISTIKApp.Entities.Models
{
    public class Package
    {
        public Guid PackageId { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre es un campo obligatorio.")]
        public string Name { get; set; }

        [Display(Name = "Destino")]
        [Required(ErrorMessage = "El destino es un campo obligatorio.")]
        public string Destination { get; set; }

        [Display(Name = "Detalles")]
        [Required(ErrorMessage = "El detalle es un campo obligatorio.")]
        public string Details { get; set; }

        [Display(Name = "Transporte")]
        [Required(ErrorMessage = "El transporte es un campo obligatorio.")]
        public string Transport { get; set; }

        [Display(Name = "Hotel")]
        [Required(ErrorMessage = "El hotel es un campo obligatorio.")]
        public string Hotel { get; set; }

        [Display(Name = "Fecha de Salida")]
        [Required(ErrorMessage = "La fecha de salida " +
                                 "es un campo obligatorio.")]
        public string DepartureDate { get; set; }

        [Display(Name = "Fecha de Llegada")]
        [Required(ErrorMessage = "La fecha de llegada " +
                                 "es un campo obligatorio.")]
        public string ArrivalDate { get; set; }

        [Display(Name = "Lugar de Salida")]
        [Required(ErrorMessage = "El lugar de salida " +
                                 "es un campo obligatorio.")]
        public string DeparturePoint { get; set; }

        [Display(Name = "Cupos")]
        [Required(ErrorMessage = "Los cupos es un campo obligatorio.")]
        public int TotalQuotas { get; set; }

        [Display(Name = "Cupos Disponibles")]
        public int AvailableQuotas { get; set; }

        [Display(Name = "Precio")]
        [Required(ErrorMessage = "El precio es un campo obligatorio.")]
        public decimal Price { get; set; }

        [Display(Name = "Imagen")]
        [Required(ErrorMessage = "La imagen es un campo obligatorio.")]
        public string Image { get; set; }

        [Display(Name = "Estado")]
        public int Status { get; set; }

        //AQUÍ VAN LOS ICOLLETION

    }
}
