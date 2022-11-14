using System;
namespace Z_Food
{
    public class FoodItem : IMenu
    {
        private static int _Id = 300000;
        string Name { set; get; }
        float Price { set; get; }
        bool Availability { set; get; }
        string Description { set; get; }
        int Food_Id { get; }
        Category CategoryType { set; get; }

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

        public void ViewFoodDetails()
        {
            Console.Write(PrintStatement.Name);
            Console.WriteLine(Name);
            Console.Write(PrintStatement.Price);
            Console.WriteLine(Price);
            Console.Write(PrintStatement.Availability);
            Console.WriteLine(Availability);
            Console.Write(PrintStatement.Description);
            Console.WriteLine(Description);
            Console.Write(PrintStatement.Category);
            Console.WriteLine(CategoryType);
        }
    }
}

