using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SolicitudEstudiante.Models
{
    public partial class ADMISION_ESTContext : DbContext
    {
        public ADMISION_ESTContext()
        {
        }

        public ADMISION_ESTContext(DbContextOptions<ADMISION_ESTContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Campus> Campuses { get; set; }
        public virtual DbSet<Carrera> Carreras { get; set; }
        public virtual DbSet<Contacto> Contactos { get; set; }
        public virtual DbSet<Documento> Documentos { get; set; }
        public virtual DbSet<Escuela> Escuelas { get; set; }
        public virtual DbSet<Estudiante> Estudiantes { get; set; }
        public virtual DbSet<Facultad> Facultads { get; set; }
        public virtual DbSet<Identificacion> Identificacions { get; set; }
        public virtual DbSet<Nacionalidad> Nacionalidads { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<PlanEstudio> PlanEstudios { get; set; }
        public virtual DbSet<Sexo> Sexos { get; set; }
        public virtual DbSet<TipoSolicitud> TipoSolicituds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=ADMISION_EST;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Campus>(entity =>
            {
                entity.HasKey(e => e.IdCampus)
                    .HasName("PK__Campus__DA49C2DEA9AA21E6");

                entity.ToTable("Campus");

                entity.Property(e => e.NombreCampus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Carrera>(entity =>
            {
                entity.HasKey(e => e.IdCarrera)
                    .HasName("PK__Carrera__884A8F1FA357A602");

                entity.ToTable("Carrera");

                entity.Property(e => e.NombreCarrera)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Contacto>(entity =>
            {
                entity.HasKey(e => e.IdContacto)
                    .HasName("PK__Contacto__A4D6BBFA7CE36B7E");

                entity.ToTable("Contacto");

                entity.Property(e => e.NombreContacto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Documento>(entity =>
            {
                entity.HasKey(e => e.IdDocumento)
                    .HasName("PK__Document__E52073475A23FBB2");

                entity.Property(e => e.CarnetEstudiante)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CopiaCedula)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FormRegTemaInves)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Foto)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HojaRotacionInternado)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.KardexAcademico)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RecibodePago)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RecordNotas)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEstudianteNavigation)
                    .WithMany(p => p.Documentos)
                    .HasForeignKey(d => d.IdEstudiante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Documento__IdEst__45F365D3");
            });

            modelBuilder.Entity<Escuela>(entity =>
            {
                entity.HasKey(e => e.IdEscuela)
                    .HasName("PK__Escuela__D6C6BBF50B3E794D");

                entity.ToTable("Escuela");

                entity.Property(e => e.NombreEscuela)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Estudiante>(entity =>
            {
                entity.HasKey(e => e.MatriculaEst)
                    .HasName("PK__Estudian__06987727E08FE865");

                entity.ToTable("Estudiante");

                entity.HasOne(d => d.IdCampusNavigation)
                    .WithMany(p => p.Estudiantes)
                    .HasForeignKey(d => d.IdCampus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Estudiant__IdCam__3E52440B");

                entity.HasOne(d => d.IdCarreraNavigation)
                    .WithMany(p => p.Estudiantes)
                    .HasForeignKey(d => d.IdCarrera)
                    .HasConstraintName("FK__Estudiant__IdCar__412EB0B6");

                entity.HasOne(d => d.IdEscuelaNavigation)
                    .WithMany(p => p.Estudiantes)
                    .HasForeignKey(d => d.IdEscuela)
                    .HasConstraintName("FK__Estudiant__IdEsc__403A8C7D");

                entity.HasOne(d => d.IdFacultadNavigation)
                    .WithMany(p => p.Estudiantes)
                    .HasForeignKey(d => d.IdFacultad)
                    .HasConstraintName("FK__Estudiant__IdFac__3F466844");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.Estudiantes)
                    .HasForeignKey(d => d.IdPersona)
                    .HasConstraintName("FK__Estudiant__IdPer__3D5E1FD2");

                entity.HasOne(d => d.IdPlanEstudioNavigation)
                    .WithMany(p => p.Estudiantes)
                    .HasForeignKey(d => d.IdPlanEstudio)
                    .HasConstraintName("FK__Estudiant__IdPla__4316F928");

                entity.HasOne(d => d.IdTipoSolicitudNavigation)
                    .WithMany(p => p.Estudiantes)
                    .HasForeignKey(d => d.IdTipoSolicitud)
                    .HasConstraintName("FK__Estudiant__IdTip__4222D4EF");
            });

            modelBuilder.Entity<Facultad>(entity =>
            {
                entity.HasKey(e => e.IdFacultad)
                    .HasName("PK__Facultad__443D4D5E2CB33C30");

                entity.ToTable("Facultad");

                entity.Property(e => e.NombreFacultad)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Identificacion>(entity =>
            {
                entity.HasKey(e => e.IdIdentificacion)
                    .HasName("PK__Identifi__D0E8A53DBD3BB1AB");

                entity.ToTable("Identificacion");

                entity.Property(e => e.NombreIdentificacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Nacionalidad>(entity =>
            {
                entity.HasKey(e => e.IdNacionalidad)
                    .HasName("PK__Nacional__021E36BEAC1FA7B2");

                entity.ToTable("Nacionalidad");

                entity.Property(e => e.NombreNacionalidad)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.IdPersona)
                    .HasName("PK__Persona__2EC8D2ACB131E30D");

                entity.ToTable("Persona");

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.PriApeEst)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PriNomEst)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SegApeEst)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SegNomEst)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdContactoNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.IdContacto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Persona__IdConta__37A5467C");

                entity.HasOne(d => d.IdIdentificacionNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.IdIdentificacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Persona__IdIdent__38996AB5");

                entity.HasOne(d => d.IdNacionalidadNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.IdNacionalidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Persona__IdNacio__36B12243");

                entity.HasOne(d => d.IdSexoNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.IdSexo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Persona__IdSexo__35BCFE0A");
            });

            modelBuilder.Entity<PlanEstudio>(entity =>
            {
                entity.HasKey(e => e.IdPlanEstudio)
                    .HasName("PK__PlanEstu__A5717D6ADF84C9D4");

                entity.ToTable("PlanEstudio");

                entity.Property(e => e.NombrePlanEstudio)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sexo>(entity =>
            {
                entity.HasKey(e => e.IdSexo)
                    .HasName("PK__Sexo__A7739FA297252026");

                entity.ToTable("Sexo");

                entity.Property(e => e.NombreSexo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoSolicitud>(entity =>
            {
                entity.HasKey(e => e.IdTipoSolicitud)
                    .HasName("PK__TipoSoli__D4202077E3BB8FEA");

                entity.ToTable("TipoSolicitud");

                entity.Property(e => e.NombreServicio)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
