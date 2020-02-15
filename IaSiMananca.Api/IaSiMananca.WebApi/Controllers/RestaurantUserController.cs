using IaSiMananca.Business.Logic.Interfaces;
using IaSiMananca.Business.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace IaSiMananca.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantUserController : ControllerBase
    {
        private IRestaurantUserLogic _restaurantUserLogic;

        public RestaurantUserController(IRestaurantUserLogic restaurantUserLogic)
        {
            _restaurantUserLogic = restaurantUserLogic;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_restaurantUserLogic.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetUsers([FromRoute] Guid id)
        {
            return Ok(_restaurantUserLogic.GetById(id));
        }

        [HttpGet("/api/RestaurantUser/Filter/EmailAndPassword")]
        public IActionResult GetUserCredentials([FromQuery] string s,[FromQuery] string p)
        {
            return Ok(_restaurantUserLogic.GetByEmailAndPassword(s,p));
        }

        [HttpPost]
        public IActionResult Create([FromBody] RestaurantUserCreateModel User)
        {
            _restaurantUserLogic.Create(User);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromBody] RestaurantUserUpdateModel User)
        {
            _restaurantUserLogic.Update(User);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] Guid id)
        {
            _restaurantUserLogic.Delete(id);
            return Ok();
        }
    }
}