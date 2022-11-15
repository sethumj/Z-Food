using System;
namespace Z_Food
{
    public class CustomerDriver
    {
        private static CustomerDriver customerDriver = new CustomerDriver();
        private static CustomerRegister CustomerRegisterObj = CustomerRegister.GetInstance();
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
                        Customer NewCustomer = CustomerRegisterObj.SignUp();
                        if (NewCustomer != null)
                        {
                            Console.WriteLine();
                            Console.WriteLine(PrintStatement.Welcome + NewCustomer.Name + "!");
                            customerDriver.Start(NewCustomer);
                        }
                        else
                        {
                            Console.WriteLine(PrintStatement.SignInFailed);
                        }
                        break;
                    case 2:
                        Customer ExistingCustomer = CustomerRegisterObj.SignIn();
                        if (ExistingCustomer != null)
                        {
                            Console.WriteLine();
                            Console.WriteLine(PrintStatement.Welcome + ExistingCustomer.Name + "!");
                            customerDriver.Start(ExistingCustomer);
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
        public void Start(Customer customer)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine(PrintStatement.CustomerOptions);
                int choice = Validation.GetInput<int>(Input.Integer);
                switch (choice)
                {
                    case 1:
                        
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

