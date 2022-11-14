using Z_Food;

class Program
{
    public static void Main(string[] args)
    {
        RestaurantDriver restaurantDriver = RestaurantDriver.GetInstance();
        while (true)
        {
            restaurantDriver.Register();
        }

    }
}
