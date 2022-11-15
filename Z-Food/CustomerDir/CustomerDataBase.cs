using System;
namespace Z_Food
{
    public class CustomerDataBase
    {
            static CustomerDataBase CustomerDbObj = new CustomerDataBase();
            private CustomerDataBase()
            {

            }
            private static int _Id = 30000000;
            static Dictionary<int, Customer> CustomerDb = new Dictionary<int, Customer>();
            static Dictionary<string, IdPassword> Credintials = new Dictionary<string, IdPassword>();
            public static CustomerDataBase GetInstance()
            {
                return CustomerDbObj;
            }

            public Customer AddCustomer(Customer NewCustomer, string Password)
            {
                CustomerDb.Add(_Id, NewCustomer);
                Credintials.Add(NewCustomer.Email, new IdPassword(_Id, Password));
                _Id++;
                return NewCustomer;
            }
            public Customer CheckCredintials(string Email, string Password)
            {
                if (Credintials.ContainsKey(Email))
                {
                    IdPassword temp = Credintials[Email];
                    if (temp.Password.Equals(Password))
                    {
                        return CustomerDb[temp.CustomerId];
                    }
                }
                return null;
            }
            class IdPassword
            {
                public int CustomerId { get; }
                public string Password { get; }

                public IdPassword(int CustomerId, string Password)
                {
                    this.CustomerId = CustomerId;
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

