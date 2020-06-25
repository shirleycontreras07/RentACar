using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models.RentCarModels
{
    public class TipoPersona
    {
        public TipoPersona()
        {

            this.Cliente = new HashSet<Cliente>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoPersona { get; set; }

        [RegularExpression(@"^[a-zA-Z\s\.]*$")]
        [Required]
        public string Descripcion { get; set; }

        public bool Estado { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
