using IaSiMananca.Business.Logic.Interfaces;
using IaSiMananca.Business.Models;
using IaSiMananca.DataAccess.Entities;
using IaSiMananca.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace IaSiMananca.Business.Logic.Implementations
{
    public class RestaurantReviewLogic : IRestaurantReviewLogic
    {
        private IRepository<RestaurantReview> _restaurantReviewRepository;

        public RestaurantReviewLogic(IRepository<RestaurantReview> restaurantReviewRepository)
        {
            _restaurantReviewRepository = restaurantReviewRepository;
        }

        public IEnumerable<RestaurantReview> GetAll()
        {
            return _restaurantReviewRepository.GetAll();
        }

        public IEnumerable<RestaurantReview> GetAllByRestaurantId(Guid id)
        {
            return _restaurantReviewRepository.Filter(rr => rr.RestaurantId == id);
        }

        public RestaurantReview GetById(Guid id)
        {
            return _restaurantReviewRepository.GetById(id);
        }

        public Double GetAverageRatingByRestaurantId(Guid id)
        {
            return GetAllByRestaurantId(id).Average(rr => rr.Rating);
        }

        public void Create(RestaurantReviewCreateModel entity)
        {
            RestaurantReview restaurantReview = new RestaurantReview
            {
                Id = new Guid(),
                NameUser = entity.NameUser,
                CommentDate = entity.CommentDate,
                Order = entity.Order,
                Comment = entity.Comment,
                Rating = entity.Rating,
                RestaurantId = entity.RestaurantId
            };
            _restaurantReviewRepository.Create(restaurantReview);
            _restaurantReviewRepository.Save();
        }

        public void Update(RestaurantReviewUpdateModel entity)
        {
            RestaurantReview restaurantReview = new RestaurantReview
            {
                Id = entity.Id,
                NameUser = entity.NameUser,
                CommentDate = entity.CommentDate,
                Order = entity.Order,
                Comment = entity.Comment,
                Rating = entity.Rating,
                RestaurantId = entity.RestaurantId
            };
            _restaurantReviewRepository.Update(restaurantReview);
            _restaurantReviewRepository.Save();
        }

        public void Delete(Guid id)
        {
            RestaurantReview review = new RestaurantReview
            {
                Id = id
            };
            _restaurantReviewRepository.Delete(review);
            _restaurantReviewRepository.Save();
        }
    }
}
