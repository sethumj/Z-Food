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
        public Restaurant CheckCredintials(string Email, string Password)
        {
            if (Credintials.ContainsKey(Email))
            {
                IdPassword temp = Credintials[Email];
                if (temp.Password.Equals(Password))
                {
                    return RestaurantDb[temp.RestaurantId];
                }
            }
            return null;
        }
        class IdPassword
        {
            public int RestaurantId { get; }
            public string Password { get; }

            public IdPassword(int RestaurantId, string Password)
            {
                this.RestaurantId = RestaurantId;
                this.Password = Password;
            }
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
    }
}

