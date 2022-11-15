using System;
namespace Z_Food
{
    public class SearchFood
    {
        static SearchFood SearchFoodObj = new SearchFood();
        private static RestaurantDataBase RestaurantDataBase = RestaurantDataBase.GetInstance();
        private static FoodService FoodServiceObj = FoodService.GetInstance();
        private SearchFood()
        {
        }
        public SearchFood GetInstance()
        {
            return SearchFoodObj;
        }
        public void Search()
        {
            Console.WriteLine(PrintStatement.WhatDoYouWant);
            string DishName = Validation.GetInput<string>(Input.String).ToLower();
            int Count = 1;
            foreach(var restaurant in RestaurantDataBase.RestaurantDb)
            {
                foreach(var food in restaurant.Value.Db.GetList())
                {
                    if (DishName.Equals(food.Name.ToLower()))
                    {
                        Console.WriteLine(PrintStatement.Sno + Count);
                        FoodServiceObj.ViewFoodDetails(food);
                        Count++;
                    }
                }
            }


        }
    }
}

