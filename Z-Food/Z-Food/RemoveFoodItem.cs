using System;
namespace Z_Food
{
    public class RemoveFoodItem
    {
        public static RemoveFoodItem RemoveFoodItemObj = new RemoveFoodItem();
        private RemoveFoodItem()
        {
        }
        public static RemoveFoodItem GetInstance()
        {
            return RemoveFoodItemObj;
        }
        public void Remove(Restaurant restaurant)
        {
            Console.Write(PrintStatement.EnterItemId);
            int Id = Validation.GetInput<int>(Input.PositiveInteger);
            if (restaurant.Db.FoodDb.ContainsKey(Id))
            {
                while (true)
                {
                    Console.WriteLine(PrintStatement.ConfirmMenu);
                    int option = Validation.GetInput<int>(Input.PositiveInteger);
                    if (option == 1)
                    {
                        restaurant.Db.FoodDb.Remove(Id);
                        Console.WriteLine("\n"+PrintStatement.ItemRemoved+"\n");
                        return;
                    }
                    else if (option == 2)
                    {
                        Console.WriteLine("\n"+PrintStatement.NoChangesDone+"\n");
                        return;
                    }
                    else
                    {
                        Console.WriteLine(PrintStatement.NoSuchOption);
                    }
                }
            }
            else
            {
                Console.WriteLine(PrintStatement.NoSuchItem);
            }
        }
    }
}

