using System;
namespace Z_Food
{
    public class FoodItem
    {
        private static int _Id = 300000;
        public string Name { set; get; }
        public float Price { set; get; }
        public bool Availability { set; get; }
        public string Description { set; get; }
        public int Food_Id { get; }
        public Category CategoryType { set; get; }

        public FoodItem(string Name,float Price,bool Availability,string Description,Category CategoryType)
        {
            this.Name = Name;
            this.Price = Price;
            this.Availability = Availability;
            this.Description = Description;
            this.CategoryType = CategoryType;
            this.Food_Id = _Id;
            _Id++;
        }
    }
}

