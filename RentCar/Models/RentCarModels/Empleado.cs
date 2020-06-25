using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models.RentCarModels
{
    public class Empleado
    {
        public Empleado()
        {
            this.Inspeccion = new HashSet<Inspeccion>();
            this.RentaDevolucion = new HashSet<RentaDevolucion>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Código del empleado")]
        public int IdEmpleado { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Nombre del Empleado")]
        [RegularExpression(@"^[a-zA-Z\s\.]*$")]
        [MinLength(4)]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        [MinLength(11)]
        [Display(Name = "Cédula del cliente")]
        public string Cedula { get; set; }

        [Required]
        [Display(Name = "Tanda del empleado")]
        public int IdTanda { get; set; }

        [Required]
        [Display(Name = "Porciento de comisión")]
        public int Comision { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de ingreso del empleado")]
        public DateTime FechaIngreso { get; set; }

        public bool Estado { get; set; }

        public virtual Tanda Tanda { get; set; }
        public virtual ICollection<Inspeccion> Inspeccion { get; set; }
        public virtual ICollection<RentaDevolucion> RentaDevolucion { get; set; }
    }
}
