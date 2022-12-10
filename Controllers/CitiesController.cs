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
using BankClientApi.Contracts;

namespace BankClientApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ICitiesRepository _citiesRepository;
        private readonly IMapper _mapper;

        public CitiesController(ICitiesRepository citiesRepository, IMapper mapper)
        {
            this._citiesRepository = citiesRepository;
            _mapper = mapper;
        }

        // GET: api/Cities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetCityDto>>> GetCities()
        {
            var cities = await _citiesRepository.GetAllCitiesAsync();
            var records = _mapper.Map<List<GetCityDto>>(cities);
            return Ok(records);
        }

        // GET: api/Cities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetCityDto>> GetCity(int id)
        {
            var city = await _citiesRepository.GetAsync(id);
            var records = _mapper.Map<GetCityDto>(city);  
            if (city == null)
            {
                return NotFound();
            }

            return Ok(records);
        }

        private async Task<bool> CityExists(int id)
        {
            return await _citiesRepository.Exists(id);
        }
    }
}
