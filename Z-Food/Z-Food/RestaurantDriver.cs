using System;
namespace Z_Food
{
    public class RestaurantDriver
    {
        private static RestaurantDriver restaurantDriver = new RestaurantDriver();
        private static RestaurantRegister RestaurantRegisterObj = RestaurantRegister.GetInstance();
        public static RestaurantDriver GetInstance()
        {
            return restaurantDriver;
        }
        private RestaurantDriver()
        {
        }
        public void Register()
        {
            while (true)
            {
                Console.WriteLine(PrintStatement.RegisterMenu);
                int choice = Validation.GetInput<int>(Input.PositiveInteger);
                switch (choice)
                {
                    case 1:
                        Restaurant NewRestaurant = RestaurantRegisterObj.SignUp();
                        if (NewRestaurant != null)
                        {
                            Console.WriteLine();
                            Console.WriteLine(PrintStatement.Welcome + NewRestaurant.Name + "!");
                            restaurantDriver.Start(NewRestaurant);
                        }
                        else
                        {
                            Console.WriteLine(PrintStatement.SignInFailed);
                        }
                        break;
                    case 2:
                        Restaurant ExistingRestaurant = RestaurantRegisterObj.SignIn();
                        if (ExistingRestaurant != null)
                        {
                            Console.WriteLine();
                            Console.WriteLine(PrintStatement.Welcome + ExistingRestaurant.Name + "!");
                            restaurantDriver.Start(ExistingRestaurant);
                        }
                        else
                        {
                            Console.WriteLine(PrintStatement.InvalidCredintials);
                        }
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine(PrintStatement.NoSuchOption);
                        break;
                }
            }
        }
        public void Start(Restaurant restaurant)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine(PrintStatement.RestaurantOptions);
                int choice = Validation.GetInput<int>(Input.Integer);
                switch (choice)
                {
                    case 1:
                        AddFoodItem.GetInstance().Add(restaurant);
                        break;
                    case 2:
                        RemoveFoodItem.GetInstance().Remove(restaurant);
                        break;
                    case 3:
                        break;
                    case 4:
                        ViewFoodItem.GetInstance().View(restaurant);
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        return;
                    default:
                        Console.WriteLine(PrintStatement.NoSuchOption);
                        break;
                }
            }
        }
    }
}

