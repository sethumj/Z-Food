using System;
namespace Z_Food
{
    public class Utilities
    {
        public string PasswordVerification()
        {
            while (true)
            {
                Console.Write(PrintStatement.EnterYourPassword);
                string Password = Validation.GetInput<string>(Input.String);
                Console.Write(PrintStatement.ConfirmPassword);
                string ConfirmPassword = Validation.GetInput<string>(Input.String);
                if (Password.Equals(ConfirmPassword)) return Password;
                Console.WriteLine(PrintStatement.PasswordMismatch); 
            }
        }
    }
}

