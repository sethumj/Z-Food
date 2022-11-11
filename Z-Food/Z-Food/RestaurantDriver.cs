using System;
namespace Z_Food
{
    public class RestaurantDriver
    {
        private static RestaurantDriver restaurantDriver = new RestaurantDriver();
        static RestaurantDriver GetInstance()
        {
            return restaurantDriver;
        }
        private RestaurantDriver()
        {
        }
        public void Register()
        {
            Console.WriteLine(PrintStatement.RegisterMenu);
            int choice = Validation.GetInput<int>(Input.Integer);
            switch (choice)
            {
                case 1:
                    break;
            }
        }
        public void Start()
        {
            while (true)
            {
                int choice = Validation.GetInput<int>(Input.Integer);
                switch (choice)
                {

                }
            }
        }
    }
}

