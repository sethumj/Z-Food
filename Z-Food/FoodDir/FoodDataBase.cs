using System;
namespace Z_Food
{
    public class FoodDataBase : IDataBase
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
        public List<FoodItem> GetList()
        {
            List<FoodItem> ItemList = new List<FoodItem>();
            foreach(var i in FoodDb)
            {
                ItemList.Add(i.Value);
            }
            return ItemList;
        }
        public FoodItem GetByIndex(int i)
        {
            List<FoodItem> ItemList = GetList();
            return ItemList[i];
        }
    }
}
