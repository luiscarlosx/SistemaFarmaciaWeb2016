namespace SistemaFarmaciaWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DetalleOrdenPedido")]
    public partial class DetalleOrdenPedido
    {
        [Key]
        [StringLength(8)]
        public string num_ordenp { get; set; }

        [Required]
        [StringLength(8)]
        public string cod_pro { get; set; }

        [Required]
        [StringLength(40)]
        public string nom_pro { get; set; }

        public decimal? cantidad { get; set; }

        public decimal? precio_venta { get; set; }

        public decimal? importe { get; set; }

        public virtual Producto Producto { get; set; }
    }
}
