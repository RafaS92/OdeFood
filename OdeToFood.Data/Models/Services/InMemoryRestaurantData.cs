﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Models.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {

        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
                {
                    new Restaurant {Id = 1 , Name = "Rafa's Pizza", Cuisine = CuisineType.Italian},
                    new Restaurant {Id = 2 , Name = "Ashley's Masala", Cuisine = CuisineType.Indian},
                    new Restaurant {Id = 3 , Name = "Kelly's Baggete", Cuisine = CuisineType.French}
                };   
        }           
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
