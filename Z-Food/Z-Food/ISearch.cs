using System;
namespace Z_Food
{
    public interface ISearch
    {
        T GetDish<T>(string name);
    }
}

