using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models.RentCarModels
{
    public class Vehiculo
    {
        public Vehiculo()
        {
            this.Inspeccion = new HashSet<Inspeccion>();
            this.RentaDevolucion = new HashSet<RentaDevolucion>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Código del vehículo")]
        public int IdVehiculo { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Descripción")]
        [MinLength(3)]
        
        public string Descripcion { get; set; }

        [Required]
        [Column(TypeName = "varchar(9)")]
        [MinLength(8)]
        [MaxLength(8)]
        [Display(Name = "Número de chasis")]
        public string NumChasis { get; set; }

        [Required]
        [Column(TypeName = "varchar(8)")]
        [MinLength(7)]
        [MaxLength(8)]
        [Display(Name = "Número de placa")]
        public string NumPlaca { get; set; }

        [Required]
        [Display(Name = "Tipo de vehículo")]
        public int IdTipoVehiculo { get; set; }

        [Required]
        [Display(Name = "Marca")]
        public int IdMarca { get; set; }

        [Required]
        [Display(Name = "Modelo")]
        public int IdModelo { get; set; }

        [Required]
        [Display(Name = "Tipo de vehículo")]
        public int IdTipoCombustible { get; set; }

        public bool Estado { get; set; }



        public virtual TipoVehiculo TipoVehiculo { get; set; }
        public virtual TipoCombustible TipoCombustible { get; set; }
        public virtual Marca Marca { get; set; }
        public virtual Modelo Modelo { get; set; }

        public virtual ICollection<Inspeccion> Inspeccion { get; set; }
        public virtual ICollection<RentaDevolucion> RentaDevolucion { get; set; }
    }
}
