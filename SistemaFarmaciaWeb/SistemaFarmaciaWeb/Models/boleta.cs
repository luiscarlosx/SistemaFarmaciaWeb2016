namespace SistemaFarmaciaWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("boleta")]
    public partial class boleta
    {
        [Key]
        [StringLength(8)]
        public string num_boleta { get; set; }

        public DateTime fecha { get; set; }

        [Required]
        [StringLength(8)]
        public string cod_empl { get; set; }

        [Required]
        [StringLength(8)]
        public string cod_cli { get; set; }

        [Required]
        [StringLength(8)]
        public string num_ordenpedido { get; set; }

        public int subtotal { get; set; }

        public int? descuento { get; set; }

        public int total { get; set; }

        public virtual OrdenPedido OrdenPedido { get; set; }
    }
}
