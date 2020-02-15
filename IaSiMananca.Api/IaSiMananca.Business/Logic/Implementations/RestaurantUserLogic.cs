using IaSiMananca.Business.Logic.Interfaces;
using IaSiMananca.Business.Models;
using IaSiMananca.DataAccess.Entities;
using IaSiMananca.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace IaSiMananca.Business.Logic.Implementations
{
    public class RestaurantUserLogic : IRestaurantUserLogic
    {
        private IRepository<RestaurantUser> _restaurantUserRepository;

        public RestaurantUserLogic(IRepository<RestaurantUser> restaurantUserRepository)
        {
            _restaurantUserRepository = restaurantUserRepository;
        }

        public IEnumerable<RestaurantUser> GetAll()
        {
            return _restaurantUserRepository.GetAll();
        }

        public RestaurantUser GetById(Guid id)
        {
            return _restaurantUserRepository.GetById(id);
        }

        public void Create(RestaurantUserCreateModel entity)
        {
            RestaurantUser restaurantUser = new RestaurantUser
            {
                Id = new Guid(),
                User = entity.User,
                Password = entity.Password,
                Email = entity.Email,
                Privilege = RestaurantUser.PrivilegeValues.None,
               
            };
            _restaurantUserRepository.Create(restaurantUser);
            _restaurantUserRepository.Save();
        }

        public void Update(RestaurantUserUpdateModel entity)
        {
            RestaurantUser restaurantUser = new RestaurantUser
            {
                Id = entity.Id,
                User = entity.User,
                Password = entity.Password,
                Email = entity.Email,
                RestaurantId = entity.RestaurantId
            };
            _restaurantUserRepository.Update(restaurantUser);
            _restaurantUserRepository.Save();
        }

        public void Delete(Guid id)
        {
            RestaurantUser User = new RestaurantUser
            {
                Id = id
            };
            _restaurantUserRepository.Delete(User);
            _restaurantUserRepository.Save();
        }

        public IEnumerable<RestaurantUser> GetByName(string n)
        {
            return _restaurantUserRepository.Filter(rd => rd.User == n);
        }

        public IEnumerable<RestaurantUser> GetByEmail(string e)
        {
            return _restaurantUserRepository.Filter(rd => rd.Email == e);
        }

        public IEnumerable<RestaurantUser> GetByEmailAndPassword(string e, string p)
        {
            return _restaurantUserRepository.Filter(rd =>  rd.Email == e && rd.Password == p );
        }
    }
}
