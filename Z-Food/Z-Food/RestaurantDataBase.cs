using System;
namespace Z_Food
{
    public class RestaurantDataBase
    {
        private static int _Id = 40000;
        static Dictionary<int, Restaurant> RestaurantDb = new Dictionary<int, Restaurant>();
        static Dictionary<int, string> Credintials = new Dictionary<int, string>();

        public bool AddRestaurant(Restaurant NewRestaurant)
        {
            RestaurantDb.Add(_Id, NewRestaurant);
            Credintials.Add(_Id,)
            _Id++;
            return true;
        }
    }
}

