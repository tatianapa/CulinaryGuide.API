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
    [Migration("20190304204905_AddingTagsPlaces")]
    partial class AddingTagsPlaces
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

                    b.HasData(
                        new { PlaceId = 1, Description = "Simple but elegant food. Great cocktail choice", Name = "Menza" },
                        new { PlaceId = 3, Description = "Best friday morning bouffet in town!", Name = "Rimon" },
                        new { PlaceId = 2, Description = "Vide choice of ice cream & frozen yoghurt", Name = "Katzefet" }
                    );
                });

            modelBuilder.Entity("CulinaryGuide.API.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("color");

                    b.Property<string>("text");

                    b.HasKey("TagId");

                    b.ToTable("Tags");

                    b.HasData(
                        new { TagId = 1, color = "#45ab78", text = "NonKosher" },
                        new { TagId = 2, color = "#78ab78", text = "Breakfast" },
                        new { TagId = 3, color = "#23cb78", text = "Bar" },
                        new { TagId = 6, color = "#aa3418", text = "Italian" },
                        new { TagId = 8, color = "#565be3", text = "Dairy" },
                        new { TagId = 4, color = "#23ada8", text = "Family" },
                        new { TagId = 5, color = "#12aa56", text = "Sandwich&Coffee" },
                        new { TagId = 7, color = "#67ebe3", text = "Ice Cream" },
                        new { TagId = 9, color = "#34aeae", text = "Meat" },
                        new { TagId = 10, color = "#34aeae", text = "Business Lunch" }
                    );
                });

            modelBuilder.Entity("CulinaryGuide.API.Models.TagPlace", b =>
                {
                    b.Property<int>("TagId");

                    b.Property<int>("PlaceId");

                    b.HasKey("TagId", "PlaceId");

                    b.HasIndex("PlaceId");

                    b.ToTable("TagPlaces");

                    b.HasData(
                        new { TagId = 4, PlaceId = 3 },
                        new { TagId = 8, PlaceId = 3 },
                        new { TagId = 9, PlaceId = 3 },
                        new { TagId = 10, PlaceId = 3 },
                        new { TagId = 7, PlaceId = 2 },
                        new { TagId = 4, PlaceId = 2 },
                        new { TagId = 8, PlaceId = 2 },
                        new { TagId = 1, PlaceId = 1 },
                        new { TagId = 2, PlaceId = 1 },
                        new { TagId = 3, PlaceId = 1 }
                    );
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