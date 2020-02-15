using IaSiMananca.Business.Models;
using IaSiMananca.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IaSiMananca.Business.Logic.Interfaces
{
    public interface IRestaurantUserLogic
    {
        IEnumerable<RestaurantUser> GetAll();

        RestaurantUser GetById(Guid id);

        void Create(RestaurantUserCreateModel entity);

        void Update(RestaurantUserUpdateModel entity);

        void Delete(Guid id);
        IEnumerable<RestaurantUser> GetByName(string n);
        IEnumerable<RestaurantUser> GetByEmail(string e);

        IEnumerable<RestaurantUser> GetByEmailAndPassword(string e, string p);
    }
}
