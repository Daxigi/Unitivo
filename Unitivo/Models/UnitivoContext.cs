using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Unitivo.Models;

public partial class UnitivoContext : DbContext
{
    public UnitivoContext()
    {
    }

    public UnitivoContext(DbContextOptions<UnitivoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categorium> Categoria { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<DetalleFactura> DetalleFacturas { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<Perfile> Perfiles { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Talle> Talles { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categorium>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("PK__categori__CD54BC5A58F0EA4A");

            entity.ToTable("categoria");

            entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");
            entity.Property(e => e.DescripcionCategoria)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("descripcion_categoria");
            entity.Property(e => e.EstadoCategoria).HasColumnName("estado_categoria");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PK__clientes__677F38F5C549AC78");

            entity.ToTable("clientes");

            entity.HasIndex(e => e.CorreoCliente, "UQ__clientes__84B2AA4ED80D529B").IsUnique();

            entity.HasIndex(e => e.DniCliente, "UQ__clientes__F53D4BA4E66C2206").IsUnique();

            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.ApellidoCliente)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("apellido_cliente");
            entity.Property(e => e.CorreoCliente)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("correo_cliente");
            entity.Property(e => e.DireccionCliente)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("direccion_cliente");
            entity.Property(e => e.DniCliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("dni_cliente");
            entity.Property(e => e.EstadoCliente).HasColumnName("estado_cliente");
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FechaModificacion).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombre_cliente");
            entity.Property(e => e.TelefonoCliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono_cliente");
        });

        modelBuilder.Entity<DetalleFactura>(entity =>
        {
            entity.HasKey(e => e.IdDetalleVenta).HasName("PK__detalle___5B265D4702140082");

            entity.ToTable("detalle_factura");

            entity.Property(e => e.IdDetalleVenta).HasColumnName("id_detalle_venta");
            entity.Property(e => e.CantidadDetalle).HasColumnName("cantidad_detalle");
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdProducto).HasColumnName("id_producto");
            entity.Property(e => e.PrecioDetalle)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio_detalle");

            entity.HasOne(d => d.IdFacturaNavigation).WithMany(p => p.DetalleFacturas)
                .HasForeignKey(d => d.IdFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__detalle_f__id_fa__5AEE82B9");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.DetalleFacturas)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__detalle_f__id_pr__5BE2A6F2");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.IdEmpleado).HasName("PK__empleado__88B51394A1F3D958");

            entity.ToTable("empleados");

            entity.HasIndex(e => e.DniEmpleado, "UQ__empleado__0FA5136FC09AE263").IsUnique();

            entity.HasIndex(e => e.CorreoEmpleado, "UQ__empleado__6E485B81C1BDDF56").IsUnique();

            entity.HasIndex(e => e.TelefonoEmpleado, "UQ__empleado__D7BB1777906F52B6").IsUnique();

            entity.Property(e => e.IdEmpleado).HasColumnName("id_empleado");
            entity.Property(e => e.ApellidoEmpleado)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("apellido_empleado");
            entity.Property(e => e.CorreoEmpleado)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("correo_empleado");
            entity.Property(e => e.DireccionEmpleado)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("direccion_empleado");
            entity.Property(e => e.DniEmpleado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("dni_empleado");
            entity.Property(e => e.EstadoEmpleado).HasColumnName("estado_empleado");
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FechaModificacion).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.NombreEmpleado)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombre_empleado");
            entity.Property(e => e.TelefonoEmpleado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono_empleado");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.IdFactura).HasName("PK__factura__6C08ED53E39ABF4E");

            entity.ToTable("factura");

            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.EstadoFactura).HasColumnName("estado_factura");
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FechaFactura)
                .HasColumnType("date")
                .HasColumnName("fecha_factura");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__factura__id_clie__4D94879B");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__factura__id_usua__4CA06362");
        });


        modelBuilder.Entity<Perfile>(entity =>
        {
            entity.HasKey(e => e.IdPerfil).HasName("PK__perfiles__1D1C876842C500B4");

            entity.ToTable("perfiles");

            entity.Property(e => e.IdPerfil).HasColumnName("id_perfil");
            entity.Property(e => e.DescripcionPerfil)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("descripcion_perfil");
            entity.Property(e => e.EstadoPerfil).HasColumnName("estado_perfil");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("PK__producto__FF341C0DA5128EE0");

            entity.ToTable("productos");

            entity.Property(e => e.IdProducto).HasColumnName("id_producto");
            entity.Property(e => e.EstadoProducto).HasColumnName("estado_producto");
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FechaModificacion).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");
            entity.Property(e => e.IdTalle).HasColumnName("id_talle");
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombre_producto");
            entity.Property(e => e.Imagen)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("imagen");
            entity.Property(e => e.PrecioProducto)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio_producto");
            entity.Property(e => e.StockProducto).HasColumnName("stock_producto");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdCategoria)
                .HasConstraintName("FK__productos__id_ca__5629CD9C");

            entity.HasOne(d => d.IdTalleNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdTalle)
                .HasConstraintName("FK__productos__id_ta__571DF1D5");
        });

        modelBuilder.Entity<Talle>(entity =>
        {
            entity.HasKey(e => e.IdTalle).HasName("PK__talle__C16F4021DC24F35A");

            entity.ToTable("talle");

            entity.Property(e => e.IdTalle).HasColumnName("id_talle");
            entity.Property(e => e.DescripcionTalle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion_talle");
            entity.Property(e => e.EstadoTalle).HasColumnName("estado_talle");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__usuarios__4E3E04AD882F841C");

            entity.ToTable("usuarios");

            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.ContraseñaUsuario)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("contraseña_usuario");
            entity.Property(e => e.EstadoUsuario).HasColumnName("estado_usuario");
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FechaModificacion).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.IdEmpleado).HasColumnName("id_empleado");
            entity.Property(e => e.IdPerfil).HasColumnName("id_perfil");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_usuario");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdEmpleado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__usuarios__id_emp__4316F928");

            entity.HasOne(d => d.IdPerfilNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdPerfil)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__usuarios__id_per__4222D4EF");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
