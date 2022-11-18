using System;
namespace Z_Food
{
    public class Customer
    {
        public string Name { get; } 
        public string Email { get; }
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
            this.Cart = new List<string>();
            this.OrderHistory = new List<int>();
        }
    }
}

