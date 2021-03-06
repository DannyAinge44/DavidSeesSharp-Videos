﻿// <auto-generated />
using System;
using BlazorServerEFCore5;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorServerEFCore5.Migrations
{
    [DbContext(typeof(VisitContext))]
    partial class VisitContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BlazorServerEFCore5.PageVisit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TimeOfVisit")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("PageVisits");
                });
#pragma warning restore 612, 618
        }
    }
}
