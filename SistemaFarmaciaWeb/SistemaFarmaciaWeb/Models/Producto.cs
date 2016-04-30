namespace SistemaFarmaciaWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Entity.Spatial;

    [Table("Producto")]
    public partial class Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            DetalleOrdenPedido = new HashSet<DetalleOrdenPedido>();
        }

        [Key]
        [StringLength(8)]
        public string cod_pro { get; set; }

        [Required]
        [StringLength(40)]
        public string nom_pro { get; set; }

        public decimal pre_venta { get; set; }

        public decimal pre_compra { get; set; }

        public DateTime fecha_venc { get; set; }

        public int stock { get; set; }

        [Required]
        [StringLength(8)]
        public string cod_cate { get; set; }

        [StringLength(8)]
        public string cod_prov { get; set; }

        [StringLength(8)]
        public string cod_pres { get; set; }

        public virtual categoria categoria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleOrdenPedido> DetalleOrdenPedido { get; set; }

        public virtual presentacion presentacion { get; set; }

        public virtual proveedor proveedor { get; set; }

        public List<Producto> Listar()
        {
            var productos =new List<Producto>();
            try
            {
                using (var ctx=new FarmaciaContext())
                {
                    productos = ctx.Producto.ToList();
                }
            }
            catch (Exception)
            {
                throw;

            }

            return productos;         
        }
        
        public void Guardar(Producto producto)
        {
            try
            {
                using(var ctx=new FarmaciaContext())
                {
                    if (producto.cod_pro != "")
                    {

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

        }  
    }
}
