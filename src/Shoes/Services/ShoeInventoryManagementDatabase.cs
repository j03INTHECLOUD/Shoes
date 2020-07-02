using Shoes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.Cosmos;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace Shoes.Services
{
    public class ShoeInventoryManagementDatabase : IShoeInvemtoryManagement
    {
        private CosmosClient _databaseClient;
        public ShoeInventoryManagementDatabase()
        {
        // _databaseClient = new CosmosClient("test");
        }

        public PairOfShoes AddPairShoesToInventory(PairOfShoes shoe)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, PairOfShoes> GetShoeInventory()
        {
            throw new NotImplementedException();
        }
    }
}
