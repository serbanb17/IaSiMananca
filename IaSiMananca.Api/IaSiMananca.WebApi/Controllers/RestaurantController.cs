using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IaSiMananca.Business.Logic.Interfaces;
using IaSiMananca.Business.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IaSiMananca.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase

    {
        private IRestaurantLogic _restaurantLogic;

        public RestaurantController(IRestaurantLogic restaurantLogic)
        {
            _restaurantLogic = restaurantLogic;
        }

        [HttpGet]
        public IActionResult GetReviews()
        {
            return Ok(_restaurantLogic.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetReviews([FromRoute] Guid id)
        {
            return Ok(_restaurantLogic.GetById(id));
        }

        [HttpGet("/api/Restaurant/Filter/Name/{id}")]
        public IActionResult GetDishesByRestaurantId([FromRoute] string s)
        {
            return Ok(_restaurantLogic.GetByName(s));
        }

        [HttpGet("/api/Restaurant/Filter/Type/{s}")]
        public IActionResult GetDishesByType([FromRoute] string s)
        {
            return Ok(_restaurantLogic.GetByType(s));
        }

        [HttpGet("/api/Restaurant/Filter/DishName/{s}")]
        public IActionResult GetRestaurantsByDishName([FromRoute] string s)
        {
            return Ok(_restaurantLogic.GetRestaurantByDishName(s));
        }

        [HttpPost]
        public IActionResult Create([FromBody] RestaurantCreateModel restaurant)
        {
            _restaurantLogic.Create(restaurant);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, [FromBody] RestaurantUpdateModel restaurant)
        {
            _restaurantLogic.Update(id, restaurant);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _restaurantLogic.Delete(id);
            return Ok();
        }

    }
}