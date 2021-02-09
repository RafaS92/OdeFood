using System;
using System.Collections.Generic;

namespace OdeToFood.Data.Models.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        public IEnumerable<Restaurant> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
