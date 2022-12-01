using System;
namespace Z_Food
{
    public class RestaurantDataBase
    {
        public static RestaurantDataBase RestaurantObj = new RestaurantDataBase();
        private RestaurantDataBase()
        {

        }
        private static int _Id = 40000;
        public static Dictionary<int, Restaurant> RestaurantDb = new Dictionary<int, Restaurant>();
        static Dictionary<string, IdPassword> Credintials = new Dictionary<string, IdPassword>();
        public static RestaurantDataBase GetInstance()
        {
            return RestaurantObj;
        }

        public Restaurant AddRestaurant(Restaurant NewRestaurant, string Password)
        {
            RestaurantDb.Add(_Id, NewRestaurant);
            Credintials.Add(NewRestaurant.Email, new IdPassword(_Id, Password));
            _Id++;
            return NewRestaurant;
        }
        public Dictionary<string, IdPassword> GetCredintials()
        {
            Dictionary<string, IdPassword> ExistingMails = new Dictionary<string, IdPassword>();
            foreach (var i in Credintials)
            {
                ExistingMails.Add(i.Key, i.Value);
            }
            return ExistingMails;
        }
        public class IdPassword
        {
            public int RestaurantId { get; }
            public string Password { get; }

            public IdPassword(int RestaurantId, string Password)
            {
                this.RestaurantId = RestaurantId;
                this.Password = Password;
            }
        }
        public Restaurant GetRestaurant(int id)
        {
            return RestaurantDb[id];
        }

        public string GetEmail()
        {
            while (true)
            {
                string Email = Validation.GetInput<string>(Input.Email);
                if (Credintials.ContainsKey(Email))
                {
                    Console.WriteLine(PrintStatement.MailAlreadyExist);
                    return "";
                }
                return Email;
            }
        }
        public string GetRestaurantName(int id)
        {
            return RestaurantDb[id].Name;
        }
        public string GetFoodName(int res_Id,int food_Id)
        {
            return RestaurantDb[res_Id].Db.GetFoodName(food_Id);
        }
        public float GetFoodPrice(int res_Id,int food_Id)
        {
            return RestaurantDb[res_Id].Db.GetFoodPrice(food_Id);
        }
        public Dictionary<int, Restaurant> GetDb()
        {
            Dictionary<int, Restaurant> temp = new Dictionary<int, Restaurant>();
            foreach(var i in RestaurantDb)
            {
                temp.Add(i.Key, i.Value);
            }
            return temp;
        }
    }
}

