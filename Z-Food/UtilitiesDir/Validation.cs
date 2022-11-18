using System;
namespace Z_Food
{
    public class Validation
    {
        public static T GetInput<T>(Input input)
        {
            while (true)
            {
                try
                {
                    string temp1;
                    int temp;
                    long temp2;
                    float temp3;
                    switch (input)
                    {
                        case Input.Integer:
                            temp = Convert.ToInt32(Console.ReadLine());
                            return (T) Convert.ChangeType(temp,typeof(T));

                        case Input.String:
                            temp1 = Console.ReadLine();
                            if(temp1 == null || temp1.Equals(""))
                            {
                                throw new Exception(PrintStatement.NullNotSupported);
                            }
                            return (T) Convert.ChangeType(temp1,typeof(T));

                        case Input.Long:
                            temp2 = Convert.ToInt64(Console.ReadLine());
                            return (T) Convert.ChangeType(temp2,typeof(T));

                        case Input.Email:
                            temp1 = Console.ReadLine();
                            if(temp1.Contains(".") && temp1.Contains("@"))
                            {
                                return (T)Convert.ChangeType(temp1, typeof(T));
                            }
                            throw new Exception(PrintStatement.InvalidMail);
                        case Input.ContactNo:
                            temp2 = Convert.ToInt64(Console.ReadLine());
                            if(temp2 > 1000000000 && temp2 <= 9999999999)
                            {
                                return (T)Convert.ChangeType(temp2, typeof(T));
                            }
                            throw new Exception(PrintStatement.InvalidContactNo);
                        case Input.Postcode:
                            temp = Convert.ToInt32(Console.ReadLine());
                            if (temp > 100000 && temp <= 999999)
                            {
                                return (T)Convert.ChangeType(temp, typeof(T));
                            }
                            throw new Exception(PrintStatement.InvalidPostCode);
                        case Input.PositiveInteger:
                            temp = Convert.ToInt32(Console.ReadLine());
                            if (temp >= 0)
                            {
                                return (T)Convert.ChangeType(temp, typeof(T));
                            }
                            throw new Exception(PrintStatement.EnterPositiveNumber);
                        case Input.PositiveFloat:
                            temp3 = Convert.ToSingle(Console.ReadLine());
                            if (temp3 >= 0)
                            {
                                return (T)Convert.ChangeType(temp3, typeof(T));
                            }
                            throw new Exception(PrintStatement.EnterPositiveNumber);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.Write(PrintStatement.TryAgain);
                }
            }
        }
    }
}

