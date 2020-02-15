using IaSiMananca.Business.Logic.Interfaces;
using IaSiMananca.Business.Models;
using IaSiMananca.DataAccess.Entities;
using IaSiMananca.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IaSiMananca.Business.Logic.Implementations
{
    public class RestaurantLogic : IRestaurantLogic
    {
        private IRepository<Restaurant> _restaurantRepository;

        public RestaurantLogic(IRepository<Restaurant> restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }

        public void Create(RestaurantCreateModel r)
        {
            Restaurant restaurant = new Restaurant
            {
                Id = new Guid(),
                Name = r.Name,
                Type = r.Type,
                Address = r.Address,
                PhoneNumber = r.PhoneNumber,
                OpeningClosingTime = r.OpeningClosingTime,
                Website = r.Website,
                Rating = r.Rating

            };
            _restaurantRepository.Create(restaurant);
            _restaurantRepository.Save();
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurantRepository.GetAll();
        }

        public Restaurant GetById(Guid id)
        {
            return _restaurantRepository.GetById(id);
        }

        public void Update(Guid id, RestaurantUpdateModel r)
        {

            Restaurant restaurant = GetById(id);

            restaurant.Name = r.Name;
            restaurant.PhoneNumber = r.PhoneNumber;
            restaurant.Type = r.Type;
            restaurant.Website = r.Website;
            restaurant.OpeningClosingTime = r.OpeningClosingTime;
            restaurant.Address = r.Address;
            restaurant.Rating = r.Rating;
            _restaurantRepository.Update(restaurant);
            _restaurantRepository.Save();
        }

        public void Delete(Guid id)
        {
            Restaurant restaurant = new Restaurant
            {
                Id = id
            };
            _restaurantRepository.Delete(restaurant);
            _restaurantRepository.Save();
        }

        public IEnumerable<Restaurant> GetByName(string s)
        {
            return _restaurantRepository.Filter(rd => rd.Name == s);
        }

        public IEnumerable<Restaurant> GetByType(string s)
        {
            return _restaurantRepository.Filter(rd => rd.Type == s);
        }

        public IEnumerable<Restaurant> GetRestaurantByDishName(string s)
        {
            return _restaurantRepository.Filter(x => x.Name.Contains(s) || x.RestaurantDishes.Any(y => y.DishName.Contains(s)) || x.Type.Contains(s));
        }
    }
}
