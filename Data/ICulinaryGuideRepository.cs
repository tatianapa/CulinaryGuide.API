using System.Collections.Generic;
using System.Threading.Tasks;
using CulinaryGuide.API.Models;

namespace CulinaryGuide.API.Data
{
    public interface ICulinaryGuideRepository
    {
          void Add<T>(T entity) where T:class;

         void Delete<T>(T entity) where T: class;

         Task<bool> SaveAllAsync();

        //  Task<User> GetUsers(UserParams userParams);

         Task<User> GetUser(int id);

         Task<IEnumerable<Place>> GetPlaces();

         Task<IEnumerable<Place>> GetPlacesForTag(int id);

         Task<IEnumerable<Tag>> GetTagsForPlace(int id);

         Task<IEnumerable<Tag>> GetTags();

         Task<IEnumerable<Place>> GetPlacesByName(string name);
    }
}