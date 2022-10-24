﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _24AMPag.Context;

namespace Rutcun.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Rutcun.Models.Calle", b =>
                {
                    b.Property<int>("PkCalle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PkCalle");

                    b.ToTable("Calle");
                });

            modelBuilder.Entity("Rutcun.Models.CalleTransitada", b =>
                {
                    b.Property<int>("FkCalle")
                        .HasColumnType("int");

                    b.Property<int>("FkTrasporte")
                        .HasColumnType("int");

                    b.HasKey("FkCalle", "FkTrasporte");

                    b.HasIndex("FkTrasporte");

                    b.ToTable("CalleTransitada");
                });

            modelBuilder.Entity("Rutcun.Models.PuntoInteres", b =>
                {
                    b.Property<int>("PkPunto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Coordenadas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PkPunto");

                    b.ToTable("PuntoInteres");
                });

            modelBuilder.Entity("Rutcun.Models.PuntoTransitado", b =>
                {
                    b.Property<int>("FkPunto")
                        .HasColumnType("int");

                    b.Property<int>("FkTrasporte")
                        .HasColumnType("int");

                    b.HasKey("FkPunto", "FkTrasporte");

                    b.HasIndex("FkTrasporte");

                    b.ToTable("PuntoTransitado");
                });

            modelBuilder.Entity("Rutcun.Models.TipoTrasporte", b =>
                {
                    b.Property<int>("PkTipo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PkTipo");

                    b.ToTable("TipoTrasporte");
                });

            modelBuilder.Entity("Rutcun.Models.Trasporte", b =>
                {
                    b.Property<int>("PkTrasporte")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Dia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estatus")
                        .HasColumnType("bit");

                    b.Property<int?>("FkTipo")
                        .HasColumnType("int");

                    b.Property<string>("HoraFinal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoraInicial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PkTrasporte");

                    b.HasIndex("FkTipo");

                    b.ToTable("Trasporte");
                });

            modelBuilder.Entity("Rutcun.Models.CalleTransitada", b =>
                {
                    b.HasOne("Rutcun.Models.Calle", "Calle")
                        .WithMany()
                        .HasForeignKey("FkCalle")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rutcun.Models.Trasporte", "Trasporte")
                        .WithMany()
                        .HasForeignKey("FkTrasporte")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Calle");

                    b.Navigation("Trasporte");
                });

            modelBuilder.Entity("Rutcun.Models.PuntoTransitado", b =>
                {
                    b.HasOne("Rutcun.Models.PuntoInteres", "Punto")
                        .WithMany()
                        .HasForeignKey("FkPunto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rutcun.Models.Trasporte", "Trasporte")
                        .WithMany()
                        .HasForeignKey("FkTrasporte")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Punto");

                    b.Navigation("Trasporte");
                });

            modelBuilder.Entity("Rutcun.Models.Trasporte", b =>
                {
                    b.HasOne("Rutcun.Models.TipoTrasporte", "Tipo")
                        .WithMany()
                        .HasForeignKey("FkTipo");

                    b.Navigation("Tipo");
                });
#pragma warning restore 612, 618
        }
    }
}