using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IaSiMananca.Business.Logic.Implementations;
using IaSiMananca.Business.Logic.Interfaces;
using IaSiMananca.Business.Models;
using IaSiMananca.DataAccess.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IaSiMananca.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantImageController : ControllerBase
    {
        private RestaurantImageLogic _restaurantImageLogic;

        public RestaurantImageController(RestaurantImageLogic restaurantImageLogic)
        {
            _restaurantImageLogic = restaurantImageLogic;
        }

        [HttpGet]
        public IActionResult GetReviews()
        {
            return Ok(_restaurantImageLogic.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetReviews([FromRoute] Guid id)
        {
            return Ok(_restaurantImageLogic.GetById(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody] RestaurantImageModel restaurant)
        {
            _restaurantImageLogic.Create(restaurant);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromBody] RestaurantImageModel restaurant)
        {
            _restaurantImageLogic.Update(restaurant);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] RestaurantImageModel restaurant)
        {
            _restaurantImageLogic.Delete(restaurant);
            return Ok();
        }
    }
}