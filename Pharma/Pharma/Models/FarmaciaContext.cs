using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Pharma.Models
{
    public partial class FarmaciaContext : DbContext
    {
        public FarmaciaContext()
        {
        }

        public FarmaciaContext(DbContextOptions<FarmaciaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<ClienteTipoPago> ClienteTipoPagos { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<OrdenCompra> OrdenCompras { get; set; }
        public virtual DbSet<OrdenProducto> OrdenProductos { get; set; }
        public virtual DbSet<Pedido> Pedidos { get; set; }
        public virtual DbSet<PedidoProducto> PedidoProductos { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Proveedor> Proveedors { get; set; }
        public virtual DbSet<TipoPago> TipoPagos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=SPICY-SAUCE;Database=Farmacia;User ID=SPICY-SAUCE\\eliam;Trusted_Connection=true;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("Cliente");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodPostal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClienteTipoPago>(entity =>
            {
                entity.HasKey(e => new { e.IdPago, e.IdCliente })
                    .HasName("PK_ClienteTipoPago_1");

                entity.ToTable("ClienteTipoPago");

                entity.Property(e => e.IdPago).HasColumnName("ID_Pago");

                entity.Property(e => e.IdCliente).HasColumnName("ID_Cliente");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.ClienteTipoPagos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClienteTipoPago_Cliente");

                entity.HasOne(d => d.IdPagoNavigation)
                    .WithMany(p => p.ClienteTipoPagos)
                    .HasForeignKey(d => d.IdPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClienteTipoPago_TipoPago");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado);

                entity.ToTable("Empleado");

                entity.Property(e => e.IdEmpleado).HasColumnName("ID_Empleado");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Puesto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasKey(e => e.IdFactura);

                entity.ToTable("Factura");

                entity.Property(e => e.IdFactura).HasColumnName("ID_Factura");

                entity.Property(e => e.FechaFactura)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Factura");

                entity.Property(e => e.IdPedido).HasColumnName("ID_Pedido");

                entity.Property(e => e.IdTipoPago).HasColumnName("ID_TipoPago");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.IdPedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Factura_Pedido");

                entity.HasOne(d => d.IdTipoPagoNavigation)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.IdTipoPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Factura_TipoPago");
            });

            modelBuilder.Entity<OrdenCompra>(entity =>
            {
                entity.HasKey(e => e.IdOrComp);

                entity.ToTable("OrdenCompra");

                entity.Property(e => e.IdOrComp).HasColumnName("ID_OrComp");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.IdEmpleado).HasColumnName("ID_Empleado");

                entity.Property(e => e.IdProveedor).HasColumnName("ID_Proveedor");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.OrdenCompras)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdenCompra_Empleado");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.OrdenCompras)
                    .HasForeignKey(d => d.IdProveedor)
                    .HasConstraintName("FK_OrdenCompra_Proveedors");
            });

            modelBuilder.Entity<OrdenProducto>(entity =>
            {
                entity.HasKey(e => new { e.IdOc, e.IdProducto });

                entity.ToTable("OrdenProducto");

                entity.Property(e => e.IdOc).HasColumnName("ID_OC");

                entity.Property(e => e.IdProducto).HasColumnName("ID_Producto");

                entity.HasOne(d => d.IdOcNavigation)
                    .WithMany(p => p.OrdenProductos)
                    .HasForeignKey(d => d.IdOc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdenProducto_OrdenCompra");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.OrdenProductos)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdenProducto_Productos");
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.HasKey(e => e.IdPedido);

                entity.ToTable("Pedido");

                entity.Property(e => e.IdPedido).HasColumnName("ID_Pedido");

                entity.Property(e => e.FechaPedido)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Pedido");

                entity.Property(e => e.IdCliente).HasColumnName("ID_Cliente");
            });

            modelBuilder.Entity<PedidoProducto>(entity =>
            {
                entity.HasKey(e => new { e.Idpedido, e.Idproducto });

                entity.ToTable("PedidoProducto");

                entity.Property(e => e.Idpedido).HasColumnName("IDPedido");

                entity.Property(e => e.Idproducto).HasColumnName("IDProducto");

                entity.HasOne(d => d.IdpedidoNavigation)
                    .WithMany(p => p.PedidoProductos)
                    .HasForeignKey(d => d.Idpedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PedidoProducto_Pedido");

                entity.HasOne(d => d.IdproductoNavigation)
                    .WithMany(p => p.PedidoProductos)
                    .HasForeignKey(d => d.Idproducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PedidoProducto_Productos");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaVencimiento).HasColumnType("date");

                entity.Property(e => e.Itbis)
                    .HasColumnName("ITBIS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Laboratorio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PrecioCompra).HasColumnName("Precio_Compra");

                entity.Property(e => e.PrecioVenta).HasColumnName("Precio_Venta");

                entity.Property(e => e.TipoProducto)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.HasKey(e => e.IdProveedor)
                    .HasName("PK_Proveedor");

                entity.Property(e => e.IdProveedor).HasColumnName("ID_Proveedor");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoPago>(entity =>
            {
                entity.HasKey(e => e.IdPago);

                entity.ToTable("TipoPago");

                entity.Property(e => e.IdPago)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Pago");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(20)
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
