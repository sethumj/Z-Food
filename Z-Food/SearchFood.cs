using System;
namespace Z_Food
{
    public class SearchFood
    {
        static SearchFood SearchFoodObj = new SearchFood();
        private static RestaurantDataBase RestaurantDataBase = RestaurantDataBase.GetInstance();
        private static FoodService FoodServiceObj = FoodService.GetInstance();
        private static AddToCart AddToCartObj = AddToCart.GetInstance();
        private SearchFood()
        {
        }
        public static SearchFood GetInstance()
        {
            return SearchFoodObj;
        }
        public void Search(int CustomerId)
        {
            Dictionary<int, int> TempList = new Dictionary<int, int>();
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
                        TempList.Add(restaurant.Key, food.Key);
                        Count++;
                    }
                }
            }



        }
    }
}

