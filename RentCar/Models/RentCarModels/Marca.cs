using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models.RentCarModels
{
    public class Marca
    {
        public Marca()
        {
            this.Modelo = new HashSet<Modelo>();
            this.Vehiculo = new HashSet<Vehiculo>();

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Código de marca")]
        public int IdMarca { get; set; }

        [RegularExpression(@"^[a-zA-Z\s\.]*$")]
        [Required]
        [MinLength(3)]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }

        public bool Estado { get; set; }

        public virtual ICollection<Modelo> Modelo { get; set; }
        public virtual ICollection<Vehiculo> Vehiculo { get; set; }
    }
}
