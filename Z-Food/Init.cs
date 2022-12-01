using System;
namespace Z_Food
{
    public class Init
    {
        public static Init InitObj = new Init();
        RestaurantDataBase RestaurantObj = RestaurantDataBase.GetInstance();
        CustomerDataBase CustomerDataBaseObj = CustomerDataBase.GetInstance();
        private Init()
        {
        }
        public static Init GetInstance()
        {
            return InitObj;
        }
        public void LoadRestaurantData()
        {
            Address address = new Address("1", "4th cross st", "Anna Nagar", "Chennai", 600056, "TamilNadu");
            Restaurant Zaitoon = new Restaurant("Zaitoon", "zaitoon@gmail.com", 1234567890, address, new HashSet<int>());
            RestaurantObj.AddRestaurant(Zaitoon, "pass");
            FoodItem Cbiryani = new FoodItem("Chicken Biryani", 350, true, "250g biryani rice with 2 pieces of chicken", Category.MainCourse);
            FoodItem Mbiryani = new FoodItem("Mutton Biryani", 450, true, "250g biryani rice with 2 pieces of soft meat", Category.MainCourse);
            FoodItem DragonChicken = new FoodItem("Dragon Chicken", 250, true, "The chicken lightly fried and simmered in a spicy tangy sauce.\nThe entire dish with loads of flavor.", Category.Starter);
            FoodItem ChickenTikka = new FoodItem("Chicken Tikka", 250, true, "", Category.Starter);
            FoodItem CocoCola = new FoodItem("Coca-cola", 60, true, "Coke 750ml", Category.Beverages);

            Zaitoon.Db.AddToDb(Cbiryani);
            Zaitoon.Db.AddToDb(Mbiryani);
            Zaitoon.Db.AddToDb(DragonChicken);
            Zaitoon.Db.AddToDb(ChickenTikka);
            Zaitoon.Db.AddToDb(CocoCola);

            Restaurant StarBiryani = new Restaurant("Ambur Star Biryani", "star@gmail.com", 1234567890, address, new HashSet<int>());
            RestaurantObj.AddRestaurant(StarBiryani, "pass");
            Cbiryani = new FoodItem("Chicken Biryani", 260, true, "Delicious and savory Ambur Biryani cooked with seeraga samba rice, \nloaded with spicy marinated chicken.\nServerd with brinjal and raita.", Category.MainCourse);
            Mbiryani = new FoodItem("Mutton Biryani", 365, true, "Delicious and savory Ambur Biryani cooked with seeraga samba rice, \nloaded with spicy marinated mutton. \nServerd with brinjal and raita.", Category.MainCourse);
            DragonChicken = new FoodItem("Dragon Chicken", 219, true, "The chicken lightly fried and simmered in a spicy tangy sauce.\nThe entire dish with loads of flavor.", Category.Starter);
            ChickenTikka = new FoodItem("Chicken Tikka", 219, true, "[Chef's Special]", Category.Starter);
            CocoCola = new FoodItem("Coca-cola", 40, true, "Coke 750ml", Category.Beverages);

            StarBiryani.Db.AddToDb(Cbiryani);
            StarBiryani.Db.AddToDb(Mbiryani);
            StarBiryani.Db.AddToDb(DragonChicken);
            StarBiryani.Db.AddToDb(ChickenTikka);
            StarBiryani.Db.AddToDb(CocoCola);



        }
        public void LoadCustomersData()
        {
            Address address = new Address("1", "4th cross st", "Anna Nagar", "Chennai", 600056, "TamilNadu");
            Customer sethu = new Customer("Sethu Mj", "sethu@gmail.com", 8903007767, address);
            CustomerDataBaseObj.AddCustomer(sethu, "pass");
            Customer susil = new Customer("Susil Darwin", "susil@gmail.com", 6263646566, address);
            CustomerDataBaseObj.AddCustomer(susil, "pass");
        }
    }
}

