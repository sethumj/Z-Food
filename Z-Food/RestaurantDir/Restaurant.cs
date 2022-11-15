using System;
namespace Z_Food
{
    public class Restaurant
    {
       
        public string Name { get; }
        public string Email { get;  }
        long ContactNo { get; }
        Address Address { get; }
        HashSet<int> PostCode { get; }
        public IDataBase Db { get; }

        public Restaurant(string Name,string Email,long ContactNo,Address Address,HashSet<int> PostCode)
        {
            this.Name = Name;
            this.Email = Email;
            this.ContactNo = ContactNo;
            this.Address = Address;
            this.PostCode = PostCode;
            this.Db = new FoodDataBase();
        }
    }
}

