using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CulinaryGuide.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CulinaryGuide.API.Data
{
    public class CulinaryGuideRepository : ICulinaryGuideRepository
    {
        private readonly DataContext _context;
        public CulinaryGuideRepository(DataContext context)
        {
            _context = context;

        }
        public void Add<T>(T entity) where T : class
        {
             _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<IEnumerable<Place>> GetPlaces()
        {
        //    return  await _context.Places.Include(t => t.tagPlaces).ThenInclude(t=>t.tag).ToListAsync();

        // var joinPlacesWithTP = from p in _context.Places join t in _context.TagPlaces
        //              on p.PlaceId equals t.PlaceId
        //              select new { Name = p.Name, Description = p.Description, PhotoLocation = p.PhotoLocation, TagId = t.TagId};

        // var result = from j in joinPlacesWithTP join t in _context.Tags
        //              on j.TagId equals t.TagId
        //              select new {Name = j.Name, Description = j.Description, PhotoLocation = j.PhotoLocation, Text = t.text, color = t.color };
        
        var result = await _context.Places.ToListAsync();
        return result;
        }

        public async Task<IEnumerable<Place>> GetPlacesForTag(int id)
        {
           var placeTags = _context.TagPlaces.Where(x => x.TagId == id).ToList();

           var places = await _context.Places.Where(p => p.tagPlaces.Intersect(placeTags).Any()).ToListAsync();

           return places;

        }

     public async Task<IEnumerable<Place>> GetPlacesByName(string name)
        {
            var places = await _context.Places.Where(p => p.Name.StartsWith(name)).ToListAsync();

            return places;
        }

        public  async Task<IEnumerable<Tag>> GetTags()
        {
            var tags =  await _context.Tags.ToListAsync();

            return tags;
        }

        public async  Task<IEnumerable<Tag>> GetTagsForPlace(int id)
        {
            var placeTags = _context.TagPlaces.Where(x => x.PlaceId == id).ToList();
            
            var tags = await _context.Tags.Where(p => p.tagPlaces.Intersect(placeTags).Any()).ToListAsync();

            return tags;
                      
        }

        public async Task<User> GetUser(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.id == id);

            return user;
        }

        // public Task<User> GetUsers(UserParams userParams)
        // {
        //     throw new System.NotImplementedException();
        // }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public Task<bool> SaveAllAsync()
        {
            throw new System.NotImplementedException();
        }
   

    }
}