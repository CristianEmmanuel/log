﻿using Login.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Login.Migrations.SqliteMigrations
{

    [DbContext(typeof(SqliteDataContext))]
    partial class SqliteDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("WebApi.Entities.User", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("FirstName")
                    .HasColumnType("TEXT");

                b.Property<string>("LastName")
                    .HasColumnType("TEXT");

                b.Property<byte[]>("PasswordHash")
                    .HasColumnType("BLOB");

                b.Property<byte[]>("PasswordSalt")
                    .HasColumnType("BLOB");

                b.Property<string>("Username")
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.ToTable("Users");
            });
#pragma warning restore 612, 618
        }
    }
}
