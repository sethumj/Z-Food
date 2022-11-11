using System;
namespace Z_Food
{
    public class Restaurant
    {
       
        string Name { get; }
        string Email { get;  }
        long ContactNo { get; }
        Address Address { get; }
        HashSet<int> PostCode { get; }

        public Restaurant(string Name,string Email,long ContactNo,Address Address,HashSet<int> PostCode)
        {
            this.Name = Name;
            this.Email = Email;
            this.ContactNo = ContactNo;
            this.Address = Address;
            this.PostCode = PostCode;
        }
    }
}

