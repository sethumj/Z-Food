using System;
namespace Z_Food
{
    public interface IFoodDB
    {
        public int AddToDb(FoodItem input);
        public void RemoveFromDb(int input);
        public bool Contains(int input);
        public int Size();
        public Dictionary<int,FoodItem> GetList();
        public FoodItem GetByIndex(int index);
        public string GetFoodName(int id);
        public float GetFoodPrice(int id);
    }
}

