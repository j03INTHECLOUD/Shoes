using Shoes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoes.Services
{
    public interface IShoeInvemtoryManagement
    {
        PairOfShoes AddPairShoesToInventory(PairOfShoes shoe);
        Dictionary<string, PairOfShoes> GetShoeInventory();
    }
}
