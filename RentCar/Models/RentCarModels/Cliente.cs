using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models.RentCarModels
{
    public class Cliente
    {
        public Cliente()
        {
            this.Inspeccion = new HashSet<Inspeccion>();
            this.RentaDevolucion = new HashSet<RentaDevolucion>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Código del cliente")]
        public int IdCliente { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50, MinimumLength = 5)]
        [RegularExpression(@"^[a-zA-Z\s\.]*$")]
        [Display(Name = "Nombre del cliente")]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        [Display(Name = "Cedula del cliente")]
        [MinLength(11)]
        public string Cedula { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        [StringLength(19, MinimumLength = 13)]
        [Display(Name = "Tarjeta de crédito")]
        [DataType(DataType.CreditCard)]
        public string TarjetaCr { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Límite de crédito")]
        public int LimiteCr { get; set; }

        [Required]
        [Display(Name = "Tipo de persona")]
        public int IdTipoPersona { get; set; }

        public bool Estado { get; set; }

        public virtual TipoPersona TipoPersona { get; set; }
        public virtual ICollection<Inspeccion> Inspeccion { get; set; }
        public virtual ICollection<RentaDevolucion> RentaDevolucion { get; set; }
    }
}
