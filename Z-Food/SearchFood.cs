using System;
namespace Z_Food
{
    public class SearchFood
    {
        static SearchFood SearchFoodObj = new SearchFood();
        private static RestaurantDataBase RestaurantDataBase = RestaurantDataBase.GetInstance();
        private static FoodService FoodServiceObj = FoodService.GetInstance();
        private static Cart CartObj = Cart.GetInstance();
        private SearchFood()
        {
        }
        public static SearchFood GetInstance()
        {
            return SearchFoodObj;
        }
        public void Search(int CustomerId)
        {
            List<KeyValuePair<int, int>> TempList = new List<KeyValuePair<int, int>>();
            Console.WriteLine(PrintStatement.WhatDoYouWant);
            Console.Write(PrintStatement.TypeExit);
            string DishName = Validation.GetInput<string>(Input.String).ToLower();
            if (DishName.ToLower().Equals("exit")) return;
            int Count = 1;
            Console.WriteLine();
            foreach(var restaurant in RestaurantDataBase.RestaurantDb)
            {
                foreach(var food in restaurant.Value.Db.GetList())
                {
                    if (DishName.Equals(food.Value.Name.ToLower()))
                    { 
                        Console.WriteLine(PrintStatement.Sno + Count);
                        Console.WriteLine(PrintStatement.RestaurantName + restaurant.Value.Name);
                        FoodServiceObj.ViewFoodDetails(food.Value);
                        Console.WriteLine();
                        TempList.Add(new KeyValuePair<int, int>(restaurant.Key, food.Key));
                        Count++;
                    }
                }
            }
            Console.WriteLine(Count + PrintStatement.Back);
            CartObj.AddItems(TempList,CustomerId);
            return;
        }
    }
}

