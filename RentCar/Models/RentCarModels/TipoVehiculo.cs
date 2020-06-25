
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models.RentCarModels
{
    public class TipoVehiculo
    {
        public TipoVehiculo()
        {
            this.Vehiculo = new HashSet<Vehiculo>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Código del tipo de vehículo")]
        public int IdTipoVehiculo { get; set; }

        [RegularExpression(@"^[a-zA-Z\s\.]*$")]
        [Required]
        [MinLength(2)]
        public string Descripcion { get; set; }

        public bool Estado { get; set; }

        public virtual ICollection<Vehiculo> Vehiculo { get; set; }
    }
}
