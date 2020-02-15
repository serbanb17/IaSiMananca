using IaSiMananca.Business.Models;
using IaSiMananca.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IaSiMananca.Business.Logic.Interfaces
{
    public interface IRestaurantImageLogic
    {
        IEnumerable<RestaurantImage> GetAll();

        RestaurantImage GetById(Guid id);

        void Create(RestaurantImageModel entity);

        void Update(RestaurantImageModel entity);

        void Delete(RestaurantImageModel entity);
    }
}
