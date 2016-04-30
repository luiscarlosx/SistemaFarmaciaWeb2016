namespace SistemaFarmaciaWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FarmaciaContext : DbContext
    {
        public FarmaciaContext()
            : base("name=FarmaciaContext")
        {
        }

        public virtual DbSet<boleta> boleta { get; set; }
        public virtual DbSet<categoria> categoria { get; set; }
        public virtual DbSet<clientes> clientes { get; set; }
        public virtual DbSet<DetalleOrdenPedido> DetalleOrdenPedido { get; set; }
        public virtual DbSet<distrito> distrito { get; set; }
        public virtual DbSet<empleado> empleado { get; set; }
        public virtual DbSet<OrdenPedido> OrdenPedido { get; set; }
        public virtual DbSet<presentacion> presentacion { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<proveedor> proveedor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<boleta>()
                .Property(e => e.num_boleta)
                .IsUnicode(false);

            modelBuilder.Entity<boleta>()
                .Property(e => e.cod_empl)
                .IsUnicode(false);

            modelBuilder.Entity<boleta>()
                .Property(e => e.cod_cli)
                .IsUnicode(false);

            modelBuilder.Entity<boleta>()
                .Property(e => e.num_ordenpedido)
                .IsUnicode(false);

            modelBuilder.Entity<categoria>()
                .Property(e => e.cod_cate)
                .IsUnicode(false);

            modelBuilder.Entity<categoria>()
                .Property(e => e.nom_des)
                .IsUnicode(false);

            modelBuilder.Entity<categoria>()
                .HasMany(e => e.Producto)
                .WithRequired(e => e.categoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.cod_cli)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.nom_cli)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.dir_cli)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.cod_dis)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.sexo)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .HasMany(e => e.OrdenPedido)
                .WithOptional(e => e.clientes)
                .HasForeignKey(e => e.cod_cli);

            modelBuilder.Entity<clientes>()
                .HasMany(e => e.OrdenPedido1)
                .WithOptional(e => e.clientes1)
                .HasForeignKey(e => e.cod_cli);

            modelBuilder.Entity<DetalleOrdenPedido>()
                .Property(e => e.num_ordenp)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleOrdenPedido>()
                .Property(e => e.cod_pro)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleOrdenPedido>()
                .Property(e => e.nom_pro)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleOrdenPedido>()
                .Property(e => e.cantidad)
                .HasPrecision(10, 2);

            modelBuilder.Entity<DetalleOrdenPedido>()
                .Property(e => e.precio_venta)
                .HasPrecision(10, 2);

            modelBuilder.Entity<DetalleOrdenPedido>()
                .Property(e => e.importe)
                .HasPrecision(10, 2);

            modelBuilder.Entity<distrito>()
                .Property(e => e.cod_dis)
                .IsUnicode(false);

            modelBuilder.Entity<distrito>()
                .Property(e => e.nom_dis)
                .IsUnicode(false);

            modelBuilder.Entity<distrito>()
                .HasMany(e => e.empleado)
                .WithRequired(e => e.distrito)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<distrito>()
                .HasMany(e => e.proveedor)
                .WithOptional(e => e.distrito)
                .HasForeignKey(e => e.id_distrito);

            modelBuilder.Entity<empleado>()
                .Property(e => e.cod_emp)
                .IsUnicode(false);

            modelBuilder.Entity<empleado>()
                .Property(e => e.nom_emp)
                .IsUnicode(false);

            modelBuilder.Entity<empleado>()
                .Property(e => e.dir_emp)
                .IsUnicode(false);

            modelBuilder.Entity<empleado>()
                .Property(e => e.cod_dis)
                .IsUnicode(false);

            modelBuilder.Entity<empleado>()
                .Property(e => e.cargo)
                .IsUnicode(false);

            modelBuilder.Entity<empleado>()
                .Property(e => e.edad)
                .IsUnicode(false);

            modelBuilder.Entity<empleado>()
                .Property(e => e.clave)
                .IsUnicode(false);

            modelBuilder.Entity<empleado>()
                .HasMany(e => e.OrdenPedido)
                .WithOptional(e => e.empleado)
                .HasForeignKey(e => e.cod_emp);

            modelBuilder.Entity<empleado>()
                .HasMany(e => e.OrdenPedido1)
                .WithOptional(e => e.empleado1)
                .HasForeignKey(e => e.cod_emp);

            modelBuilder.Entity<OrdenPedido>()
                .Property(e => e.num_ordenPedido)
                .IsUnicode(false);

            modelBuilder.Entity<OrdenPedido>()
                .Property(e => e.cod_cli)
                .IsUnicode(false);

            modelBuilder.Entity<OrdenPedido>()
                .Property(e => e.nom_cli)
                .IsUnicode(false);

            modelBuilder.Entity<OrdenPedido>()
                .Property(e => e.cod_emp)
                .IsUnicode(false);

            modelBuilder.Entity<OrdenPedido>()
                .Property(e => e.cod_tipoPago)
                .IsUnicode(false);

            modelBuilder.Entity<OrdenPedido>()
                .HasMany(e => e.boleta)
                .WithRequired(e => e.OrdenPedido)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<presentacion>()
                .Property(e => e.cod_pre)
                .IsUnicode(false);

            modelBuilder.Entity<presentacion>()
                .Property(e => e.nom_pre)
                .IsUnicode(false);

            modelBuilder.Entity<presentacion>()
                .HasMany(e => e.Producto)
                .WithOptional(e => e.presentacion)
                .HasForeignKey(e => e.cod_pres);

            modelBuilder.Entity<Producto>()
                .Property(e => e.cod_pro)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.nom_pro)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.pre_venta)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Producto>()
                .Property(e => e.pre_compra)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Producto>()
                .Property(e => e.cod_cate)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.cod_prov)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.cod_pres)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .HasMany(e => e.DetalleOrdenPedido)
                .WithRequired(e => e.Producto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<proveedor>()
                .Property(e => e.cod_prov)
                .IsUnicode(false);

            modelBuilder.Entity<proveedor>()
                .Property(e => e.nom_prov)
                .IsUnicode(false);

            modelBuilder.Entity<proveedor>()
                .Property(e => e.dir_prov)
                .IsUnicode(false);

            modelBuilder.Entity<proveedor>()
                .Property(e => e.telefono)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<proveedor>()
                .Property(e => e.celular)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<proveedor>()
                .Property(e => e.id_distrito)
                .IsUnicode(false);
        }
    }
}
