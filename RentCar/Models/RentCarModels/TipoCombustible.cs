using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models.RentCarModels
{
    public class TipoCombustible
    {
        public TipoCombustible()
        {
            this.Vehiculo = new HashSet<Vehiculo>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdTipoCombustible { get; set; }

        [Display(Name = "Código del tipo de computible")]
        [RegularExpression(@"^[a-zA-Z\s\.]*$")]
        [Required]
        [MinLength(3)]
        public string Descripcion { get; set; }

        public bool Estado { get; set; }

        public virtual ICollection<Vehiculo> Vehiculo { get; set; }
    }
}
