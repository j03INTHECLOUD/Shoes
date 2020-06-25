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
    public class ShoeControllerAddShoeUnitTest
    {
        PairOfShoes shoe1;

        public ShoeControllerAddShoeUnitTest()
        {
            shoe1 = new PairOfShoes("123", "Nike", 15.65, "small scrap on left heel", "Blue", "Winged Check");
        }
        [Fact]
        public void Test1()
        {
            var mockShoeInventoryManagement = new Mock<IShoeInvemtoryManagement>();
            mockShoeInventoryManagement.SetupAllProperties();
            mockShoeInventoryManagement.Setup(p => p.AddPairShoesToInventory(It.IsAny<PairOfShoes>())).Returns(shoe1);
            var shoeController = new ShoeController(mockShoeInventoryManagement.Object);
            var result = shoeController.AddShoe(shoe1).Value;
            Assert.Equal(shoe1, result);
        }
    }
}
