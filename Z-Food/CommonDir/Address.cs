using System;
namespace Z_Food
{
    public class Address
    {

        string DoorNo { get; }
        string Street { get; }
        string Area { get; }
        string District { get; }
        int PostCode { get; }
        string State { get; }

        public Address(string DoorNo,string Street,string Area,string District,int PostCode,string State)
        {
            this.DoorNo = DoorNo;
            this.Street = Street;
            this.Area = Area;
            this.District = District;
            this.PostCode = PostCode;
            this.State = State;
        }
    }
}

