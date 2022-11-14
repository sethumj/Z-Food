using System;
namespace Z_Food
{
    public class FoodDataBase
    {
        static int _Id = 600000;
        public FoodDataBase()
        {
        }
        public Dictionary<int, FoodItem> FoodDb = new Dictionary<int, FoodItem>();
        public int AddToDb(FoodItem NewFoodItem)
        {
            FoodDb.Add(_Id, NewFoodItem);
            _Id++;
            return _Id-1;
        }
    }
}

