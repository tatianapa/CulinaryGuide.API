using System.Threading.Tasks;
using AutoMapper;
using CulinaryGuide.API.Data;
using CulinaryGuide.API.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CulinaryGuide.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController: ControllerBase
    {
        private readonly ICulinaryGuideRepository _repo;
        private readonly IMapper _mapper;
        public UsersController(ICulinaryGuideRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;

        }
         [HttpGet("{id}", Name="GetUser")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _repo.GetUser(id);

            var userToReturn  = _mapper.Map<UserForList>(user);

            return Ok(userToReturn);
        }
        

    }
}