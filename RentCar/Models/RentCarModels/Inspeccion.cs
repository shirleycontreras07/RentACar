using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models.RentCarModels
{
    public class Inspeccion
    {
        public Inspeccion()
        {
            this.RentaDevolucion = new HashSet<RentaDevolucion>();
           
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Código de la transacción")]
        public int IdTransaccion { get; set; }

        [Required]
        [Display(Name = "Verhículo")]
        public int IdVehiculo { get; set; }

        [Required]
        [Display(Name = "Cliente")]
        public int IdCliente { get; set; }
        
        [Required]
        [Display(Name = "Empleado")]
        public int IdEmpleado { get; set; }

        [Display(Name = "Ralladura")]
        public bool Ralladura { get; set; }

        [Display(Name = "Goma de repuesta")]
        public bool GomaRepuesta { get; set; }

        [Display(Name = "Gato")]
        public bool Gato { get; set; }

        [Display(Name = "Roturas de cristal")]
        public bool RoturaCristal { get; set; }

        [Display(Name = "Estado goma delatera izquierda")]
        public bool PrimeraGoma { get; set; }

        [Display(Name = "Estado goma delatera derecha")]
        public bool SegundaGoma { get; set; }

        [Display(Name = "Estado goma trasera izquierda")]
        public bool TerceraGoma { get; set; }

        [Display(Name = "Estado goma trasera derecha")]
        public bool CuartaGoma { get; set; }

        [Range(1, 100)]
        [Required]
        [Display(Name = "Cantidad de combustible")]
        public int CantidadCombustible { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de inspección")]
        public DateTime Fecha { get; set; }

        public bool Estado { get; set; }

        public virtual Vehiculo Vehiculo { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Empleado Empleado { get; set; }

        public virtual ICollection<RentaDevolucion> RentaDevolucion { get; set; }
    }
}
