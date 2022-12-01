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

            public int AddCustomer(Customer NewCustomer, string Password)
            {
                CustomerDb.Add(_Id, NewCustomer);
                Credintials.Add(NewCustomer.Email, new IdPassword(_Id, Password));
                _Id++;
                return _Id-1;
            }
            public Dictionary<string,IdPassword> GetCredintials()
            {
            Dictionary<string,IdPassword> ExistingMails = new Dictionary<string, IdPassword>();
            foreach(var i in Credintials)
            {
                ExistingMails.Add(i.Key,i.Value);
            }
            return ExistingMails;
            }
            public class IdPassword
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
            public Customer GetCustomer(int id)
            {
                return CustomerDb[id];
            }
    }
}

