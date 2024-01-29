using DatabaseFirstDotnetCore.ConsoleApp.Modelo;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirstDotnetCore.ConsoleApp.CamadaAcessoDados;

public partial class ConferenciaCientificaContext : DbContext
{
    public ConferenciaCientificaContext()
    {
    }

    public ConferenciaCientificaContext(DbContextOptions<ConferenciaCientificaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Artigo> Artigos { get; set; }

    public virtual DbSet<Palestra> Palestras { get; set; }

    public virtual DbSet<Pessoa> Pessoas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=ConferenciaCientifica;integrated security=True;trustservercertificate=True");
        



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Artigo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07C9D35171");

            entity.Property(e => e.Abstract)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Titulo)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Autor).WithMany(p => p.ArtigoAutors)
                .HasForeignKey(d => d.AutorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Artigos__AutorId__4BAC3F29");

            entity.HasOne(d => d.Palestrante).WithMany(p => p.ArtigoPalestrantes)
                .HasForeignKey(d => d.PalestranteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Artigos__Palestr__4CA06362");
        });

        modelBuilder.Entity<Palestra>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07CBD06D94");

            entity.Property(e => e.DataEhora)
                .HasColumnType("datetime")
                .HasColumnName("DataEHora");

            entity.HasOne(d => d.Artigo).WithMany(p => p.Palestras)
                .HasForeignKey(d => d.ArtigoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Palestras__Artig__48CFD27E");

            entity.HasOne(d => d.Autor).WithMany(p => p.Palestras)
                .HasForeignKey(d => d.AutorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Palestras__Autor__4D94879B");
        });

        modelBuilder.Entity<Pessoa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07C155DE04");

            entity.Property(e => e.Especialidade)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Filiacao)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Participacao)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefone)
                .HasMaxLength(14)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
