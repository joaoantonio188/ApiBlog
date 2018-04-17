﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TodoApi.Models;

namespace TodoApi.Migrations
{
    [DbContext(typeof(TodoContext))]
    [Migration("20180415234110_add Iditem")]
    partial class addIditem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TodoApi.Models.Blog", b =>
                {
                    b.Property<long>("Iditem")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ComentarioNota");

                    b.Property<string>("DataCriação");

                    b.Property<string>("DataTexto");

                    b.Property<string>("DonoBlog");

                    b.Property<string>("Email");

                    b.Property<bool>("IsComplete");

                    b.Property<string>("Name");

                    b.Property<float>("Nota");

                    b.Property<string>("Texto");

                    b.Property<string>("TituloBlog");

                    b.Property<string>("User");

                    b.HasKey("Iditem");

                    b.ToTable("TodoItems");
                });
#pragma warning restore 612, 618
        }
    }
}
