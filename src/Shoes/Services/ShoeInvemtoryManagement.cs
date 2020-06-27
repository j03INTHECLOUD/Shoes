using Shoes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoes.Services
{
    public class ShoeInvemtoryManagement : IShoeInvemtoryManagement
    {
        private readonly Dictionary<string, PairOfShoes> _ShoeInventory;
        public ShoeInvemtoryManagement()
        {
            _ShoeInventory = new Dictionary<string, PairOfShoes>();
        }
        public PairOfShoes AddPairShoesToInventory(PairOfShoes shoe)
        {
            try
            {
                _ShoeInventory.Add(shoe.Title, shoe);
            }
            catch(Exception e)
            {
                throw new Exception("Failed to add the shoe to the invemtory list.");
            }
            return shoe;
        }
        public Dictionary<string, PairOfShoes> GetShoeInventory()
        {
            return _ShoeInventory;
        }

    }
}
