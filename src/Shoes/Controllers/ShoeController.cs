using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shoes.Models;
using Shoes.Services;

namespace Shoes.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class ShoeController : ControllerBase
    {
        private readonly IShoeInvemtoryManagement _services;
        public ShoeController(IShoeInvemtoryManagement services)
        {
            _services = services;
        }
        [HttpPost]
        [Route("shoe")]
        public ActionResult<PairOfShoes> AddShoe(PairOfShoes shoe)
        {
            return _services.AddPairShoesToInventory(shoe);
        }

        [HttpGet]
        [Route("shoe")]
        public ActionResult<Dictionary<string, PairOfShoes>> GetShoe()
        {
            return _services.GetShoeInventory();
        }
    }
}
