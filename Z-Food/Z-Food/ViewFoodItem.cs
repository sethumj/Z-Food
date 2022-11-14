using System;
namespace Z_Food
{
    public class ViewFoodItem
    {
        public static ViewFoodItem ViewFoodItemObj = new ViewFoodItem();
        private ViewFoodItem()
        {
        }
        public static ViewFoodItem GetInstance()
        {
            return ViewFoodItemObj;
        }
        public void View(Restaurant restaurant)
        {
            if(restaurant.Db.FoodDb.Count == 0)
            {
                Console.WriteLine(PrintStatement.NothingToShow);
                return;
            }
            Console.WriteLine(PrintStatement.YourItemsAre+"\n");
            foreach(var i in restaurant.Db.FoodDb)
            {
                i.Value.ViewFoodDetails();
                Console.WriteLine();
            }
        }
    }
}

