using System;
namespace Z_Food
{
    public class ViewRestaurant
    {
        public static ViewRestaurant ViewRestaurantObj = new ViewRestaurant();
        private static FoodService FoodServiceObj = FoodService.GetInstance();
        RestaurantDataBase Db = RestaurantDataBase.GetInstance();
        private static Cart CartObj = Cart.GetInstance();
        private ViewRestaurant()
        {
        }
        public static ViewRestaurant GetInstance()
        {
            return ViewRestaurantObj;
        }
        public void ViewByRestaurant(int customerId)
        {
            List<KeyValuePair<int, int>> TempList = new List<KeyValuePair<int, int>>();
            int Count = 1;
            foreach(var restaurant in Db.GetDb())
            {
                Console.WriteLine(Count + "." + restaurant.Value.Name);
                Count++;
            }
            Console.WriteLine(Count + PrintStatement.Back);
            Console.WriteLine();
            Console.WriteLine(PrintStatement.SelectOneFromOption);
            int Option = Validation.GetInput<int>(Input.PositiveInteger)-1;
            if (Option >= Db.GetDb().Count) return;
            int index = 1;
            foreach(var food in Db.GetDb().ElementAt(Option).Value.Db.GetList())
            {
                Console.WriteLine(PrintStatement.Sno + index);
                FoodServiceObj.ViewFoodDetails(food.Value);
                Console.WriteLine();
                TempList.Add(new KeyValuePair<int, int>( Db.GetDb().ElementAt(Option).Key, food.Key));
                index++;
            }
            Console.WriteLine(index + PrintStatement.Back);
            CartObj.AddItems(TempList, customerId);
            return;
        }

    }
}

