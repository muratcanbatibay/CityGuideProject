using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SehirRehberi.Data;
using SehirRehberi.DTOs;
using SehirRehberi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRehberi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        IAppRepository _appRepostitory;
        IMapper _mapper;
        public CitiesController(IAppRepository appRepository, IMapper mapper)
        {
            _appRepostitory = appRepository;
            _mapper = mapper;
        }
        [HttpGet("getcities")]
        public IActionResult GetCities()
        {
            var cities = _appRepostitory.GetCities();
            var citiesToReturn = _mapper.Map<List<CityForListDto>>(cities);
            return Ok(citiesToReturn);
        }
        [HttpPost("cityadd")]
        public IActionResult AddCity([FromBody] City city)
        {
            _appRepostitory.Add(city);
            _appRepostitory.SaveAll();
            return Ok(city);

        }
        [HttpGet("getcity")]
        public IActionResult GetCityById(int id)
        {
            var city= _appRepostitory.GetCityById(id);
            var cityToReturn = _mapper.Map<CityForDetailDto>(city);
            return Ok(cityToReturn);
        }
        [HttpGet("photos")]
        public IActionResult GetPhotosByCityId(int id)
        {
            var photos = _appRepostitory.GetPhotosByCity(id);
            return Ok(photos);
        }
    }
}
