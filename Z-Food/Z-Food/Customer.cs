using System;
namespace Z_Food
{
    public class Customer
    {
        private static int Id = 1000;
        string Name { get; }
        int CustomerId { get; }
        string Email { get; }
        long ContactNo { get; }
        Address Address { get; }
        List<string> Cart { set; get; }
        List<int> OrderHistory { set; get; }


        public Customer(string Name,string Email,long ContactNo,Address Address)
        {
            this.Name = Name;
            this.Email = Email;
            this.ContactNo = ContactNo;
            this.Address = Address;
            this.CustomerId = Id;
            this.Cart = new List<string>();
            this.OrderHistory = new List<int>();
            Id++;
        }
    }
}

