using Z_Food;

class Program
{
    public static void Main(string[] args)
    {
        RestaurantDriver restaurantDriver = RestaurantDriver.GetInstance();
        CustomerDriver customerDriver = CustomerDriver.GetInstance();
        Init InitObj = Init.GetInstance();
        InitObj.LoadRestaurantData();
        InitObj.LoadCustomersData();
        while (true)
        {
            Console.WriteLine(PrintStatement.LogInAs);
            int option = Validation.GetInput<int>(Input.PositiveInteger);
            switch (option)
            {
                case 1:
                    restaurantDriver.Register();
                    break;
                case 2:
                    customerDriver.Register();
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine(PrintStatement.NoSuchOption);
                    break;
            }
        }

    }
}
