using System;
namespace Z_Food
{
    public class FoodDataBase : IFoodDB
    {
        static int _Id = 600000;
        public FoodDataBase()
        {
        }
        Dictionary<int, FoodItem> FoodDb = new Dictionary<int, FoodItem>();
        public int AddToDb(FoodItem NewFoodItem)
        {
            FoodDb.Add(_Id, NewFoodItem);
            _Id++;
            return _Id-1;
        }
        public void RemoveFromDb(int FoodIdToRemove) {
            FoodDb.Remove(FoodIdToRemove);
        }
        public bool Contains(int id)
        {
            if (FoodDb.ContainsKey(id)) return true;
            return false;
        }
        public int Size()
        {
            return FoodDb.Count;
        }
        public Dictionary<int,FoodItem> GetList()
        {
            Dictionary<int,FoodItem> ItemList = new Dictionary<int, FoodItem>();
            foreach(var i in FoodDb)
            {
                ItemList.Add(i.Key,i.Value);
            }
            return ItemList;
        }
        public FoodItem GetByIndex(int i)
        {
            Dictionary<int,FoodItem> ItemList = GetList();
            int Count = 0;
            foreach(var Food in ItemList)
            {
                if (Count == i) return Food.Value;
                Count++;
            }
            return null; 
        }
        public string GetFoodName(int id)
        {
            return FoodDb[id].Name;
        }
        public float GetFoodPrice(int id)
        {
            return FoodDb[id].Price;
        }
    }
}
