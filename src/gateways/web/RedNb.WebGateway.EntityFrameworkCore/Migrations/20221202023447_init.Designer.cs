﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RedNb.WebGateway.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

#nullable disable

namespace RedNb.WebGateway.EntityFrameworkCore.Migrations
{
    [DbContext(typeof(WebGatewayDbContext))]
    [Migration("20221202023447_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("_Abp_DatabaseProvider", EfCoreDatabaseProvider.MySql)
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("RedNb.WebGateway.Domain.Clusters.Cluster", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasColumnOrder(0);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Cluster");
                });

            modelBuilder.Entity("RedNb.WebGateway.Domain.Clusters.Destination", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasColumnOrder(0);

                    b.Property<long?>("ClusterId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("ClusterId");

                    b.ToTable("Destination");
                });

            modelBuilder.Entity("RedNb.WebGateway.Domain.Clusters.MetaData", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasColumnOrder(0);

                    b.Property<long?>("ClusterId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("ClusterId");

                    b.ToTable("MetaData");
                });

            modelBuilder.Entity("RedNb.WebGateway.Domain.Routes.Match", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasColumnOrder(0);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<long?>("RouteId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RouteId");

                    b.ToTable("Match");
                });

            modelBuilder.Entity("RedNb.WebGateway.Domain.Routes.Route", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasColumnOrder(0);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Route");
                });

            modelBuilder.Entity("RedNb.WebGateway.Domain.Routes.Transform", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasColumnOrder(0);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<long?>("RouteId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RouteId");

                    b.ToTable("Transform");
                });

            modelBuilder.Entity("RedNb.WebGateway.Domain.Clusters.Destination", b =>
                {
                    b.HasOne("RedNb.WebGateway.Domain.Clusters.Cluster", "Cluster")
                        .WithMany()
                        .HasForeignKey("ClusterId");

                    b.Navigation("Cluster");
                });

            modelBuilder.Entity("RedNb.WebGateway.Domain.Clusters.MetaData", b =>
                {
                    b.HasOne("RedNb.WebGateway.Domain.Clusters.Cluster", "Cluster")
                        .WithMany()
                        .HasForeignKey("ClusterId");

                    b.Navigation("Cluster");
                });

            modelBuilder.Entity("RedNb.WebGateway.Domain.Routes.Match", b =>
                {
                    b.HasOne("RedNb.WebGateway.Domain.Routes.Route", "Route")
                        .WithMany()
                        .HasForeignKey("RouteId");

                    b.Navigation("Route");
                });

            modelBuilder.Entity("RedNb.WebGateway.Domain.Routes.Transform", b =>
                {
                    b.HasOne("RedNb.WebGateway.Domain.Routes.Route", "Route")
                        .WithMany()
                        .HasForeignKey("RouteId");

                    b.Navigation("Route");
                });
#pragma warning restore 612, 618
        }
    }
}
