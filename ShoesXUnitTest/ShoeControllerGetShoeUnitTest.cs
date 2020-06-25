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
    public class ShoeControllerGetShoeUnitTest
    {
        PairOfShoes shoe1;
        PairOfShoes shoe2;
        
        public ShoeControllerGetShoeUnitTest ()
        {
            shoe1 = new PairOfShoes("123",  "Nike", 15.65, "small scrap on left heel", "Blue", "Winged Check");
            shoe2 = new PairOfShoes("124", "Nike", 98.99, "perfect condition", "Green", "Royal Check");
        }
        [Fact]
        public void Test1()
        {
            var getresult = new Dictionary<string, PairOfShoes>();
            getresult.Add(shoe1.Id, shoe1);
            getresult.Add(shoe2.Id, shoe2);
            var mockShoeInventoryManagement = new Mock<IShoeInvemtoryManagement>();
            mockShoeInventoryManagement.SetupAllProperties();
            mockShoeInventoryManagement.Setup(p => p.GetShoeInventory()).Returns(getresult);
            var shoeController = new ShoeController(mockShoeInventoryManagement.Object);
            var result = shoeController.GetShoe().Value;
            Assert.Equal(2, result.Count());
            Assert.Equal(shoe1, result[shoe1.Id]);
        }
        [Fact] 
        public void Test2()
        {
            var getresult = new Dictionary<string, PairOfShoes>();
            var mockShoeInventoryManagement = new Mock<IShoeInvemtoryManagement>();
            mockShoeInventoryManagement.SetupAllProperties();
            mockShoeInventoryManagement.Setup(p => p.GetShoeInventory()).Returns(getresult);
            var shoeController = new ShoeController(mockShoeInventoryManagement.Object);
            var result = shoeController.GetShoe().Value;
            Assert.Empty(result);
        }
    }
}
