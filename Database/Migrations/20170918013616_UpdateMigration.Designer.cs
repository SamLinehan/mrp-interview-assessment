using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Database;

namespace Database.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20170918013616_UpdateMigration")]
    partial class UpdateMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Database.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("First");

                    b.Property<string>("Last");

                    b.Property<string>("PictureUrl");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
        }
    }
}
