﻿// <auto-generated />
using System;
using Aliquota.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Aliquota.Domain.Migrations
{
    [DbContext(typeof(OperationDB))]
    partial class OperationDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("Aliquota.Domain.Model.Operation", b =>
                {
                    b.Property<Guid>("iD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<float>("amount")
                        .HasColumnType("REAL");

                    b.Property<string>("clientCPF")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("operationType")
                        .HasColumnType("INTEGER");

                    b.Property<float>("profitPerMonth")
                        .HasColumnType("REAL");

                    b.Property<bool>("withdrawn")
                        .HasColumnType("INTEGER");

                    b.HasKey("iD");

                    b.ToTable("NewOperations");
                });
#pragma warning restore 612, 618
        }
    }
}