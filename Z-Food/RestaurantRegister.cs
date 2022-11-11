using System;
namespace Z_Food
{
    public class RestaurantRegister : IRegister
    {

        public bool SignUp()
        {
            Console.Write(PrintStatement.EnterRestaurantName);
            string Name = Validation.GetInput<string>(Input.String);
            Console.Write(PrintStatement.EnterMailId);
            string Email = Validation.GetInput<string>(Input.Email);
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
            string state = Validation.GetInput<string>(Input.String);
            Console.WriteLine(PrintStatement.ServicablePostcode);
            Console.Write(PrintStatement.HowMany);
            int size = Validation.GetInput<int>(Input.PositiveInteger);
            HashSet<int> ServicablePostcodes = new HashSet<int>();
            for(int i = 0; i < size; i++) ServicablePostcodes.Add(Validation.GetInput<int>(Input.Postcode));
            Address address = new Address()


        }

        public bool SignIn()
        {
            throw new NotImplementedException();
        }
    }
}

