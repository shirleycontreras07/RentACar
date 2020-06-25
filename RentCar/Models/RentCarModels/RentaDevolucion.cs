using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models.RentCarModels
{
    public class RentaDevolucion
    { 

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Código de renta")]
        public int IdRenta { get; set; }

        [Required]
        [Display(Name = "Cliente")]
        public int IdCliente { get; set; }
        
        [Required]
        [Display(Name = "Empleado")]
        public int IdEmpleado { get; set; }

        [Required]
        [Display(Name = "Inspeccion")]
        public int IdInspeccion { get; set; }

        [Required]
        [Display(Name = "Vehículo")]
        public int IdVehiculo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de renta")]
        public DateTime FechaRenta { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de devolución")]
        public DateTime? FechaDevolucion { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Monto por día")]
        public int MontoDiario { get; set; }

        [Required]
        [Display(Name = "Cantidad de días")]
        public int CantidadDias { get; set; }

        [Display(Name = "Comentario")]
        [Column(TypeName = "varchar(200)")]
        [RegularExpression(@"^[a-zA-Z\s\.]*$")]
        public string Comentario { get; set; }

        [Display(Name = "Devuelto")]
        public bool Estado { get; set; }

        public virtual Empleado Empleado { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
        public virtual Inspeccion Inspeccion { get; set; }
    }
}
