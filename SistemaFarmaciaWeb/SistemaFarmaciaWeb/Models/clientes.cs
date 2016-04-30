namespace SistemaFarmaciaWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    public partial class clientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public clientes()
        {
            OrdenPedido = new HashSet<OrdenPedido>();
            OrdenPedido1 = new HashSet<OrdenPedido>();
        }

        [Key]
        [StringLength(8)]
        public string cod_cli { get; set; }

        [Required]
        [StringLength(40)]
        public string nom_cli { get; set; }

        [StringLength(40)]
        public string dir_cli { get; set; }

        [StringLength(8)]
        public string cod_dis { get; set; }

        [Required]
        [StringLength(1)]
        public string sexo { get; set; }

        public int? DNI { get; set; }

        public int? RUC { get; set; }

        public int? Telefono { get; set; }

        public int? Celular { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenPedido> OrdenPedido { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenPedido> OrdenPedido1 { get; set; }

        public virtual distrito distrito { get; set; }

        public List<clientes> Listar()
        {
            var listaClientes = new List<clientes>();
            try
            {
                using (var ctx = new FarmaciaContext())
                {
                    listaClientes = ctx.clientes.ToList();
                }
            }
            catch (Exception)
            {
                throw;

            }

            return listaClientes;
        }
    }
}
