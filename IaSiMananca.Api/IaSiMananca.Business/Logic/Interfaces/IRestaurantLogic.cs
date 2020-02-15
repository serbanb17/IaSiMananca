using IaSiMananca.Business.Models;
using IaSiMananca.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IaSiMananca.Business.Logic.Interfaces
{
    public interface IRestaurantLogic
    {

        IEnumerable<Restaurant> GetAll();

        Restaurant GetById(Guid id);

        void Create(RestaurantCreateModel r);

        void Update(Guid id, RestaurantUpdateModel r);

        void Delete(Guid id);

        IEnumerable<Restaurant> GetByName(string s);

        IEnumerable<Restaurant> GetByType(string s);

        IEnumerable<Restaurant> GetRestaurantByDishName(string s);
    }
}
