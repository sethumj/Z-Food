using System;
namespace Z_Food
{
    public class Restaurant
    {
        private static int _Id = 40000;
        string Name { get; }
        int RestaurantId { get; }
        string Email { get;  }
        string ContactNo { get; }
        Address Address { get; }
        HashSet<int> PostCode { get; }

        public Restaurant(string Name,string Email,string ContactNo,Address Address,HashSet<int> PostCode)
        {
            this.Name = Name;
            this.Email = Email;
            this.ContactNo = ContactNo;
            this.Address = Address;
            this.PostCode = PostCode;
            this.RestaurantId = _Id;
            _Id++;
        }
    }
}

