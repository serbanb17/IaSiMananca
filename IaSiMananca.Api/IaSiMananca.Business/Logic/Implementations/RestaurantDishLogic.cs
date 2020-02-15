using IaSiMananca.Business.Logic.Interfaces;
using IaSiMananca.Business.Models;
using IaSiMananca.DataAccess.Entities;
using IaSiMananca.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace IaSiMananca.Business.Logic.Implementations
{
    public class RestaurantDishLogic : IRestaurantDishLogic
    {
        private IRepository<RestaurantDish> _restaurantDishRepository;

        public RestaurantDishLogic(IRepository<RestaurantDish> restaurantDishRepository)
        {
            _restaurantDishRepository = restaurantDishRepository;
        }

        public IEnumerable<RestaurantDish> GetAll()
        {
            return _restaurantDishRepository.GetAll();
        }

        public IEnumerable<RestaurantDish> GetByRestaurantId(Guid restaurantId)
        {
            return _restaurantDishRepository.Filter(rd => rd.RestaurantId == restaurantId);
        }

        public IEnumerable<RestaurantDish> GetDishByDishName(string name)
        {
            return _restaurantDishRepository.Filter(rd => rd.DishName.Contains(name));
        }

        public IEnumerable<RestaurantDish> GetByCategory(string category)
        {
            return _restaurantDishRepository.Filter(rd => rd.Category == category);
        }

        public RestaurantDish GetById(Guid id)
        {
            return _restaurantDishRepository.GetById(id);
        }

        public void Create(RestaurantDishCreateModel entity)
        {
            RestaurantDish restaurantDish = new RestaurantDish
            {
                Id = new Guid(),
                DishName = entity.DishName,
                Category = entity.Category,
                Ingredients = entity.Ingredients,
                Price = entity.Price,
                Weight = entity.Weight,
                RestaurantId = entity.RestaurantId
            };
            _restaurantDishRepository.Create(restaurantDish);
            _restaurantDishRepository.Save();
        }

        public void Update(RestaurantDishUpdateModel entity)
        {
            RestaurantDish restaurantDish = new RestaurantDish
            {
                Id = entity.Id,
                DishName = entity.DishName,
                Category = entity.Category,
                Ingredients = entity.Ingredients,
                Price = entity.Price,
                Weight = entity.Weight,
                RestaurantId = entity.RestaurantId
            };
            _restaurantDishRepository.Update(restaurantDish);
            _restaurantDishRepository.Save();
        }

        public void Delete(Guid id) 
        {
            RestaurantDish restaurantDish = new RestaurantDish
            {
                Id = id,
            };
            _restaurantDishRepository.Delete(restaurantDish);
            _restaurantDishRepository.Save();
        }
    }
}
