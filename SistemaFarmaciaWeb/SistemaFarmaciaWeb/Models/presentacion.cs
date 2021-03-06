namespace SistemaFarmaciaWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("presentacion")]
    public partial class presentacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public presentacion()
        {
            Producto = new HashSet<Producto>();
        }

        [Key]
        [StringLength(8)]
        public string cod_pre { get; set; }

        [StringLength(50)]
        public string nom_pre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto> Producto { get; set; }


        public List<presentacion> Listar()
        {
            var presentaciones = new List<presentacion>();
            try
            {
                using (var ctx = new FarmaciaContext())
                {
                    presentaciones = ctx.presentacion.ToList();
                }
            }
            catch (Exception)
            {
                throw;

            }

            return presentaciones;
        }
    }
}
