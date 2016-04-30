namespace SistemaFarmaciaWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("empleado")]
    public partial class empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public empleado()
        {
            OrdenPedido = new HashSet<OrdenPedido>();
            OrdenPedido1 = new HashSet<OrdenPedido>();
        }

        [Key]
        [StringLength(8)]
        public string cod_emp { get; set; }

        [Required]
        [StringLength(40)]
        public string nom_emp { get; set; }

        [StringLength(40)]
        public string dir_emp { get; set; }

        [Required]
        [StringLength(8)]
        public string cod_dis { get; set; }

        [Required]
        [StringLength(40)]
        public string cargo { get; set; }

        [StringLength(2)]
        public string edad { get; set; }

        public int tel { get; set; }

        public int? cel { get; set; }

        public DateTime ingreso { get; set; }

        [Required]
        [StringLength(20)]
        public string clave { get; set; }

        public virtual distrito distrito { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenPedido> OrdenPedido { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenPedido> OrdenPedido1 { get; set; }
    }
}
