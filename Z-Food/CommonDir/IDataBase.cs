using System;
namespace Z_Food
{
    public interface IDataBase
    {
        public int AddToDb(FoodItem input);
        public void RemoveFromDb(int input);
        public bool Contains(int input);
        public int Size();
        public List<FoodItem> GetList();

    }
}

