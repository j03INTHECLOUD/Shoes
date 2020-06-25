using System;
using Xunit;
using Moq;
using Shoes;
using Shoes.Services;
using Shoes.Controllers;
using Shoes.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShoesXUnitTest
{
    public class ShoeInventoryManagementAddPairShoesToInventoryAddShoeUnitTest
    {
        PairOfShoes shoe1;

        public ShoeInventoryManagementAddPairShoesToInventoryAddShoeUnitTest()
        {
            shoe1 = new PairOfShoes("123", "Nike", 15.65, "small scrap on left heel", "Blue", "Winged Check");
        }
        [Fact]
        public void TestNormalInsertion()
        {
            var shoeInvemtoryManagement = new ShoeInvemtoryManagement();
            var result = shoeInvemtoryManagement.AddPairShoesToInventory(shoe1);
            Assert.Equal(shoe1, result);
        }
        [Fact]
        public void TestDuplicateInsertion()
        {
            var shoeInvemtoryManagement = new ShoeInvemtoryManagement();
            var result = shoeInvemtoryManagement.AddPairShoesToInventory(shoe1);
            Assert.Throws<Exception>(() => shoeInvemtoryManagement.AddPairShoesToInventory(shoe1));
        }

    }
}
