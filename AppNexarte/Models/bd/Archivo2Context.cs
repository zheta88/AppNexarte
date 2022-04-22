using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AppNexarte.Models.bd
{
    public partial class Archivo2Context : DbContext
    {
        public Archivo2Context()
        {
        }

        public Archivo2Context(DbContextOptions<Archivo2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<LogConsultaNomNominaDefinitiva> LogConsultaNomNominaDefinitivas { get; set; } = null!;
        public virtual DbSet<NomConceptosNomina> NomConceptosNominas { get; set; } = null!;
        public virtual DbSet<NomEmpleado> NomEmpleados { get; set; } = null!;
        public virtual DbSet<NomNominaDefinitiva> NomNominaDefinitivas { get; set; } = null!;
        public virtual DbSet<RegSolicitudesIngreso> RegSolicitudesIngresos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=EN911305\\MSSQLSERVER1;Database=Archivo2;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LogConsultaNomNominaDefinitiva>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("log_consulta_nom_nomina_definitiva");

                entity.Property(e => e.DescripciónDeEvento).HasColumnName("descripción_de_evento");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.IdRegistro)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_registro");

                entity.Property(e => e.Operación)
                    .HasMaxLength(10)
                    .HasColumnName("operación");

                entity.Property(e => e.Usuario).HasMaxLength(30);
            });

            modelBuilder.Entity<NomConceptosNomina>(entity =>
            {
                entity.HasKey(e => e.IdConcepto)
                    .HasName("PK__NOM_CONC__EFAAA4B41E5B3034");

                entity.ToTable("NOM_CONCEPTOS_NOMINA");

                entity.Property(e => e.IdConcepto).HasColumnName("ID_CONCEPTO");

                entity.Property(e => e.CodConcepto)
                    .HasMaxLength(30)
                    .HasColumnName("COD_CONCEPTO");

                entity.Property(e => e.DescConcepto)
                    .HasMaxLength(40)
                    .HasColumnName("DESC_CONCEPTO");
            });

            modelBuilder.Entity<NomEmpleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado)
                    .HasName("PK__NOM_EMPL__D22EA205DF551A3D");

                entity.ToTable("NOM_EMPLEADOS");

                entity.Property(e => e.IdEmpleado).HasColumnName("id_EMPLEADO");

                entity.Property(e => e.IdSolicitud).HasColumnName("ID_SOLICITUD");

                entity.HasOne(d => d.IdSolicitudNavigation)
                    .WithMany(p => p.NomEmpleados)
                    .HasForeignKey(d => d.IdSolicitud)
                    .HasConstraintName("FK__NOM_EMPLE__ID_SO__3E52440B");
            });

            modelBuilder.Entity<NomNominaDefinitiva>(entity =>
            {
                entity.HasKey(e => e.Registro)
                    .HasName("PK__NOM_NOMI__9A691DFDE70A102F");

                entity.ToTable("NOM_NOMINA_DEFINITIVA");

                entity.Property(e => e.Registro).HasColumnName("REGISTRO");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.FchCre)
                    .HasColumnType("date")
                    .HasColumnName("FCH_CRE");

                entity.Property(e => e.IdConceptoF).HasColumnName("ID_CONCEPTO_F");

                entity.Property(e => e.IdEmpleadoF).HasColumnName("ID_EMPLEADO_F");

                entity.Property(e => e.ValNomina).HasColumnName("VAL_NOMINA");

                entity.HasOne(d => d.IdConceptoFNavigation)
                    .WithMany(p => p.NomNominaDefinitivas)
                    .HasForeignKey(d => d.IdConceptoF)
                    .HasConstraintName("FK__NOM_NOMIN__ID_CO__3F466844");

                entity.HasOne(d => d.IdEmpleadoFNavigation)
                    .WithMany(p => p.NomNominaDefinitivas)
                    .HasForeignKey(d => d.IdEmpleadoF)
                    .HasConstraintName("FK__NOM_NOMIN__ID_EM__403A8C7D");
            });

            modelBuilder.Entity<RegSolicitudesIngreso>(entity =>
            {
                entity.HasKey(e => e.IdSolicitud)
                    .HasName("PK__REG_SOLI__5E60BD60C23E0B6E");

                entity.ToTable("REG_SOLICITUDES_INGRESOS");

                entity.Property(e => e.IdSolicitud).HasColumnName("id_SOLICITUD");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(30)
                    .HasColumnName("APELLIDOS");

                entity.Property(e => e.Documento)
                    .HasMaxLength(10)
                    .HasColumnName("DOCUMENTO");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(30)
                    .HasColumnName("NOMBRES");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
