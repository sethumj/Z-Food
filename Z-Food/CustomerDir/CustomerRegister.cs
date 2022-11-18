using System;
using System.Net;

namespace Z_Food
{
    public class CustomerRegister : ICustomerRegister
    {
        static CustomerRegister CustomerRegisterObj = new CustomerRegister();
        static CustomerDataBase CustomerDataBaseObj = CustomerDataBase.GetInstance();
        public CustomerRegister()
        {
        }
        public static CustomerRegister GetInstance()
        {
            return CustomerRegisterObj;
        }
        public int SignUp()
        {
            Console.Write(PrintStatement.EnterMailId);
            string Email = CustomerDataBaseObj.GetEmail();
            if (Email.Equals("")) return -1;
            Console.Write(PrintStatement.EnterName);
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
            Address NewAddress = new Address(DoorNo, StreetName, Area, District, Postcode, State);
            Customer NewCustomer = new Customer(Name, Email, ContactNo, NewAddress);
            return CustomerDataBaseObj.AddCustomer(NewCustomer, Utilities.PasswordVerification());
        }
        public int SignIn()
        {
            Console.Write(PrintStatement.EnterMailId);
            string Email = Validation.GetInput<string>(Input.Email);
            Console.Write(PrintStatement.EnterYourPassword);
            string Password = Validation.GetInput<string>(Input.String);
            if (CustomerDataBaseObj.GetCredintials().ContainsKey(Email))
            {
                var temp = CustomerDataBaseObj.GetCredintials()[Email];
                if (temp.Password.Equals(Password))
                {
                    return temp.CustomerId;
                }
            }
            return -1;
        }
    }
}

