﻿// <auto-generated />
using System;
using CodeFirst.PostagensBlog.AcessoDados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeFirst.PostagensBlog.Migrations
{
    [DbContext(typeof(PostagemContext))]
    partial class PostagemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CodeFirst.PostagensBlog.Modelo.Comentario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid>("ComentaristaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataEHora")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PostagemId")
                        .HasColumnType("int");

                    b.Property<string>("Texto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ComentaristaId");

                    b.HasIndex("PostagemId");

                    b.ToTable("Comentarios");
                });

            modelBuilder.Entity("CodeFirst.PostagensBlog.Modelo.Comentarista", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("EmailComentarista")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Nome")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.ToTable("Comentaristas");
                });

            modelBuilder.Entity("CodeFirst.PostagensBlog.Modelo.Postagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Conteudo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Postagens");
                });

            modelBuilder.Entity("CodeFirst.PostagensBlog.Modelo.Comentario", b =>
                {
                    b.HasOne("CodeFirst.PostagensBlog.Modelo.Comentarista", "Comentarista")
                        .WithMany()
                        .HasForeignKey("ComentaristaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirst.PostagensBlog.Modelo.Postagem", null)
                        .WithMany("Comentarios")
                        .HasForeignKey("PostagemId");

                    b.Navigation("Comentarista");
                });

            modelBuilder.Entity("CodeFirst.PostagensBlog.Modelo.Postagem", b =>
                {
                    b.Navigation("Comentarios");
                });
#pragma warning restore 612, 618
        }
    }
}
