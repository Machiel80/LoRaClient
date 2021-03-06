using System;
using Betabit.Lora.Nuget.Example.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;


namespace Betabit.Lora.Nuget.Example.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20160325072915_ExtendedDeviceWithLoRaProperties")]
    partial class ExtendedDeviceWithLoRaProperties
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Betabit.Lora.Nuget.Example.Models.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DeviceAddress");

                    b.Property<string>("Name");

                    b.Property<string>("NetworkAddress");

                    b.Property<string>("NetworkKey");

                    b.Property<int?>("RoomId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Betabit.Lora.Nuget.Example.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Betabit.Lora.Nuget.Example.Models.Device", b =>
                {
                    b.HasOne("Betabit.Lora.Nuget.Example.Models.Room")
                        .WithMany()
                        .HasForeignKey("RoomId");
                });
        }
    }
}
