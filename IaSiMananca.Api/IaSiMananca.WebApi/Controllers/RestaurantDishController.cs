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
    public class RestaurantDishController : ControllerBase
    {
        private IRestaurantDishLogic _restaurantDishLogic;

        public RestaurantDishController(IRestaurantDishLogic restaurantDishLogic)
        {
            _restaurantDishLogic = restaurantDishLogic;
        }

        [HttpGet]
        public IActionResult GetDishes()
        {
            return Ok(_restaurantDishLogic.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetDishes([FromRoute] Guid id)
        {
            return Ok(_restaurantDishLogic.GetById(id));
        }

        [HttpGet("/api/RestaurantDish/Filter/RestaurantID/{id}")]
        public IActionResult GetDishesByRestaurantId([FromRoute] Guid id)
        {
            return Ok(_restaurantDishLogic.GetByRestaurantId(id));
        }

        [HttpGet("/api/RestaurantDish/Filter/Category/{s}")]
        public IActionResult GetDishesByCategory([FromRoute] string s)
        {
            return Ok(_restaurantDishLogic.GetByCategory(s));
        }

        [HttpGet("/api/RestaurantDish/Filter/DishName/{s}")]
        public IActionResult GetDishesByName([FromRoute] string s)
        {
            return Ok(_restaurantDishLogic.GetDishByDishName(s));
        }

        [HttpPost]
        public IActionResult Create([FromBody] RestaurantDishCreateModel dish)
        {
            _restaurantDishLogic.Create(dish);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromBody] RestaurantDishUpdateModel dish)
        {
            _restaurantDishLogic.Update(dish);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] Guid id)
        {
            _restaurantDishLogic.Delete(id);
            return Ok();
        }
    }
}