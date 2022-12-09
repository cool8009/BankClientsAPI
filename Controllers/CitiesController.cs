using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BankClientApi.Data;
using AutoMapper;
using BankClientApi.Models.City;

namespace BankClientApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly BankClientsDbContext _context;
        private readonly IMapper _mapper;

        public CitiesController(BankClientsDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Cities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetCityDto>>> GetCities()
        {
            var cities = await _context.Cities.ToListAsync();
            var records = _mapper.Map<List<GetCityDto>>(cities);
            return Ok(records);
        }

        // GET: api/Cities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetCityDto>> GetCity(int id)
        {
            var city = await _context.Cities.FindAsync(id);
            var records = _mapper.Map<GetCityDto>(city);  
            if (city == null)
            {
                return NotFound();
            }

            return Ok(records);
        }

        private bool CityExists(int id)
        {
            return _context.Cities.Any(e => e.Id == id);
        }
    }
}
