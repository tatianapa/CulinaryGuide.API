﻿// <auto-generated />
using System;
using CulinaryGuide.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CulinaryGuide.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190224193809_AddedTagPlaceRelationship")]
    partial class AddedTagPlaceRelationship
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CulinaryGuide.API.Models.Place", b =>
                {
                    b.Property<int>("PlaceId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("PhotoLocation");

                    b.HasKey("PlaceId");

                    b.ToTable("Places");
                });

            modelBuilder.Entity("CulinaryGuide.API.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("color");

                    b.Property<string>("text");

                    b.HasKey("TagId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("CulinaryGuide.API.Models.TagPlace", b =>
                {
                    b.Property<int>("TagId");

                    b.Property<int>("PlaceId");

                    b.HasKey("TagId", "PlaceId");

                    b.HasIndex("PlaceId");

                    b.ToTable("TagPlace");
                });

            modelBuilder.Entity("CulinaryGuide.API.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Gender");

                    b.Property<string>("KnownAs");

                    b.Property<DateTime>("LastActive");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("Username");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CulinaryGuide.API.Models.TagPlace", b =>
                {
                    b.HasOne("CulinaryGuide.API.Models.Place", "place")
                        .WithMany("tagPlaces")
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CulinaryGuide.API.Models.Tag", "tag")
                        .WithMany("tagPlaces")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
