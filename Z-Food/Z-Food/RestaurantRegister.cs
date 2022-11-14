using System;
namespace Z_Food
{
    public class RestaurantRegister : IRegister
    {
        static RestaurantRegister RestaurantRegisterObj = new RestaurantRegister();
        static RestaurantDataBase RestaurantDataBaseObj = RestaurantDataBase.GetInstance();
        private RestaurantRegister() { }
        public static RestaurantRegister GetInstance()
        {
            return RestaurantRegisterObj;
        }

        RestaurantDataBase RestaurantObj = RestaurantDataBase.GetInstance();

        public Restaurant SignUp()
        {
            Console.Write(PrintStatement.EnterMailId);
            string Email = RestaurantDataBaseObj.GetEmail();
            if (Email.Equals("")) return null;
            Console.Write(PrintStatement.EnterRestaurantName);
            string Name = Validation.GetInput<string>(Input.String);
            Console.Write(PrintStatement.EnterContactNo);
            long ContactNo = Validation.GetInput<long>(Input.ContactNo);
            Console.Write(PrintStatement.EnterDoorNo);
            string DoorNo = Validation.GetInput<string>(Input.String);
            Console.Write(PrintStatement.EnterStreetName);
            string StreetName = Validation.GetInput<string>(Input.String);
            Console.Write(PrintStatement.EnterArea);
            string Area = Validation.GetInput<string>(Input.String);
            Console.Write(PrintStatement.EnterDistrict);
            string District = Validation.GetInput<string>(Input.String);
            Console.Write(PrintStatement.EnterPostCode);
            int Postcode = Validation.GetInput<int>(Input.Postcode);
            Console.Write(PrintStatement.EnterState);
            string State = Validation.GetInput<string>(Input.String);
            Console.WriteLine(PrintStatement.ServicablePostcode);
            Console.Write(PrintStatement.HowMany);
            int size = Validation.GetInput<int>(Input.PositiveInteger);
            HashSet<int> ServicablePostcodes = new HashSet<int>();
            for (int i = 0; i < size; i++) ServicablePostcodes.Add(Validation.GetInput<int>(Input.Postcode));
            Address NewAddress = new Address(DoorNo, StreetName, Area, District, Postcode, State);
            Restaurant NewRestaurant = new Restaurant(Name, Email, ContactNo, NewAddress, ServicablePostcodes);
            return RestaurantObj.AddRestaurant(NewRestaurant,Utilities.PasswordVerification());
        }

        public Restaurant SignIn()
        {
            Console.Write(PrintStatement.EnterMailId);
            string Email = Validation.GetInput<string>(Input.Email);
            Console.Write(PrintStatement.EnterYourPassword);
            string Password = Validation.GetInput<string>(Input.String);
            return RestaurantObj.CheckCredintials(Email, Password);
        }
    }
}

