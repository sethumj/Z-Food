using System;
namespace Z_Food
{
    public class AddFoodItem
    {
        public static AddFoodItem AddFoodItemObj = new AddFoodItem();
        private AddFoodItem()
        {
        }
        public static AddFoodItem GetInstance()
        {
            return AddFoodItemObj;
        }
        public bool Add(Restaurant restaurant)
        {
            Console.WriteLine();
            Console.Write(PrintStatement.RecipeName);
            string Name = Validation.GetInput<string>(Input.String);
            Console.Write(PrintStatement.EnterPrice);
            float Price = Validation.GetInput<float>(Input.PositiveFloat);
            bool Availability;
            while (true)
            {
                Console.WriteLine(PrintStatement.EnterAvailability);
                int option = Validation.GetInput<int>(Input.PositiveInteger);
                if (option == 1) { Availability = true; break; }
                else if (option == 2) { Availability = false; break; }
                else Console.WriteLine(PrintStatement.NoSuchOption);
            }
            Console.Write(PrintStatement.EnterDescription);
            string Description = Validation.GetInput<string>(Input.String);
            Console.WriteLine(PrintStatement.SelectCategory);
            int count = 1;
            foreach(string i in Enum.GetNames(typeof(Category)))
            {
                Console.WriteLine(count +". "+ i);
                count++;
            }
            int option1;
            while (true)
            {
                option1 = Validation.GetInput<int>(Input.PositiveInteger);
                if (option1 < count) break;
                Console.WriteLine(PrintStatement.NoSuchOption);
            }
            option1--;
            Category Category = (Category)option1;
            IMenu NewFoodItem = new FoodItem(Name, Price, Availability, Description, Category);
            Console.WriteLine("\n"+PrintStatement.ItemAdded);
            Console.WriteLine(PrintStatement.YourItemId+restaurant.Db.AddToDb((FoodItem)NewFoodItem)+"\n");
            return true;

        }
    }
}

