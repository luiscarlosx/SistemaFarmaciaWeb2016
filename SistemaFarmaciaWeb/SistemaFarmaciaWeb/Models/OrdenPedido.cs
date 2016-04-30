namespace SistemaFarmaciaWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrdenPedido")]
    public partial class OrdenPedido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrdenPedido()
        {
            boleta = new HashSet<boleta>();
        }

        [Key]
        [StringLength(8)]
        public string num_ordenPedido { get; set; }

        public DateTime fecha { get; set; }

        [StringLength(8)]
        public string cod_cli { get; set; }

        [StringLength(40)]
        public string nom_cli { get; set; }

        [StringLength(8)]
        public string cod_emp { get; set; }

        [StringLength(8)]
        public string cod_tipoPago { get; set; }

        public int? total { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<boleta> boleta { get; set; }

        public virtual clientes clientes { get; set; }

        public virtual clientes clientes1 { get; set; }

        public virtual empleado empleado { get; set; }

        public virtual empleado empleado1 { get; set; }
    }
}
