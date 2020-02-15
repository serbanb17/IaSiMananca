using IaSiMananca.Business.Logic.Interfaces;
using IaSiMananca.Business.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace IaSiMananca.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantReviewController : ControllerBase
    {
        private IRestaurantReviewLogic _restaurantReviewLogic;

        public RestaurantReviewController(IRestaurantReviewLogic restaurantReviewLogic)
        {
            _restaurantReviewLogic = restaurantReviewLogic;
        }

        [HttpGet]
        public IActionResult GetReviews()
        {
            return Ok(_restaurantReviewLogic.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetReviewsByRestaurantId([FromRoute] Guid id)
        {
            return Ok(_restaurantReviewLogic.GetAllByRestaurantId(id));
        }

        [HttpGet("Entity/{id}")]
        public IActionResult GetReviews([FromRoute] Guid id)
        {
            return Ok(_restaurantReviewLogic.GetById(id));
        }

        [HttpGet("AverageRating/{id}")]
        public IActionResult GetAverageRatingByRestaurantId([FromRoute] Guid id)
        {
            return Ok(_restaurantReviewLogic.GetAverageRatingByRestaurantId(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody] RestaurantReviewCreateModel review)
        {
            _restaurantReviewLogic.Create(review);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromBody] RestaurantReviewUpdateModel review)
        {
            _restaurantReviewLogic.Update(review);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] Guid id)
        {
            _restaurantReviewLogic.Delete(id);
            return Ok();
        }
    }
}