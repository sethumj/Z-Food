using System;
namespace Z_Food
{
    public class Init
    {
        public static Init InitObj = new Init();
        RestaurantDataBase RestaurantObj = RestaurantDataBase.GetInstance();
        private Init()
        {
        }
        public Init GetInstance()
        {
            return InitObj;
        }
        public void LoadRestaurantData()
        {
            Address address = new Address("1", "4th cross st", "Anna Nagar", "Chennai", 600056, "TamilNadu");
            Restaurant Zytoon = new Restaurant("Zytoon", "Zytoon@gmail.com", 1234567890, address, new HashSet<int>());
            RestaurantObj.AddRestaurant(Zytoon, "pass");
            FoodItem Cbiryani = new FoodItem("Chicken Biryani", 350, true, "250g biryani rice with 2 pieces of chicken", Category.MainCourse);
            FoodItem Mbiryani = new FoodItem("Mutton Biryani", 450, true, "250g biryani rice with 2 pieces of soft mutton", Category.MainCourse);
            FoodItem DragonChicken = new FoodItem("Dragon Chicken", 250, true, "12 pieces of chicken", Category.Starter);
            FoodItem ChickenTikka = new FoodItem("Chicken Tikka", 250, true, "6 pieces of chicken", Category.Starter);
            FoodItem biryani = new FoodItem("Coca-cola", 60, true, "750ml", Category.Beverages);

            Zytoon.Db.AddToDb
        }
    }
}

