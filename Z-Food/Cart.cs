using System;
namespace Z_Food
{
    public class Cart
    {
        RestaurantDataBase RestaurantDb = RestaurantDataBase.GetInstance();
        CustomerDataBase CustomerDb = CustomerDataBase.GetInstance();
        Dictionary<int, int> ItemQuantity;
        public static Cart AddToCartObj = new Cart();
        private Cart()
        {
        }
        public static Cart GetInstance()
        {
            return AddToCartObj;
        }
        public void AddItems(List<KeyValuePair<int,int>> tempList,int customerId)
        {
            Console.WriteLine(PrintStatement.SelectOneFromOption);
            int Option = Validation.GetInput<int>(Input.PositiveInteger)-1;
            if (Option >= tempList.Count) {
               
                return; }
            Console.WriteLine(PrintStatement.EnterQuantity);
            int Quantity = Validation.GetInput<int>(Input.PositiveInteger);
            if (CustomerDb.GetCustomer(customerId).CartItems.Count == 0)
            { 
                ItemQuantity = new Dictionary<int, int>();
                ItemQuantity.Add(tempList.ElementAt(Option).Value, Quantity);
                CustomerDb.GetCustomer(customerId).CartItems.Add(tempList.ElementAt(Option).Key, ItemQuantity);
                Console.WriteLine(PrintStatement.ItemAdded);
                return;
            }
            else
            {
                if (CustomerDb.GetCustomer(customerId).CartItems.ElementAt(0).Key != tempList.ElementAt(Option).Key)
                {
                    Console.WriteLine(PrintStatement.DiscardPreviousCart);
                    int Choice = Validation.GetInput<int>(Input.PositiveInteger);
                    if (Choice != 1) return;
                    CustomerDb.GetCustomer(customerId).CartItems.Clear();
                    ItemQuantity = new Dictionary<int, int>();
                    ItemQuantity.Add(tempList.ElementAt(Option).Value, Quantity);
                    CustomerDb.GetCustomer(customerId).CartItems.Add(tempList.ElementAt(Option).Key, ItemQuantity);
                    Console.WriteLine(PrintStatement.ItemAdded);
                    return;
                }
                foreach (var i in CustomerDb.GetCustomer(customerId).CartItems.ElementAt(0).Value)
                {
                    if(i.Key == tempList.ElementAt(Option).Value)
                    {
                        CustomerDb.GetCustomer(customerId).CartItems.ElementAt(0).Value[i.Key] += Quantity;
                        Console.WriteLine(PrintStatement.ItemAdded);
                        return;
                    }
                }
                Console.WriteLine(PrintStatement.ItemAdded);
                CustomerDb.GetCustomer(customerId).CartItems.ElementAt(0).Value.Add(tempList.ElementAt(Option).Value, Quantity);
            }
        }
        public void ViewCart(int customerId)
        {
            if(CustomerDb.GetCustomer(customerId).CartItems.Count == 0)
            {
                Console.WriteLine(PrintStatement.NothingToShow);
                return;
            }
            Console.Write(PrintStatement.RestaurantName);
            Console.WriteLine(RestaurantDb.GetRestaurantName(CustomerDb.GetCustomer(customerId).CartItems.ElementAt(0).Key));
            Console.WriteLine();
            int Count = 1;
            float total = 0;
            foreach(var i in CustomerDb.GetCustomer(customerId).CartItems.ElementAt(0).Value)
            {
                Console.WriteLine(PrintStatement.ItemNo + Count +"\n"+RestaurantDb.GetFoodName(CustomerDb.GetCustomer(customerId).CartItems.ElementAt(0).Key, i.Key));
                Console.WriteLine(PrintStatement.EnterQuantity + i.Value);
                Console.WriteLine(PrintStatement.Price + RestaurantDb.GetFoodPrice(CustomerDb.GetCustomer(customerId).CartItems.ElementAt(0).Key, i.Key) * i.Value);
                total += RestaurantDb.GetFoodPrice(CustomerDb.GetCustomer(customerId).CartItems.ElementAt(0).Key, i.Key) * i.Value;
                Console.WriteLine();
                Count++;
            }
            Console.WriteLine(PrintStatement.TotalDottedLine);
            Console.WriteLine(PrintStatement.TotalAmount + total);
            Console.WriteLine(PrintStatement.TotalDottedLine);
            Console.WriteLine();

            Console.WriteLine(PrintStatement.PlaceOrderMenu);
        }
    }
}

