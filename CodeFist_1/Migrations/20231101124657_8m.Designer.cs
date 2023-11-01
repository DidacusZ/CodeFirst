﻿// <auto-generated />
using System;
using CodeFist_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CodeFist_1.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20231101124657_8m")]
    partial class _8m
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("CodeFist_1.Models.Accesos", b =>
                {
                    b.Property<int>("id_acceso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("id_acceso"));

                    b.Property<string>("codigo_acceso")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("descripcion_acceso")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id_acceso");

                    b.ToTable("Accesos");
                });

            modelBuilder.Entity("CodeFist_1.Models.Autores", b =>
                {
                    b.Property<int>("id_autor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("id_autor"));

                    b.Property<string>("apellidos_autor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("nombre_autor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id_autor");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("CodeFist_1.Models.Colecciones", b =>
                {
                    b.Property<int>("id_coleccion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("id_coleccion"));

                    b.Property<string>("nombre_coleccion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id_coleccion");

                    b.ToTable("Colecciones");
                });

            modelBuilder.Entity("CodeFist_1.Models.Editoriales", b =>
                {
                    b.Property<int>("id_editorial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("id_editorial"));

                    b.Property<string>("nombre_editorial")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id_editorial");

                    b.ToTable("Editoriales");
                });

            modelBuilder.Entity("CodeFist_1.Models.Estados_Prestamos", b =>
                {
                    b.Property<int>("id_estado_prestamo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("id_estado_prestamo"));

                    b.Property<string>("codigo_estado_prestamo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("descripcion_estado_prestamo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id_estado_prestamo");

                    b.ToTable("Estados_Prestamos");
                });

            modelBuilder.Entity("CodeFist_1.Models.Generos", b =>
                {
                    b.Property<int>("id_genero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("id_genero"));

                    b.Property<string>("descripcion_genero")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("nombre_genero")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id_genero");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("CodeFist_1.Models.Libros", b =>
                {
                    b.Property<int>("id_libro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("id_libro"));

                    b.Property<string>("edicion_libro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("id_coleccion")
                        .HasColumnType("integer");

                    b.Property<int>("id_editorial")
                        .HasColumnType("integer");

                    b.Property<int>("id_genero")
                        .HasColumnType("integer");

                    b.Property<string>("isbn_libro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("titulo_libro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id_libro");

                    b.HasIndex("id_coleccion");

                    b.HasIndex("id_editorial");

                    b.HasIndex("id_genero");

                    b.ToTable("Libros");
                });

            modelBuilder.Entity("CodeFist_1.Models.Prestamos", b =>
                {
                    b.Property<int>("id_prestamo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    b.Property<DateTime>("fch_entrega_prestamo")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("fch_fin_prestamo")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("fch_inicio_prestamo")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("id_estado_prestamo")
                        .HasColumnType("integer");

                    b.Property<int>("id_libro")
                        .HasColumnType("integer");

                    b.Property<int>("id_usuario")
                        .HasColumnType("integer");

                    b.HasKey("id_prestamo");

                    b.HasIndex("id_libro");

                    b.HasIndex("id_usuario");

                    b.ToTable("Prestamos");
                });

            modelBuilder.Entity("CodeFist_1.Models.Rel_Autores_Libros", b =>
                {
                    b.Property<int>("id_rel_autores_libros")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("id_rel_autores_libros"));

                    b.Property<int>("id_autor")
                        .HasColumnType("integer");

                    b.Property<int>("id_libro")
                        .HasColumnType("integer");

                    b.HasKey("id_rel_autores_libros");

                    b.HasIndex("id_autor");

                    b.HasIndex("id_libro");

                    b.ToTable("Rel_Autores_Libros");
                });

            modelBuilder.Entity("CodeFist_1.Models.Usuarios", b =>
                {
                    b.Property<int>("id_usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("id_usuario"));

                    b.Property<string>("apellidos_usuario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("clave_usuario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("dni_usuario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("email_usuario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("estaBloqueado_usuario")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("fch_alta_usuario")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("fch_baja_usuario")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("fch_fin_bloqueo_usuario")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("id_acceso")
                        .HasColumnType("integer");

                    b.Property<string>("nombre_usuario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("tlf_usuario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id_usuario");

                    b.HasIndex("id_acceso");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("CodeFist_1.Models.Libros", b =>
                {
                    b.HasOne("CodeFist_1.Models.Colecciones", "Coleccion")
                        .WithMany("Libros_coleccion")
                        .HasForeignKey("id_coleccion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFist_1.Models.Editoriales", "Editorial")
                        .WithMany("Libros_editorial")
                        .HasForeignKey("id_editorial")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFist_1.Models.Generos", "Genero")
                        .WithMany("Libros_genero")
                        .HasForeignKey("id_genero")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coleccion");

                    b.Navigation("Editorial");

                    b.Navigation("Genero");
                });

            modelBuilder.Entity("CodeFist_1.Models.Prestamos", b =>
                {
                    b.HasOne("CodeFist_1.Models.Libros", "Libro")
                        .WithMany("Prestamos_libro")
                        .HasForeignKey("id_libro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFist_1.Models.Estados_Prestamos", "Estado_Prestamo")
                        .WithMany("Prestamos_estado")
                        .HasForeignKey("id_prestamo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFist_1.Models.Usuarios", "Usuario")
                        .WithMany("Prestamos_usuario")
                        .HasForeignKey("id_usuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado_Prestamo");

                    b.Navigation("Libro");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("CodeFist_1.Models.Rel_Autores_Libros", b =>
                {
                    b.HasOne("CodeFist_1.Models.Autores", "Autor")
                        .WithMany("Rel_Autores")
                        .HasForeignKey("id_autor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFist_1.Models.Libros", "Libro")
                        .WithMany("Rel_Libros")
                        .HasForeignKey("id_libro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");

                    b.Navigation("Libro");
                });

            modelBuilder.Entity("CodeFist_1.Models.Usuarios", b =>
                {
                    b.HasOne("CodeFist_1.Models.Accesos", "Acceso")
                        .WithMany("Usuarios_acceso")
                        .HasForeignKey("id_acceso")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Acceso");
                });

            modelBuilder.Entity("CodeFist_1.Models.Accesos", b =>
                {
                    b.Navigation("Usuarios_acceso");
                });

            modelBuilder.Entity("CodeFist_1.Models.Autores", b =>
                {
                    b.Navigation("Rel_Autores");
                });

            modelBuilder.Entity("CodeFist_1.Models.Colecciones", b =>
                {
                    b.Navigation("Libros_coleccion");
                });

            modelBuilder.Entity("CodeFist_1.Models.Editoriales", b =>
                {
                    b.Navigation("Libros_editorial");
                });

            modelBuilder.Entity("CodeFist_1.Models.Estados_Prestamos", b =>
                {
                    b.Navigation("Prestamos_estado");
                });

            modelBuilder.Entity("CodeFist_1.Models.Generos", b =>
                {
                    b.Navigation("Libros_genero");
                });

            modelBuilder.Entity("CodeFist_1.Models.Libros", b =>
                {
                    b.Navigation("Prestamos_libro");

                    b.Navigation("Rel_Libros");
                });

            modelBuilder.Entity("CodeFist_1.Models.Usuarios", b =>
                {
                    b.Navigation("Prestamos_usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
