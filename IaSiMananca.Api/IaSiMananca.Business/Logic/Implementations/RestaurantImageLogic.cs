using IaSiMananca.Business.Logic.Interfaces;
using IaSiMananca.Business.Models;
using IaSiMananca.DataAccess.Entities;
using IaSiMananca.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace IaSiMananca.Business.Logic.Implementations
{
    public class RestaurantImageLogic : IRestaurantImageLogic
    {
        private IRepository<RestaurantImage> _restaurantImageRepository;

        public RestaurantImageLogic(IRepository<RestaurantImage> restaurantImageRepository)
        {
            _restaurantImageRepository = restaurantImageRepository;
        }

        public void Create(RestaurantImageModel entity)
        {
            RestaurantImage ri = new RestaurantImage
            {
                Id = entity.RestaurantId,
                Path = entity.Path
            };
            _restaurantImageRepository.Create(ri);
            _restaurantImageRepository.Save();
        }

        public void Delete(RestaurantImageModel entity)
        {
            RestaurantImage ri = new RestaurantImage
            {
                Id = entity.RestaurantId
            };
            _restaurantImageRepository.Delete(ri);
            _restaurantImageRepository.Save();
        }

        public IEnumerable<RestaurantImage> GetAll()
        {
            return _restaurantImageRepository.GetAll();
        }

        public RestaurantImage GetById(Guid id)
        {
            return _restaurantImageRepository.GetById(id);
        }

        public void Update(RestaurantImageModel entity)
        {
            RestaurantImage ri = new RestaurantImage
            {
                Id = entity.RestaurantId,
                Path = entity.Path
            };
            _restaurantImageRepository.Update(ri);
            _restaurantImageRepository.Save();
        }
    }
}
