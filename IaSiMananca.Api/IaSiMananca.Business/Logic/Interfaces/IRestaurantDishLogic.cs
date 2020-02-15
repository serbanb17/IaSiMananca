using IaSiMananca.Business.Models;
using IaSiMananca.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IaSiMananca.Business.Logic.Interfaces
{
    public interface IRestaurantDishLogic
    {
        IEnumerable<RestaurantDish> GetAll();

        IEnumerable<RestaurantDish> GetByRestaurantId(Guid id);

        IEnumerable<RestaurantDish> GetDishByDishName(string name);
       
        IEnumerable<RestaurantDish> GetByCategory(string s);

        RestaurantDish GetById(Guid id);

        void Create(RestaurantDishCreateModel entity);

        void Update(RestaurantDishUpdateModel entity);

        void Delete(Guid id);
    }
}
