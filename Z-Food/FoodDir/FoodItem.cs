using System;
namespace Z_Food
{
    public class FoodItem
    {
        public string Name { set; get; }
        public float Price { set; get; }
        public bool Availability { set; get; }
        public string Description { set; get; }
        public Category CategoryType { set; get; }

        public FoodItem(string Name,float Price,bool Availability,string Description,Category CategoryType)
        {
            this.Name = Name;
            this.Price = Price;
            this.Availability = Availability;
            this.Description = Description;
            this.CategoryType = CategoryType;
        }
    }
}

