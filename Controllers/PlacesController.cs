using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CulinaryGuide.API.Data;
using CulinaryGuide.API.Dtos;
using CulinaryGuide.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CulinaryGuide.API.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PlacesController: ControllerBase
    {
        private readonly ICulinaryGuideRepository _repo;
        private readonly IMapper _mapper;
        public PlacesController(ICulinaryGuideRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }
        [HttpGet]
        public Task<IEnumerable<Place>> GetPlaces(){
            
            var places =  _repo.GetPlaces();

            return places;
        }
        [HttpGet("gettagsforplace/{id}")]
        public Task<IEnumerable<Tag>> GetTagsForPlace([FromRoute] int id){
            var tags = _repo.GetTagsForPlace(id);

            return tags;
        }

        [HttpGet("getplacesfortag/{id}")]
        public Task<IEnumerable<Place>> GetPlacesForTag([FromRoute] int id){
            
            var places = _repo.GetPlacesForTag(id);

            return places;
        }

        [HttpPost("getplacesforname")]
        public Task<IEnumerable<Place>> GetPlacesForName(PlaceForSearchDto place){
            
            var places = _repo.GetPlacesByName(place.Name);

            return places;
        }
        [HttpGet("gettags")]
        public Task<IEnumerable<Tag>> GetTags(){
            var tags = _repo.GetTags();
            return tags;
        }

        
    }
}