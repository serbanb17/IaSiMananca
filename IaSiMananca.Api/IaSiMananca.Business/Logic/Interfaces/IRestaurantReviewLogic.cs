using IaSiMananca.Business.Models;
using IaSiMananca.DataAccess.Entities;
using System;
using System.Collections.Generic;

namespace IaSiMananca.Business.Logic.Interfaces
{
    public interface IRestaurantReviewLogic
    {
        IEnumerable<RestaurantReview> GetAll();

        IEnumerable<RestaurantReview> GetAllByRestaurantId(Guid id);

        RestaurantReview GetById(Guid id);

        Double GetAverageRatingByRestaurantId(Guid id);

        void Create(RestaurantReviewCreateModel entity);

        void Update(RestaurantReviewUpdateModel entity);

        void Delete(Guid id);
    }
}
