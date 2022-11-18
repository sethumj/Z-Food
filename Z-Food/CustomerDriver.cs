using System;
namespace Z_Food
{
    public class CustomerDriver
    {
        private static CustomerDriver customerDriver = new CustomerDriver();
        private static CustomerRegister CustomerRegisterObj = CustomerRegister.GetInstance();
        private static SearchFood SearchFoodObj = SearchFood.GetInstance();
        private static CustomerDataBase CustomerDataBaseObj = CustomerDataBase.GetInstance();
        public static CustomerDriver GetInstance()
        {
            return customerDriver;
        }
        private CustomerDriver()
        {
        }
        public void Register()
        {
            while (true)
            {
                Console.WriteLine(PrintStatement.RegisterMenu);
                int choice = Validation.GetInput<int>(Input.PositiveInteger);
                switch (choice)
                {
                    case 1:
                        int NewCustomerId = CustomerRegisterObj.SignUp();
                        if (NewCustomerId != -1)
                        {
                            Console.WriteLine();
                            Console.WriteLine(PrintStatement.Welcome + CustomerDataBaseObj.GetCustomer(NewCustomerId).Name + "!");
                            customerDriver.Start(NewCustomerId,CustomerDataBaseObj.GetCustomer(NewCustomerId));
                        }
                        else
                        {
                            Console.WriteLine(PrintStatement.SignInFailed);
                        }
                        break;
                    case 2:
                        int ExistingCustomerId = CustomerRegisterObj.SignIn();
                        if (ExistingCustomerId != -1)
                        {
                            Console.WriteLine();
                            Console.WriteLine(PrintStatement.Welcome + CustomerDataBaseObj.GetCustomer(ExistingCustomerId).Name + "!");
                            customerDriver.Start(ExistingCustomerId,CustomerDataBaseObj.GetCustomer(ExistingCustomerId));
                        }
                        else
                        {
                            Console.WriteLine(PrintStatement.InvalidCredintials);
                        }
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine(PrintStatement.NoSuchOption);
                        break;
                }
            }
        }
        public void Start(int CustomerId,Customer customer)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine(PrintStatement.CustomerOptions);
                int choice = Validation.GetInput<int>(Input.Integer);
                switch (choice)
                {
                    case 1:
                        SearchFoodObj.Search(CustomerId);
                        break;
                    case 2:
                      
                        break;
                    case 3:
                      
                        break;
                    case 4:
                       
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine(PrintStatement.NoSuchOption);
                        break;
                }
            }
        }
    }
}

