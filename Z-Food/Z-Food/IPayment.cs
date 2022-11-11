using System;
namespace Z_Food
{
    public interface IPayment
    {
        float _TotalAmount { get; }
        bool PayForOrder();
    }
}

