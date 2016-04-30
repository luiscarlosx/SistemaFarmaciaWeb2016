namespace SistemaFarmaciaWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("proveedor")]
    public partial class proveedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public proveedor()
        {
            Producto = new HashSet<Producto>();
        }

        [Key]
        [StringLength(8)]
        public string cod_prov { get; set; }

        [Required]
        [StringLength(40)]
        public string nom_prov { get; set; }

        [StringLength(50)]
        public string dir_prov { get; set; }

        [StringLength(7)]
        public string telefono { get; set; }

        [StringLength(10)]
        public string celular { get; set; }

        [StringLength(8)]
        public string id_distrito { get; set; }

        public virtual distrito distrito { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto> Producto { get; set; }

        public List<proveedor> Listar()
        {
            var proveedores = new List<proveedor>();
            try
            {
                using (var ctx = new FarmaciaContext())
                {
                    proveedores = ctx.proveedor.ToList();
                }
            }
            catch (Exception)
            {
                throw;

            }

            return proveedores;
        }
    }
}
