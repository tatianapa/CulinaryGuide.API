using System.Collections.Generic;
using CulinaryGuide.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CulinaryGuide.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
             
        }

        public DbSet<User> Users{get; set;}

        public DbSet<Place> Places{get; set;}

        public DbSet<Tag> Tags{get; set;}

        public DbSet <TagPlace> TagPlaces {get; set;}
        private void AddPlaces()
        {
          

            // this.Places.Add(Menza);
            // this.Places.Add(Katzefet);
            // this.Places.Add(Rimon);
            
        
        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            builder.Entity<TagPlace>().HasKey(sc => new { sc.TagId, sc.PlaceId });

            builder.Entity<TagPlace>()
                .HasOne<Tag>(sc => sc.tag)
                .WithMany(s => s.tagPlaces)
                .HasForeignKey(sc => sc.TagId);


            builder.Entity<TagPlace>()
                .HasOne<Place>(sc => sc.place)
                .WithMany(s => s.tagPlaces)
                .HasForeignKey(sc => sc.PlaceId);
             var Menza = new Place
            {
              PlaceId = 1,
               
              Name = "Menza",

              PhotoLocation = null,
          
              Description = "Simple but elegant food. Great cocktail choice"

            };
             var Katzefet = new Place
            {
            
              PlaceId = 2,
               
              Name = "Katzefet",

              PhotoLocation = null,
          
              Description = "Vide choice of ice cream & frozen yoghurt"

            };
             var Rimon = new Place
            {

             PlaceId = 3,
               
              Name = "Rimon",

              PhotoLocation = null,
          
              Description = "Best friday morning bouffet in town!"

            };
            var NonKosher = new Tag { TagId = 1, text = "NonKosher", color = "#45ab78" };
            var Breakfast = new Tag { TagId = 2, text = "Breakfast", color = "#78ab78" };
            var Bar = new Tag { TagId = 3, text = "Bar", color = "#23cb78" };
            var Family = new Tag { TagId = 4, text = "Family", color = "#23ada8" };
            var SandwichCoffee = new Tag { TagId = 5, text = "Sandwich&Coffee", color = "#12aa56"};
            var Italian = new Tag {TagId = 6, text = "Italian", color = "#aa3418"};
            var IceCream = new Tag {TagId = 7, text = "Ice Cream", color = "#67ebe3"};
            var Dairy = new Tag {TagId = 8, text = "Dairy", color = "#565be3"};
            var Meat = new Tag { TagId = 9, text = "Meat", color = "#34aeae"};
            var BusinessLunch = new Tag { TagId = 10, text = "Business Lunch", color = "#34aeae"};
            
           
            builder.Entity<Tag>().HasData(
                NonKosher,
                Breakfast,
                Bar,
                Italian,
                Dairy,
                Family,
                SandwichCoffee,
                IceCream,
                Meat,
                BusinessLunch
            );
            builder.Entity<TagPlace>().HasData(
            new TagPlace {
            PlaceId = 3,
            TagId = 4
            },
            new TagPlace {
                PlaceId = 3,
            TagId = 8
            },
            new TagPlace {
                PlaceId = 3,
            TagId = 9
            },
            new TagPlace {
            PlaceId = 3,
            TagId = 10
            },
            new TagPlace {
            PlaceId = 2,
            TagId = 7
            },
            new TagPlace {
            PlaceId = 2,
            TagId = 4
            },
            new TagPlace {
            PlaceId = 2,
            TagId = 8
            },
            new TagPlace {
            PlaceId = 1,
            TagId = 1
            },
            new TagPlace {
            PlaceId = 1,
            TagId = 2
            },
            new TagPlace {
            PlaceId = 1,
            TagId = 3
            }

            );
            builder.Entity<Place>().HasData(
            Menza,
            Rimon,
            Katzefet
            );
            base.OnModelCreating( builder );
            

       }

    }
}