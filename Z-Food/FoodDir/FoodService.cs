using System;

namespace Z_Food
{
    public class FoodService
    {
        public static FoodService FoodServiceObj = new FoodService();

        private FoodService()
        {
        }

        public static FoodService GetInstance()
        {
            return FoodServiceObj;
        }

        public bool Add(FoodDataBase foodDb)
        {
            Console.WriteLine();
            string Name = SetName();
            float Price = SetPrice();
            bool Availability = SetAvailability();
            string Description = SetDescription();
            Category Category = SetCategory();
            FoodItem NewFoodItem = new FoodItem(Name, Price, Availability, Description, Category);
            Console.WriteLine("\n" + PrintStatement.ItemAdded);
            Console.WriteLine(PrintStatement.YourItemId + foodDb.AddToDb((FoodItem)NewFoodItem) + "\n");
            return true;

        }

        public void Remove(FoodDataBase foodDb)
        {
            Console.Write(PrintStatement.EnterItemId);
            int Id = Validation.GetInput<int>(Input.PositiveInteger);
            if (foodDb.Contains(Id))
            {
                while (true)
                {
                    Console.WriteLine(PrintStatement.ConfirmMenu);
                    int option = Validation.GetInput<int>(Input.PositiveInteger);
                    if (option == 1)
                    {
                        foodDb.RemoveFromDb(Id);
                        Console.WriteLine("\n" + PrintStatement.ItemRemoved + "\n");
                        return;
                    }
                    else if (option == 2)
                    {
                        Console.WriteLine("\n" + PrintStatement.NoChangesDone + "\n");
                        return;
                    }
                    else
                    {
                        Console.WriteLine(PrintStatement.NoSuchOption);
                    }
                }
            }
            else
            {
                Console.WriteLine(PrintStatement.NoSuchItem);
            }
        }
        public void View(FoodDataBase foodDb)
        {
            if (foodDb.Size() == 0)
            {
                Console.WriteLine(PrintStatement.NothingToShow);
                return;
            }
            Console.WriteLine(PrintStatement.YourItemsAre + "\n");
            int count = 1;
            foreach (var i in foodDb.GetList())
            {
                Console.WriteLine(PrintStatement.DottedLine);
                Console.WriteLine(PrintStatement.Sno + count);
                ViewFoodDetails(i);
                Console.WriteLine(PrintStatement.DottedLine);
                Console.WriteLine();
                count++;
            }
        }
        public void ViewFoodDetails(FoodItem food)
        {
            Console.Write(PrintStatement.Name);
            Console.WriteLine(food.Name);
            Console.Write(PrintStatement.Price);
            Console.WriteLine(food.Price);
            Console.Write(PrintStatement.Availability);
            Console.WriteLine(food.Availability);
            Console.Write(PrintStatement.Description);
            Console.WriteLine(food.Description);
            Console.Write(PrintStatement.Category);
            Console.WriteLine(food.CategoryType);
        }
        public void Update(FoodDataBase foodDb)
        {
            Console.WriteLine(PrintStatement.SelectOneForUpdate);
            View(foodDb);
            int option = Validation.GetInput<int>(Input.PositiveInteger) - 1;
            if(option>= foodDb.Size())
            {
                Console.WriteLine(PrintStatement.NoSuchItem);
                return;
            }
            UpdateItem(foodDb.GetByIndex(option));
        }
        private void UpdateItem(FoodItem food)
        {
            while (true) {
                Console.WriteLine();
                ViewFoodDetails(food);
                Console.WriteLine(PrintStatement.Update);
                Console.WriteLine(PrintStatement.UpdateMenu);
                int option = Validation.GetInput<int>(Input.PositiveInteger);
                switch(option)
                {
                    case 1:
                        food.Name = SetName();
                        Console.WriteLine(PrintStatement.UpdateSuccessful);
                        break;
                    case 2:
                        food.Price = SetPrice();
                        Console.WriteLine(PrintStatement.UpdateSuccessful);
                        break;
                    case 3:
                        food.Availability = SetAvailability();
                        Console.WriteLine(PrintStatement.UpdateSuccessful);
                        break;
                    case 4:
                        food.Description = SetDescription();
                        Console.WriteLine(PrintStatement.UpdateSuccessful);
                        break;
                    case 5:
                        food.CategoryType = SetCategory();
                        Console.WriteLine(PrintStatement.UpdateSuccessful);
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine(PrintStatement.NoSuchOption);
                        break;

                }
            }
        }

        private string SetName()
        {
            Console.Write(PrintStatement.RecipeName);
            return Validation.GetInput<string>(Input.String);
        }
        private float SetPrice()
        {
            Console.Write(PrintStatement.EnterPrice);
            return Validation.GetInput<float>(Input.PositiveFloat);
        }
        private bool SetAvailability()
        {
            while (true)
            {
                Console.WriteLine(PrintStatement.EnterAvailability);
                int option = Validation.GetInput<int>(Input.PositiveInteger);
                if (option == 1) return true;
                else if (option == 2) return false;
                else Console.WriteLine(PrintStatement.NoSuchOption);
            }
        }
        private string SetDescription()
        {
            Console.Write(PrintStatement.EnterDescription);
            return Validation.GetInput<string>(Input.String);
        }
        private Category SetCategory()
        {
            Console.WriteLine(PrintStatement.SelectCategory);
            int count = 1;
            foreach (string i in Enum.GetNames(typeof(Category)))
            {
                Console.WriteLine(count + ". " + i);
                count++;
            }
            int option1;
            while (true)
            {
                option1 = Validation.GetInput<int>(Input.PositiveInteger);
                if (option1 < count) break;
                Console.WriteLine(PrintStatement.NoSuchOption);
            }
            option1--;
            return (Category)option1;
        }

    }
}

