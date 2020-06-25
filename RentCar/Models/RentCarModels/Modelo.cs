using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models.RentCarModels
{
    public class Modelo
    {
        public Modelo()
        {

            this.Vehiculo = new HashSet<Vehiculo>();
        }
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Código de Modelo")]
        public int IdModelo { get; set; }

       
        [Required]
        [MinLength(2)]
        public string Descripcion { get; set; }

        public int IdMarca { get; set; }

        public bool Estado { get; set; }

        public virtual Marca Marca { get; set; }

        public virtual ICollection<Vehiculo> Vehiculo { get; set; }
    }
}
